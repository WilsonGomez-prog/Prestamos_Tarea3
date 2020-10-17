using Prestamos_Tarea3.BLL;
using Prestamos_Tarea3.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Prestamos_Tarea3.UI.Registros
{
    public partial class rMoras : Window
    {
        Moras mora;
        public rMoras()
        {
            InitializeComponent();
            mora = new Moras();
            this.DataContext = mora;

            DetallesDataGrid.ItemsSource = new List<MorasDetalle>();

            PrestamoComboBox.ItemsSource = PrestamoBLL.GetList();
            PrestamoComboBox.SelectedValuePath = "PrestamoId";
            PrestamoComboBox.DisplayMemberPath = "Concepto";
        }

        public bool Existe()
        {
            var moras = MorasBLL.Buscar(Convert.ToInt32(MoraIdTextBox.Text));

            return moras != null;
        }

        private void Actualizar()
        {
            this.DataContext = null;
            this.DataContext = mora;
            DetallesDataGrid.ItemsSource = mora.DetalleMora;
        }

        private void Limpiar()
        {
            MoraIdTextBox.Text = "0";
            FechaDatePicker.Text = Convert.ToString(DateTime.Now);

            DetallesDataGrid.ItemsSource = new List<MorasDetalle>();
            mora = new Moras();
            this.DataContext = mora;
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            bool guardado = false;

            if (string.IsNullOrWhiteSpace(MoraIdTextBox.Text) || MoraIdTextBox.Text == "0")
                guardado = MorasBLL.Guardar(mora);
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("Esta mora no se puede modificar \nporque no existe en la base de datos.", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                guardado = MorasBLL.Modificar(mora);
            }

            if (guardado)
            {
                Limpiar();
                MessageBox.Show("La mora ha sido guardada correctamente.", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Esta mora no ha podido ser guardada.", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void RemoverButton_Click(object sender, RoutedEventArgs e)
        {
            mora.DetalleMora.RemoveAt(DetallesDataGrid.FrozenColumnCount);
            Actualizar();
        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            this.mora.DetalleMora.Add(new MorasDetalle(mora.MoraId, Convert.ToInt32(PrestamoComboBox.SelectedValue.ToString()), Convert.ToDouble(ValorTextBox.Text)));
            mora.Total = Convert.ToDouble(ValorTextBox.Text);

            Actualizar();
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (MorasBLL.Eliminar(Convert.ToInt32(MoraIdTextBox.Text)))
            {
                MessageBox.Show("La mora ha sido eliminada correctamente.", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Esta mora no ha podido ser eliminada.", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Moras anterior = MorasBLL.Buscar(Convert.ToInt32(MoraIdTextBox.Text));

            if (anterior != null)
            {
                mora = anterior;
                Actualizar();
            }
            else
            {
                MessageBox.Show("La mora buscada no ha podido ser encontrada.");
            }
        }
    }
}
