using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3.Aliens
{
    /// <summary>
    /// абстрактный класс Alien - может как частично содержать реализацию, так и только шаблоны 
    /// в унаследованных классах уже реализуется уникальная логика того, что было заявлено в абстрактом классе
    /// </summary>
    internal abstract class Alien
    {
        public AlienType AlienType { get; set; } //автосвойство типа пришельца
        //свойство Name  проверяющее длину имени перед записью
        string name;
        public string Name
        {
            get => name;
            set
            {
                if (value.Length >= 3 || value.Length <= 50)
                    name = value;
                else Console.WriteLine("длина имени от 3 до 50 символов");
            }
        }
        //свойство продолжительности жизни, проверяющее что значение не меньше нула.
        //и если оно меньше = обнуляет
        int lifeExp;
        public int LifeExpectancy
        {
            get => lifeExp;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Продолжительность жизни должна " +
                        "быть положительной");
                    lifeExp = 0;
                }
                else lifeExp = value;
            }
        }
        //абстрактный метод взаимодействия с другими типами пришельцев
        //реализуется строго в классах-наследниках
        public abstract void Interaction(AlienType type);

    }
}
