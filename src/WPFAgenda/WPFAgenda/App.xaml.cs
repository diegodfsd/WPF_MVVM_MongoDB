using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using WPFAgenda.ViewModels;

namespace WPFAgenda
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            TodosContatosViewModel todosContatosViewModel = new TodosContatosViewModel();
            MainWindow mainWindow = new MainWindow();
            mainWindow.DataContext = todosContatosViewModel;
            mainWindow.Show();
        }
    }
}
