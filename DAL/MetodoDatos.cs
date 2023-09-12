using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class MetodoDatos
    {
        public static DataSet ExecuteDataset(string sp, params object[] parametros)
        { 
            
            DataSet ds = new DataSet();
            string cadenaxonexio = configuracion.CadenaConexion;

            SqlConnection con = new SqlConnection(cadenaxonexio);

            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                else
                {

                    //comando para sql(so,conexion)
                    SqlCommand cmd = new SqlCommand(sp, con);
                    //definimos que el comando sera ejecutando un sp (stored procedure)
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = sp;

                    //validamos si existen y estan completos los parametros 
                    if (parametros != null && parametros.Length % 2 != 0)
                    {
                        throw new Exception("Los parametros deben estar en pares (clave:'valor')");
                    }
                    else
                    {
                        //asignamos los parametros al comando 
                        for (int i = 0; i < parametros.Length; i = i + 2)
                        {
                            cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                        }
                        //abrimos la conexion
                        con.Open();
                        //ejecutamos el comando
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        //llenamos el ds
                        adapter.Fill(ds);
                        //cerramos la conexion
                        con.Close();
                    }
                }
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        public static int ExecuteScalar(string sp, params object[] parametros)
        {
            int id = 0;
            string cadenaConexion = configuracion.CadenaConexion;
            
            SqlConnection con = new SqlConnection(cadenaConexion);

            try
            {
                
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                else
                {
                    
                    SqlCommand cmd = new SqlCommand(sp, con);
                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = sp;

                    //validamos si existen y estan completos los parametros 
                    if (parametros != null && parametros.Length % 2 != 0)
                    {
                        throw new Exception("Los parametros deben estar en pares (clave:'valor')");
                    }
                    else
                    {
                        //asignamos los parametros al comando 
                        for (int i = 0; i < parametros.Length; i = i + 2)
                        {
                            cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                        }
                        //abrimos la conexion
                        con.Open();
                        //ejecutamos el comando
                        id = int.Parse(cmd.ExecuteScalar().ToString());
                        //cerramos la conexion
                        con.Close();
                    }
                }
                return id;
            }
            catch (Exception)
            {
                return id;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        public static int ExecuteNonQuery(string sp, params object[] parametros)
        {
            int id = 0;
            string cadenaConexion = configuracion.CadenaConexion;
            
            SqlConnection con = new SqlConnection(cadenaConexion);

            try
            {
               
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                else
                {
                    
                    SqlCommand cmd = new SqlCommand(sp, con);
                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = sp;

                    //validamos si existen y estan completos los parametros 
                    if (parametros != null && parametros.Length % 2 != 0)
                    {
                        throw new Exception("Los parametros deben estar en pares (clave:'valor')");
                    }
                    else
                    {
                        //asignamos los parametros al comando 
                        for (int i = 0; i < parametros.Length; i = i + 2)
                        {
                            cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                        }
                        //abrimos la conexion
                        con.Open();
                        //ejecutamos el comando
                        cmd.ExecuteNonQuery();
                        id = 1;
                        //cerramos la conexion
                        con.Close();
                    }
                }
                return id;
            }
            catch (Exception)
            {
                return id;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

    }
}
