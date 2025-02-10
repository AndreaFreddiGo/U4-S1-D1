namespace U4_S1_D1
{
    public class Veicolo
    {
        public string Targa { get; private set; }
        public string Categoria { get; private set; }
        public string Colore { get; private set; }
        public int Ruote { get; private set; }

        public Veicolo(string targa, string categoria, string colore, int ruote)
        {
            this.Targa = targa;
            this.Categoria = categoria;
            this.Colore = colore;
            this.Ruote = ruote;
        }

        public void ShowData()
        {
            Console.WriteLine("Il veicolo con targa " + Targa + ", è di categoria " + Categoria + ", di colore " + Colore + " e ha " + Ruote + " ruote.");
        }
    }
}
