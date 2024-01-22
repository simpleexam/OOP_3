using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3.Aliens
{
    internal class Hybrid : Alien
    {
        //конструктор, создающий объект гибрид
        //принимает только имя
        //продолжительность жизни может отличаться
        public Hybrid(string name, AlienType motherType, AlienType fatherType)
        {
            AlienType = AlienType.Hybrid;
            //если гибрид образован от zeta+human или 
            if (motherType == AlienType.Zeta && fatherType == AlienType.Human) { LifeExpectancy = 500; }
            else if (motherType == AlienType.Reptoid && fatherType == AlienType.Human) { LifeExpectancy = 150; }
            else { LifeExpectancy = 200; }
            Name = name;
        }

        public override void Interaction(AlienType type)
        {
            string resultOfInteraction = "";

            switch (type)
            {
                case AlienType.Reptoid:
                    resultOfInteraction = "дружит";
                    break;
                case AlienType.Insectoid:
                    resultOfInteraction = "дружит";
                    break;
                case AlienType.Human:
                    resultOfInteraction = "дружит";
                    break;
                case AlienType.Zeta:
                    resultOfInteraction = "дружит";
                    break;
                case AlienType.Hybrid:
                    resultOfInteraction = "Дружит";
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
