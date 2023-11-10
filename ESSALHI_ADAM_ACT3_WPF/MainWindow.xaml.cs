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

namespace ESSALHI_ADAM_ACT3_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TxtA.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            TxtB.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            TxtC.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);

        }
        public void VerifTextInput(Object sender, TextCompositionEventArgs e)
        {          

            if (e.Text != "," && !EstEntier(e.Text))
            {
                e.Handled = true;
            }

        }
        private bool EstEntier(string texteUser)
        {
            string texteUser.TryParse
        }




    }
}
