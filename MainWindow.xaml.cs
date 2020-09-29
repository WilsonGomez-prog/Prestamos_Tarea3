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
using Prestamos_Tarea3.UI.Registros;
using Prestamos_Tarea3.UI.Consultas;

namespace Prestamos_Tarea3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void rPersonaMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rPersona registroPersona = new rPersona();
            registroPersona.Show();
        }

        public void rPrestamoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rPrestamo registroPrestamo = new rPrestamo();
            registroPrestamo.Show();
        }

        public void cPersonaMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cPersona consultaPersona = new cPersona();
            consultaPersona.Show();
        }

        public void cPrestamoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cPrestamo consultaPrestamo = new cPrestamo();
            consultaPrestamo.Show();
        } 
    }
}
