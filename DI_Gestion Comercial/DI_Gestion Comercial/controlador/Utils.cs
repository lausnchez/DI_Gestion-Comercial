using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Gestion_Comercial.controlador
{
    internal class Utils
    {
        public static Boolean comprobarInt(String valor)
        {
            try
            {
                int.Parse(valor);
                return true;
            }catch(Exception e)
            {
                return false;
            }
        }

        public static Boolean comprobarFloat(String valor)
        {
            try
            {
                float.Parse(valor);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

    }
}
