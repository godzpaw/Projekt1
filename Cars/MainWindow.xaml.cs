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
using System.ComponentModel;
using System.Data;

namespace Cars
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AutaEntities context = new AutaEntities();
        public MainWindow()
        {

            InitializeComponent();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            context.Autas.Add(new Auta { Marka = "Bajkówka", Model = "Mariuszka", Numer = "0", OC = DateTime.Now, Ubezpieczenie = DateTime.Now });
            context.SaveChanges();
        }
        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.RefreshGrid();
        }

        private void RefreshGrid()
        {
            Cars.AutaDataSet autaDataSet = ((Cars.AutaDataSet)(this.FindResource("autaDataSet")));
            Cars.AutaDataSetTableAdapters.AutaTableAdapter autaDataSetAutaTableAdapter = new Cars.AutaDataSetTableAdapters.AutaTableAdapter();
            autaDataSetAutaTableAdapter.Fill(autaDataSet.Auta);
            System.Windows.Data.CollectionViewSource autaViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("autaViewSource")));
            autaViewSource.View.MoveCurrentToFirst();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            this.OpenWindow();
        }

        private void OpenWindow(Auta data = null)
        {
            Window1 o2 = new Window1(data);
            o2.Closing += OnWindowClosing;
            o2.Show();
        }

        private void OnWindowClosing(object sender, CancelEventArgs e)
        {
            this.RefreshGrid();
        }

        private void usun_Click(object sender, RoutedEventArgs e)
        {
            var selected = this.GetSelectedFromDataGrid();
            this.context.Autas.Remove(selected);
            this.context.SaveChanges();
            this.RefreshGrid();
        }

        private Auta GetSelectedFromDataGrid()
        {
            var selectedId = ((this.carsGrid.SelectedItem as DataRowView).Row as AutaDataSet.AutaRow).Id;
            return this.context.Autas.First(i => i.Id == selectedId);
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            var selected = this.GetSelectedFromDataGrid();
            this.OpenWindow(selected);
        }
    }
}
