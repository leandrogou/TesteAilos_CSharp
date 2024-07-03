﻿using Dapper;
using IdempotentAPI.Core;
using MediatR;
using Microsoft.Data.Sqlite;
using Questao5.Domain.Entities;
using Questao5.Infrastructure.Sqlite;

namespace Questao5.Infrastructure.Database.CommandStore.Requests
{
    public class APIBanco : IAPIBanco
    {
        private readonly DatabaseConfig databaseConfig;

        public APIBanco(DatabaseConfig databaseConfig)
        {
            this.databaseConfig = databaseConfig;
        }
        public Task<RequisicaoConta> RetornarSaldo(int numeroConta)
        {
            try
            {
                string sql = string.Format("SELECT a.idcontacorrente as idRequisicao, a.numero as idContacorrente,IFNULL(sum(b.valor),0) as valorMovimentar,CURRENT_TIMESTAMP as Resposta FROM contacorrente a" +
                    " LEFT JOIN movimento b ON (a.numero = b.idcontacorrente) WHERE a.numero = {0} GROUP BY a.numero;", numeroConta);
                using var connection = new SqliteConnection(databaseConfig.Name);

                RequisicaoConta retorna = connection.Query<RequisicaoConta>(sql).FirstOrDefault();

                return Task.FromResult(retorna);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public Task Save(Movimento movimento)
        {
            string sql = string.Format("INSERT INTO movimento (idmovimento,idcontacorrente,datamovimento,tipomovimento,valor) VALUES ('{0}',{1},'{2}','{3}',{4})",
                movimento.IdMovimento,movimento.IdContaCorrente,movimento.DataMovimento,movimento.TipoMovimento,movimento.Valor);
            using var connection = new SqliteConnection(databaseConfig.Name);

            return connection.ExecuteAsync(sql);
        }

        public Task Save(IdEmpotencia idEmpotencia)
        {
            string sql = string.Format("INSERT INTO idempotencia (chave_idempotencia,requisicao,resultado) VALUES ('{0}','{1}','{2}')",
                idEmpotencia.chave_IdEmpotencia,idEmpotencia.Requisicao,idEmpotencia.Resultado);
            using var connection = new SqliteConnection(databaseConfig.Name);

            return connection.ExecuteAsync(sql);
        }

        public Task Update(Movimento movimento)
        {
            string sql = string.Format("UPDATE movimento SET valor = {0}, tipomovimento = '{1}',datamovimento = '{2}'WHERE idcontacorrente = {3}",
            movimento.Valor,movimento.TipoMovimento,movimento.DataMovimento,movimento.IdContaCorrente);
            using var connection = new SqliteConnection(databaseConfig.Name);
            return connection.ExecuteAsync(sql);
        }

        public Task Update(IdEmpotencia idEmpotencia)
        {
            throw new NotImplementedException();
        }
    }
}
