namespace U4_S1_D1
{
    public class Dipendente
    {
        private string Nome { get; set; }
        private string Cognome { get; set; }
        private string Mansione { get; set; }
        private int Età { get; set; }

        public Dipendente(string nome, string cognome, string mansione, int età)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Mansione = mansione;
            this.Età = età;
        }

        public void ShowData()
        {
            Console.WriteLine("Il dipendente di nome " + Nome + ", e di cognome " + Cognome + ", svolge la mansione di " + Mansione + " ed ha " + Età + " anni.");
        }
    }
}
