namespace FileCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjutada faili läbi konsooli");

            string filePath = "C:/Users/opilane/Desktop/WriteToFile.txt";
            string imput = Console.ReadLine();

            File.WriteAllText(filePath, imput);
        }
    }
}
