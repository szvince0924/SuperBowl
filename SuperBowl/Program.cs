namespace SuperBowl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Donto> Dontok = new();
            foreach (var sor in File.ReadAllLines("SuperBowl.txt").Skip(1))
            {
                Dontok.Add(new Donto(sor));
            }
            Console.WriteLine($"4.feladat:dontok szama")
        }
    }
}
