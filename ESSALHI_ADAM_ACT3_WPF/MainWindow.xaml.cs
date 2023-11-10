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
            BtnCalculer.Click += new RoutedEventHandler (BtnCalculer_Click);
            BtnCalculer.MouseEnter += new MouseEventHandler(SurvolBouton);
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
            else if (e.Text != ",")
            {
                if (((TextBox)sender).Text.IndexOf(e.Text) > -1)
                {
                    e.Handled = true;
                }
        }
 
        }
        private bool EstEntier(string texteUser)
        {
            int n;

            if (int.TryParse(texteUser, out n))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void BtnCalculer_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(TxtA.Text);
            double b = double.Parse(TxtB.Text);
            double c = double.Parse(TxtC.Text);
            string type;
            MethodesDuProjet mesOutils = new MethodesDuProjet();
            mesOutils.ResoudTrinome(a, b, c, out type);

        }
        private void SurvolBouton(object sender, MouseEventArgs e)
        {

        }






    }
}
