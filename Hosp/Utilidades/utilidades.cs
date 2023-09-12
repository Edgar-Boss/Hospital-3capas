using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Hosp.Utilidades
{
    public class utilidades
    {
        public static void SweetBox(string ex, string sub, string type, Page pg, Object obj)
        {
            string s = "<script languaje='javascript'>swal('" + ex.Replace("\r\n", "\\n").Replace("'", "") +
                                                          "','" + sub.Replace("\r\n", "\\n").Replace("'", "")
                                                          + "','" + type + "');</script>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }
        public static void SweetBox_question(string ex, string sub, string type, Page pg, Object obj)
        {
            string s = "";



            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }

    }
}