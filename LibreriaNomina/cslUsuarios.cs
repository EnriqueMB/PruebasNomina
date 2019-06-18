using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaNomina
{
    public class cslUsuarios
    {
        #region propiedades
        public int idUsuario { get; set; }
        public string  login { get; set; }
        public string nombreCompleto { get; set; }
        public int nivel { get; set; }

        #endregion

        #region metodos
        public  int loginAcceso(string pass)
        {
            if (login != "marcos")
                return -1;
            else
            {
                if (pass != "expea")
                    return -2;
                else
                {
                    nivel = 99;
                    return 1;
                }
            }


        }
        #endregion
    }
}
