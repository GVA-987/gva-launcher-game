using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GVA_Launcher_Private.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddGame_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Games and Executable (*.exe)|*.exe|All files (.)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                // Get the path of the selected file
                string gamePath = openFileDialog.FileName;

                // For now, let's just show a message with the path
                MessageBox.Show("Selected game: " + gamePath, "Game Added!");
            }
        }
    }
}