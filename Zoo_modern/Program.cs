namespace Zoo_modern {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Zoo!");

            Lager lager = new Lager();
            List<Tier> tiere = new List<Tier> ();
            Tierpfleger tschackeline = new Tierpfleger();
            Tierpfleger kevin = new Tierpfleger();
            Verwaltung verwaltung = new Verwaltung();
            Erlebniswelt alaska = new Erlebniswelt();
            Erlebniswelt asien = new Erlebniswelt();
            Erlebniswelt afrika = new Erlebniswelt();
            FutterverwaltungsSystem fvs = new FutterverwaltungsSystem();

            Lieferant l1 = new Lieferant("Toni");



        }
    }
}