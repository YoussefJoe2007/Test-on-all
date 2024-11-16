using System.Windows;
using System.Windows.Controls;
using Test_on_all;

namespace Test_on_all
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new UserManagementWindow().Show();
            new ViewTasksWindow().Show();


        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
