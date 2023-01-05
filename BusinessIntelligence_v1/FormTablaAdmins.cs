using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BusinessIntelligence_v1
{
    public partial class FormTablaAdmins : Form
    {
        public FormTablaAdmins()
        {
            InitializeComponent();
        }

        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataAdapter adaptar;

        private void FormTablaAdmins_Load(object sender, EventArgs e)
        {
            BusinessIntelligence_v1.ConexionBD conexion = new BusinessIntelligence_v1.ConexionBD();
            conn = conexion.ConectarMysql();

            DataTable tabla1 = new DataTable();
            DataTable tabla2 = new DataTable();
            DataTable tabla3 = new DataTable();

            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            

            try
            {
                cmd.CommandText = ("select * from usuarios;");
                adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = cmd;
                adaptar.Fill(tabla1);
                dataGridView1.DataSource = tabla1;

                cmd.CommandText = ("select * from discentes;");
                adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = cmd;
                adaptar.Fill(tabla2);
                dataGridView2.DataSource = tabla2;

                cmd.CommandText = ("select * from datos_academicos_discente;");
                adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = cmd;
                adaptar.Fill(tabla3);
                dataGridView3.DataSource = tabla3;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Algo salió mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable tabla1 = new DataTable();
            DataTable tabla2 = new DataTable();
            DataTable tabla3 = new DataTable();

            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;


            try
            {
                cmd.CommandText = ("select * from usuarios;");
                adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = cmd;
                adaptar.Fill(tabla1);
                dataGridView1.DataSource = tabla1;

                cmd.CommandText = ("select * from discentes;");
                adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = cmd;
                adaptar.Fill(tabla2);
                dataGridView2.DataSource = tabla2;

                cmd.CommandText = ("select * from datos_academicos_discente;");
                adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = cmd;
                adaptar.Fill(tabla3);
                dataGridView3.DataSource = tabla3;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Algo salió mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
