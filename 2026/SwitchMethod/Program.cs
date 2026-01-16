namespace SwitchMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine(" Saad valida enda meetodi, kui sisestad numbri");
            Console.WriteLine("1. Tagurpidi püramiid");
            Console.WriteLine("2. Ristkülik");
            Console.WriteLine("3. Rüütvõrrand"); 
            string choise = Console.ReadLine();

            if (choise == "1")
            {
                TagurpidiPüramiid();
            }
            else if (choise == "2")
            {
                Ristkülik();
            }
            else if (choise == "3")
            {
                Ruutvõrrand();
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }

        static void TagurpidiPüramiid()
            {
            Console.WriteLine("Loome tärnidest püramiidi: \n");
            Console.WriteLine("-----------------------------");
            Console.Write("\n\n");
            Console.WriteLine("Sisesta suurus: ");
            int i, j, n;
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 10; i <= n; i++)
            {
                for (j = 15; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 15; j <= 2 * i - 10; j++)
                {
                    Console.Write("*");
                }
                Console.Write('\n');
            }
            for (i = n - 1; i >= 1; i--)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write('\n');
            }
        }

            static void Ristkülik()
            {
                Console.WriteLine("Sisesta pikkus");
                int row = int.Parse(Console.ReadLine());
                Console.WriteLine("Sisesta laius");
                int col = int.Parse(Console.ReadLine());

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }

                int area = row * col;
                int around = 2 * (row + col);

                Console.WriteLine("Pindala on " + area);
                Console.WriteLine("Ümbermõõt on " + around);
            }
        
        static void Ruutvõrrand()
        {
            Console.WriteLine("Ruutvõrrand!");

            //b2 (ruudus)* -4ac 

            //sisesta a, b ja c väärtus
            //kasutaja peab saama sisestada neid väärtuseid

            Console.Write("Sisesta a väärtus: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Sisesta b väärtus: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Sisesta c väärtus: ");
            double c = double.Parse(Console.ReadLine());

            double d = b * b - 4 * a * c;

            Console.WriteLine($"x1 = {(-b + Math.Sqrt(d)) / (2 * a)}, x2 = {(-b + Math.Sqrt(d)) / (2 * a)}");
        }
    }
}





