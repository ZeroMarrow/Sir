using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace Sir
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

        private void batton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            int day = int.Parse(x1.Text);
            string mounth = (X1.Text);
                switch (mounth)
                {
                    case "Январь":
                        if (day >= 1 && day < 21)
                        {
                            vivod.Text = "Ваш знак зодиака: Козерог";
                        }
                        if (day >= 21 && day <= 31)
                        {
                            vivod.Text = ("Ваш знак зодиака: Водолей");
                        }
                        break;
                    case "Февраль":
                        if (day >= 1 && day < 20)
                        {
                            vivod.Text = ("Ваш знак зодиака: Водолей");
                        }
                        if (day >= 20 && day <= 31)
                        {
                            vivod.Text = ("Ваш знак зодиака: Рыбы");
                        }
                        break;
                    case "Март":
                        if (day >= 1 && day < 21)
                        {
                            vivod.Text = ("Ваш знак зодиака: Рыбы");
                        }
                        if (day >= 21 && day <= 31)
                        {
                            vivod.Text = ("Ваш знак зодиака: Овен");
                        }
                        break;
                    case "Апрель":
                        if (day >= 1 && day < 21)
                        {
                            vivod.Text = ("Ваш знак зодиака: Овен");
                        }
                        if (day >= 21 && day <= 31)
                        {
                            vivod.Text = ("Ваш знак зодиака: Телец");
                        }
                        break;
                    case "Май":
                        if (day >= 1 && day < 21)
                        {
                            vivod.Text = ("Ваш знак зодиака: Телец");
                        }
                        if (day >= 21 && day <= 31)
                        {
                            vivod.Text = ("Ваш знак зодиака: Близнецы");
                        }
                        break;
                    case "Июнь":
                        if (day >= 1 && day < 21)
                        {
                            vivod.Text = ("Ваш знак зодиака: Близнецы");
                        }
                        if (day >= 21 && day <= 31)
                        {
                            vivod.Text = ("Ваш знак зодиака: Рак");
                        }
                        break;
                    case "Июль":
                        if (day >= 1 && day < 21)
                        {
                            vivod.Text = ("Ваш знак зодиака: Рак");
                        }
                        if (day >= 21 && day <= 31)
                        {
                            vivod.Text = ("Ваш знак зодиака: Лев");
                        }
                        break;
                    case "Август":
                        if (day >= 1 && day < 21)
                        {
                            vivod.Text = ("Ваш знак зодиака: Лев");
                        }
                        if (day >= 21 && day <= 31)
                        {
                            vivod.Text = ("Ваш знак зодиака: Дева");
                        }
                        break;
                    case "Сентябрь":
                        if (day >= 1 && day < 21)
                        {
                            vivod.Text = ("Ваш знак зодиака: Дева");
                        }
                        if (day >= 21 && day <= 31)
                        {
                            vivod.Text = ("Ваш знак зодиака: Весы");
                        }
                        break;
                    case "Октябрь":
                        if (day >= 1 && day < 21)
                        {
                            vivod.Text = ("Ваш знак зодиака: Весы");
                        }
                        if (day >= 21 && day <= 31)
                        {
                            vivod.Text = ("Ваш знак зодиака: Скорпион");
                        }
                        break;
                    case "Ноябрь":
                        if (day >= 1 && day < 21)
                        {
                            vivod.Text = ("Ваш знак зодиака: Скорпион");
                        }
                        if (day >= 21 && day <= 31)
                        {
                            vivod.Text = ("Ваш знак зодиака: Стрелец");
                        }
                        break;
                    case "Декабрь":
                        if (day >= 1 && day < 21)
                        {
                            vivod.Text = ("Ваш знак зодиака: Стрелец");
                        }
                        if (day >= 21 && day <= 31)
                        {
                            vivod.Text = ("Ваш знак зодиака: Козерог");
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
