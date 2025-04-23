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

namespace smartShop_3;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    // open modal window
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        MyModalWindow modal = new MyModalWindow();
        modal.Owner = this; // Asosiy oynani owner qilish (tavsiya etiladi)
        modal.ShowDialog(); // Modal tarzda ochiladi
    }
}