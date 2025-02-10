namespace U4_S1_D1
{
    public class Animale
    {
        private string Nome { get; set; }
        private string Razza { get; set; }
        private string Colore { get; set; }
        private int Zampe { get; set; }

        public Animale(string nome, string razza, string colore, int zampe)
        {
            this.Nome = nome;
            this.Razza = razza;
            this.Colore = colore;
            this.Zampe = zampe;
        }

        public void ShowData()
        {
            Console.WriteLine("L'animale di nome " + Nome + ", è di razza " + Razza + ", di colore " + Colore + " e ha " + Zampe + " zampe.");
        }
    }
}
