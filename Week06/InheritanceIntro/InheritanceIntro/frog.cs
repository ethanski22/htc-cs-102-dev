using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    class frog : animal
    {
        public frog()
        {

        }
        public frog(int height, string name)
        {
            this.height = height;
            this.name = name;
        }

        public void ribbit()
        {
            MessageBox.Show("ribbit");
        }
        public void poisonous()
        {
            MessageBox.Show(name + " is poisonous");
        }
    }
}
