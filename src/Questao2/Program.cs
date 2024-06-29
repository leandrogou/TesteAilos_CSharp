using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;

public class Program
{
    public static void Main()
    {
        string teamName = "Paris Saint-Germain";
        int year = 2013;
        int totalGoals = getTotalScoredGoals(teamName, year);

        Console.WriteLine("Team "+ teamName +" scored "+ totalGoals.ToString() + " goals in "+ year);

        teamName = "Chelsea";
        year = 2014;
        totalGoals = getTotalScoredGoals(teamName, year);

        Console.WriteLine("Team " + teamName + " scored " + totalGoals.ToString() + " goals in " + year);

        // Output expected:
        // Team Paris Saint - Germain scored 109 goals in 2013
        // Team Chelsea scored 92 goals in 2014
    }

    private static int getTotalScoredGoals(string team, int year)
    {
        int totalGoals = 0;
        totalGoals += ProcessarAPI("team1", team, year);
        totalGoals += ProcessarAPI("team2", team, year);
        return totalGoals;
    }
    private static int ProcessarAPI(string casaVisitante,string team,int year)
    {
        int pagina = 1;
        int gols = 0;
        JObject jo = new JObject();
        do
        {
            string link = string.Format("https://jsonmock.hackerrank.com/api/football_matches?year={0}&{1}={2}&page={3}", year,casaVisitante, team, pagina);
            jo = AcessarAPI(link);
            foreach (var item in jo["data"])
            {
                gols += item.Value<int>(casaVisitante+"goals");
            }
            pagina++;
        } while (pagina <= jo.Value<int>("total_pages"));
        return gols;
    }

    private static JObject AcessarAPI(string link)
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(link);
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

        JObject json = JObject.Parse(client.GetStringAsync(client.BaseAddress).Result);

        return json;
    }

}