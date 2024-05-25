using System.Diagnostics;
using System.Reflection.PortableExecutable;
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
using static System.Net.Mime.MediaTypeNames;

namespace _07_WPF_SwordDamage_Final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random random = new Random();
        SwordDamage swordDamage = new SwordDamage(RollDice());
        public MainWindow()
        {
            InitializeComponent();
            SetMagic(false);
            SetFlaming(false);
            swordDamage.Roll = RollDice();
            DisplayDamage();
        }
        public static int RollDice()
        {
            int rollDice = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
            return rollDice;
        }

        public void SetMagic(bool isMagic)
        {
            if (isMagic)
            {
                swordDamage.Magic = 1.75M;
            }
            else
            {
                swordDamage.Magic = 1M;
            }
        }
        public void SetFlaming(bool isFlaming)
        {
            if (isFlaming)
            {
                swordDamage.Flaming = 2;
            }
            else
            {
                swordDamage.Flaming = 0;
            }
        }


        void DisplayDamage()
        {
            damage.Text = "Rolled " + swordDamage.Roll + " for " + swordDamage.Damage + " HP";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            swordDamage.Roll = RollDice();
            DisplayDamage();
        }
        private void flaming_Checked(object sender, RoutedEventArgs e)
        {
            SetFlaming(true);
            DisplayDamage();
        }
        private void flaming_Unchecked(object sender, RoutedEventArgs e)
        {
            SetFlaming(false);
            DisplayDamage();
        }
        private void magic_Checked(object sender, RoutedEventArgs e)
        {
            SetMagic(true);
            DisplayDamage();
        }
        private void magic_Unchecked(object sender, RoutedEventArgs e)
        {
            SetMagic(false);
            DisplayDamage();
        }
    }
}