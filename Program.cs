using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inputs

            // Separately data input
            Console.WriteLine("Insira um número: // Insert a number:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um character: // Insert a character:");
            char ch = char.Parse(Console.ReadLine());

            Console.WriteLine("Insira um número double: // Insert a double number:");
            double number2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Vector data entry
            Console.WriteLine("Insira nome, gênero, idade e altura // Enter name, gender, age and height");
            string[] vetor = Console.ReadLine().Split(" ");
            string nome = vetor[0];
            char genero = char.Parse(vetor[1]);
            int idade = int.Parse(vetor[2]);
            double altura = double.Parse(vetor[3], CultureInfo.InvariantCulture);

            // Outputs

            Console.WriteLine("Você digitou");
            Console.WriteLine(number1);
            Console.WriteLine(ch);
            Console.WriteLine(number2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}