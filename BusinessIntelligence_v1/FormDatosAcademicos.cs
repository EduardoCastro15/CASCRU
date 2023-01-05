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
    public partial class FormDatosAcademicos: Form
    {
        public FormDatosAcademicos()
        {
            InitializeComponent();
        }

        private MySqlConnection conn;
        private MySqlCommand cmd;

        private void FormDatosAcademicos_Load(object sender, EventArgs e)
        {
            double sumaMate = 0.0;
            double sumaEspe = 0.0;
            double sumaInst = 0.0;
            double sumaTerm = 0.0;
            BusinessIntelligence_v1.ConexionBD conexion = new BusinessIntelligence_v1.ConexionBD();
            conn = conexion.ConectarMysql();

            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = ("select * from datos_academicos_discente where matricula_discente = '" + textBox1.Text + "' ");
                MySqlDataReader leer = cmd.ExecuteReader();
                if (leer.HasRows)
                {
                    leer.Read();
                    textBox101.Text = leer["analisis_vectorial"].ToString();
                    textBox102.Text = leer["calculo"].ToString();
                    textBox103.Text = leer["matematicas_discretas"].ToString();
                    textBox104.Text = leer["algoritmia_y_programacion_estructurada"].ToString();
                    textBox105.Text = leer["fisica"].ToString();
                    textBox106.Text = leer["ingenieria_etica_sociedad"].ToString();
                    textBox107.Text = leer["ecuaciones_diferenciales"].ToString();
                    textBox108.Text = leer["algebra_lineal"].ToString();
                    textBox109.Text = leer["calculo_aplicado"].ToString();
                    textBox110.Text = leer["estructuras_de_datos"].ToString();
                    textBox111.Text = leer["comunicacion_oral_y_escrita"].ToString();
                    textBox112.Text = leer["analisis_fundamental_de_circuitos"].ToString();
                    textBox113.Text = leer["matematicas_avanzadas_para_la_ingenieria"].ToString();
                    textBox114.Text = leer["fundamentos_economicos"].ToString();
                    textBox115.Text = leer["fundamentos_de_diseño_digital"].ToString();
                    textBox116.Text = leer["teoria_computacional"].ToString();
                    textBox117.Text = leer["bases_de_datos"].ToString();
                    textBox118.Text = leer["programacion_orientada_a_objetos"].ToString();
                    textBox119.Text = leer["electronica_analogica"].ToString();
                    textBox120.Text = leer["redes_de_computadoras"].ToString();
                    textBox121.Text = leer["diseno_de_sistemas_computacionales"].ToString();
                    textBox122.Text = leer["probabilidad_y_estadistica"].ToString();
                    textBox123.Text = leer["sistemas_operativos"].ToString();
                    textBox124.Text = leer["analisis_y_diseno_orientado_objetos"].ToString();
                    textBox125.Text = leer["tecnologias_para_la_web"].ToString();
                    textBox126.Text = leer["administracion_financiera"].ToString();
                    textBox127.Text = leer["optativa_A"].ToString();
                    textBox128.Text = leer["arquitectura_de_computadoras"].ToString();
                    textBox129.Text = leer["analisis_de_algoritmos"].ToString();
                    textBox130.Text = leer["optativa_B"].ToString();
                    textBox131.Text = leer["ingenieria_de_software"].ToString();
                    textBox132.Text = leer["administracion_de_proyectos"].ToString();
                    textBox133.Text = leer["instrumentacion"].ToString();
                    textBox134.Text = leer["teoria_de_comunicaciones_y_senales"].ToString();
                    textBox135.Text = leer["aplicaciones_para_comunicaciones_en_red"].ToString();
                    textBox136.Text = leer["metodos_cuantitativos_para_la_toma_de_decisiones"].ToString();
                    textBox137.Text = leer["introduccion_a_los_microcontroladores"].ToString();
                    textBox138.Text = leer["compiladores"].ToString();
                    textBox139.Text = leer["optativa_C"].ToString();
                    textBox140.Text = leer["optativa_D"].ToString();
                    textBox141.Text = leer["desarrollo_de_sistemas_distribuidos"].ToString();
                    textBox142.Text = leer["administracion_de_servicios_en_red"].ToString();
                    textBox143.Text = leer["gestion_empresarial"].ToString();
                    textBox144.Text = leer["liderazgo"].ToString();
                    textBox145.Text = leer["trabajo_terminal_I"].ToString();
                    textBox146.Text = leer["electiva"].ToString();
                    textBox147.Text = leer["trabajo_terminal_II"].ToString();


                    if (textBox101.Text == "-1.0") textBox101.Text = "0.0";
                    if (textBox102.Text == "-1.0") textBox102.Text = "0.0";
                    if (textBox103.Text == "-1.0") textBox103.Text = "0.0";
                    if (textBox104.Text == "-1.0") textBox104.Text = "0.0";
                    if (textBox105.Text == "-1.0") textBox105.Text = "0.0";
                    if (textBox106.Text == "-1.0") textBox106.Text = "0.0";
                    if (textBox107.Text == "-1.0") textBox107.Text = "0.0";
                    if (textBox108.Text == "-1.0") textBox108.Text = "0.0";
                    if (textBox109.Text == "-1.0") textBox109.Text = "0.0";
                    if (textBox110.Text == "-1.0") textBox110.Text = "0.0";
                    if (textBox111.Text == "-1.0") textBox111.Text = "0.0";
                    if (textBox112.Text == "-1.0") textBox112.Text = "0.0";
                    if (textBox113.Text == "-1.0") textBox113.Text = "0.0";
                    if (textBox114.Text == "-1.0") textBox114.Text = "0.0";
                    if (textBox115.Text == "-1.0") textBox115.Text = "0.0";
                    if (textBox116.Text == "-1.0") textBox116.Text = "0.0";
                    if (textBox117.Text == "-1.0") textBox117.Text = "0.0";
                    if (textBox118.Text == "-1.0") textBox118.Text = "0.0";
                    if (textBox119.Text == "-1.0") textBox119.Text = "0.0";
                    if (textBox120.Text == "-1.0") textBox120.Text = "0.0";
                    if (textBox121.Text == "-1.0") textBox121.Text = "0.0";
                    if (textBox122.Text == "-1.0") textBox122.Text = "0.0";
                    if (textBox123.Text == "-1.0") textBox123.Text = "0.0";
                    if (textBox124.Text == "-1.0") textBox124.Text = "0.0";
                    if (textBox125.Text == "-1.0") textBox125.Text = "0.0";
                    if (textBox126.Text == "-1.0") textBox126.Text = "0.0";
                    if (textBox127.Text == "-1.0") textBox127.Text = "0.0";
                    if (textBox128.Text == "-1.0") textBox128.Text = "0.0";
                    if (textBox129.Text == "-1.0") textBox129.Text = "0.0";
                    if (textBox130.Text == "-1.0") textBox130.Text = "0.0";
                    if (textBox131.Text == "-1.0") textBox131.Text = "0.0";
                    if (textBox132.Text == "-1.0") textBox132.Text = "0.0";
                    if (textBox133.Text == "-1.0") textBox133.Text = "0.0";
                    if (textBox134.Text == "-1.0") textBox134.Text = "0.0";
                    if (textBox135.Text == "-1.0") textBox135.Text = "0.0";
                    if (textBox136.Text == "-1.0") textBox136.Text = "0.0";
                    if (textBox137.Text == "-1.0") textBox137.Text = "0.0";
                    if (textBox138.Text == "-1.0") textBox138.Text = "0.0";
                    if (textBox139.Text == "-1.0") textBox139.Text = "0.0";
                    if (textBox140.Text == "-1.0") textBox140.Text = "0.0";
                    if (textBox141.Text == "-1.0") textBox141.Text = "0.0";
                    if (textBox142.Text == "-1.0") textBox142.Text = "0.0";
                    if (textBox143.Text == "-1.0") textBox143.Text = "0.0";
                    if (textBox144.Text == "-1.0") textBox144.Text = "0.0";
                    if (textBox145.Text == "-1.0") textBox145.Text = "0.0";
                    if (textBox146.Text == "-1.0") textBox146.Text = "0.0";
                    if (textBox147.Text == "-1.0") textBox147.Text = "0.0";

                    sumaMate += double.Parse(textBox101.Text);
                    sumaMate += double.Parse(textBox102.Text);
                    sumaMate += double.Parse(textBox103.Text);
                    sumaEspe += double.Parse(textBox104.Text);
                    sumaMate += double.Parse(textBox105.Text);
                    sumaInst += double.Parse(textBox106.Text);
                    sumaMate += double.Parse(textBox107.Text);
                    sumaMate += double.Parse(textBox108.Text);
                    sumaMate += double.Parse(textBox109.Text);
                    sumaEspe += double.Parse(textBox110.Text);
                    sumaInst += double.Parse(textBox111.Text);
                    sumaEspe += double.Parse(textBox112.Text);
                    sumaMate += double.Parse(textBox113.Text);
                    sumaEspe += double.Parse(textBox114.Text);
                    sumaEspe += double.Parse(textBox115.Text);
                    sumaMate += double.Parse(textBox116.Text);
                    sumaEspe += double.Parse(textBox117.Text);
                    sumaEspe += double.Parse(textBox118.Text);
                    sumaEspe += double.Parse(textBox119.Text);
                    sumaEspe += double.Parse(textBox120.Text);
                    sumaEspe += double.Parse(textBox121.Text);
                    sumaMate += double.Parse(textBox122.Text);
                    sumaEspe += double.Parse(textBox123.Text);
                    sumaEspe += double.Parse(textBox124.Text);
                    sumaEspe += double.Parse(textBox125.Text);
                    sumaEspe += double.Parse(textBox126.Text);
                    sumaEspe += double.Parse(textBox127.Text);
                    sumaEspe += double.Parse(textBox128.Text);
                    sumaMate += double.Parse(textBox129.Text);
                    sumaEspe += double.Parse(textBox130.Text);
                    sumaEspe += double.Parse(textBox131.Text);
                    sumaEspe += double.Parse(textBox132.Text);
                    sumaEspe += double.Parse(textBox133.Text);
                    sumaEspe += double.Parse(textBox134.Text);
                    sumaEspe += double.Parse(textBox135.Text);
                    sumaMate += double.Parse(textBox136.Text);
                    sumaEspe += double.Parse(textBox137.Text);
                    sumaEspe += double.Parse(textBox138.Text);
                    sumaEspe += double.Parse(textBox139.Text);
                    sumaEspe += double.Parse(textBox140.Text);
                    sumaTerm += double.Parse(textBox141.Text);
                    sumaTerm += double.Parse(textBox142.Text);
                    sumaTerm += double.Parse(textBox143.Text);
                    sumaInst += double.Parse(textBox144.Text);
                    sumaTerm += double.Parse(textBox145.Text);
                    sumaTerm += double.Parse(textBox146.Text);
                    sumaTerm += double.Parse(textBox147.Text);

                    //suma = Convert.ToDouble(textBox1.Text + textBox10.Text);
                    if (sumaMate != 0.0)
                    {
                        button1.Visible = true;
                        sumaMate /= 12.0;
                        sumaMate = (sumaMate * 100.0) / 10.0;
                        textBox2.Text = sumaMate.ToString();
                    }
                    else if (sumaMate == 0.0)
                    {
                        button1.Visible = true;
                        sumaMate = 0.0;
                        textBox2.Text = sumaMate.ToString();
                    }
                    if (sumaEspe != 0.0)
                    {
                        button2.Visible = true;
                        sumaEspe /= 26.0;
                        sumaEspe = (sumaEspe * 100.0) / 10.0;
                        textBox3.Text = sumaEspe.ToString();
                    }
                    else if (sumaEspe == 0.0)
                    {
                        button2.Visible = true;
                        sumaEspe = 0.0;
                        textBox3.Text = sumaEspe.ToString();
                    }
                }

                if (textBox101.Text == "-1.0") textBox101.Text = "N/P";
                if (textBox102.Text == "-1.0") textBox102.Text = "N/P";
                if (textBox103.Text == "-1.0") textBox103.Text = "N/P";
                if (textBox104.Text == "-1.0") textBox104.Text = "N/P";
                if (textBox105.Text == "-1.0") textBox105.Text = "N/P";
                if (textBox106.Text == "-1.0") textBox106.Text = "N/P";
                if (textBox107.Text == "-1.0") textBox107.Text = "N/P";
                if (textBox108.Text == "-1.0") textBox108.Text = "N/P";
                if (textBox109.Text == "-1.0") textBox109.Text = "N/P";
                if (textBox110.Text == "-1.0") textBox110.Text = "N/P";
                if (textBox111.Text == "-1.0") textBox111.Text = "N/P";
                if (textBox112.Text == "-1.0") textBox112.Text = "N/P";
                if (textBox113.Text == "-1.0") textBox113.Text = "N/P";
                if (textBox114.Text == "-1.0") textBox114.Text = "N/P";
                if (textBox115.Text == "-1.0") textBox115.Text = "N/P";
                if (textBox116.Text == "-1.0") textBox116.Text = "N/P";
                if (textBox117.Text == "-1.0") textBox117.Text = "N/P";
                if (textBox118.Text == "-1.0") textBox118.Text = "N/P";
                if (textBox119.Text == "-1.0") textBox119.Text = "N/P";
                if (textBox120.Text == "-1.0") textBox120.Text = "N/P";
                if (textBox121.Text == "-1.0") textBox121.Text = "N/P";
                if (textBox122.Text == "-1.0") textBox122.Text = "N/P";
                if (textBox123.Text == "-1.0") textBox123.Text = "N/P";
                if (textBox124.Text == "-1.0") textBox124.Text = "N/P";
                if (textBox125.Text == "-1.0") textBox125.Text = "N/P";
                if (textBox126.Text == "-1.0") textBox126.Text = "N/P";
                if (textBox127.Text == "-1.0") textBox127.Text = "N/P";
                if (textBox128.Text == "-1.0") textBox128.Text = "N/P";
                if (textBox129.Text == "-1.0") textBox129.Text = "N/P";
                if (textBox130.Text == "-1.0") textBox130.Text = "N/P";
                if (textBox131.Text == "-1.0") textBox131.Text = "N/P";
                if (textBox132.Text == "-1.0") textBox132.Text = "N/P";
                if (textBox133.Text == "-1.0") textBox133.Text = "N/P";
                if (textBox134.Text == "-1.0") textBox134.Text = "N/P";
                if (textBox135.Text == "-1.0") textBox135.Text = "N/P";
                if (textBox136.Text == "-1.0") textBox136.Text = "N/P";
                if (textBox137.Text == "-1.0") textBox137.Text = "N/P";
                if (textBox138.Text == "-1.0") textBox138.Text = "N/P";
                if (textBox139.Text == "-1.0") textBox139.Text = "N/P";
                if (textBox140.Text == "-1.0") textBox140.Text = "N/P";
                if (textBox141.Text == "-1.0") textBox141.Text = "N/P";
                if (textBox142.Text == "-1.0") textBox142.Text = "N/P";
                if (textBox143.Text == "-1.0") textBox143.Text = "N/P";
                if (textBox144.Text == "-1.0") textBox144.Text = "N/P";
                if (textBox145.Text == "-1.0") textBox145.Text = "N/P";
                if (textBox146.Text == "-1.0") textBox146.Text = "N/P";
                if (textBox147.Text == "-1.0") textBox147.Text = "N/P";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Algo salió mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormPorcenMat formularios;
            formularios = panel2.Controls.OfType<FormPorcenMat>().FirstOrDefault();
            if (formularios == null)
            {
                formularios = new FormPorcenMat()
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };
                panel2.Controls.Add(formularios);
                panel2.Tag = formularios;

                formularios.textBox1.Text = textBox2.Text;

                formularios.Show();
                formularios.BringToFront();
            }
            else
            {
                formularios.BringToFront();
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormPorcenEspe formularios;
            formularios = panel2.Controls.OfType<FormPorcenEspe>().FirstOrDefault();
            if (formularios == null)
            {
                formularios = new FormPorcenEspe()
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };
                panel2.Controls.Add(formularios);
                panel2.Tag = formularios;

                formularios.textBox1.Text = textBox3.Text;

                formularios.Show();
                formularios.BringToFront();
            }
            else
            {
                formularios.BringToFront();
            }
        }
    }
}
