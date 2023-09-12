using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VO;


namespace Hosp.Catalogos.Doctores
{
    public partial class Doctores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            else
            {

            }
        }




        protected void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            string sub = "";
            string clase = "";

            DoctoresVO _doctor = new DoctoresVO()
            {
                Nombre = txtnombre.Text,
                Apaterno = txtapaterno.Text,
                Amaterno = txtamaterno.Text,
                Edad = int.Parse(txtedad.Text),
                Telefono = int.Parse(txttelefono.Text),
                Urlfoto = txturlfoto.Text,
                Consultorio_id = int.Parse(txtconsultorioid.Text)

            };

            try
            {
                if (Request.QueryString["Id"] == null)
                {
                    string salida = DAL_Doctores.InsertarDoctor(_doctor);
                    if (!salida.Contains("Error"))
                    {
                        mensaje = "Correcto";
                        sub = "Producto Nuevo Agregado";
                        clase = "success";
                    }
                    else
                    {
                        mensaje = "Incorrecto";
                        sub = "Producto No Agregado";
                        clase = "Warnig";
                    }


                }
                else
                {
                    mensaje = "Correcto";
                    sub = "Producto Nuevo Actualizado";
                    clase = "success";
                }
            }   
            catch
            {

            }
            Utilidades.utilidades.SweetBox(mensaje, sub, clase, this.Page, this.GetType());
            
        }
    }
}