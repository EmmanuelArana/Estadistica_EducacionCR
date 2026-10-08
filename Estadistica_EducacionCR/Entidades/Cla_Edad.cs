using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadistica_EducacionCR.Entidades
{
    public class Cla_Edad
    {
        #region Atributos 
        public int Edad { get; set; }
        public int hombres { get; set; }
        public int mujeres { get; set; }
        public int[] Nivel_Educacion = { 0, 0, 0, 0, 0, 0, 0};
        #endregion

        public Cla_Edad(int PEdad, 
                        int PHombres, 
                        int PMujeres, 
                        int PP_I, 
                        int PP_C, 
                        int PS_I, 
                        int PS_C, 
                        int PU_C, 
                        int PU_I, 
                        int PS_E)
        {
            Edad = PEdad;
            hombres = PHombres;
            mujeres = PMujeres;

            Nivel_Educacion[0] = PP_I; //PP= PRIMARIA - I = INCOMPLETA 
            Nivel_Educacion[1] = PP_C; //PP= PRIMARIA - C = COMPLETA
            Nivel_Educacion[2] = PS_C; //PS= SECUNDARIA - C = COMPLETA
            Nivel_Educacion[3] = PS_I; //PS= SECUNDARIA - I = INCOMPLETA
            Nivel_Educacion[4] = PU_C; //PU= UNIVERSITARIA - C = COMPLETA
            Nivel_Educacion[5] = PU_I; //PU= UNIVERSITARIA - I = INCOMPLETA
            Nivel_Educacion[6] = PS_E; //SIN ESTUDIOS
        }
    }
}
