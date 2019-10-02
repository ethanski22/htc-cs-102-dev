using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassesIntro
{
    public class Dog
    {
        public string Breed;
        public int Height;
        public string Name;
        public string Color;
        public int Age;

        public void Bark()
        {
            MessageBox.Show("Bark");
        }
        public void SayName()
        {
            MessageBox.Show("my name is " + Name);
        }
        public void NewDog()
        {
            MessageBox.Show("A new dog has arrison!");
        }
        
        public Dog() { }

        public Dog(string breed, int height, string name)
        {
            this.Breed = breed;
            this.Height = height;
            this.Name = name;
        }
    }
}
