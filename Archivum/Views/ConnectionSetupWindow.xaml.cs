using System.Windows;
using Archivum.ViewModels;

namespace Archivum.Views;

public partial class ConnectionSetupWindow : Window
{
    public ConnectionSetupWindow()
    {
        InitializeComponent();
        DataContext = new ConnectionSetupViewModel();
    }
}