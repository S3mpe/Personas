using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace Personas
{
    class DialogoNacionalidadVM : ObservableObject
    {
        private string nacionalidad;

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }


        public DialogoNacionalidadVM()
        {

        }

        public void Aceptar()
        {
            //Aquí incluiremos la lógica necesaria cuando se pulse el botón aceptar
        }
    }
}