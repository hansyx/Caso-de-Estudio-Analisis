using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Logica
    {

        String nombre = "admin";
        String contra = "0000";
        String alerta = "";

        public Boolean revisarCredenciales(String usuario, String contraseña)
        {

            if (usuario.Equals(nombre) && contraseña.Equals(contra))
            {
                return true;
            }
            else if (!usuario.Equals(nombre) && contraseña.Equals(contra))
            {
                alerta = "El nombre de usuario es incorrecto";
                return false;
            }
            else if (usuario.Equals(nombre) && !contraseña.Equals(contra))
            {
                alerta = "La contraseña ingresada es incorrecta";
                return false;
            }
            else
            {
                alerta = "Las credenciales no son correctas";
                return false;
            }

        }

        public String getAlerta()
        {
            return alerta;
        }

    }
}
