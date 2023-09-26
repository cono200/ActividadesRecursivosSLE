namespace EjercicioRecursivosSLE26Sep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recu recu1 = new Recu();

            Console.WriteLine("Introducce el numero para el valor DESCEDENTE");
            int numeroUsuario= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(recu1.NumeroDescendente(numeroUsuario));



            Console.WriteLine("Escribe el numero para valor ascedente");
            int numeroUsuario1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(recu1.NumeroAscedente(numeroUsuario1));
        }
    }
}