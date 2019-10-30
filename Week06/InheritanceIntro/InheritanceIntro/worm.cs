using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    class worm : animal
    {
        public worm()
        {

        }
        public worm(int height, string name)
        {
            this.height = height;
            this.name = name;
        }

        public void vibrate()
        {
            MessageBox.Show("vibrate");
        }
    }
}
