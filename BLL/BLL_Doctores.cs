using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace BLL
{
    public class BLL_Doctores
    {
        //insertar(create)
        public static string InsertarCamion(DoctoresVO doctor)
        {
            return DAL_Doctores.InsertarDoctor(doctor);
        }
    }
}
