using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
using System.Windows.Shapes;

namespace Cars
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        AutaEntities context = new AutaEntities();
        Auta ToEdit;
        public Window1(Auta toEdit = null)
        {
            InitializeComponent();

            if(toEdit != null)
            {
                this.ToEdit = this.context.Autas.First(i => i.Id == toEdit.Id);
                InitializeData();
            }
        }

        private void InitializeData()
        {
            this.marka.Text = this.ToEdit.Marka;
            this.model.Text = this.ToEdit.Model; ;
            this.numer.Text = this.ToEdit.Numer; ;
            this.calendar_oc.SelectedDate = this.ToEdit.OC; ;
            this.calendar_insurance.SelectedDate = this.ToEdit.Ubezpieczenie; ;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(this.ToEdit != null)
            {
                this.ToEdit.Marka = this.marka.Text;
                this.ToEdit.Model = this.model.Text;
                this.ToEdit.Numer = this.numer.Text;
                this.ToEdit.OC = this.calendar_oc.SelectedDate ?? DateTime.Now;
                this.ToEdit.Ubezpieczenie = this.calendar_insurance.SelectedDate ?? DateTime.Now;
            }
            else
            {
                context.Autas.Add(new Auta
                {
                    Marka = this.marka.Text,
                    Model = this.model.Text,
                    Numer = this.numer.Text,
                    OC = this.calendar_oc.SelectedDate ?? DateTime.Now,
                    Ubezpieczenie = this.calendar_insurance.SelectedDate ?? DateTime.Now,
                });
            }

            context.SaveChanges();
            this.Close();
        }

        private void marka_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void numer_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
