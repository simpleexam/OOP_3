namespace OOP_3
{
    enum AlienType { Reptoid, Insectoid, Human, Zeta, Hybrid };
    internal class Program
    {
        static void Main(string[] args)
        {
            Reptoid rep1 = new Reptoid("jhgfyktrdkf");
            Human hum1 = new Human("Tom");
            Zeta zeta1 = new Zeta("oaoaoaoo");

            Console.WriteLine(rep1 +"\n" +hum1 +"\n" +zeta1);

            Console.WriteLine();

            rep1.Interaction(hum1.AlienType);
            zeta1.Interaction(rep1.AlienType);
        }
    }
}