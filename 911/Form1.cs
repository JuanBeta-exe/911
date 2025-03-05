using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _911
{
    public partial class Form1 : Form
    {
        private PictureBox avion;
        private PictureBox picOsama;
        private Timer timerTorres;
        private Timer timerMisil;
        private int velocidadAvion = 5;
        private int velocidadMisil = 10;
        private bool misilDisparado = false;
        private bool move = false;
        private int colison;

        public Form1()
        {
            InitializeComponent();
        }

        private void InicializarJuego()
        {
            // OSAMA como cursor
            picOsama = new PictureBox
            {
                Image = Properties.Resources.Osama,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size (80,100),
                BackColor = Color.Transparent
            };
            this.Controls.Add(picOsama);
            this.MouseMove += Form1_MouseMove;


            // Crear el Avion misil para las torres
            avion = new PictureBox
            {
                Image = Properties.Resources.Avion,
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(60, 120),
                Visible = false
            };
            this.Controls.Add(avion);

            // Timer para mover las torres
            timerTorres = new Timer { Interval = 50 };
            timerTorres.Tick += MoverAvion;
            timerTorres.Start();

            // Timer para mover el avion misil
            timerMisil = new Timer { Interval = 30 };
            timerMisil.Tick += MoverMisil;

            // Evento para disparar con el mouse
            this.MouseClick += Form1_MouseClick;
        }

        private void MoverAvion(object sender, EventArgs e)
        {
            picbxTorresGenelas.Left += velocidadAvion;

            // Si el avión toca los bordes, cambia de dirección
            if (picbxTorresGenelas.Right >= this.ClientSize.Width || picbxTorresGenelas.Left <= 0)
            {
                velocidadAvion = -velocidadAvion;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!misilDisparado)
            {
                avion.Location = new Point(e.X - avion.Width / 2, this.ClientSize.Height - picOsama.Height - avion.Height);
                avion.Visible = true;
                misilDisparado = true;
                timerMisil.Start();
            }
        }

        private void MoverMisil(object sender, EventArgs e)
        {
            if (misilDisparado)
            {
                avion.Top -= velocidadMisil;

                // Verificar colisión con el avión
                if (avion.Bounds.IntersectsWith(picbxTorresGenelas.Bounds))
                {
                    colison++;
                    lblNumTorres.Text = "TORRES DERRUMBADAS  " + colison;
                    timerMisil.Stop();
                    avion.Visible = false;
                    misilDisparado = false;
                    if (colison == 2) {  Mesaje(); }

                }

                // Si el misil sale de la pantalla, se oculta
                if (avion.Top <= 0)
                {
                    timerMisil.Stop();
                    avion.Visible = false;
                    misilDisparado = false;
                }
            }
        }

        private void Mesaje()
        {
            Label feli = new Label();  
            this.Controls.Add(feli);
            feli.Size = new Size(400, 50);
            feli.BackColor = Color.Transparent;
            feli.ForeColor = Color.Orange;
            feli.Font = new Font("Verdana", 12, FontStyle.Bold);
            feli.TextAlign = ContentAlignment.MiddleCenter; 
            feli.Text = "FELICITACIONES DERRUMBASTE LAS 2 TORRES. \n        ERES UN PERFECTO TERRORISTA";
            feli.Location= new Point(this.ClientSize.Width / 2 - 125 , this.ClientSize.Height / 2);
        }
        private void bttAtentar_Click(object sender, EventArgs e)
        {
            bttAtentar.Hide();
            InicializarJuego();
            move = true;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                // Mantener la imagen en la parte baja y solo moverla en X
                picOsama.Location = new Point(e.X - picOsama.Width / 2, this.ClientSize.Height - picOsama.Height - 10);
            }    
      
        }
    }
}
