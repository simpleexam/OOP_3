using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_3.Aliens
{
    internal class Zeta : Alien
    {
        //конструктор, создающий объект человека
        //принимает только имя
        //продолж жизни и тип одинаковы для всех объектов
        public Zeta(string name)
        {
            AlienType = AlienType.Zeta;
            LifeExpectancy = 1000;
            Name = name;
        }

        public override void Interaction(AlienType type)
        {
            string resultOfInteraction = "";

            switch (type)
            {
                case AlienType.Reptoid:
                    resultOfInteraction = "??";
                    break;
                case AlienType.Insectoid:
                    resultOfInteraction = "??";
                    break;
                case AlienType.Human:
                    resultOfInteraction = "учит";
                    break;
                case AlienType.Zeta:
                    resultOfInteraction = "дружит";
                    break;
                case AlienType.Hybrid:
                    resultOfInteraction = "помогает";
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
