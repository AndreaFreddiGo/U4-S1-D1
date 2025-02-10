namespace U4_S1_D1
{
    public class Atleta
    {
        private string Nome { get; set; }
        private string Cognome { get; set; }
        private string Disciplina { get; set; }
        private int Età { get; set; }

        public Atleta(string nome, string cognome, string disciplina, int età)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Disciplina = disciplina;
            this.Età = età;
        }

        public void ShowData()
        {
            Console.WriteLine("L'atleta di nome " + Nome + ", e di cognome " + Cognome + ", pratica la disciplina di " + Disciplina + " ed ha " + Età + " anni.");
        }

    }
}
