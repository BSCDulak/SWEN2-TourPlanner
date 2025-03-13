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

namespace SWEN2_TourPlanner.Views.UserControls
{
    /// <summary>
    /// Interaction logic for MenuBar.xaml
    /// </summary>
    public partial class MenuBar : UserControl
    {
        public MenuBar()
        {
            InitializeComponent();
        }
    }

    private void AddButton_Click(object sender, RoutedEventArgs e)
    {
        ItemList.Items.Add(UserInput.Text);
        UserInput.Clear();
        UserInput.Focus();
    }

    void AddViaEnter(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            AddButton_Click(sender, e);
        }
    }
    }
