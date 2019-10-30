using System.Windows;
using WpfEmployeesApp.ViewModel;

namespace WpfEmployeesApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			this.DataContext = new MainViewModel();
		}
	}
}
