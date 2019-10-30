using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    public class animal : organism
    {
        public int height;
        public string name;

        public void sayname()
        {
            MessageBox.Show("my name is " + name + ".");
        }
    }
}
