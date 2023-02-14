using Lapshin_FitnessClub.ClassHelper;
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
    /// Логика взаимодействия для RegistrationContinue.xaml
    /// </summary>
    public partial class RegistrationContinue : Page
    {
        public RegistrationContinue()
        {
            InitializeComponent();
        }

        private void TbBackUri_MouseEnter(object sender, MouseEventArgs e)
        {
            TbBackUri.TextDecorations = TextDecorations.Underline;
            TbBackUri.Foreground = new SolidColorBrush(Color.FromArgb(255, 92, 166, 250));
        }

        private void TbBackUri_MouseLeave(object sender, MouseEventArgs e)
        {
            TbBackUri.TextDecorations = null;
            TbBackUri.Foreground = new SolidColorBrush(Color.FromArgb(255, 12, 121, 245));
        }

        private void TbBackUri_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            NavigationService.Navigate(ClassHelper.PageMaster.registration);
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            ConnectionClass cc = new ConnectionClass();
            
            if (!String.IsNullOrWhiteSpace(TbxFirstName.Text)
                && !String.IsNullOrWhiteSpace(TbxLastName.Text))
            {
                cc.newUser.firstName = TbxFirstName.Text;
                cc.newUser.lastName = TbxLastName.Text;
                if(!String.IsNullOrWhiteSpace(TbxPatronymic.Text))
                {
                    cc.newUser.patronymic = TbxPatronymic.Text;
                }
                cc.newUser.phone = TbxPhone.Text;
                cc.newUser.birthday = DpBirthday.SelectedDate.Value;

                //cc.newUser.Gender.id
            }
        }
    }
}
