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

namespace Wpf_styles
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = combobox.SelectedIndex;
            if (index == 0)
            {
                drAtr.Color = Colors.Black;
            }
            else if (index == 1)
            {
                drAtr.Color = Colors.Red;
            }
            else if (index == 2)
            {
                drAtr.Color = Colors.Blue;
            }
            else if (index == 3)
            {
                drAtr.Color = Colors.Green;
            }

        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            drAtr.Height = slider.Value;
            drAtr.Width = slider.Value;
        }

        private void radio1_Checked(object sender, RoutedEventArgs e)
        {
            Canvas.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void radio2_Checked(object sender, RoutedEventArgs e)
        {
            Canvas.EditingMode = InkCanvasEditingMode.Select;
        }

        private void radio3_Checked(object sender, RoutedEventArgs e)
        {
            Canvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
        }
    }
}
