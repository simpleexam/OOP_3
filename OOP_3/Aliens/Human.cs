using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_3.Aliens
{
    /// <summary>
    /// класс Human уснаследованный от Alien
    /// </summary>
    internal class Human : Alien
    {
        //конструктор, создающий объект человека
        //принимает только имя
        //продолж жизни и тип одинаковы для всех объектов
        public Human(string name)
        {
            AlienType = AlienType.Human;
            LifeExpectancy = 100;
            Name = name;
        }
        /// <summary>
        /// метод - имитация взаимодействия с другими расами 
        /// </summary>
        /// <param name="type">тип пришельца</param>
        public override void Interaction(AlienType type)
        {
            string resultOfInteraction = "";

            switch (type)
            {
                case AlienType.Reptoid:
                    resultOfInteraction = "подчиняется";
                    break;
                case AlienType.Insectoid:
                    resultOfInteraction = "боится";
                    break;
                case AlienType.Human:
                    resultOfInteraction = "дружит";
                    break;
                case AlienType.Zeta:
                    resultOfInteraction = "учится";
                    break;
                case AlienType.Hybrid:
                    resultOfInteraction = "дружит";
                    break;
                default:
                    resultOfInteraction = "Изучает";
                    break;
            }

            Console.WriteLine(AlienType + " " + resultOfInteraction + " " + type);

        }

        //переопределенный от класса Object метод ToString 
        public override string ToString()
        {
            return new string($"Объект {Name} относится к типу {AlienType}\n" +
                $"продолжительность жизни {LifeExpectancy}");
        }
    }
}
