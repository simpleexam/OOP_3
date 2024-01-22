using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class Reptoid : Alien
    {
        //конструктор, создающий объект рептоида
        //принимает только имя
        //продолж жизни и тип одинаковы для всех объектов
        public Reptoid(string name) 
        {
            AlienType = AlienType.Reptoid;
            LifeExpectancy = 300;
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
                    resultOfInteraction = "ест";
                    break;
                case AlienType.Human:
                    resultOfInteraction = "Порабощает";
                    break;
                case AlienType.Zeta:
                    resultOfInteraction = "боится";
                    break;
                case AlienType.Hybrid:
                    resultOfInteraction = "Порабощает";
                    break;
                default:
                    resultOfInteraction = "Изучает";
                    break;
            }

            Console.WriteLine(this.AlienType +" "+resultOfInteraction+" "+ type);

        }

        public override string ToString() 
        {
            return new string($"Объект {Name} относится к типу {AlienType}\n" +
                $"продолжительность жизни {LifeExpectancy}");
        }
    }
}
