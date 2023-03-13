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

namespace HomeTrainer.Pages.AuthRegPages
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

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            if (TbFName.Text != "" && TbLName.Text != "" && TbHeight.Text != "" &&
                TbWeight.Text != "" && TbAge.Text != "" && TbLogin.Text != "" && Password.Password != "")
            {

            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }
        }
    }
}
