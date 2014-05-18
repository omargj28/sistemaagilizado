using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Sistema_Agilizado
{
    class AdminDB
    {
        static MySqlConnection sqlConexion = new MySqlConnection();
        static string serv = "Server= localhost;";
        static string db = "Database= sistemaagilizado;";
        static string usuario = "User Id= root;";
        static string pass = "Password=1234;";

        string cadenaDeConexion = serv + db + usuario + pass;

        static MySqlCommand comando = new MySqlCommand();
        static MySqlDataAdapter adaptador = new MySqlDataAdapter();

        public void Conectar()
        {
            try
            {
                sqlConexion.ConnectionString = cadenaDeConexion;
                sqlConexion.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Desconectar()
        {
            sqlConexion.Close();
        }

        public void buscaPedidos()
        {
            //
        }
       
        public void insertaPedidos(string nombre, DateTime fecha_reg, DateTime fecha_entrega, bool _diseño, bool _tarjetas, bool _web, bool _folletos, bool _volantes, bool _impresion, bool _ifolletos, bool _itarjetas, bool _ivolantes)
        {
            int diseño = _diseño == true ? 1 : 0;
            int tarjetas = _tarjetas == true ? 1 : 0;
            int web = _web == true ? 1 : 0;
            int folletos = _folletos == true ? 1 : 0;
            int volantes = _volantes == true ? 1 : 0;
            int impresion = _impresion == true ? 1 : 0;
            int ifolletos = _ifolletos == true ? 1 : 0;
            int itarjetas = _itarjetas == true ? 1 : 0;
            int ivolantes = _ivolantes == true ? 1 : 0;
            
            string strSQL = "INSERT INTO pedidos (Nombre, Fecha_reg, Fecha_entrega, Diseño, Tarjetas, Web, Folletos, Volantes, Impresion, IFolletos, ITarjetas, IVolantes) ";
            strSQL += "VALUES (?Nombre, ?Fecha_reg, ?Fecha_entrega, ?Diseño, ?Tarjetas, ?Web, ?Folletos, ?Volantes, ?Impresion, ?IFolletos, ?ITarjetas, ?IVolantes)";

            comando = new MySqlCommand(strSQL, sqlConexion);
            comando.Parameters.Add(new MySqlParameter("?Nombre", nombre));
            comando.Parameters.Add(new MySqlParameter("?Fecha_reg", fecha_reg));
            comando.Parameters.Add(new MySqlParameter("?Fecha_entrega", fecha_entrega));
            comando.Parameters.Add(new MySqlParameter("?Diseño", diseño));
            comando.Parameters.Add(new MySqlParameter("?Tarjetas", tarjetas));
            comando.Parameters.Add(new MySqlParameter("?Web", web));
            comando.Parameters.Add(new MySqlParameter("?Folletos", folletos));
            comando.Parameters.Add(new MySqlParameter("?Volantes", volantes));
            comando.Parameters.Add(new MySqlParameter("?Impresion", impresion));
            comando.Parameters.Add(new MySqlParameter("?IFolletos", ifolletos));
            comando.Parameters.Add(new MySqlParameter("?ITarjetas", itarjetas));
            comando.Parameters.Add(new MySqlParameter("?IVolantes", ivolantes));
            comando.ExecuteNonQuery();
        }

        public void actualizaPedidos(int IDPedido, string nombre, DateTime fecha_reg, DateTime fecha_entrega, bool _diseño, bool _tarjetas, bool _web, bool _folletos, bool _volantes, bool _impresion, bool _ifolletos, bool _itarjetas, bool _ivolantes)
        {
            int diseño = _diseño == true ? 1 : 0;
            int tarjetas = _tarjetas == true ? 1 : 0;
            int web = _web == true ? 1 : 0;
            int folletos = _folletos == true ? 1 : 0;
            int volantes = _volantes == true ? 1 : 0;
            int impresion = _impresion == true ? 1 : 0;
            int ifolletos = _ifolletos == true ? 1 : 0;
            int itarjetas = _itarjetas == true ? 1 : 0;
            int ivolantes = _ivolantes == true ? 1 : 0;

            string strSQL = "UPDATE pedidos SET ";
            strSQL += "Nombre = ?Nombre, ";
            strSQL += "Fecha_reg = ?Fecha_reg, ";
            strSQL += "Fecha_entrega = ?Fecha_entrega, ";
            strSQL += "Diseño = ?Diseño, ";
            strSQL += "Tarjetas = ?Tarjetas, ";
            strSQL += "Web = ?Web, ";
            strSQL += "Folletos = ?Folletos, ";
            strSQL += "Volantes = ?Volantes, ";
            strSQL += "Impresion = ?Impresion, ";
            strSQL += "IFolletos = ?IFolletos, ";
            strSQL += "ITarjetas = ?ITarjetas, ";
            strSQL += "IVolantes = ?IVolantes ";
            strSQL += "WHERE IDPedido = ?IDPedido";

            comando = new MySqlCommand(strSQL, sqlConexion);
            comando.Parameters.Add(new MySqlParameter("?Nombre", nombre));
            comando.Parameters.Add(new MySqlParameter("?Fecha_reg", fecha_reg));
            comando.Parameters.Add(new MySqlParameter("?Fecha_entrega", fecha_entrega));
            comando.Parameters.Add(new MySqlParameter("?Diseño", diseño));
            comando.Parameters.Add(new MySqlParameter("?Tarjetas", tarjetas));
            comando.Parameters.Add(new MySqlParameter("?Web", web));
            comando.Parameters.Add(new MySqlParameter("?Folletos", folletos));
            comando.Parameters.Add(new MySqlParameter("?Volantes", volantes));
            comando.Parameters.Add(new MySqlParameter("?Impresion", impresion));
            comando.Parameters.Add(new MySqlParameter("?IFolletos", ifolletos));
            comando.Parameters.Add(new MySqlParameter("?ITarjetas", itarjetas));
            comando.Parameters.Add(new MySqlParameter("?IVolantes", ivolantes));
            comando.Parameters.Add(new MySqlParameter("?IDPedido", IDPedido));
            comando.ExecuteNonQuery();
        }
       
    }
}
