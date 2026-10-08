using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Estadistica_EducacionCR.Logica
{
    public class Cla_Utilidad
    {
        public int Salir()
        {
            return Dialogo("Desea Salir?", "Atención");
        }

        public int Grabar()
        {
            return Dialogo("Desea Grabar el Registro?", "Atención");
        }

        public int Borrar()
        {
            return Dialogo("Desea Borrar el Registro?", "Atención");
        }

        private int Dialogo(string Pregunta, string Titulo) //El profe utiliza funciones WPF, pero, nosotros tamos en WinForms Ema//
        {
            DialogResult result = MessageBox.Show(Pregunta,
                                                  Titulo, 
                                                  MessageBoxButtons.YesNoCancel, 
                                                  MessageBoxIcon.Warning);
            switch (result)
            {
                case DialogResult.Yes:
                    return 1;
                case DialogResult.No:
                    return 0;
                case DialogResult.Cancel:
                    return 0;
            }
            return 0;
        }

        public void Mensaje(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Atención",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
        }
    }
}
