using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas.servicios
{
    class NavigationService
    {
        private static readonly UserControl listadoPersonas = new ListadoPersonasUserControl();

        public NavigationService()
        {

        }

        public UserControl ObtenerNuevaPersona()
        {
            return new NuevaPersonaUserControl();
        }

        public UserControl ObtenerListadoPersonas()
        {
            return listadoPersonas;
        }

        public bool? AbrirDialogoNacionalidad()
        {
            DialogoNacionalidad dialogo = new DialogoNacionalidad();
            return dialogo.ShowDialog();
        }
    }
}
