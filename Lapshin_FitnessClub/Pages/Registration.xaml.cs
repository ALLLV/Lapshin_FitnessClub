﻿using System;
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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void TbAuthUri_MouseEnter(object sender, MouseEventArgs e)
        {
            TbAuthUri.TextDecorations = TextDecorations.Underline;
            TbAuthUri.Foreground = new SolidColorBrush(Color.FromArgb(255, 92, 166, 250));
        }

        private void TbAuthUri_MouseLeave(object sender, MouseEventArgs e)
        {
            TbAuthUri.TextDecorations = null;
            TbAuthUri.Foreground = new SolidColorBrush(Color.FromArgb(255, 12, 121, 245));
        }

        private void TbAuthUri_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Authorisation());
        }

        private void BtnContinue_Click(object sender, RoutedEventArgs e)
        {
            if (TbxEmail.Text.Contains('@') && TbxEmail.Text.Contains('.')
                && TbxLogin.Text != ""
                && TbxPassword.Password != ""
                && TbxPasswordConfirm.Password == TbxPassword.Password)
            {
                NavigationService.Navigate(ClassHelper.PageMaster.registrationContinue);
            }
        }
    }
}
