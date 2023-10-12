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
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // заполняет тем что уже есть в tasks.txt
            string s;
            StreamReader f = new StreamReader("tasks.txt");
            while ((s = f.ReadLine()) != null)
            {
                lstNames.Items.Add(s);
            }
            f.Close();
        }

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
            {
                string name = txtName.Text;
                var t = new Task(name + "");
                t.create(txtName.Text + "\n");
                lstNames.Items.Add(txtName.Text);
                txtName.Clear();
            }

        }
    }
}
