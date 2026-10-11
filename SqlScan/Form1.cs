using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SqlScan
{
    public partial class Form1 : Form
    {

        public SqlConnection crearConexion(string server, string usuario, string contrasena)
        {
            SqlConnection conexion = new SqlConnection();
            return conexion = new SqlConnection($"Server={server};User Id={usuario};Password={contrasena};TrustServerCertificate=True;");
        }

        public void ocultarPaneles()
        {
            pnlBD.Visible = false;
            pnlCredenciales.Visible = false;
            pnlFeatures.Visible = false;
            pnlRiesgos.Visible = false;
            pnlUsuarios.Visible = false;
        }

        // Método táctico para enumeración masiva y volcado de tablas
        public DataTable extraerTablaDatos(string consulta, SqlConnection conexion)
        {
            DataTable tablaResultados = new DataTable();

            // El SqlDataAdapter actúa como una red de arrastre, capturando todas las filas y columnas
            using (SqlCommand objQuery = new SqlCommand(consulta, conexion))
            {
                using (SqlDataAdapter adaptador = new SqlDataAdapter(objQuery))
                {
                    // Fill se encarga automáticamente de abrir la conexión, 
                    // extraer los datos y volver a cerrarla de forma segura.
                    adaptador.Fill(tablaResultados);
                }
            }

            return tablaResultados;
        }
        public Form1()
        {
            InitializeComponent();
            ocultarPaneles();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txUsuario.Clear();
            txServer.Clear();
            txContraseña.Clear();
            txServer.Focus();
            gbInformacion.Visible = false;
        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txServer.Text) && String.IsNullOrEmpty(txUsuario.Text) &&
                String.IsNullOrEmpty(txContraseña.Text))
            {
                MessageBox.Show("Debe ingresar los datos requeridos");
                txServer.Focus();
            }
            else
            {
                string server = txServer.Text;
                string usuario = txUsuario.Text;
                string contrasena = txContraseña.Text;
                SqlConnection conexion = crearConexion(server, usuario, contrasena);
                string consultaVersion = "SELECT @@VERSION;";
                string consultaHostName = "SELECT SERVERPROPERTY('ServerName')";
                string consultaPuerto = "SELECT TOP 1 local_tcp_port FROM sys.dm_exec_connections WHERE local_tcp_port IS NOT NULL;";
                string consultaUsuarioActual = "SELECT CURRENT_USER;";
                try
                {
                    conexion.Open();
                    SqlCommand queryVersion = new SqlCommand(consultaVersion, conexion);
                    string version = queryVersion.ExecuteScalar()?.ToString(); //? Si resultado NO es null, llama a ToString(). Si es null, ignora y devuelve null
                                                                               //ExecuteScalar ejecuta la query y devuelve el primer valor de la primera fila.
                    txVersion.Text = version;
                    SqlCommand queryHost = new SqlCommand(consultaHostName, conexion);
                    string host = queryHost.ExecuteScalar()?.ToString();
                    txHostName.Text = host;
                    SqlCommand queryPuerto = new SqlCommand(consultaPuerto, conexion);
                    string puerto = queryPuerto.ExecuteScalar()?.ToString();
                    txPuerto.Text = puerto;
                    SqlCommand queryUsuarioActual = new SqlCommand(consultaUsuarioActual, conexion);
                    string usuarioActual = queryUsuarioActual.ExecuteScalar()?.ToString();
                    txUsuarioActual.Text = usuarioActual;
                    conexion.Close();
                    gbInformacion.Visible = true;
                    gbTabs.Visible = true;

                }
                catch (SqlException ex2)
                {
                    MessageBox.Show($"Algo fallo: {ex2.Message}");
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btUsuarios_Click(object sender, EventArgs e)
        {
            ocultarPaneles();
            pnlUsuarios.Visible = true;
            string server = txServer.Text;
            string usuario = txUsuario.Text;
            string contrasena = txContraseña.Text;

            // procedo con la logica del boton
            string queryUsuarios = "SELECT name AS 'Nombre de Usuario', type_desc AS 'Tipo de Cuenta', is_disabled AS 'Deshabilitado' FROM sys.server_principals WHERE type IN ('S', 'U', 'G');";
            SqlConnection conexion = crearConexion(server, usuario, contrasena);

            {
                try
                {
                    conexion.Open();
                    try
                    {
                        var usuarios = extraerTablaDatos(queryUsuarios, conexion);
                        dgvUsuarios.DataSource = usuarios;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Algo fallo!");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Fallo en la comunicacion con la DB");
                    {
                    }
                }
            }
        }

        private void btBD_Click(object sender, EventArgs e)
        {
            //ocultarPaneles();
            pnlBD.Visible = true;
            string server = txServer.Text;
            string usuario = txUsuario.Text;
            string contrasena = txContraseña.Text;
            string consultaExtraerDb = "SELECT name AS 'Base de Datos', state_desc AS 'Estado Operativo', recovery_model_desc AS 'Modelo de Recuperación' \r\nFROM sys.databases;";

            var conexion = crearConexion(server, usuario, contrasena);
            try
            {
                conexion.Open();
                var ExtraerDbs = extraerTablaDatos(consultaExtraerDb,conexion);
                dgvDB.DataSource = ExtraerDbs;

            }catch (SqlException ex)
            {
                MessageBox.Show("Hubo un error");
            }

        }

        private void btFeatures_Click(object sender, EventArgs e)
        {
            // ocultarPaneles();
            pnlFeatures.Visible = true;
            string server = txServer.Text;
            string usuario = txUsuario.Text;
            string contrasena = txContraseña.Text;
            string consultaFeatures = "EXEC sp_configure;";

            var conexion = crearConexion(server, usuario, contrasena);
            try
            {
                conexion.Open();
                var ExtraerDbs = extraerTablaDatos(consultaFeatures, conexion);
                dgvFeatures.DataSource = ExtraerDbs;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hubo un error");
            }

        }

        private void btCredenciales_Click(object sender, EventArgs e)
        {
            //ocultarPaneles();
            pnlCredenciales.Visible = true;
            string server = txServer.Text;
            string usuario = txUsuario.Text;
            string contrasena = txContraseña.Text;
            string consultaCredenciales = "SELECT name AS 'Usuario', CONVERT(VARCHAR(MAX), password_hash, 1) AS 'Hash de Contraseña' FROM sys.sql_logins WHERE password_hash IS NOT NULL;";

            var conexion = crearConexion(server, usuario, contrasena);
            try
            {
                conexion.Open();
                try
                {
                    var ExtraerDbs = extraerTablaDatos(consultaCredenciales, conexion);
                    dgvCredenciales.DataSource = ExtraerDbs;
                }catch (Exception ex1)
                {
                    MessageBox.Show($"Algo sucedio: {ex1.Message}");
                    return;
                }
               

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hubo un error");
            }

        }

        private void btRiesgos_Click(object sender, EventArgs e)
        {
            //ocultarPaneles();
            pnlRiesgos.Visible = true;
            string server = txServer.Text;
            string usuario = txUsuario.Text;
            string contrasena = txContraseña.Text;
            string consultaRiesgos = "SELECT r.name AS 'Rol', m.name AS 'Miembro con Privilegios' \r\nFROM sys.server_role_members rm \r\nJOIN sys.server_principals r ON rm.role_principal_id = r.principal_id \r\nJOIN sys.server_principals m ON rm.member_principal_id = m.principal_id \r\nWHERE r.name = 'sysadmin';";

            var conexion = crearConexion(server, usuario, contrasena);
            try
            {
                conexion.Open();
                var ExtraerDbs = extraerTablaDatos(consultaRiesgos, conexion);
                //.DataSource = ExtraerDbs;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hubo un error");
            }

        }
    }
}

