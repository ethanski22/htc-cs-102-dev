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

        public string title { get; set; }
        public string releasedate { get; set; }
        public int rottentomatoes { get; set; }

        public movie(string title, string releasedate, int rottentomatoes)
        {
            //this. means it goes to the public string and int to get the var
            this.title = title;
            this.releasedate = releasedate;
            this.rottentomatoes = rottentomatoes;

        }
        public void showdetails()
        {
            MessageBox.Show(title + " was released in " + releasedate);
        }

    }
}
