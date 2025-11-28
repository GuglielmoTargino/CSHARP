namespace ExecAula1
{

    public class Aluno
    {
        public string Nome;
        public double Nota;

        public void Exibir()
        {
            Console.WriteLine($"Aluno: {Nome}, Nota: {Nota}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
      
            Aluno a = new Aluno();
            a.Nome = "Carlos";
            a.Nota = 8.5;
            a.Exibir();
        
    }
    }
}
