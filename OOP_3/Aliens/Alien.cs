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
        public AlienType AlienType { get; set; }    //автосвойство типа пришельца
        string name;    //закрытое поле имени                            
        public string Name  //свойство name  проверяющее длину имени перед записью
        {
            get => name;
            set
            {
                //если имя не попадает по длине в диапазон от 3 до 50 символов - то 
                //выводится предупреждение о некоррекности
                //и в поле name записывается строка none
                if (value.Length >= 3 || value.Length <= 50) //bvz 
                    name = value;
                else
                {
                    Console.WriteLine("длина имени от 3 до 50 символов");
                    name = "none";
                }
            }
        }
        int lifeExp; //закрытое поле продолжительности жизни
        public int LifeExpectancy //свойство продолжительности жизни, проверяющее что значение не меньше нуля
                                  //и если оно меньше - обнуляет
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
