using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    class tree : organism
    {
        public string leafcolor;
        public string typeofwood;
        public string typeoftree;
        public int height;

        public void trees()
        {
            MessageBox.Show(typeoftree + " has " + leafcolor + " leaves and is " + height + " tall.");
        }
    }
}
