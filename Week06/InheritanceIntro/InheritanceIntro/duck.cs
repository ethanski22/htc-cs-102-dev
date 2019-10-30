using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    public class duck : animal
    {
        public duck()
        {

        }
        public duck(int height, string name)
        {
            this.height = height;
            this.name = name;
        }

        public void quack()
        {
            MessageBox.Show("quack");
        }
    }
}
