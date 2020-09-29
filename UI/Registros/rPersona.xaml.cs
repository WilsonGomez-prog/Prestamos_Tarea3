using System;
using System.Windows;
using Prestamos_Tarea3.Entidades;

namespace Prestamos_Tarea3.UI.Registros
{
    public partial class rPersona : Window
    {
        Persona persona;
        public rPersona()
        {
            InitializeComponent();
            persona = new Persona();
            this.DataContext = persona;
        }

        private void Limpiar()
        {
            this.persona = new Persona();
            this.DataContext = persona;
        }

        private bool Validar()
        {
            bool valido = true;

            if(NombreTextBox.Text.Length == 0)
            {
                valido = false;
                MessageBox.Show("Error, persona no válida. El nombre está vacio.", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if(Convert.ToDouble(BalanceTextBox.Text) > 0 || Convert.ToDouble(BalanceTextBox.Text) < 0 )
            {
                valido = false;
                MessageBox.Show("Error, persona no válida. El balance va vacío", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if(Convert.ToInt32(PersonaIdTextBox.Text) > 0 || Convert.ToInt32(PersonaIdTextBox.Text) < 0 )
            {
                valido = false;
                MessageBox.Show("Error, persona no válida. El ID de la persona va vacío", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            return valido;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var persona = PersonaBLL.Buscar(Convert.ToInt32(PersonaIdTextBox.Text));
            if(persona != null)
            {
                this.persona = persona;
            }
            else
            {
                this.persona = new Persona();
            }
            this.DataContext = this.persona;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }  

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if(!Validar())
                return;
                
            var guardo = PersonaBLL.Guardar(persona);

            if(guardo)
            {
                Limpiar();
                MessageBox.Show("Se guardó exitosamente.", "¡Exito!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar la persona.", "¡Fallo!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if(PersonaBLL.Eliminar(Convert.ToInt32(PersonaIdTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Se eliminó exitosamente.", "¡Exito!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la persona. El ID ingrasado no coincide con ninguna persona.", "¡Fallo!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
