using Lapshin_FitnessClub.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace Lapshin_FitnessClub
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ClassHelper.PageMaster.registration = new Registration();
            ClassHelper.PageMaster.registrationContinue = new RegistrationContinue();
            ClassHelper.PageMaster.authorisation = new Authorisation();

            //Page Auth = new Authorisation();

            MainFrame.Navigate(ClassHelper.PageMaster.authorisation);
        }
    }
}
