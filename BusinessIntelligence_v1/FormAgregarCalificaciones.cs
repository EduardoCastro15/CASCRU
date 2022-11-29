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
                    conn.Close();
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
                /*if (textBox10.Text == "")
                    textBox10.Text = "-1.0";
                if (textBox11.Text == "")
                    textBox11.Text = "-1.0";
                if (textBox12.Text == "")
                    textBox12.Text = "-1.0";
                if (textBox13.Text == "")
                    textBox13.Text = "-1.0";
                if (textBox14.Text == "")
                    textBox14.Text = "-1.0";
                if (textBox15.Text == "")
                    textBox15.Text = "-1.0";
                if (textBox16.Text == "")
                    textBox16.Text = "-1.0";
                if (textBox17.Text == "")
                    textBox17.Text = "-1.0";
                if (textBox18.Text == "")
                    textBox18.Text = "-1.0";
                if (textBox19.Text == "")
                    textBox19.Text = "-1.0";
                if (textBox2.Text == "")
                    textBox2.Text = "-1.0";
                if (textBox20.Text == "")
                    textBox20.Text = "-1.0";
                if (textBox21.Text == "")
                    textBox21.Text = "-1.0";
                if (textBox22.Text == "")
                    textBox22.Text = "-1.0";
                if (textBox23.Text == "")
                    textBox23.Text = "-1.0";
                if (textBox24.Text == "")
                    textBox24.Text = "-1.0";
                if (textBox25.Text == "")
                    textBox25.Text = "-1.0";
                if (textBox26.Text == "")
                    textBox26.Text = "-1.0";
                if (textBox27.Text == "")
                    textBox27.Text = "-1.0";
                if (textBox28.Text == "")
                    textBox28.Text = "-1.0";
                if (textBox29.Text == "")
                    textBox29.Text = "-1.0";
                if (textBox3.Text == "")
                    textBox3.Text = "-1.0";
                if (textBox30.Text == "")
                    textBox30.Text = "-1.0";
                if (textBox31.Text == "")
                    textBox31.Text = "-1.0";
                if (textBox32.Text == "")
                    textBox32.Text = "-1.0";
                if (textBox33.Text == "")
                    textBox33.Text = "-1.0";
                if (textBox34.Text == "")
                    textBox34.Text = "-1.0";
                if (textBox35.Text == "")
                    textBox35.Text = "-1.0";
                if (textBox36.Text == "")
                    textBox36.Text = "-1.0";
                if (textBox37.Text == "")
                    textBox37.Text = "-1.0";
                if (textBox38.Text == "")
                    textBox38.Text = "-1.0";
                if (textBox39.Text == "")
                    textBox39.Text = "-1.0";
                if (textBox4.Text == "")
                    textBox4.Text = "-1.0";
                if (textBox40.Text == "")
                    textBox40.Text = "-1.0";
                if (textBox41.Text == "")
                    textBox41.Text = "-1.0";
                if (textBox42.Text == "")
                    textBox42.Text = "-1.0";
                if (textBox43.Text == "")
                    textBox43.Text = "-1.0";
                if (textBox44.Text == "")
                    textBox44.Text = "-1.0";
                if (textBox45.Text == "")
                    textBox45.Text = "-1.0";
                if (textBox46.Text == "")
                    textBox46.Text = "-1.0";
                if (textBox47.Text == "")
                    textBox47.Text = "-1.0";
                if (textBox48.Text == "")
                    textBox48.Text = "-1.0";
                if (textBox49.Text == "")
                    textBox49.Text = "-1.0";
                if (textBox5.Text == "")
                    textBox5.Text = "-1.0";
                if (textBox50.Text == "")
                    textBox50.Text = "-1.0";
                if (textBox51.Text == "")
                    textBox51.Text = "-1.0";
                if (textBox52.Text == "")
                    textBox52.Text = "-1.0";
                if (textBox53.Text == "")
                    textBox53.Text = "-1.0";
                if (textBox54.Text == "")
                    textBox54.Text = "-1.0";
                if (textBox55.Text == "")
                    textBox55.Text = "-1.0";
                if (textBox56.Text == "")
                    textBox56.Text = "-1.0";
                if (textBox57.Text == "")
                    textBox57.Text = "-1.0";
                if (textBox6.Text == "")
                    textBox6.Text = "-1.0";
                if (textBox7.Text == "")
                    textBox7.Text = "-1.0";
                if (textBox8.Text == "")
                    textBox8.Text = "-1.0";
                if (textBox9.Text == "")
                    textBox9.Text = "-1.0";*/

                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = ("insert into datos_academicos_discente( analisis_vectorial, calculo, matematicas_discretas, algoritmia_y_programacion_estructurada, " +
                    "fisica, ingenieria_etica_sociedad, ecuaciones_diferenciales, algebra_lineal, calculo_aplicado, estructuras_de_datos, comunicacion_oral_y_escrita, " +
                    "analisis_fundamental_de_circuitos, matematicas_avanzadas_para_la_ingenieria, fundamentos_economicos, fundamentos_de_diseño_digital, " +
                    "teoria_computacional, bases_de_datos, programacion_orientada_a_objetos, electronica_analogica, redes_de_computadoras, diseno_de_sistemas_computacionales, " +
                    "probabilidad_y_estadistica, sistemas_operativos, analisis_y_diseno_orientado_objetos, tecnologias_para_la_web, administracion_financiera, optativa_A, " +
                    "arquitectura_de_computadoras, analisis_de_algoritmos, optativa_B, ingenieria_de_software, administracion_de_proyectos, instrumentacion, " +
                    "teoria_de_comunicaciones_y_senales, aplicaciones_para_comunicaciones_en_red, metodos_cuantitativos_para_la_toma_de_decisiones, " +
                    "introduccion_a_los_microcontroladores, compiladores, optativa_C, optativa_D, desarrollo_de_sistemas_distribuidos, administracion_de_servicios_en_red, " +
                    "gestion_empresarial, liderazgo, trabajo_terminal_I, electiva, trabajo_terminal_II) " +
                    "values('" + textBox101.Text + "', '" + textBox102.Text + "', '" + textBox103.Text + "', '" + textBox104.Text + "', '" +
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
                conn.Close();
                MessageBox.Show("Las calificaciones del usuario se agregaron con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Algo salió mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
