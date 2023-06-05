using System.Linq;
using System.Windows;
using tren1.Model;

namespace tren1
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

        private void Vhod_Click(object sender, RoutedEventArgs e)
        {
            var db = new ekzEntities();
            var User = db.Users.AsNoTracking().FirstOrDefault(u => u.Login == LogBox.Text && u.Password == PassBox.Text);
            if (User != null) 
            {
                if (User.Role == 1)
                {
                    Manager MW = new Manager();
                    MW.Show();
                    Close();
                }
                if (User.Role == 2)
                {
                    Kladovshik MW = new Kladovshik();
                    MW.Show();
                    Close();
                }
                if (User.Role == 3)
                {
                    Director MW = new Director();
                    MW.Show();
                    Close();
                }
                if (User.Role == 4)
                {
                    Postavka MW = new Postavka();
                    MW.Show();
                    Close();
                }
            }
                else
                {
                MessageBox.Show("логин либо пароль не верны");
                 }
                
            }

                    private void Vihod_Click(object sender, RoutedEventArgs e)
            {
                Close();
            }
        }
    }

