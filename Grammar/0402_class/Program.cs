using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0402_class
{
    class Cat
    {
        public string name;
        public string color;
        public Cat()
        {
            name = "";
            color = "";
        }
        public Cat(string _name, string _color)
        {
            name = _name;
            color = _color;
        }
        ~Cat()
        {
            Console.WriteLine("{0}", name + " 잘가");
        }
        public void meow()
        {
            Console.WriteLine("{0}", name + " 냥");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat pingpong = new Cat();

            pingpong.name = "삥뽕";
            pingpong.color = "white";
            pingpong.meow();

            Cat nero = new Cat("네로", "black");
            nero.meow();
        }
    }
}
