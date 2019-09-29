namespace PCSleep
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
            this.Poke2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.cb_sec = new System.Windows.Forms.ComboBox();
            this.cb_min = new System.Windows.Forms.ComboBox();
            this.cb_hora = new System.Windows.Forms.ComboBox();
            this.lb_hora = new System.Windows.Forms.Label();
            this.lb_event = new System.Windows.Forms.Label();
            this.evento = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.Poke3 = new System.Windows.Forms.PictureBox();
            this.Poke1 = new System.Windows.Forms.PictureBox();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Poke2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poke3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poke1)).BeginInit();
            this.SuspendLayout();
            // 
            // Poke2
            // 
            this.Poke2.Image = ((System.Drawing.Image)(resources.GetObject("Poke2.Image")));
            this.Poke2.Location = new System.Drawing.Point(-131, -28);
            this.Poke2.Name = "Poke2";
            this.Poke2.Size = new System.Drawing.Size(276, 276);
            this.Poke2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Poke2.TabIndex = 0;
            this.Poke2.TabStop = false;
            this.Poke2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Poke2_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelHora);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.cb_sec);
            this.panel1.Controls.Add(this.cb_min);
            this.panel1.Controls.Add(this.cb_hora);
            this.panel1.Controls.Add(this.lb_hora);
            this.panel1.Controls.Add(this.lb_event);
            this.panel1.Controls.Add(this.evento);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Poke2);
            this.panel1.Location = new System.Drawing.Point(186, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 200);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "PCSleeper por Carlos Ezequiel Centurion 2019";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(185, 136);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(79, 20);
            this.labelHora.TabIndex = 10;
            this.labelHora.Text = "00:00:00";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(289, 134);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(161, 27);
            this.start.TabIndex = 9;
            this.start.Text = "Iniciar";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.Start_Click);
            // 
            // cb_sec
            // 
            this.cb_sec.FormattingEnabled = true;
            this.cb_sec.Location = new System.Drawing.Point(289, 88);
            this.cb_sec.Name = "cb_sec";
            this.cb_sec.Size = new System.Drawing.Size(44, 21);
            this.cb_sec.TabIndex = 7;
            // 
            // cb_min
            // 
            this.cb_min.FormattingEnabled = true;
            this.cb_min.Location = new System.Drawing.Point(239, 88);
            this.cb_min.Name = "cb_min";
            this.cb_min.Size = new System.Drawing.Size(44, 21);
            this.cb_min.TabIndex = 6;
            // 
            // cb_hora
            // 
            this.cb_hora.FormattingEnabled = true;
            this.cb_hora.Location = new System.Drawing.Point(189, 88);
            this.cb_hora.Name = "cb_hora";
            this.cb_hora.Size = new System.Drawing.Size(44, 21);
            this.cb_hora.TabIndex = 5;
            // 
            // lb_hora
            // 
            this.lb_hora.AutoSize = true;
            this.lb_hora.Location = new System.Drawing.Point(134, 88);
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(45, 13);
            this.lb_hora.TabIndex = 4;
            this.lb_hora.Text = "Hora    :";
            // 
            // lb_event
            // 
            this.lb_event.AutoSize = true;
            this.lb_event.Location = new System.Drawing.Point(134, 56);
            this.lb_event.Name = "lb_event";
            this.lb_event.Size = new System.Drawing.Size(47, 13);
            this.lb_event.TabIndex = 3;
            this.lb_event.Text = "Evento :";
            // 
            // evento
            // 
            this.evento.FormattingEnabled = true;
            this.evento.Location = new System.Drawing.Point(189, 52);
            this.evento.Name = "evento";
            this.evento.Size = new System.Drawing.Size(266, 21);
            this.evento.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(184)))), ((int)(((byte)(235)))));
            this.panel2.Controls.Add(this.Minimize);
            this.panel2.Controls.Add(this.Close);
            this.panel2.Controls.Add(this.Poke3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 31);
            this.panel2.TabIndex = 1;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseMove);
            // 
            // Minimize
            // 
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(408, 4);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(30, 24);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimize.TabIndex = 4;
            this.Minimize.TabStop = false;
            this.ToolTip.SetToolTip(this.Minimize, "Minimizar");
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(441, 4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(31, 24);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close.TabIndex = 3;
            this.Close.TabStop = false;
            this.ToolTip.SetToolTip(this.Close, "Cerrar");
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Poke3
            // 
            this.Poke3.Image = ((System.Drawing.Image)(resources.GetObject("Poke3.Image")));
            this.Poke3.Location = new System.Drawing.Point(-131, -28);
            this.Poke3.Name = "Poke3";
            this.Poke3.Size = new System.Drawing.Size(276, 276);
            this.Poke3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Poke3.TabIndex = 2;
            this.Poke3.TabStop = false;
            this.Poke3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Poke3_MouseMove);
            // 
            // Poke1
            // 
            this.Poke1.Image = ((System.Drawing.Image)(resources.GetObject("Poke1.Image")));
            this.Poke1.Location = new System.Drawing.Point(56, 77);
            this.Poke1.Name = "Poke1";
            this.Poke1.Size = new System.Drawing.Size(276, 276);
            this.Poke1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Poke1.TabIndex = 2;
            this.Poke1.TabStop = false;
            this.Poke1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Poke1_MouseMove);
            // 
            // TrayIcon
            // 
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "PCSleeper";
            this.TrayIcon.Visible = true;
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // Timer
            // 
            this.Timer.Interval = 10;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Poke1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PC Sleep";
            this.TransparencyKey = System.Drawing.Color.Honeydew;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Poke2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poke3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poke1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Poke2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Poke3;
        private System.Windows.Forms.PictureBox Poke1;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.ComboBox evento;
        private System.Windows.Forms.ComboBox cb_sec;
        private System.Windows.Forms.ComboBox cb_min;
        private System.Windows.Forms.ComboBox cb_hora;
        private System.Windows.Forms.Label lb_hora;
        private System.Windows.Forms.Label lb_event;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label1;
    }
}

