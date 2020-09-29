using System;
using System.Windows;
using Prestamos_Tarea3.Entidades;

namespace Prestamos_Tarea3.UI.Registros
{
    /// <summary>
    /// Interaction logic for rPersona.xaml
    /// </summary>
    public partial class rPrestamo : Window
    {
        private Prestamo prestamo;
        public rPrestamo()
        {
            InitializeComponent();
            prestamo = new Prestamo();
            this.DataContext = prestamo;
        }

        private void Limpiar()
        {
            this.prestamo = new Prestamo();
            this.DataContext = prestamo;
        }

        private bool Validar()
        {
            bool validado = true;
            
            if(PersonaIdTextBox.Text.Length == 0 || Convert.ToInt32(PersonaIdTextBox.Text) == 0)
            {
                validado = false;
                MessageBox.Show("El préstamo no puede ser validado. El ID de la persona es 0 o esta vacío.", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if(MontoTextBox.Text.Length == 0)
            {
                validado = false;
                MessageBox.Show("El préstamo no puede ser validado. El monto del préstamo es 0 o esta vacío.", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if(Convert.ToInt32(PrestamoIdTextBox.Text) > 0 || Convert.ToInt32(PrestamoIdTextBox.Text) < 0 )
            {
                validado = false;
                MessageBox.Show("Error, persona no válida. El ID del prestamo va vacío.", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if(ConceptoTextBox.Text.Length == 0)
            {   
                validado = false;
                MessageBox.Show("El préstamo no puede ser validado. El concepto del préstamo esta vacío.", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return validado;
        }
        
        public void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        public void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var prestamo = PrestamoBLL.Buscar(Convert.ToInt32(PrestamoIdTextBox.Text));
            
            if(prestamo != null)
            {
                this.prestamo = prestamo;
            }
            else
            {
                this.prestamo = new Prestamo();
            }
             
            this.DataContext = prestamo;
        }

        public void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if(!Validar())
                return;
            
            var guardado = PrestamoBLL.Guardar(prestamo);

            if(guardado)
            {
                Limpiar();
                MessageBox.Show("El prestamo fue guardado exitosamente.", "Exito", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                MessageBox.Show("El prestamo no pudo ser guardado.", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        public void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if(PrestamoBLL.Eliminar(Convert.ToInt32(PrestamoIdTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("El prestamo fue eliminado exitosamente.", "Exito", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                MessageBox.Show("El prestamo no pudo ser eliminado.", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}