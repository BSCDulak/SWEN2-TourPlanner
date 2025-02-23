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

namespace SWEN2_TourPlanner;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void AddButton_Click(object sender, RoutedEventArgs e)
    {
        ItemList.Items.Add(UserInput.Text);
        UserInput.Clear();
        UserInput.Focus();
    }

    private void AddViaEnter(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            AddButton_Click(sender, e);
        }
    }

    private void DeleteSelectedButton_Click(object sender, RoutedEventArgs e)
    {
        while (ItemList.SelectedItems.Count > 0)
        {
            ItemList.Items.Remove(ItemList.SelectedItem);
        }
    }
}