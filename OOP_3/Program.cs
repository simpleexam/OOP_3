using OOP_3.Aliens;

namespace OOP_3
{
    //перечисление типов пришельцев
    enum AlienType { Reptoid, Insectoid, Human, Zeta, Hybrid };
    internal class Program
    {
        static void Main(string[] args)
        {
            Reptoid rep1 = new Reptoid("jhgfyktrdkf");  //объект рептилоида
            Human hum1 = new Human("Tom");              //объект человека
            Zeta zeta1 = new Zeta("oaoaoaoo");          //объект зета

            Console.WriteLine("Вывод информации по объектам:\n" +
                "------------------------------------------------------");
            Console.WriteLine(rep1 +"\n" +hum1 +"\n" +zeta1); //вывод информации по объектам

            Console.WriteLine("\n" +
                "\nВывод взаимоотношений отдельных типов пришельцев:\n" +
                "------------------------------------------------------");

            rep1.Interaction(hum1.AlienType);
            zeta1.Interaction(rep1.AlienType);
        }
    }
}