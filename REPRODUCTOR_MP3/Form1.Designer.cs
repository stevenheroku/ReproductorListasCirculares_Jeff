﻿namespace REPRODUCTOR_MP3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_text = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_buscar = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btn_buscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_artista = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_playlist = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImagebtn_eliminar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImagebtn_agregar = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_restaurar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_nom = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_maximizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImagebtn_minimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImagebtn_cerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_random = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_repetir = new Bunifu.Framework.UI.BunifuImageButton();
            this.lvl_volumen = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_final = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_inicio = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_sonido = new Bunifu.Framework.UI.BunifuImageButton();
            this.validar_volumen = new XComponent.SliderBar.MACTrackBar();
            this.duracion_cancion = new XComponent.SliderBar.MACTrackBar();
            this.bunifuImagebtn_pause = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_play = new Bunifu.Framework.UI.BunifuImageButton();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImagebtn_siguiente = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImagebtn_anterior = new Bunifu.Framework.UI.BunifuImageButton();
            this.lis_canciones = new System.Windows.Forms.ListBox();
            this.time_slider = new System.Windows.Forms.Timer(this.components);
            this.lbl_hora = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_fecha = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer_hora = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImagebtn_eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImagebtn_agregar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImagebtn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImagebtn_cerrar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_random)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_repetir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sonido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImagebtn_pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImagebtn_siguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImagebtn_anterior)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_text);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txt_buscar);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.btn_artista);
            this.panel1.Controls.Add(this.btn_playlist);
            this.panel1.Controls.Add(this.bunifuImagebtn_eliminar);
            this.panel1.Controls.Add(this.bunifuImagebtn_agregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 633);
            this.panel1.TabIndex = 0;
            // 
            // btn_text
            // 
            this.btn_text.BackColor = System.Drawing.Color.Transparent;
            this.btn_text.Image = ((System.Drawing.Image)(resources.GetObject("btn_text.Image")));
            this.btn_text.ImageActive = null;
            this.btn_text.Location = new System.Drawing.Point(9, 462);
            this.btn_text.Margin = new System.Windows.Forms.Padding(4);
            this.btn_text.Name = "btn_text";
            this.btn_text.Size = new System.Drawing.Size(67, 62);
            this.btn_text.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_text.TabIndex = 14;
            this.btn_text.TabStop = false;
            this.btn_text.Zoom = 10;
            this.btn_text.Click += new System.EventHandler(this.btn_text_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 161);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txt_buscar
            // 
            this.txt_buscar.BorderColor = System.Drawing.Color.PaleGreen;
            this.txt_buscar.Location = new System.Drawing.Point(57, 38);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(155, 22);
            this.txt_buscar.TabIndex = 4;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageActive = null;
            this.btn_buscar.Location = new System.Drawing.Point(1, 31);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(49, 38);
            this.btn_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_buscar.TabIndex = 12;
            this.btn_buscar.TabStop = false;
            this.btn_buscar.Zoom = 10;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_artista
            // 
            this.btn_artista.ActiveBorderThickness = 1;
            this.btn_artista.ActiveCornerRadius = 20;
            this.btn_artista.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_artista.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btn_artista.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_artista.BackColor = System.Drawing.Color.Black;
            this.btn_artista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_artista.BackgroundImage")));
            this.btn_artista.ButtonText = "Artist";
            this.btn_artista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_artista.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_artista.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_artista.IdleBorderThickness = 2;
            this.btn_artista.IdleCornerRadius = 20;
            this.btn_artista.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_artista.IdleForecolor = System.Drawing.Color.White;
            this.btn_artista.IdleLineColor = System.Drawing.Color.Green;
            this.btn_artista.Location = new System.Drawing.Point(9, 373);
            this.btn_artista.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_artista.Name = "btn_artista";
            this.btn_artista.Size = new System.Drawing.Size(211, 48);
            this.btn_artista.TabIndex = 11;
            this.btn_artista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_artista.Click += new System.EventHandler(this.btn_artista_Click);
            // 
            // btn_playlist
            // 
            this.btn_playlist.ActiveBorderThickness = 1;
            this.btn_playlist.ActiveCornerRadius = 20;
            this.btn_playlist.ActiveFillColor = System.Drawing.Color.Black;
            this.btn_playlist.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btn_playlist.ActiveLineColor = System.Drawing.Color.Black;
            this.btn_playlist.BackColor = System.Drawing.Color.Black;
            this.btn_playlist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_playlist.BackgroundImage")));
            this.btn_playlist.ButtonText = "PlayList";
            this.btn_playlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_playlist.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playlist.ForeColor = System.Drawing.Color.Snow;
            this.btn_playlist.IdleBorderThickness = 2;
            this.btn_playlist.IdleCornerRadius = 20;
            this.btn_playlist.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_playlist.IdleForecolor = System.Drawing.Color.Black;
            this.btn_playlist.IdleLineColor = System.Drawing.Color.Black;
            this.btn_playlist.Location = new System.Drawing.Point(4, 129);
            this.btn_playlist.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_playlist.Name = "btn_playlist";
            this.btn_playlist.Size = new System.Drawing.Size(211, 48);
            this.btn_playlist.TabIndex = 9;
            this.btn_playlist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_playlist.Visible = false;
            // 
            // bunifuImagebtn_eliminar
            // 
            this.bunifuImagebtn_eliminar.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImagebtn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImagebtn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImagebtn_eliminar.Image")));
            this.bunifuImagebtn_eliminar.ImageActive = null;
            this.bunifuImagebtn_eliminar.Location = new System.Drawing.Point(112, 529);
            this.bunifuImagebtn_eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImagebtn_eliminar.Name = "bunifuImagebtn_eliminar";
            this.bunifuImagebtn_eliminar.Size = new System.Drawing.Size(103, 87);
            this.bunifuImagebtn_eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImagebtn_eliminar.TabIndex = 3;
            this.bunifuImagebtn_eliminar.TabStop = false;
            this.bunifuImagebtn_eliminar.Zoom = 10;
            this.bunifuImagebtn_eliminar.Click += new System.EventHandler(this.bunifuImagebtn_eliminar_Click);
            // 
            // bunifuImagebtn_agregar
            // 
            this.bunifuImagebtn_agregar.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImagebtn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImagebtn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImagebtn_agregar.Image")));
            this.bunifuImagebtn_agregar.ImageActive = null;
            this.bunifuImagebtn_agregar.Location = new System.Drawing.Point(7, 529);
            this.bunifuImagebtn_agregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImagebtn_agregar.Name = "bunifuImagebtn_agregar";
            this.bunifuImagebtn_agregar.Size = new System.Drawing.Size(100, 87);
            this.bunifuImagebtn_agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImagebtn_agregar.TabIndex = 2;
            this.bunifuImagebtn_agregar.TabStop = false;
            this.bunifuImagebtn_agregar.Zoom = 10;
            this.bunifuImagebtn_agregar.Click += new System.EventHandler(this.bunifuImagebtn_agregar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btn_restaurar);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.bunifuImageButton3);
            this.panel2.Controls.Add(this.lbl_nom);
            this.panel2.Controls.Add(this.btn_maximizar);
            this.panel2.Controls.Add(this.bunifuImagebtn_minimizar);
            this.panel2.Controls.Add(this.bunifuImagebtn_cerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(231, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 188);
            this.panel2.TabIndex = 1;
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_restaurar.Image = ((System.Drawing.Image)(resources.GetObject("btn_restaurar.Image")));
            this.btn_restaurar.ImageActive = null;
            this.btn_restaurar.Location = new System.Drawing.Point(717, 15);
            this.btn_restaurar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(52, 39);
            this.btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_restaurar.TabIndex = 9;
            this.btn_restaurar.TabStop = false;
            this.btn_restaurar.Visible = false;
            this.btn_restaurar.Zoom = 10;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(5, 14);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(286, 42);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "MP3_JEFFERSON";
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.BackgroundImage")));
            this.bunifuImageButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(4, 149);
            this.bunifuImageButton3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(43, 39);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 6;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_nom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_nom.Location = new System.Drawing.Point(49, 164);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(108, 17);
            this.lbl_nom.TabIndex = 7;
            this.lbl_nom.Text = "--------------------";
            this.lbl_nom.Click += new System.EventHandler(this.bunifuCustomlbl_nombre_Click);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_maximizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_maximizar.Image")));
            this.btn_maximizar.ImageActive = null;
            this.btn_maximizar.Location = new System.Drawing.Point(717, 12);
            this.btn_maximizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(52, 39);
            this.btn_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_maximizar.TabIndex = 6;
            this.btn_maximizar.TabStop = false;
            this.btn_maximizar.Zoom = 10;
            this.btn_maximizar.Click += new System.EventHandler(this.btn_maximizar_Click);
            // 
            // bunifuImagebtn_minimizar
            // 
            this.bunifuImagebtn_minimizar.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImagebtn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImagebtn_minimizar.Image")));
            this.bunifuImagebtn_minimizar.ImageActive = null;
            this.bunifuImagebtn_minimizar.Location = new System.Drawing.Point(659, 12);
            this.bunifuImagebtn_minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImagebtn_minimizar.Name = "bunifuImagebtn_minimizar";
            this.bunifuImagebtn_minimizar.Size = new System.Drawing.Size(53, 39);
            this.bunifuImagebtn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImagebtn_minimizar.TabIndex = 5;
            this.bunifuImagebtn_minimizar.TabStop = false;
            this.bunifuImagebtn_minimizar.Zoom = 10;
            this.bunifuImagebtn_minimizar.Click += new System.EventHandler(this.bunifuImagebtn_minimizar_Click);
            // 
            // bunifuImagebtn_cerrar
            // 
            this.bunifuImagebtn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImagebtn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImagebtn_cerrar.Image")));
            this.bunifuImagebtn_cerrar.ImageActive = null;
            this.bunifuImagebtn_cerrar.Location = new System.Drawing.Point(775, 12);
            this.bunifuImagebtn_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImagebtn_cerrar.Name = "bunifuImagebtn_cerrar";
            this.bunifuImagebtn_cerrar.Size = new System.Drawing.Size(53, 39);
            this.bunifuImagebtn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImagebtn_cerrar.TabIndex = 4;
            this.bunifuImagebtn_cerrar.TabStop = false;
            this.bunifuImagebtn_cerrar.Zoom = 10;
            this.bunifuImagebtn_cerrar.Click += new System.EventHandler(this.bunifuImagebtn_cerrar_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btn_random);
            this.panel3.Controls.Add(this.btn_repetir);
            this.panel3.Controls.Add(this.lvl_volumen);
            this.panel3.Controls.Add(this.lbl_final);
            this.panel3.Controls.Add(this.lbl_inicio);
            this.panel3.Controls.Add(this.btn_sonido);
            this.panel3.Controls.Add(this.validar_volumen);
            this.panel3.Controls.Add(this.duracion_cancion);
            this.panel3.Controls.Add(this.bunifuImagebtn_pause);
            this.panel3.Controls.Add(this.btn_play);
            this.panel3.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel3.Controls.Add(this.bunifuImageButton2);
            this.panel3.Controls.Add(this.bunifuImageButton1);
            this.panel3.Controls.Add(this.bunifuImagebtn_siguiente);
            this.panel3.Controls.Add(this.bunifuImagebtn_anterior);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(231, 507);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(840, 126);
            this.panel3.TabIndex = 2;
            // 
            // btn_random
            // 
            this.btn_random.BackColor = System.Drawing.Color.Transparent;
            this.btn_random.Image = ((System.Drawing.Image)(resources.GetObject("btn_random.Image")));
            this.btn_random.ImageActive = null;
            this.btn_random.Location = new System.Drawing.Point(306, 64);
            this.btn_random.Margin = new System.Windows.Forms.Padding(4);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(49, 45);
            this.btn_random.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_random.TabIndex = 16;
            this.btn_random.TabStop = false;
            this.btn_random.Zoom = 10;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // btn_repetir
            // 
            this.btn_repetir.BackColor = System.Drawing.Color.Transparent;
            this.btn_repetir.Image = ((System.Drawing.Image)(resources.GetObject("btn_repetir.Image")));
            this.btn_repetir.ImageActive = null;
            this.btn_repetir.Location = new System.Drawing.Point(619, 64);
            this.btn_repetir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_repetir.Name = "btn_repetir";
            this.btn_repetir.Size = new System.Drawing.Size(49, 45);
            this.btn_repetir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_repetir.TabIndex = 15;
            this.btn_repetir.TabStop = false;
            this.btn_repetir.Zoom = 10;
            this.btn_repetir.Click += new System.EventHandler(this.btn_repetir_Click);
            // 
            // lvl_volumen
            // 
            this.lvl_volumen.AutoSize = true;
            this.lvl_volumen.Location = new System.Drawing.Point(793, 105);
            this.lvl_volumen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvl_volumen.Name = "lvl_volumen";
            this.lvl_volumen.Size = new System.Drawing.Size(16, 17);
            this.lvl_volumen.TabIndex = 14;
            this.lvl_volumen.Text = "0";
            // 
            // lbl_final
            // 
            this.lbl_final.AutoSize = true;
            this.lbl_final.Location = new System.Drawing.Point(692, 42);
            this.lbl_final.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_final.Name = "lbl_final";
            this.lbl_final.Size = new System.Drawing.Size(36, 17);
            this.lbl_final.TabIndex = 13;
            this.lbl_final.Text = "0:00";
            // 
            // lbl_inicio
            // 
            this.lbl_inicio.AutoSize = true;
            this.lbl_inicio.Location = new System.Drawing.Point(260, 42);
            this.lbl_inicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.Size = new System.Drawing.Size(36, 17);
            this.lbl_inicio.TabIndex = 12;
            this.lbl_inicio.Text = "0:00";
            // 
            // btn_sonido
            // 
            this.btn_sonido.BackColor = System.Drawing.Color.Transparent;
            this.btn_sonido.Image = ((System.Drawing.Image)(resources.GetObject("btn_sonido.Image")));
            this.btn_sonido.ImageActive = null;
            this.btn_sonido.Location = new System.Drawing.Point(733, 84);
            this.btn_sonido.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sonido.Name = "btn_sonido";
            this.btn_sonido.Size = new System.Drawing.Size(43, 34);
            this.btn_sonido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_sonido.TabIndex = 11;
            this.btn_sonido.TabStop = false;
            this.btn_sonido.Zoom = 10;
            this.btn_sonido.Click += new System.EventHandler(this.btn_sonido_Click);
            // 
            // validar_volumen
            // 
            this.validar_volumen.BackColor = System.Drawing.Color.Transparent;
            this.validar_volumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.validar_volumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validar_volumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.validar_volumen.IndentHeight = 6;
            this.validar_volumen.Location = new System.Drawing.Point(783, 11);
            this.validar_volumen.Margin = new System.Windows.Forms.Padding(4);
            this.validar_volumen.Maximum = 100;
            this.validar_volumen.Minimum = 0;
            this.validar_volumen.Name = "validar_volumen";
            this.validar_volumen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.validar_volumen.Size = new System.Drawing.Size(28, 100);
            this.validar_volumen.TabIndex = 10;
            this.validar_volumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.validar_volumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.validar_volumen.TickHeight = 1;
            this.validar_volumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.validar_volumen.TrackerColor = System.Drawing.Color.White;
            this.validar_volumen.TrackerSize = new System.Drawing.Size(16, 16);
            this.validar_volumen.TrackLineColor = System.Drawing.Color.Black;
            this.validar_volumen.TrackLineHeight = 3;
            this.validar_volumen.TrackLineSelectedColor = System.Drawing.Color.Black;
            this.validar_volumen.Value = 0;
            this.validar_volumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.validar_volumen_ValueChanged);
            this.validar_volumen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.validar_volumen_MouseDoubleClick);
            // 
            // duracion_cancion
            // 
            this.duracion_cancion.BackColor = System.Drawing.Color.Transparent;
            this.duracion_cancion.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.duracion_cancion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duracion_cancion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.duracion_cancion.IndentHeight = 6;
            this.duracion_cancion.Location = new System.Drawing.Point(248, 4);
            this.duracion_cancion.Margin = new System.Windows.Forms.Padding(4);
            this.duracion_cancion.Maximum = 100;
            this.duracion_cancion.Minimum = 0;
            this.duracion_cancion.Name = "duracion_cancion";
            this.duracion_cancion.Size = new System.Drawing.Size(481, 28);
            this.duracion_cancion.TabIndex = 9;
            this.duracion_cancion.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.duracion_cancion.TickColor = System.Drawing.Color.BlanchedAlmond;
            this.duracion_cancion.TickHeight = 1;
            this.duracion_cancion.TickStyle = System.Windows.Forms.TickStyle.None;
            this.duracion_cancion.TrackerColor = System.Drawing.Color.White;
            this.duracion_cancion.TrackerSize = new System.Drawing.Size(16, 16);
            this.duracion_cancion.TrackLineColor = System.Drawing.Color.Black;
            this.duracion_cancion.TrackLineHeight = 3;
            this.duracion_cancion.TrackLineSelectedColor = System.Drawing.Color.Black;
            this.duracion_cancion.Value = 0;
            this.duracion_cancion.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.duracion_cancion_ValueChanged);
            // 
            // bunifuImagebtn_pause
            // 
            this.bunifuImagebtn_pause.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImagebtn_pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImagebtn_pause.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImagebtn_pause.Image")));
            this.bunifuImagebtn_pause.ImageActive = null;
            this.bunifuImagebtn_pause.Location = new System.Drawing.Point(455, 62);
            this.bunifuImagebtn_pause.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImagebtn_pause.Name = "bunifuImagebtn_pause";
            this.bunifuImagebtn_pause.Size = new System.Drawing.Size(61, 47);
            this.bunifuImagebtn_pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImagebtn_pause.TabIndex = 8;
            this.bunifuImagebtn_pause.TabStop = false;
            this.bunifuImagebtn_pause.Visible = false;
            this.bunifuImagebtn_pause.Zoom = 10;
            this.bunifuImagebtn_pause.Click += new System.EventHandler(this.bunifuImagebtn_pause_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_play.Image = ((System.Drawing.Image)(resources.GetObject("btn_play.Image")));
            this.btn_play.ImageActive = null;
            this.btn_play.Location = new System.Drawing.Point(455, 64);
            this.btn_play.Margin = new System.Windows.Forms.Padding(4);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(61, 47);
            this.btn_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_play.TabIndex = 4;
            this.btn_play.TabStop = false;
            this.btn_play.Zoom = 10;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(248, 19);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(267, 10);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Black;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1, -2);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(224, 127);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 6;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Visible = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Black;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(-4, -2);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(229, 126);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuImagebtn_siguiente
            // 
            this.bunifuImagebtn_siguiente.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImagebtn_siguiente.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.bunifuImagebtn_siguiente.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImagebtn_siguiente.Image")));
            this.bunifuImagebtn_siguiente.ImageActive = null;
            this.bunifuImagebtn_siguiente.Location = new System.Drawing.Point(535, 64);
            this.bunifuImagebtn_siguiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImagebtn_siguiente.Name = "bunifuImagebtn_siguiente";
            this.bunifuImagebtn_siguiente.Size = new System.Drawing.Size(63, 47);
            this.bunifuImagebtn_siguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImagebtn_siguiente.TabIndex = 2;
            this.bunifuImagebtn_siguiente.TabStop = false;
            this.bunifuImagebtn_siguiente.Zoom = 10;
            this.bunifuImagebtn_siguiente.Click += new System.EventHandler(this.bunifuImagebtn_siguiente_Click);
            // 
            // bunifuImagebtn_anterior
            // 
            this.bunifuImagebtn_anterior.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImagebtn_anterior.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.bunifuImagebtn_anterior.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImagebtn_anterior.Image")));
            this.bunifuImagebtn_anterior.ImageActive = null;
            this.bunifuImagebtn_anterior.Location = new System.Drawing.Point(372, 64);
            this.bunifuImagebtn_anterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImagebtn_anterior.Name = "bunifuImagebtn_anterior";
            this.bunifuImagebtn_anterior.Size = new System.Drawing.Size(63, 47);
            this.bunifuImagebtn_anterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImagebtn_anterior.TabIndex = 1;
            this.bunifuImagebtn_anterior.TabStop = false;
            this.bunifuImagebtn_anterior.Zoom = 10;
            this.bunifuImagebtn_anterior.Click += new System.EventHandler(this.bunifuImagebtn_anterior_Click);
            // 
            // lis_canciones
            // 
            this.lis_canciones.FormattingEnabled = true;
            this.lis_canciones.ItemHeight = 16;
            this.lis_canciones.Location = new System.Drawing.Point(231, 192);
            this.lis_canciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lis_canciones.Name = "lis_canciones";
            this.lis_canciones.Size = new System.Drawing.Size(839, 276);
            this.lis_canciones.TabIndex = 3;
            this.lis_canciones.SelectedIndexChanged += new System.EventHandler(this.lis_canciones_SelectedIndexChanged);
            // 
            // time_slider
            // 
            this.time_slider.Tick += new System.EventHandler(this.time_slider_Tick);
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_hora.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.White;
            this.lbl_hora.Location = new System.Drawing.Point(704, 7);
            this.lbl_hora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(24, 16);
            this.lbl_hora.TabIndex = 4;
            this.lbl_hora.Text = "----";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Black;
            this.lbl_fecha.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_fecha.Location = new System.Drawing.Point(111, 7);
            this.lbl_fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(24, 16);
            this.lbl_fecha.TabIndex = 5;
            this.lbl_fecha.Text = "----";
            // 
            // timer_hora
            // 
            this.timer_hora.Enabled = true;
            this.timer_hora.Tick += new System.EventHandler(this.timer_hora_Tick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.lbl_hora);
            this.panel4.Controls.Add(this.lbl_fecha);
            this.panel4.Location = new System.Drawing.Point(235, 471);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(832, 33);
            this.panel4.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1071, 633);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lis_canciones);
            this.Controls.Add(this.panel4);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImagebtn_eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImagebtn_agregar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImagebtn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImagebtn_cerrar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_random)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_repetir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sonido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImagebtn_pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImagebtn_siguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImagebtn_anterior)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lis_canciones;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImagebtn_agregar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImagebtn_eliminar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImagebtn_minimizar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImagebtn_cerrar;
        private Bunifu.Framework.UI.BunifuImageButton btn_maximizar;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_nom;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImagebtn_siguiente;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImagebtn_anterior;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btn_restaurar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_playlist;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_artista;
        private Bunifu.Framework.UI.BunifuImageButton btn_buscar;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_buscar;
        private Bunifu.Framework.UI.BunifuImageButton btn_play;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImagebtn_pause;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton btn_text;
        private XComponent.SliderBar.MACTrackBar validar_volumen;
        private XComponent.SliderBar.MACTrackBar duracion_cancion;
        private System.Windows.Forms.Timer time_slider;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_final;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_inicio;
        private Bunifu.Framework.UI.BunifuCustomLabel lvl_volumen;
        private Bunifu.Framework.UI.BunifuImageButton btn_sonido;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_hora;
        private System.Windows.Forms.Timer timer_hora;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_fecha;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuImageButton btn_random;
        private Bunifu.Framework.UI.BunifuImageButton btn_repetir;
    }
}

