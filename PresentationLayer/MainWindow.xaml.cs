using PresentationLayer.UIProcessComponents;
using System.Windows;

namespace PresentationLayer.UIComponents
{
    //namespace UIComponents
    //{
    //using UIProcessComponents;

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Calc.DataContext = new CalcViewModel();
        }
    }
    //}
}
