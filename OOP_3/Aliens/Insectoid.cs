using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_3.Aliens
{
    internal class Insectoid : Alien
    {
        //конструктор, создающий объект рептоида
        //принимает только имя
        //продолж жизни и тип одинаковы для всех объектов
        public Insectoid(string name)
        {
            AlienType = AlienType.Insectoid;
            LifeExpectancy = 50;
            Name = name;
        }

        public override void Interaction(AlienType type)
        {
            string resultOfInteraction = "";

            switch (type)
            {
                case AlienType.Reptoid:
                    resultOfInteraction = "боится";
                    break;
                case AlienType.Insectoid:
                    resultOfInteraction = "дружит";
                    break;
                case AlienType.Human:
                    resultOfInteraction = "Изучает";
                    break;
                case AlienType.Zeta:
                    resultOfInteraction = "??";
                    break;
                case AlienType.Hybrid:
                    resultOfInteraction = "??";
                    break;
                default:
                    resultOfInteraction = "Изучает";
                    break;
            }

            Console.WriteLine(AlienType + " " + resultOfInteraction + " " + type);

        }

        public override string ToString()
        {
            return new string($"Объект {Name} относится к типу {AlienType}\n" +
                $"продолжительность жизни {LifeExpectancy}");
        }
    }
}
