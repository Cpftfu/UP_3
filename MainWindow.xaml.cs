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

using UP_3.MagazineDataSetTableAdapters;
namespace UP_3
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		ClientsTableAdapter clients = new ClientsTableAdapter();

		public MainWindow()
		{
			InitializeComponent();
			fullDataGrid.ItemsSource = clients.GetDataBy();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			fullDataGrid.Columns[0].Visibility = Visibility.Collapsed;
			fullDataGrid.Columns[5].Visibility = Visibility.Collapsed;
		}
	}
}
