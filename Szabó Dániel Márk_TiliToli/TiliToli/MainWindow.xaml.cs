using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace TiliToli
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int db = 0;

        public MainWindow()
        {
            InitializeComponent();
            Button1.IsEnabled = false;
            Button2.IsEnabled = false;
            Button3.IsEnabled = false;
            Button4.IsEnabled = false;
            Button5.IsEnabled = false;
            Button6.IsEnabled = false;
            Button7.IsEnabled = false;
            Button8.IsEnabled = false;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Button egyikGomb = sender as Button;
            Button nullaGomb = (Button)FindName("Button0");
            int vtav = Math.Abs((int)(egyikGomb.Margin.Left - nullaGomb.Margin.Left));
            int ftav = Math.Abs((int)(egyikGomb.Margin.Top - nullaGomb.Margin.Top));
            if ((vtav < 115 && ftav == 0) || (ftav < 115 && vtav == 0))
            {
                var seged = egyikGomb.Margin;
                egyikGomb.Margin = nullaGomb.Margin;
                nullaGomb.Margin = seged;
                db++;
                Lepesszam.Content = "Lépésszám: " + db;
            }

            Button elsoGomb = (Button)FindName("Button1");
            Button kettoGomb = (Button)FindName("Button2");
            Button haromGomb = (Button)FindName("Button3");
            Button negyGomb = (Button)FindName("Button4");
            Button otGomb = (Button)FindName("Button5");
            Button hatGomb = (Button)FindName("Button6");
            Button hetGomb = (Button)FindName("Button7");
            Button nyolcGomb = (Button)FindName("Button8");
            if ((int)(elsoGomb.Margin.Left) == 10 && (int)(elsoGomb.Margin.Top) == 50 && (int)(kettoGomb.Margin.Left) == 115 && (int)(kettoGomb.Margin.Top) == 50 && (int)(haromGomb.Margin.Left) == 220 && (int)(haromGomb.Margin.Top) == 50)
            {
                if ((int)(negyGomb.Margin.Left) == 10 && (int)(negyGomb.Margin.Top) == 155 && (int)(otGomb.Margin.Left) == 115 && (int)(otGomb.Margin.Top) == 155 && (int)(hatGomb.Margin.Left) == 220 && (int)(hatGomb.Margin.Top) == 155)
                {
                    if ((int)(hetGomb.Margin.Left) == 10 && (int)(hetGomb.Margin.Top) == 260 && (int)(nyolcGomb.Margin.Left) == 115 && (int)(nyolcGomb.Margin.Top) == 260)
                    {
                        string message = "Sikeresen kiraktad " + Convert.ToString(db) + " lépésből.";
                        keszLabel.Content = message;
                        db = 0;
                        Button1.IsEnabled = false;
                        Button2.IsEnabled = false;
                        Button3.IsEnabled = false;
                        Button4.IsEnabled = false;
                        Button5.IsEnabled = false;
                        Button6.IsEnabled = false;
                        Button7.IsEnabled = false;
                        Button8.IsEnabled = false;
                        uj.IsEnabled = true;
                    }
                }
            }
        }

        private void _new_Click(object sender, RoutedEventArgs e)
        {
            Button1.IsEnabled = true;
            Button2.IsEnabled = true;
            Button3.IsEnabled = true;
            Button4.IsEnabled = true;
            Button5.IsEnabled = true;
            Button6.IsEnabled = true;
            Button7.IsEnabled = true;
            Button8.IsEnabled = true;
            uj.IsEnabled = false;
            keszLabel.Content = " ";
            byte veletlen = 0;
            byte most = 0;
            byte keveres = 0;
            Lepesszam.Content = "Lépésszám: ";
            Button nullGomb = (Button)FindName("Button0");
            Random r = new Random();
            do
            {
                do
                {
                    veletlen = Convert.ToByte(r.Next(1, 9));
                } while (most == veletlen);
                most = veletlen;
                string gomb = "Button" + veletlen;
                Button egyGomb = (Button)FindName(gomb);
                int vtav = Math.Abs((int)(egyGomb.Margin.Left - nullGomb.Margin.Left));
                int ftav = Math.Abs((int)(egyGomb.Margin.Top - nullGomb.Margin.Top));
                if ((vtav < 115 && ftav == 0) || (ftav < 115 && vtav == 0))
                {
                    var seged = egyGomb.Margin;
                    egyGomb.Margin = nullGomb.Margin;
                    nullGomb.Margin = seged;
                    keveres++;
                }
            } while (keveres != 80);
        }
    }
}
