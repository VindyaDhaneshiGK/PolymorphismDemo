namespace PolymorphismDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Piano piano = new Piano();
            Guitar guitar = new Guitar();
            Console.WriteLine("Hello, World!");
            piano.Play(); // Outputs: The piano is playing
            guitar.Play(); // Outputs: The guitar is playing    
            Console.ReadLine();

        }
    }
}
