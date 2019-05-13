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

namespace Homework5
{
    /// <summary>
    /// Catherine Powell Homework 5 
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Initialize button list.  
            UIElementCollection element = uxGrid.Children;
            List<FrameworkElement> elements = element.Cast<FrameworkElement>().ToList();
            buttons = elements.OfType<Button>().ToList();

            DoNewGame();

        }

        //To keep track of X or O
        bool isX = true;  //Initialize isX to true

        //Ref to a list of all buttons.
        List<Button> buttons;


        private void uxNewGame_Click(object sender, RoutedEventArgs e)
        {
            DoNewGame();

        }

        void DoNewGame()
        {
            isX = true;
            ClearButtonText();
            EnableDisableAllButtons(true);
            SetButtonForeground(Brushes.Black);

        }

        void ClearButtonText()
        {
            buttons.ForEach(b => b.Content = "");

        }


        void EnableDisableAllButtons(bool enabled)
        {
            buttons.ForEach(b => b.IsEnabled = enabled);

        }

        void SetButtonForeground(Brush brush)
        {
            buttons.ForEach(b => b.Foreground = brush);

        }


        private void uxExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button cmd = (Button)sender;

            if (isX)
            {
                cmd.Content = "X";
                isX = false;

            }
            else
            {
                cmd.Content = "O";
                isX = true;
            }

            cmd.IsEnabled = false;

            bool gameOver = CheckForWinner();
            if (gameOver) EnableDisableAllButtons(false);

        }


        bool CheckForWinner()
        {
            bool isWinner = false;


            Button ZeroZero = buttons.SingleOrDefault(b => b.Tag.ToString() == "0,0");
            Button ZeroOne = buttons.SingleOrDefault(b => b.Tag.ToString() == "0,1");
            Button ZeroTwo = buttons.SingleOrDefault(b => b.Tag.ToString() == "0,2");

            Button OneZero = buttons.SingleOrDefault(b => b.Tag.ToString() == "1,0");
            Button OneOne = buttons.SingleOrDefault(b => b.Tag.ToString() == "1,1");
            Button OneTwo = buttons.SingleOrDefault(b => b.Tag.ToString() == "1,2");

            Button TwoZero = buttons.SingleOrDefault(b => b.Tag.ToString() == "2,0");
            Button TwoOne = buttons.SingleOrDefault(b => b.Tag.ToString() == "2,1");
            Button TwoTwo = buttons.SingleOrDefault(b => b.Tag.ToString() == "2,2");


            //---------------------------Rows---------------------------------


            //First Row.
            if (ZeroZero.Content.ToString() != string.Empty && ZeroZero.Content.ToString() ==  ZeroOne.Content.ToString() && ZeroOne.Content.ToString() == ZeroTwo.Content.ToString())
            {
                ZeroZero.Foreground = Brushes.Red;
                ZeroOne.Foreground = Brushes.Red;
                ZeroTwo.Foreground = Brushes.Red;
                string content = ZeroZero.Content.ToString();
                MessageBox.Show("Winner is " + content);
                isWinner = true;

            }

            //Second Row.
            if (OneZero.Content.ToString() != string.Empty && OneZero.Content.ToString() == OneOne.Content.ToString() && OneOne.Content.ToString() == OneTwo.Content.ToString())
            {
                OneZero.Foreground = Brushes.Red;
                OneOne.Foreground = Brushes.Red;
                OneTwo.Foreground = Brushes.Red;
                string content = OneZero.Content.ToString();
                MessageBox.Show("Winner is " + content);
                isWinner = true;

            }


            //Third Row.
            if (TwoZero.Content.ToString() != string.Empty && TwoZero.Content.ToString() == TwoOne.Content.ToString() && TwoOne.Content.ToString() == TwoTwo.Content.ToString())
            {
                TwoZero.Foreground = Brushes.Red;
                TwoOne.Foreground = Brushes.Red;
                TwoTwo.Foreground = Brushes.Red;
                string content = TwoZero.Content.ToString();
                MessageBox.Show("Winner is " + content);
                isWinner = true;

            }


            //---------------------------Columns---------------------------------

            //First Col.
            if (ZeroZero.Content.ToString() != string.Empty && ZeroZero.Content.ToString() == OneZero.Content.ToString() && OneZero.Content.ToString() == TwoZero.Content.ToString())
            {
                ZeroZero.Foreground = Brushes.Red;
                OneZero.Foreground = Brushes.Red;
                TwoZero.Foreground = Brushes.Red;
                string content = ZeroZero.Content.ToString();
                MessageBox.Show("Winner is " + content);
                isWinner = true;

            }

            //Second Col.
            if (ZeroOne.Content.ToString() != string.Empty && ZeroOne.Content.ToString() == OneOne.Content.ToString() && OneOne.Content.ToString() == TwoOne.Content.ToString())
            {
                ZeroOne.Foreground = Brushes.Red;
                OneOne.Foreground = Brushes.Red;
                TwoOne.Foreground = Brushes.Red;
                string content = ZeroOne.Content.ToString();
                MessageBox.Show("Winner is " + content);
                isWinner = true;

            }


            //Third Col.
            if (ZeroTwo.Content.ToString() != string.Empty && ZeroTwo.Content.ToString() == OneTwo.Content.ToString() && OneTwo.Content.ToString() == TwoTwo.Content.ToString())
            {
                ZeroTwo.Foreground = Brushes.Red;
                OneTwo.Foreground = Brushes.Red;
                TwoTwo.Foreground = Brushes.Red;
                string content = ZeroTwo.Content.ToString();
                MessageBox.Show("Winner is " + content);
                isWinner = true;

            }



            //---------------------------Diagonal---------------------------------

            //Left Down.
            if (ZeroZero.Content.ToString() != string.Empty && ZeroZero.Content.ToString() == OneOne.Content.ToString() && OneOne.Content.ToString() == TwoTwo.Content.ToString())
            {
                ZeroZero.Foreground = Brushes.Red;
                OneOne.Foreground = Brushes.Red;
                TwoTwo.Foreground = Brushes.Red;
                string content = ZeroZero.Content.ToString();
                MessageBox.Show("Winner is " + content);
                isWinner = true;

            }

            //Left Up.
            if (TwoZero.Content.ToString() != string.Empty && TwoZero.Content.ToString() == OneOne.Content.ToString() && OneOne.Content.ToString() == ZeroTwo.Content.ToString())
            {
                TwoZero.Foreground = Brushes.Red;
                OneOne.Foreground = Brushes.Red;
                ZeroTwo.Foreground = Brushes.Red;
                string content = TwoZero.Content.ToString();
                MessageBox.Show("Winner is " + content);
                isWinner = true;

            }






            return isWinner;

        }
    }
}
