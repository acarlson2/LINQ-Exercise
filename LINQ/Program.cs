namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string>();

            games.Add("Pokemon Black 2");
            games.Add("Warframe");
            games.Add("The Legend of Zelda: Tears of the Kingdom");
            games.Add("Super Smash Brothers Ultimate");
            games.Add("Horizon: Zero Dawn");
            games.Add("Splatoon 3");
            games.Add("Spider-Man 2");

            List<string> sorted = games.OrderBy(g => g.Length).ToList();

            for(int i = 0; i < sorted.Count; i++)
            {
                Console.WriteLine(sorted[i]);
            }
        }
    }
}
