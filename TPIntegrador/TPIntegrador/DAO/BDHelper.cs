using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// importar 
using System.Data.SqlClient;
using System.Data;
//
namespace TPIntegrador
{
    class BDHelper
    {
        //Unica instancia de la clase
        private static BDHelper instance; 
        public static BDHelper getBDHelper()
        {
            if (instance == null)
                instance = new BDHelper();
            return instance;
        }
        //atributos
        private string cadenaConexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        //
        //properties (propiedades)
        public SqlCommand Comando
        {
            get { return comando; }
            set { comando = value; }
        }
        public SqlConnection Conexion
        {
            get { return conexion; }
            set { conexion = value; }
        }

        public string CadenaConexion
        {
            set { cadenaConexion = value; }
            get { return cadenaConexion; }
        }
        //
        //contructores
        public BDHelper()
        {
            cadenaConexion = @"Data Source=desktop-2hufh55\sqlexpress;Initial Catalog=TP_Integrador;User ID=David;Password=gerasimchukqwer12";
            conexion = new SqlConnection();
            comando = new SqlCommand();
        }

        public BDHelper(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
            conexion = new SqlConnection();
            comando = new SqlCommand();
        }
        //
        //Parte transaccion
        enum TransactionStatus
        {
            exito, fracaso, iniciada, desactivada
        }
        private TransactionStatus estadoTransaccion = TransactionStatus.desactivada;
        private SqlTransaction transaccion = null;
        public bool resultadoDeTrasaccion = true;

        private void conectarTransacion()
        {
            if (estadoTransaccion != TransactionStatus.exito)
            {
                transaccion = conexion.BeginTransaction();
                comando.Connection = conexion;
                comando.Transaction = transaccion;
                estadoTransaccion = TransactionStatus.exito;
            }
            
        }
        private void desconectarTransacion()
        {
            if (estadoTransaccion==TransactionStatus.exito)
            {
                transaccion.Commit();
                resultadoDeTrasaccion = true;
            }
            else if (estadoTransaccion == TransactionStatus.fracaso)
            {
                transaccion.Rollback();
                resultadoDeTrasaccion = false;
            }
        }
        public void startTransaction()
        {
            estadoTransaccion = TransactionStatus.iniciada;
        }
        public void endTransaction()
        {
            desconectarTransacion();
            estadoTransaccion = TransactionStatus.desactivada;
            desconectar();
        }
        //
        //metodos
        private void conectar()
        {
            if (estadoTransaccion == TransactionStatus.desactivada)
            {
                conexion = new SqlConnection();
                conexion.ConnectionString = this.cadenaConexion;
                conexion.Open();
                comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
            }
            if (estadoTransaccion==TransactionStatus.iniciada)
            {
                conexion = new SqlConnection();
                conexion.ConnectionString = this.cadenaConexion;
                conexion.Open();
                comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                conectarTransacion();
            }

        }

        private void desconectar()
        {
            if (estadoTransaccion==TransactionStatus.desactivada)
            {
                conexion.Close();
            }
                      
        }

        public DataTable consultarTabla(string nombreTabla)
        {
            DataTable tabla = new DataTable();
            conectar();
            comando.CommandText = "Select * from " + nombreTabla;
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }
        public DataTable consultarSQL(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            conectar();
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }
        //
        public void actualizarBD(string sql)
        {
            try
            {
                conectar();
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                desconectar();
            }
            catch (Exception ex)
            {
                if (estadoTransaccion == TransactionStatus.exito)
                    estadoTransaccion = TransactionStatus.fracaso;
                throw ex;
            }
            
        }
        public bool verificarUsuario(string usuario)
        {
            DataTable conUsu = consultarSQL("select usuario from Empleado where usuario LIKE '" + usuario + "'");
            if (conUsu.Rows.Count > 0 )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool verificarUsuarioID(string usuario, string id)
        {
            DataTable conUsu = consultarSQL("select id_empleado, usuario from Empleado where usuario LIKE '" + usuario + "'");
            if (conUsu.Rows.Count > 0)
            {
                if (conUsu.Rows[0].ItemArray[0].ToString() == id)
                    return false;
                else
                    
                    return true;
            }
            else
            {
                return false;
            }
        }
    }
}
