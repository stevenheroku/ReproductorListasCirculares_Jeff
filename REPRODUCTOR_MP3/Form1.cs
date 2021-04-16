using REPRODUCTOR_MP3.Clases.reproducir;
using REPRODUCTOR_MP3.Clases.reproducir_Circulares;
using REPRODUCTOR_MP3.Clases.reproducir_Dobles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REPRODUCTOR_MP3
{
    public partial class Form1 : Form
    {

        OpenFileDialog buscarCanciones = new OpenFileDialog();
        int cant = 1;
        int tam;
        int vl = 100;
        private string arch;
        private string[] rut;
        ListarCanciones list = new ListarCanciones();
        ListaDobles addlist = new ListaDobles();
        ListarCirculares addlistCirculares = new ListarCirculares();
        private Nodo_C actual;


        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImagebtn_agregar_Click(object sender, EventArgs e)
        {
            try
            {

                buscarCanciones.Multiselect = true;
                buscarCanciones.Filter = "Archivos audios (*.mp3),(*.mp4),(*.wav),(*.png)|";



                if (buscarCanciones.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    if (list.buscar(buscarCanciones.SafeFileName))
                    {
                        MessageBox.Show("ESA CANCION YA ESTA INGRESADA");
                        //continue;
                    }
                    else
                    {

                        for (int i = 0; i < buscarCanciones.SafeFileNames.Length; i++)
                        {

                            //list.insertar(buscarCanciones.SafeFileNames[i]);
                            addlist.insertarcabezaLista(buscarCanciones.FileNames[i]);
                            addlistCirculares.insertarCircular(buscarCanciones.FileNames[i]);
                            //string dato = buscarCanciones.FileNames[i];
                            lis_canciones.Items.Add(buscarCanciones.SafeFileNames[i]);
                        }

                            axWindowsMediaPlayer1.URL = buscarCanciones.FileNames[0];
                            lis_canciones.SelectedIndex = 0;
                            bunifuImagebtn_pause.Visible = true;
                            time_slider.Start();

                            MessageBox.Show("CANCIONES AGREGADAS AL PLAYLIST");
                        
                        int pausa;
                        pausa = 0;



                    }
                }
            }
            catch (Exception en)
            {
                MessageBox.Show(en.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuImagebtn_eliminar_Click(object sender, EventArgs e)
        {
            if (addlist.IsEmpty())
            {
                return;
            }
            else
            if (lis_canciones.SelectedIndex != -1)               
            {
                int entrada = lis_canciones.SelectedIndex;
                

                addlist.eliminarDoble(arch);
                addlistCirculares.eliminarCircular(arch);
                //list.eliminarNodo(arch);
                lis_canciones.Items.Remove(lis_canciones.SelectedItem);
                lbl_nom.Text = "------";
                axWindowsMediaPlayer1.Ctlcontrols.stop();


            }

            int pausa;
            pausa = 0;
        }
       

        private void lis_canciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (lis_canciones.SelectedIndex != -1)
                {
                    axWindowsMediaPlayer1.URL = buscarCanciones.FileNames[lis_canciones.SelectedIndex];
                    int select = lis_canciones.SelectedIndex;
                    actual = new Nodo_C(buscarCanciones.FileNames[select]);
                    arch = buscarCanciones.FileNames[lis_canciones.SelectedIndex];
                    bunifuImagebtn_pause.Visible = true;
                    btn_play.Visible = false;
                    lbl_nom.Text = buscarCanciones.SafeFileNames[lis_canciones.SelectedIndex];

                }


            }
            catch (IndexOutOfRangeException exi)
            {
                 MessageBox.Show("ERROR" + exi);
            }
        }



        private void bunifuImagebtn_cerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImagebtn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btn_maximizar.Visible = false;
            btn_restaurar.Visible = true;
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_maximizar.Visible = true;
        }

        private void bunifuImagebtn_anterior_Click(object sender, EventArgs e)
        {
            //keybd_event(VK_MEDIA_NEXT_TRACK, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
            if (lis_canciones.SelectedIndex <= 0)
            {
                MessageBox.Show("YA NO HAY CANCIONES ANTERIORES");
            }
            else if (lis_canciones.SelectedIndex > 0)
            {
                lis_canciones.SelectedIndex -= 1;
            }
        }

        private void bunifuImagebtn_siguiente_Click(object sender, EventArgs e)
        {
            if (lis_canciones.SelectedIndex == lis_canciones.Items.Count+1)
            {
                MessageBox.Show("YA NO HAY CANCIONES PARA SEGUIR ");
            }
            else if (lis_canciones.SelectedIndex < lis_canciones.Items.Count - 1)
            {
                lis_canciones.SelectedIndex += 1;
            }
            //else
            //{
            //    //MessageBox.Show("SI PASA");
            //    recorrer();
            //}
        }

        private void bunifuImagebtn_pausa_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void bunifuImagebtn_play_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btn_artista_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.Ctlcontrols.play();
            btn_play.Visible = false;
            bunifuImagebtn_pause.Visible = true;
        }

        private void bunifuImagebtn_pause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            bunifuImagebtn_pause.Visible = false;
            btn_play.Visible = true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
           
                lis_canciones.SelectedItems.Clear();

                for (int i = lis_canciones.Items.Count - 1; i >= 0; i--)
                {
                    if (lis_canciones.Items[i].ToString().ToLower().Contains(txt_buscar.Text))
                    {
                        lis_canciones.SetSelected(i, true);
                    }

                }
                MessageBox.Show(lis_canciones.SelectedItems.Count.ToString() + " CANCION ECONTRADA");
            
        }

        private void btn_text_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"C:\PlayList\mp3.txt");
            foreach (object lista in buscarCanciones.FileNames)
            {
                sw.WriteLine(lista.ToString());
            }
            sw.Close();
            MessageBox.Show("CANCIONES AGUARDAS ");
        }

        private void btn_sonido_Click(object sender, EventArgs e)
        {
            validar_volumen.Visible = true;


        }

        private void validar_volumen_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            validar_volumen.Visible = true;
        }

        private void duracion_cancion_ValueChanged(object sender, decimal value)
        {
            duracion_cancion.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration;

            if(duracion_cancion.Value == (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition)
            {

            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = duracion_cancion.Value;
            }
        }

        private void time_slider_Tick(object sender, EventArgs e)
        {

            if(axWindowsMediaPlayer1.playState ==WMPLib.WMPPlayState.wmppsPlaying)
            {

                duracion_cancion.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                duracion_cancion.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

                if(duracion_cancion.Value == duracion_cancion.Maximum)
                {
                    recorrer();
                }

            }


            try
            {
                duracion_cancion.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                lbl_inicio.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                lbl_final.Text = axWindowsMediaPlayer1.currentMedia.durationString;


            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void validar_volumen_ValueChanged(object sender, decimal value)
        {
            axWindowsMediaPlayer1.settings.volume = validar_volumen.Value;

            lvl_volumen.Text = axWindowsMediaPlayer1.settings.volume.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvl_volumen.Text = (validar_volumen.Value = axWindowsMediaPlayer1.settings.volume = vl).ToString();
            this.axWindowsMediaPlayer1.uiMode = "none";
        }

        private void timer_hora_Tick(object sender, EventArgs e)
        {
            lbl_fecha.Text = "hola";
            lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss");
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            Random numero = new Random();
            int a = numero.Next(0, lis_canciones.Items.Count - 1);

            if (addlist.primero == null)
            {
                MessageBox.Show("NO HAY CANCIONES EN EL PLAYLIST");
            }else if (lis_canciones.SelectedIndex != a)
            {

                //a = numero.Next(0, lis_canciones.Items.Count - 1);
                axWindowsMediaPlayer1.URL = buscarCanciones.FileNames[a];
                lis_canciones.SelectedIndex = a;
            }
            else
            {
                Random numero2 = new Random();
                int b = numero2.Next(0, lis_canciones.Items.Count - 1);
                axWindowsMediaPlayer1.URL = buscarCanciones.FileNames[b];
                lis_canciones.SelectedIndex = b;
            }
            //    else
            //    {
            //        Random numero = new Random();
            //        int a = numero.Next(0, lis_canciones.Items.Count - 1);
            //        axWindowsMediaPlayer1.URL = buscarCanciones.FileNames[a];
            //        lbl_nom.Text = buscarCanciones.SafeFileNames[lis_canciones.SelectedIndex];
            //    }
        }

          
        public void recorrer()
        {
            //Nodos_C p;
            if (actual != null)
            {
                actual = addlistCirculares.primero.enlace; // siguiente nodo al de acceso
                                                 // do
                while (actual == addlistCirculares.primero.enlace)
                {
                    if (lis_canciones.SelectedIndex < lis_canciones.Items.Count - 1)
                    {
                       // MessageBox.Show("NO A LLEGADO A LA ULTIMA CANCION");
                        lis_canciones.SelectedIndex += 1;
                        //recorrer();
                        actual = actual.enlace;
                    }
                    else
                    {
                        //MessageBox.Show("PASAR A LA PRIMER CANCION DE NUEVO");
                        axWindowsMediaPlayer1.URL = buscarCanciones.FileNames[0];
                        lis_canciones.SelectedIndex = 0;
                        actual = actual.enlace;
                    }


                    //MessageBox.Show("\t" + p.dato);
                    //MessageBox.Show("REDIRRECIONANDO NODOS");
                    actual = actual.enlace;
                }// while (p != addpath.primero.enlace);
            }
            else
            {
                MessageBox.Show("\t LISTA CIRCULAR VACIA");
            }
        }
        private void btn_repetir_Click(object sender, EventArgs e)
        {
            if(lis_canciones.SelectedIndex !=-1)
            {
                btn_repetir.Enabled = false;
            }
            else
            {
                btn_repetir.Enabled = true;
            }


        }


        public void  generarnumaleatorio()
        {
            


        }

        private void bunifuCustomlbl_nombre_Click(object sender, EventArgs e)
        {

        }
    }
}
