using System.Windows;
using System.Windows.Controls;
using Archivum.Services;
using Archivum.ViewModels;

namespace Archivum.Views;

public partial class ConnectExistingDatabaseWindow : Window
{
    public ConnectExistingDatabaseWindow()
    {
        InitializeComponent();
        DataContext = new ConnectExistingDatabaseViewModel(new ConnectionsRegistryService());
    }

    private void DbPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
    {
        if (DataContext is ConnectExistingDatabaseViewModel vm)
            vm.DbPassword = ((PasswordBox)sender).Password;
    }
}