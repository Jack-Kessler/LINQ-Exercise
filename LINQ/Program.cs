namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGameList = new List<string>() { "Pokemon", "Halo", "MarioKart", "Zelda", "Madden 2018", "Candy Crush" };

            //Option 1
            //var sortedList = videoGameList.Where(x => x.Length > 0).OrderByDescending(x => x);

            //foreach ( var videoGame in sortedList )
            //{
            //    Console.WriteLine(videoGame);
            //}

            //Option 2
            videoGameList.Where(x => x.Length > 0).OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
