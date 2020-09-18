using System;
using System.Collections.Generic;
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
using Syncfusion.Windows.Controls.Input;

namespace SfRating_GettingStarted
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rating.ValueChanged += Rating_ValueChanged;
        }

        private void Rating_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            ratingLabel.Content = "Rating :" + " " + e.NewValue+" /5";
        }
    }
}

