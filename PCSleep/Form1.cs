using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCSleep
{
    public partial class Form1 : Form
    {

        bool EventSet;
        bool TimeSet;
        bool hrSet;
        bool minSet;
        bool secSet;

        int Hora;
        int Minutos;
        int Segundos;

        int TimerHr;
        int TimerMin;
        int TimerSec;
        int TimerMil = 60;

        bool EventEnable;

        public Form1()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrayIcon.Visible = true;

        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            TrayIcon.Visible = false;
        }

        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
              DragableWindow drag = new DragableWindow();
              drag.DragWindow(this.Handle);
        }

        private void Poke3_MouseMove(object sender, MouseEventArgs e)
        {
            DragableWindow drag = new DragableWindow();
            drag.DragWindow(this.Handle);
        }

        private void Poke2_MouseMove(object sender, MouseEventArgs e)
        {
            DragableWindow drag = new DragableWindow();
            drag.DragWindow(this.Handle);
        }

        private void Poke1_MouseMove(object sender, MouseEventArgs e)
        {
            DragableWindow drag = new DragableWindow();
            drag.DragWindow(this.Handle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelHora.Text = string.Empty;
            evento.Items.Add("Apagar Sistema");
            evento.Items.Add("Reiniciar Sistema");
            //evento.Items.Add("Suspender Sistema");
            //evento.Items.Add("Alarma");

            for (int i = 0; i < 25; i++)
            {
                cb_hora.Items.Add(i.ToString());
            }

            for (int i = 0; i < 60; i++)
            {
                cb_min.Items.Add(i.ToString());
            }

            for (int i = 0; i < 60; i++)
            {
                cb_sec.Items.Add(i.ToString());
            }




        }

        private void Start_Click(object sender, EventArgs e)
        {
            if(!EventEnable)
            {
                switch (evento.SelectedIndex)
                {
                    case 0:
                        // Apagar Sistema
                        EventSet = true;
                        break;

                    case 1:
                        // Reiniciar Sistema
                        EventSet = true;
                        break;

                    //case 2:
                    //    // Suspender Sistema
                    //    EventSet = true;
                    //    break;

                    //case 3:
                    //    // Alarma
                    //    EventSet = true;
                    //    break;

                    default:
                        MessageBox.Show("No hay un evento seleccionado!", "Ups!");
                        EventSet = false;
                        break;

                }

                if (cb_hora.SelectedItem != null)
                {
                    hrSet = true;
                    Hora = Convert.ToInt32(cb_hora.SelectedItem.ToString());
                }


                if (cb_min.SelectedItem != null)
                {
                    minSet = true;
                    Minutos = Convert.ToInt32(cb_min.SelectedItem.ToString());
                }

                if (cb_sec.SelectedItem != null)
                {
                    secSet = true;
                    Segundos = Convert.ToInt32(cb_sec.SelectedItem.ToString());
                }

                if (hrSet && minSet && secSet)
                {
                    TimeSet = true;
                }
                else
                {
                    MessageBox.Show("Error en la configuracion horaria, por favor revise", "Ups!");
                }

                if (EventSet && TimeSet)
                {
                    evento.Enabled = false;
                    cb_hora.Enabled = false;
                    cb_min.Enabled = false;
                    cb_sec.Enabled = false;
                    EventEnable = true;

                    start.Text = "Cancelar";
                    TimerHr = Hora;
                    TimerMin = Minutos;
                    TimerSec = Segundos;
                    Timer.Enabled = true;
                }
            }
            else
            {
                Timer.Enabled = false;
                start.Text = "Iniciar";
                evento.Enabled = true;
                cb_hora.Enabled = true;
                cb_min.Enabled = true;
                cb_sec.Enabled = true;
                labelHora.Text = string.Empty;
                EventEnable = false;
            }

           


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(TimerMil > 0)
            {
                TimerMil--;
            }
            else
            {
                TimerSec--;
                TimerMil = 60;
            }

            if(TimerSec < 0 )
            {
                TimerSec = 60;
                TimerMin--;
            }

            if(TimerMin < 0)
            {
                TimerMin = 60;
                TimerHr--;
            }

            if(TimerHr <= 0)
            {
                if(TimerMin <= 0)
                {
                    if(TimerSec <= 0)
                    {
                        Timer.Enabled = false;

                        // Ejecuta Funcion

                        switch (evento.SelectedIndex)
                        {
                            case 0:
                                Process.Start("shutdown", "/s /t 0");
                                break;

                            case 1:
                                // Reiniciar Sistema
                                Process.Start("shutdown", "/r /t 0");
                                break;

                            //case 2:
                            //    // Suspender Sistema
                            //    EventSet = true;
                            //    break;

                            //case 3:
                            //    // Alarma
                            //    EventSet = true;
                            //    break;

                            default:
                                MessageBox.Show("No hay un evento seleccionado!", "Ups!");
                                EventSet = false;
                                break;

                        }
                    }
                }
            }

            labelHora.Text = (TimerHr.ToString() + ":" + TimerMin.ToString()+ ":" + TimerSec.ToString());
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
