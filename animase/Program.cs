using System;

namespace animase
{
    class Animal
    {
        public string name;
        public int age;
        public string color;
        protected string voice;
        protected int speed;

        public int Getspeed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
            
            
        }
        
        public string Getvoice
        {
            get{return voice;}
            set{voice = value;}
        }
        
        
       
    }

    class Dog : Animal
        {
            public Dog()
            {
                speed = 656;
                voice = "hawaw";
            }

            Dog(string name, int age, string color, int speed)
            {
                speed = speed;
                voice = voice;
            }
        }

        class Cat : Animal
        {
            public Cat()
            {
                speed = 26;
                voice = "meow meow";
            }

            Cat(string name, int age, string color, int speed)
            {
                speed = speed;
                voice = voice;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Dog dog = new Dog();
                Cat cat = new Cat();
                
                
                Console.WriteLine("dog speed "+dog.Getspeed+" km Voice "+dog.Getvoice);
                Console.WriteLine("cat speed "+cat.Getspeed+" km Voice "+cat.Getvoice);
                



            }
        }
    
}