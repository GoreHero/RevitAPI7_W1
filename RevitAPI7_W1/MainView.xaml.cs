using Autodesk.Revit.UI;
using System;
using System.Windows;

namespace RevitAPI7_W1
{
    /// <summary>
    /// Логика взаимодействия для MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView(ExternalCommandData commandData)
        {
            InitializeComponent();
            MainViewViewModel vm = new MainViewViewModel(commandData);
            vm.CloseRequest += (s, e) => this.Close();
            DataContext = vm;
        }
    }
}
