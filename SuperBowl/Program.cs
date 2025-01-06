namespace SuperBowl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Döntő> Dontok = new();
            foreach (var sor in File.ReadAllLines("SuperBowl.txt").Skip(1))
            {
                Dontok.Add(new Döntő(sor));
            }
            Console.WriteLine($"4.feladat:dontok szama: {Dontok.Count}");

            int pontkölömbség = 0;
            foreach (var d in Dontok)
            {
               string[] e = d.Eredmény.Split('-');

                pontkölömbség += Math.Abs(int.Parse(e[0]) - int.Parse(e[1]);

            }
            double átlag = pontkölömbség / Dontok.Count;
            Console.WriteLine($"5.feladat: Átlagos pontkülömbség: {átlag:0.0}");
        }
    }
}
