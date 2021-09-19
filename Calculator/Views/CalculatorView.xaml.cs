using System.Windows;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
namespace Calculator.Views
{
    /// <summary>
    /// Interaction logic for CalculatorView.xaml
    /// </summary>
    public partial class CalculatorView : Window
    {
        public CalculatorView()
        {
            AppCenter.Start("7aeb13a3-4493-4b12-a587-45e8a0ec3a34",
                      typeof(Analytics), typeof(Crashes));
            InitializeComponent();
            
        }
    }
}
