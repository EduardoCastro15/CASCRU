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
    public partial class FormAgregarDiscente : Form
    {
        public FormAgregarDiscente()
        {
            InitializeComponent();
        }

        private MySqlConnection conn;
        private MySqlCommand cmd;
        private string sql = null;
        public string matricula = null;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void FormAgregarDiscente_Load(object sender, EventArgs e)
        {
            BusinessIntelligence_v1.ConexionBD conexion = new BusinessIntelligence_v1.ConexionBD();
            conn = conexion.ConectarMysql();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Seleccione una foto";
            dialog.Filter = "Imagenes|*.jpg; *.png";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox31.Text = dialog.FileName;
                pictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox10.Text == "" ||
                textBox9.Text == "" || textBox8.Text == "" || textBox7.Text == "" || textBox11.Text == "" ||
                textBox13.Text == "" || textBox17.Text == "" || textBox18.Text == "" || textBox19.Text == "" ||
                textBox23.Text == "" || textBox22.Text == "" || textBox24.Text == "" || textBox25.Text == "" || textBox28.Text == "" ||
                comboBox1.SelectedIndex == -1 || comboBox10.SelectedIndex == -1 || comboBox11.SelectedIndex == -1 || comboBox12.SelectedIndex == -1 || comboBox14.SelectedIndex == -1 ||
                comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1 || comboBox4.SelectedIndex == -1 || comboBox5.SelectedIndex == -1 || comboBox13.SelectedIndex == -1 ||
                comboBox6.SelectedIndex == -1 || comboBox7.SelectedIndex == -1 || comboBox8.SelectedIndex == -1 || comboBox9.SelectedIndex == -1)
            {
                MessageBox.Show("Hay campos vacios sin llenar");
            }
            else if (textBox30.Text == "" || textBox31.Text == "")
            {
                MessageBox.Show("No se ha seleccionado la foto del discente o el horario");
            }
            else
            {
                if (comboBox2.Text == "NO")
                    textBox29.Text = null;
                if (comboBox3.Text == "NO")
                    textBox5.Text = null;
                if (comboBox4.Text == "NO")
                    textBox12.Text = null;
                if (comboBox13.Text == "NO")
                {
                    textBox14.Text = null;
                    textBox15.Text = null;
                    textBox20.Text = null;
                    dateTimePicker2.Text = null;
                    textBox21.Text = null;
                    textBox27.Text = null;
                }

                try
                {
                    conn.Open();
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;

                    MemoryStream msFoto = new MemoryStream();
                    MemoryStream msHorario = new MemoryStream();
                    pictureBox1.Image.Save(msFoto, ImageFormat.Jpeg);
                    pictureBox2.Image.Save(msHorario, ImageFormat.Jpeg);
                    byte[] aByte = msFoto.ToArray();
                    byte[] bByte = msHorario.ToArray();
                    
                    conn.Open();
                    sql = @"select crack_user('" + textBox1.Text + "')";
                    cmd = new MySqlCommand(sql, conn);
                    int result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        cmd.CommandText = ("UPDATE discentes SET matricula_discente = '" + textBox1.Text + "', nombre_discente = '" + textBox2.Text + "', apellido_paterno_discente = '" + textBox3.Text + "', apellido_materno_discente = '" + textBox4.Text + "', grado_escolar = '" + comboBox8.Text + "'" +
                                            ", plantel = '" + textBox10.Text + "', CURP = '" + textBox9.Text + "', RFC = '" + textBox8.Text + "', cartilla_militar = '" + textBox7.Text + "', generacion = '" + textBox6.Text + "', sexo = '" + textBox9.Text + "', fecha_nacimiento = '" + dateTimePicker1.Text + "'" +
                                            ", nacionalidad = '" + textBox13.Text + "', entidad_nacimiento = '" + comboBox10.Text + "', nombre_tutor = '" + textBox11.Text + "', nombre_padre = '" + textBox17.Text + "', nombre_madre = '" + textBox18.Text + "', escuela_procedencia = '" + textBox19.Text + "'" +
                                            ", tipo_escuela_procedencia = '" + comboBox11.Text + "', entidad_federativa_escuela = '" + comboBox12.Text + "', promedio_secundaria = '" + textBox23.Text + "', promedio_bachillerato = '" + textBox22.Text + "', foto = '@imagen'" +
                                            ", practica_deporte = '" + textBox13.Text + "', nombre_deporte = '" + textBox14.Text + "', nombre_entrenador = '" + textBox15.Text + "', categoria = '" + textBox20.Text + "', fecha_inicio = '" + dateTimePicker2.Text + "', lugar = '" + textBox21.Text + "'" +
                                            ", horario_deporte = '" + comboBox15.Text + "', asociacion = '" + textBox27.Text + "', peso = '" + textBox24.Text + "', estatura = '" + textBox25.Text + "', tipo_sangre = '" + comboBox1.Text + "', padece_enfermedad = '" + comboBox2.Text + "'" +
                                            ", descripcion_enfermedad = '" + textBox29.Text + "', problema_fisico = '" + comboBox3.Text + "', descripcion_problema = '" + textBox5.Text + "', operacion_fisica = '" + comboBox4.Text + "', descripcion_operacion = '" + textBox12.Text + "'" +
                                            ", tatuajes = '" + comboBox5.Text + "', pie_plano = '" + comboBox6.Text + "', lentes = '" + comboBox7.Text + "', carrera = '" + comboBox14.Text + "', promedio = '" + textBox28.Text + "', foto_horario = '@horario' WHERE (matricula_discente = '" + textBox1.Text + "');");
                        MessageBox.Show("El usuario se actualizó con éxito");
                    }
                    else
                    {
                        cmd.CommandText = ("insert into discentes (matricula_discente, nombre_discente, apellido_paterno_discente, apellido_materno_discente, grado_escolar, plantel, CURP, RFC, cartilla_militar, generacion, sexo, fecha_nacimiento, nacionalidad, entidad_nacimiento, " +
                                        "nombre_tutor, nombre_padre, nombre_madre, escuela_procedencia, tipo_escuela_procedencia, entidad_federativa_escuela, promedio_secundaria, promedio_bachillerato, foto, practica_deporte, nombre_deporte, nombre_entrenador, categoria, fecha_inicio, lugar, " +
                                        "horario_deporte, asociacion, peso, estatura, tipo_sangre, padece_enfermedad, descripcion_enfermedad, problema_fisico, descripcion_problema, " +
                                        "operacion_fisica, descripcion_operacion, tatuajes, pie_plano, lentes, carrera, promedio, foto_horario) values ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text +
                                        "', '" + comboBox8.Text + "', '" + textBox10.Text + "', '" + textBox9.Text + "', '" + textBox8.Text + "', '" + textBox7.Text + "', '" + textBox6.Text + "', '" + comboBox9.Text + "', '" + dateTimePicker1.Text + "', '" + textBox13.Text + "', '" + comboBox10.Text +
                                        "', '" + textBox11.Text + "', '" + textBox17.Text + "', '" + textBox18.Text + "', '" + textBox19.Text + "', '" + comboBox11.Text + "', '" + comboBox12.Text +
                                        "', '" + textBox23.Text + "', '" + textBox22.Text + "', @imagen, '" + comboBox13.Text + "', '" + textBox14.Text + "', '" + textBox15.Text + "', '" + textBox20.Text + "', '" + dateTimePicker2.Text + "', '" + textBox21.Text +
                                        "', '" + comboBox15.Text + "', '" + textBox27.Text + "', '" + textBox24.Text + "', '" + textBox25.Text + "', '" + comboBox1.Text + "', '" + comboBox2.Text + "', '" + textBox29.Text + "', '" + comboBox3.Text + "', '" + textBox5.Text +
                                        "', '" + comboBox4.Text + "', '" + textBox12.Text + "', '" + comboBox5.Text + "', '" + comboBox6.Text + "', '" + comboBox7.Text + "', '" + comboBox14.Text + "', '" + textBox28.Text + "', @horario);");
                        MessageBox.Show("El usuario se agregó con éxito");
                    }
                    cmd.Parameters.AddWithValue("imagen", aByte);
                    cmd.Parameters.AddWithValue("horario", bByte);
                    cmd.ExecuteNonQuery();
                    conn.Close();
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
            if ( opc == DialogResult.OK)
            {
                limpiar_campos();
            }
        }

        private void limpiar_campos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox8.Text = "";
            textBox10.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";
            comboBox9.Text = "";
            dateTimePicker1.Text = "";
            comboBox10.Text = "";
            textBox11.Text = "";
            textBox13.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            comboBox11.Text = "";
            comboBox12.Text = "";
            textBox23.Text = "";
            textBox22.Text = "";
            textBox31.Text = "";
            textBox24.Text = "";
            textBox25.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox29.Text = "";
            comboBox3.Text = "";
            textBox5.Text = "";
            comboBox4.Text = "";
            textBox12.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            comboBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox20.Text = "";
            dateTimePicker2.Text = "";
            textBox21.Text = "";
            comboBox15.Text = "";
            textBox27.Text = "";
            comboBox14.Text = "";
            textBox28.Text = "";
            textBox30.Text = "";
            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Seleccione una imagen del horario del discente";
            dialog.Filter = "Imagenes|*.jpg; *.png";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox30.Text = dialog.FileName;
                pictureBox2.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
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
                        MessageBox.Show("Se encontró la matrícula: " + textBox1.Text);
                        matricula = textBox1.Text;
                        try
                        {
                            conn.Open();
                            cmd = new MySqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandText = ("select * from discentes where matricula_discente = '" + textBox1.Text + "' ");
                            MySqlDataReader leer = cmd.ExecuteReader();
                            if (leer.HasRows)
                            {
                                leer.Read();
                                MemoryStream ms = new MemoryStream((byte[])leer["foto"]);
                                MemoryStream ms1 = new MemoryStream((byte[])leer["foto_horario"]);
                                Bitmap bm = new Bitmap(ms);
                                Bitmap bm1 = new Bitmap(ms1);
                                pictureBox1.Image = bm;
                                pictureBox2.Image = bm1;

                                textBox2.Text = leer["nombre_discente"].ToString();
                                textBox3.Text = leer["apellido_paterno_discente"].ToString();
                                textBox4.Text = leer["apellido_materno_discente"].ToString();
                                comboBox8.Text = leer["grado_escolar"].ToString();
                                textBox10.Text = leer["plantel"].ToString();
                                textBox9.Text = leer["CURP"].ToString();
                                textBox8.Text = leer["RFC"].ToString();
                                textBox7.Text = leer["cartilla_militar"].ToString();
                                textBox6.Text = leer["generacion"].ToString();
                                comboBox9.Text = leer["sexo"].ToString();
                                dateTimePicker1.Text = leer["fecha_nacimiento"].ToString();
                                comboBox10.Text = leer["entidad_nacimiento"].ToString();
                                textBox11.Text = leer["nombre_tutor"].ToString();
                                textBox13.Text = leer["nacionalidad"].ToString();
                                textBox17.Text = leer["nombre_padre"].ToString();
                                textBox18.Text = leer["nombre_madre"].ToString();
                                textBox19.Text = leer["escuela_procedencia"].ToString();
                                comboBox11.Text = leer["tipo_escuela_procedencia"].ToString();
                                comboBox12.Text = leer["entidad_federativa_escuela"].ToString();
                                textBox23.Text = leer["promedio_secundaria"].ToString();
                                textBox22.Text = leer["promedio_bachillerato"].ToString();
                                textBox31.Text = "/fakePath";
                                textBox24.Text = leer["peso"].ToString();
                                textBox25.Text = leer["estatura"].ToString();
                                comboBox1.Text = leer["tipo_sangre"].ToString();
                                comboBox2.Text = leer["padece_enfermedad"].ToString();
                                textBox29.Text = leer["descripcion_enfermedad"].ToString();
                                comboBox3.Text = leer["problema_fisico"].ToString();
                                textBox5.Text = leer["descripcion_problema"].ToString();
                                comboBox4.Text = leer["operacion_fisica"].ToString();
                                textBox12.Text = leer["descripcion_operacion"].ToString();
                                comboBox5.Text = leer["tatuajes"].ToString();
                                comboBox6.Text = leer["pie_plano"].ToString();
                                comboBox7.Text = leer["lentes"].ToString();
                                comboBox13.Text = leer["practica_deporte"].ToString();
                                textBox14.Text = leer["nombre_deporte"].ToString();
                                textBox15.Text = leer["nombre_entrenador"].ToString();
                                textBox20.Text = leer["categoria"].ToString();
                                dateTimePicker2.Text = leer["fecha_inicio"].ToString();
                                textBox21.Text = leer["lugar"].ToString();
                                comboBox15.Text = leer["horario_deporte"].ToString();
                                textBox27.Text = leer["asociacion"].ToString();
                                comboBox14.Text = leer["carrera"].ToString();
                                textBox28.Text = leer["promedio"].ToString();
                                textBox30.Text = "/fakePath";
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron registros");
                            }
                            conn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Algo salió mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            conn.Close();
                        }

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
                    //conn.Close();
                }
            }
        }
    }
}
