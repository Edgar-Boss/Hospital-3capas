using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DAL_Doctores
    {
        //insertar
        public static string  InsertarDoctor(DoctoresVO doctor)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                //sp_insertdoctores
                respuesta = MetodoDatos.ExecuteNonQuery("sp_insertdoctores",
                    "@Nombre",doctor.Nombre,
                    "@Apaterno",doctor.Apaterno,
                    "@Amaterno",doctor.Amaterno,
                    "@Edad",doctor.Edad,
                    "@Telefono",doctor.Telefono,
                    "@urlfoto",doctor.Urlfoto,
                    "@Consultorio",doctor.Consultorio_id);
                if (respuesta != 0)
                {
                    salida = "camion registrado con exito";
                }
                else
                {
                    salida = ("ha ocurrido un error");
                }
            }
            catch (Exception e)
            {
                salida = "Error: " + e.Message;
            }
            return salida;
        }

    }
}
