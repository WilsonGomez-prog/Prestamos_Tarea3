using System;
using System.Collections.Generic;
using System.Windows;
using Prestamos_Tarea3.Entidades;

namespace Prestamos_Tarea3.UI.Consultas
{
    public partial class cPrestamo : Window
    {
        public cPrestamo()
        {
            InitializeComponent();
        }
        
         private void ConsultarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Prestamo>();
            if (string.IsNullOrWhiteSpace(CriterioTextBox.Text))
            {
                listado = PrestamoBLL.GetList();
            }
            else
            {
                switch(FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = PrestamoBLL.GetList(e => e.PrestamoId == Convert.ToInt32(CriterioTextBox.Text));
                        break;
                    case 1:
                        listado = PrestamoBLL.GetList(e => e.PersonaId == Convert.ToInt32(CriterioTextBox.Text));
                        break;
                }
            }

            listado = PrestamoBLL.GetList(c => c.FechaPrestamo.Date >= DesdeDataPicker.SelectedDate && c.FechaPrestamo <= HastaDataPicker.SelectedDate);

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
            
        }
    }
}