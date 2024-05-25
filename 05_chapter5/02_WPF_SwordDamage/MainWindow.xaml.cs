using _01_SwordDamage;
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

namespace _02_WPF_SwordDamage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        SwordDamage swordDamage = new SwordDamage();
        public MainWindow()
        {
            InitializeComponent();
            swordDamage.SetMagic(false);
            swordDamage.SetFlaming(false);
            RollDice();
        }
        public void RollDice()
        {
            swordDamage.Roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
            swordDamage.SetFlaming(flaming.IsChecked.Value);
            swordDamage.SetMagic(magic.IsChecked.Value);
            DisplayDamage();
        }
        void DisplayDamage()
        {
            damage.Text = "Rolled " + swordDamage.Roll + " for " + swordDamage.Damage + " HP";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RollDice();
        }
        private void flaming_Checked(object sender, RoutedEventArgs e)
        {
            swordDamage.SetFlaming(true);
            DisplayDamage();
        }
        private void flaming_Unchecked(object sender, RoutedEventArgs e)
        {
            swordDamage.SetFlaming(false);
            DisplayDamage();
        }
        private void magic_Checked(object sender, RoutedEventArgs e)
        {
            swordDamage.SetMagic(true);
            DisplayDamage();
        }
        private void magic_Unchecked(object sender, RoutedEventArgs e)
        {
            swordDamage.SetMagic(false);
            DisplayDamage();
        }
    }
}