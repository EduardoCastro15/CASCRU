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
using System.IO;
using System.Drawing.Imaging;

namespace BusinessIntelligence_v1
{
    public partial class FormAgregarCalificaciones : Form
    {
        public FormAgregarCalificaciones()
        {
            InitializeComponent();
        }

        private MySqlConnection conn;
        private MySqlCommand cmd;
        private string sql = null;

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormAgregarCalificaciones_Load(object sender, EventArgs e)
        {
            BusinessIntelligence_v1.ConexionBD conexion = new BusinessIntelligence_v1.ConexionBD();
            conn = conexion.ConectarMysql();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("El campo de matrícula está vacío");
            }
            else
            {
                try
                {
                    conn.Open();
                    sql = @"select crack_user('" + textBox1.Text + "')";
                    cmd = new MySqlCommand(sql, conn);
                    int result = (int)cmd.ExecuteScalar();
                    if (result == 1)
                    {
                        label68.Visible = true;
                        panel2.Visible = true;
                        button2.Visible = true;
                        button4.Visible = true;
                        MessageBox.Show("Se encontró la matrícula: " + textBox1.Text);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la matrícula", "Búsqueda fallida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
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

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show("Estas seguro que desear limpiar todos los campos?", "Limpiar todos los campos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opc == DialogResult.OK)
            {
                textBox101.Text = "";
                textBox102.Text = "";
                textBox103.Text = "";
                textBox104.Text = "";
                textBox105.Text = "";
                textBox106.Text = "";
                textBox107.Text = "";
                textBox108.Text = "";
                textBox109.Text = "";
                textBox110.Text = "";
                textBox111.Text = "";
                textBox112.Text = "";
                textBox113.Text = "";
                textBox114.Text = "";
                textBox115.Text = "";
                textBox116.Text = "";
                textBox117.Text = "";
                textBox118.Text = "";
                textBox119.Text = "";
                textBox120.Text = "";
                textBox121.Text = "";
                textBox122.Text = "";
                textBox123.Text = "";
                textBox124.Text = "";
                textBox125.Text = "";
                textBox126.Text = "";
                textBox127.Text = "";
                textBox128.Text = "";
                textBox129.Text = "";
                textBox130.Text = "";
                textBox131.Text = "";
                textBox132.Text = "";
                textBox133.Text = "";
                textBox134.Text = "";
                textBox135.Text = "";
                textBox136.Text = "";
                textBox137.Text = "";
                textBox138.Text = "";
                textBox139.Text = "";
                textBox140.Text = "";
                textBox141.Text = "";
                textBox142.Text = "";
                textBox143.Text = "";
                textBox144.Text = "";
                textBox145.Text = "";
                textBox146.Text = "";
                textBox147.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox101.Text == "") textBox101.Text = "-1.0";
                if (textBox102.Text == "") textBox102.Text = "-1.0";
                if (textBox103.Text == "") textBox103.Text = "-1.0";
                if (textBox104.Text == "") textBox104.Text = "-1.0";
                if (textBox105.Text == "") textBox105.Text = "-1.0";
                if (textBox106.Text == "") textBox106.Text = "-1.0";
                if (textBox107.Text == "") textBox107.Text = "-1.0";
                if (textBox108.Text == "") textBox108.Text = "-1.0";
                if (textBox109.Text == "") textBox109.Text = "-1.0";
                if (textBox110.Text == "") textBox110.Text = "-1.0";
                if (textBox111.Text == "") textBox111.Text = "-1.0";
                if (textBox112.Text == "") textBox112.Text = "-1.0";
                if (textBox113.Text == "") textBox113.Text = "-1.0";
                if (textBox114.Text == "") textBox114.Text = "-1.0";
                if (textBox115.Text == "") textBox115.Text = "-1.0";
                if (textBox116.Text == "") textBox116.Text = "-1.0";
                if (textBox117.Text == "") textBox117.Text = "-1.0";
                if (textBox118.Text == "") textBox118.Text = "-1.0";
                if (textBox119.Text == "") textBox119.Text = "-1.0";
                if (textBox120.Text == "") textBox120.Text = "-1.0";
                if (textBox121.Text == "") textBox121.Text = "-1.0";
                if (textBox122.Text == "") textBox122.Text = "-1.0";
                if (textBox123.Text == "") textBox123.Text = "-1.0";
                if (textBox124.Text == "") textBox124.Text = "-1.0";
                if (textBox125.Text == "") textBox125.Text = "-1.0";
                if (textBox126.Text == "") textBox126.Text = "-1.0";
                if (textBox127.Text == "") textBox127.Text = "-1.0";
                if (textBox128.Text == "") textBox128.Text = "-1.0";
                if (textBox129.Text == "") textBox129.Text = "-1.0";
                if (textBox130.Text == "") textBox130.Text = "-1.0";
                if (textBox131.Text == "") textBox131.Text = "-1.0";
                if (textBox132.Text == "") textBox132.Text = "-1.0";
                if (textBox133.Text == "") textBox133.Text = "-1.0";
                if (textBox134.Text == "") textBox134.Text = "-1.0";
                if (textBox135.Text == "") textBox135.Text = "-1.0";
                if (textBox136.Text == "") textBox136.Text = "-1.0";
                if (textBox137.Text == "") textBox137.Text = "-1.0";
                if (textBox138.Text == "") textBox138.Text = "-1.0";
                if (textBox139.Text == "") textBox139.Text = "-1.0";
                if (textBox140.Text == "") textBox140.Text = "-1.0";
                if (textBox141.Text == "") textBox141.Text = "-1.0";
                if (textBox142.Text == "") textBox142.Text = "-1.0";
                if (textBox143.Text == "") textBox143.Text = "-1.0";
                if (textBox144.Text == "") textBox144.Text = "-1.0";
                if (textBox145.Text == "") textBox145.Text = "-1.0";
                if (textBox146.Text == "") textBox146.Text = "-1.0";
                if (textBox147.Text == "") textBox147.Text = "-1.0";

                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = ("insert into datos_academicos_discente( matricula_discente, analisis_vectorial, calculo, matematicas_discretas, algoritmia_y_programacion_estructurada, " +
                    "fisica, ingenieria_etica_sociedad, ecuaciones_diferenciales, algebra_lineal, calculo_aplicado, estructuras_de_datos, comunicacion_oral_y_escrita, " +
                    "analisis_fundamental_de_circuitos, matematicas_avanzadas_para_la_ingenieria, fundamentos_economicos, fundamentos_de_diseño_digital, " +
                    "teoria_computacional, bases_de_datos, programacion_orientada_a_objetos, electronica_analogica, redes_de_computadoras, diseno_de_sistemas_computacionales, " +
                    "probabilidad_y_estadistica, sistemas_operativos, analisis_y_diseno_orientado_objetos, tecnologias_para_la_web, administracion_financiera, optativa_A, " +
                    "arquitectura_de_computadoras, analisis_de_algoritmos, optativa_B, ingenieria_de_software, administracion_de_proyectos, instrumentacion, " +
                    "teoria_de_comunicaciones_y_senales, aplicaciones_para_comunicaciones_en_red, metodos_cuantitativos_para_la_toma_de_decisiones, " +
                    "introduccion_a_los_microcontroladores, compiladores, optativa_C, optativa_D, desarrollo_de_sistemas_distribuidos, administracion_de_servicios_en_red, " +
                    "gestion_empresarial, liderazgo, trabajo_terminal_I, electiva, trabajo_terminal_II) " +
                    "values('" + textBox1.Text + "', '" + textBox101.Text + "', '" + textBox102.Text + "', '" + textBox103.Text + "', '" + textBox104.Text + "', '" +
                    textBox105.Text + "', '" + textBox106.Text + "', '" + textBox107.Text + "', '" + textBox108.Text + "', '" + textBox109.Text + "', '" +
                    textBox110.Text + "', '" + textBox111.Text + "', '" + textBox112.Text + "', '" + textBox113.Text + "', '" + textBox114.Text + "', '" +
                    textBox115.Text + "', '" + textBox116.Text + "', '" + textBox117.Text + "', '" + textBox118.Text + "', '" + textBox119.Text + "', '" +
                    textBox120.Text + "', '" + textBox121.Text + "', '" + textBox122.Text + "', '" + textBox123.Text + "', '" + textBox124.Text + "', '" +
                    textBox125.Text + "', '" + textBox126.Text + "', '" + textBox127.Text + "', '" + textBox128.Text + "', '" + textBox129.Text + "', '" +
                    textBox130.Text + "', '" + textBox131.Text + "', '" + textBox132.Text + "', '" + textBox133.Text + "', '" + textBox134.Text + "', '" +
                    textBox135.Text + "', '" + textBox136.Text + "', '" + textBox137.Text + "', '" + textBox138.Text + "', '" + textBox139.Text + "', '" +
                    textBox140.Text + "', '" + textBox141.Text + "', '" + textBox142.Text + "', '" + textBox143.Text + "', '" + textBox144.Text + "', '" +
                    textBox145.Text + "', '" + textBox146.Text + "', '" + textBox147.Text + "');");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Las calificaciones del usuario se agregaron con éxito");
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
