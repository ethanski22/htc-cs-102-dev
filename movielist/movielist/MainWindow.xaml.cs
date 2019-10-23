using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace movielist
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<movie> movies = new ObservableCollection<movie>();
        public MainWindow()
        {
            InitializeComponent();
            lvmovies.ItemsSource = movies;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string title = titleinput.Text;
            string releasedate = releasedateinput.Text;
            int rottentomatoes = Convert.ToInt32(rottentomatoesinput.Text);
            
            movie movie = new movie(title, releasedate, rottentomatoes);
            movies.Add(movie);
        }
    }
}
