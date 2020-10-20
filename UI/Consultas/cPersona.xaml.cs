using System;
using System.Collections.Generic;
using System.Windows;
using Prestamos_Tarea3.Entidades;

namespace Prestamos_Tarea3.UI.Consultas
{
    public partial class cPersona : Window
    {
        public cPersona()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Persona>();
            if (string.IsNullOrWhiteSpace(CriterioTextBox.Text))
            {
                listado = PersonaBLL.GetList();
            }
            else
            {
                switch(FiltroComboBox.SelectedIndex)
                {
                    case 1:
                        listado = PersonaBLL.GetList(e => e.PersonaId == Convert.ToInt32(CriterioTextBox.Text));
                        break;
                    case 2:
                        listado = PersonaBLL.GetList(e => e.Nombres.Contains(CriterioTextBox.Text));
                        break;
                }
            }
            
            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
            
        }
    }
}
