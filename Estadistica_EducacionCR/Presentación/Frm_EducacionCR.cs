using Estadistica_EducacionCR.Logica;
using Estadistica_EducacionCR.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Estadistica_EducacionCR
{
    public partial class Frm_EducacionCR : Form
    {
        public Frm_EducacionCR()
        {
            InitializeComponent();
        }
        #region ¿Como borro esto?
        private void textBox1_TextChanged(object sender, EventArgs e) //Le di doble click al textbox y se generó este evento, pero no lo estoy usando
        {

        }

        private void lblTituloEdad_Click(object sender, EventArgs e) //JIJI
        {

        }
        #endregion

        #region Eventos del formulario
        private void Frm_EducacionCR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                btnSalir_Click(null, null); 
         
        }

        private void btnSalir_Click(object sender, EventArgs e) //La intención es verificar que los hilos estén terminados antes de salir.
        {
            //Codigo del profe, OBVIAMENTE no sirve pq no esta incializado los hilos, pero, lo dejo para que no lo tengan que buscar en el video.
            //if (Obj_Util.Salir() == 1)
            //    if (Obj_T1 != null)
            //    {
            //        if (Obj_T1.ThreadState == ThreadState.WaitSleepJoin)
            //            Obj_Util.Mensaje("El Hilo de Hombres esta en Ejecución, No se puede Salir del Programa");

            //        if (Obj_T2 != null)
            //            if ((Obj_T2.ThreadState == ThreadState.WaitSleepJoin) && (Obj_T1 != null))
            //                Obj_Util.Mensaje("El Hilo de Mujeres esta en Ejecución, No se puede Salir del Programa");

            //        if (Obj_T3 != null)
            //            if ((Obj_T3.ThreadState == ThreadState.WaitSleepJoin) && (Obj_T1 != null))
            //                Obj_Util.Mensaje("El Hilo de Escolaridad esta en Ejecución, No se puede Salir del Programa");
            //            else
            //                this.Dispose();
            //    }
            //    else
            //        this.Dispose();
            Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
