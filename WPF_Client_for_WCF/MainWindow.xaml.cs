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
using WPF_Client_for_WCF.ComplexTest;

namespace WPF_Client_for_WCF
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

        Service1Client dd = new Service1Client();
       

       

        private void ButtonDevice_Click(object sender, RoutedEventArgs e)
        {
            if (TextBlockNumerReal.Text != "Real" || TextBlockNumerReal.Text != null || TextBlockNumerUnreal.Text != "Unreal" || TextBlockNumerUnreal.Text != null ||
               TextBlockNumerReal2.Text != "Real" || TextBlockNumerReal2.Text != null || TextBlockNumerUnreal2.Text != "Unreal" || TextBlockNumerUnreal2.Text != null)
            {
               TextBlockResult.Text = dd.Subtract(Convert.ToDouble(TextBlockNumerReal.Text), Convert.ToDouble(TextBlockNumerUnreal.Text), Convert.ToDouble(TextBlockNumerReal.Text), Convert.ToDouble(TextBlockNumerUnreal.Text));
            }
        }

        private void ButtonMultiple_Click(object sender, RoutedEventArgs e)
        {
            if (TextBlockNumerReal.Text != "Real" || TextBlockNumerReal.Text != null || TextBlockNumerUnreal.Text != "Unreal" || TextBlockNumerUnreal.Text != null ||
                TextBlockNumerReal2.Text != "Real" || TextBlockNumerReal2.Text != null || TextBlockNumerUnreal2.Text != "Unreal" || TextBlockNumerUnreal2.Text != null)
            {
                TextBlockResult.Text = dd.Multiply(Convert.ToDouble(TextBlockNumerReal.Text), Convert.ToDouble(TextBlockNumerUnreal.Text), Convert.ToDouble(TextBlockNumerReal.Text), Convert.ToDouble(TextBlockNumerUnreal.Text));
            }
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            if (TextBlockNumerReal.Text != "Real" || TextBlockNumerReal.Text != null || TextBlockNumerUnreal.Text != "Unreal" || TextBlockNumerUnreal.Text != null ||
               TextBlockNumerReal2.Text != "Real" || TextBlockNumerReal2.Text != null || TextBlockNumerUnreal2.Text != "Unreal" || TextBlockNumerUnreal2.Text != null)
            {
                TextBlockResult.Text =  dd.Divide(Convert.ToDouble(TextBlockNumerReal.Text), Convert.ToDouble(TextBlockNumerUnreal.Text), Convert.ToDouble(TextBlockNumerReal.Text), Convert.ToDouble(TextBlockNumerUnreal.Text));
            }
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            if (TextBlockNumerReal.Text != "Real" || TextBlockNumerReal.Text != null || TextBlockNumerUnreal.Text != "Unreal" || TextBlockNumerUnreal.Text != null || 
                TextBlockNumerReal2.Text != "Real" || TextBlockNumerReal2.Text != null || TextBlockNumerUnreal2.Text != "Unreal" || TextBlockNumerUnreal2.Text != null)
                
            {
                //System.Windows.MessageBox.Show("chuj, mam cie");
                TextBlockResult.Text = dd.Add(Convert.ToDouble(TextBlockNumerReal.Text), Convert.ToDouble(TextBlockNumerUnreal.Text), Convert.ToDouble(TextBlockNumerReal.Text), Convert.ToDouble(TextBlockNumerUnreal.Text));
            }
        }
        private void ButtonZero_Click(object sender, RoutedEventArgs e)
        {
           
            if (array[0] != null)
            {

                if (TextBlockNumerReal.Text == "0")
                {
                    TextBlockNumerReal.Text = "0";
                    return;
                }
                else TextBlockNumerReal.Text += "0";
            }
            if (array[1] != null)
            {
                if (TextBlockNumerUnreal.Text == "0")
                {
                    TextBlockNumerUnreal.Text = "0";
                    return;
                }
                else TextBlockNumerUnreal.Text += "0";
            }
            if (array[2] != null)
            {
                if (TextBlockNumerReal2.Text == "0")
                {
                    TextBlockNumerReal2.Text = "0";
                    return;
                }
                else TextBlockNumerReal2.Text += "0";
            }
            if (array[3] != null)
            {
                if (TextBlockNumerUnreal2.Text == "0")
                {
                    TextBlockNumerUnreal2.Text = "0";
                    return;
                }
                else TextBlockNumerUnreal2.Text += "0";
            }



        }
        private void Button9_Click(object sender, RoutedEventArgs e)
        {


            if (array[0] != null)
            {
                TextBlockNumerReal.Text += "9";
            }
            if (array[1] != null)
            {
                TextBlockNumerUnreal.Text += "9";
            }
            if (array[2] != null)
            {
                TextBlockNumerReal2.Text += "9";
            }
            if (array[3] != null)
            {
                TextBlockNumerUnreal2.Text += "9";
            }
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {


            if (array[0] != null)
            {
                TextBlockNumerReal.Text += "3";
            }
            if (array[1] != null)
            {
                TextBlockNumerUnreal.Text += "3";
            }
            if (array[2] != null)
            {
                TextBlockNumerReal2.Text += "3";
            }
            if (array[3] != null)
            {
                TextBlockNumerUnreal2.Text += "3";
            }
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (array[0] != null)
            {
                TextBlockNumerReal.Text += "6";
            }
            if (array[1] != null)
            {
                TextBlockNumerUnreal.Text += "6";
            }
            if (array[2] != null)
            {
                TextBlockNumerReal2.Text += "6";
            }
            if (array[3] != null)
            {
                TextBlockNumerUnreal2.Text += "6";
            }
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (array[0] != null)
            {
                TextBlockNumerReal.Text += "8";
            }
            if (array[1] != null)
            {
                TextBlockNumerUnreal.Text += "8";
            }
            if (array[2] != null)
            {
                TextBlockNumerReal2.Text += "8";
            }
            if (array[3] != null)
            {
                TextBlockNumerUnreal2.Text += "8";
            }
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (array[0] != null)
            {
                TextBlockNumerReal.Text += "2";
            }
            if (array[1] != null)
            {
                TextBlockNumerUnreal.Text += "2";
            }
            if (array[2] != null)
            {
                TextBlockNumerReal2.Text += "2";
            }
            if (array[3] != null)
            {
                TextBlockNumerUnreal2.Text += "2";
            }
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (array[0] != null)
            {
                TextBlockNumerReal.Text += "5";
            }
            if (array[1] != null)
            {
                TextBlockNumerUnreal.Text += "5";
            }
            if (array[2] != null)
            {
                TextBlockNumerReal2.Text += "5";
            }
            if (array[3] != null)
            {
                TextBlockNumerUnreal2.Text += "5";
            }
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (array[0] != null)
            {
                TextBlockNumerReal.Text += "7";
            }
            if (array[1] != null)
            {
                TextBlockNumerUnreal.Text += "7";
            }
            if (array[2] != null)
            {
                TextBlockNumerReal2.Text += "7";
            }
            if (array[3] != null)
            {
                TextBlockNumerUnreal2.Text += "7";
            }
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (array[0] != null)
            {
                TextBlockNumerReal.Text += "4";
            }
            if (array[1] != null)
            {
                TextBlockNumerUnreal.Text += "4";
            }
            if (array[2] != null)
            {
                TextBlockNumerReal2.Text += "4";
            }
            if (array[3] != null)
            {
                TextBlockNumerUnreal2.Text += "4";
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

            if (array[0] != null)
            {
                TextBlockNumerReal.Text += "1";
            }
            if (array[1] != null)
            {
                TextBlockNumerUnreal.Text += "1";
            }
            if (array[2] != null)
            {
                TextBlockNumerReal2.Text += "1";
            }
            if (array[3] != null)
            {
                TextBlockNumerUnreal2.Text += "1";
            }
        }

        private void ButtonDouble_Click(object sender, RoutedEventArgs e)
        {
            if (array[0] != null)
            {
                if (TextBlockNumerReal.Text == "") TextBlockNumerReal.Text = "0";
                else TextBlockNumerReal.Text += "00";
            }
            if (array[1] != null)
            {
                if (TextBlockNumerUnreal.Text == "") TextBlockNumerUnreal.Text = "0";
                else TextBlockNumerUnreal.Text += "00";
            }
            if (array[2] != null)
            {
                if (TextBlockNumerReal2.Text == "") TextBlockNumerReal2.Text = "0";
                else TextBlockNumerReal2.Text += "00";
            }
            if (array[3] != null)
            {
                if (TextBlockNumerUnreal2.Text == "") TextBlockNumerUnreal2.Text = "0";
                else TextBlockNumerUnreal2.Text += "00";
            }



        }

        private void ButtonDot_Click(object sender, RoutedEventArgs e)
        {
          

            if (array[0] != null)
            {
                if (TextBlockNumerReal.Text == "")
                {
                    TextBlockNumerReal.Text = "";
                    return;
                }
                if (TextBlockNumerReal.Text.Contains(",")) return;

                TextBlockNumerReal.Text += ",";
            }
            if (array[1] != null)
            {
                if (TextBlockNumerUnreal.Text == "")
                {
                    TextBlockNumerUnreal.Text = "";
                    return;
                }
                if (TextBlockNumerUnreal.Text.Contains(",")) return;

                TextBlockNumerUnreal.Text += ",";
            }
            if (array[2] != null)
            {
                if (TextBlockNumerReal2.Text == "")
                {
                    TextBlockNumerReal2.Text = "";
                    return;
                }
                if (TextBlockNumerReal2.Text.Contains(",")) return;

                TextBlockNumerReal2.Text += ",";
            }
            if (array[3] != null)
            {
                if (TextBlockNumerUnreal2.Text == "")
                {
                    TextBlockNumerUnreal2.Text = "";
                    return;
                }
                if (TextBlockNumerUnreal2.Text.Contains(",")) return;

                TextBlockNumerUnreal2.Text += ",";
            }

        }
        /// <summary>
        /// /focus
        /// </summary>
       private Control[] array = new Control[4];

        private void Border_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TextBlockNumerReal.Text == "Real")
                TextBlockNumerReal.Text = "";


            array[0] = (Control)sender;
            array[1] = null;
            array[2] = null;
            array[3] = null;
        }
        private void TextBlockNumerUnreal_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TextBlockNumerUnreal.Text == "Unreal")
                TextBlockNumerUnreal.Text = "";

            array[0] = null;
            array[1] = (Control)sender;
            array[2] = null;
            array[3] = null;
        }

       

        private void TextBlockNumerReal2_GotFocus2(object sender, RoutedEventArgs e)
        {
            if (TextBlockNumerReal2.Text == "Real")
                TextBlockNumerReal2.Text = "";
            array[0] = null;
            array[1] = null;
            array[2] = (Control)sender;
            array[3] = null;
        }

        private void TextBlockNumerUnreal2_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TextBlockNumerUnreal2.Text == "Unreal")
                TextBlockNumerUnreal2.Text = "";
            array[0] = null;
            array[1] = null;
            array[2] = null;
            array[3] = (Control)sender;
            
            
        }
    }
}
