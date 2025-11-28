namespace ExecAula3
{
   

    public class Animal
    {
        protected string Nome;
    }

    public class Cachorro : Animal
    {
        public void DefinirNome(string nome)
        {
            Nome = nome;
        }

        public void Latir()
        {
            string pet = "cachorro";
            Console.WriteLine($"{pet} {Nome} está latindo!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Cachorro c = new Cachorro();
            c.DefinirNome("Rex");
            c.Latir();
        }
    }
}
