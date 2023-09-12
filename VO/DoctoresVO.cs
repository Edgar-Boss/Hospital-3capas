using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VO
{
    public class DoctoresVO
    {
        private int _Id_Doctor;
        private string _nombre;
        private string _apaterno;
        private string _amaterno;
        private int _edad;
        private int telefono;
        private string _urlfoto;
        private int consultorio_id;

        public int Id_Doctor { get => _Id_Doctor; set => _Id_Doctor = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apaterno { get => _apaterno; set => _apaterno = value; }
        public string Amaterno { get => _amaterno; set => _amaterno = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Urlfoto { get => _urlfoto; set => _urlfoto = value; }
        public int Consultorio_id { get => consultorio_id; set => consultorio_id = value; }




        public DoctoresVO(DataRow dr)
        {
            Id_Doctor = int.Parse(dr["ID_Doctor"].ToString());
            Nombre = dr["Nombre"].ToString();
            Apaterno = dr["Apaterno"].ToString();
            Amaterno = dr["Amaterno"].ToString();
            Edad = int.Parse(dr["Edad"].ToString());
            Telefono = int.Parse(dr["Telefono"].ToString());
            Urlfoto = dr["urlfoto"].ToString();
            Consultorio_id = int.Parse(dr["Consultorio"].ToString());
            
        }

        public DoctoresVO()
        {
            Id_Doctor = 0;
            Nombre = "";
            Apaterno = "";
            Amaterno = "";
            Edad = 0;
            telefono = 0;
            Urlfoto = "";
            consultorio_id = 0;   
        }
    }
}
