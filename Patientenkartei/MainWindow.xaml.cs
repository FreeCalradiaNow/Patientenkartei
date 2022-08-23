using System.Windows;
using System.IO;
using System.Text;

namespace Patientenkartei
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

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            string content = textBoxContent.Text;
            string filename = textBoxFileName.Text;
            

            using (FileStream fs = File.Create(filename + ".txt"))
            {
                byte[] contentconvertedToBytes = Encoding.ASCII.GetBytes(content);
                fs.Write(contentconvertedToBytes, 0, contentconvertedToBytes.Length);

            }

            MessageBox.Show("Datei wurde angelegt.");
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
