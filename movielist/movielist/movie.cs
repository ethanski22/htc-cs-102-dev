using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace movielist
{
    public class movie
    {
        public string title;
        public int releaseyear;
        public movie(string title, int releaseyear)
        {
            //this means it goes to the public string and int to get the var
            this.title = title;
            this.releaseyear = releaseyear;

        }
        public void showdetails()
        {
            MessageBox.Show(title + " was released in " + releaseyear);
        }

    }
}
