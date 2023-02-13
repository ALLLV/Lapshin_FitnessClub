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

namespace Lapshin_FitnessClub.Pages
{
    /// <summary>
    /// Логика взаимодействия для Authorisation.xaml
    /// </summary>
    public partial class Authorisation : Page
    {
        public Authorisation()
        {
            InitializeComponent();
            
        }

        private void TbRegUri_MouseEnter(object sender, MouseEventArgs e)
        {
            TbRegUri.TextDecorations = TextDecorations.Underline;
            TbRegUri.Foreground = new SolidColorBrush(Color.FromArgb(255, 92, 166, 250));
        }

        private void TbRegUri_MouseLeave(object sender, MouseEventArgs e)
        {
            TbRegUri.TextDecorations = null;
            TbRegUri.Foreground = new SolidColorBrush(Color.FromArgb(255, 12, 121, 245));
        }

        private void TbRegUri_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(ClassHelper.PageMaster.registration);
        }
    }
}
