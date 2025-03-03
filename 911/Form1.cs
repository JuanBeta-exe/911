using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _911
{
    public partial class Form1 : Form
    {
        private PictureBox misil;
        private Timer timerTorre;
        private Timer timerMisil;
        private int velocidadAvion = 5;
        private int velocidadMisil = 10;
        private bool misilDisparado = false;

        public Form1()
        {
            InitializeComponent();
            InicializarJuego();
        }

        private void InicializarJuego()
        {

            misil = new PictureBox
            {
                Image = Properties.Resources.Avion,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(60, 120),
                Visible = false // Oculto hasta que se dispare
            };
            this.Controls.Add(misil);

            // Timer para mover el avión
            timerTorre = new Timer { Interval = 50 };
            timerTorre.Tick += MoverAvion;
            timerTorre.Start();

            // Timer para mover el misil
            timerMisil = new Timer { Interval = 30 };
            timerMisil.Tick += MoverMisil;

            // Evento para disparar el misil con el clic del mouse
            this.MouseClick += Form1_MouseClick;
        }

        private void MoverAvion(object sender, EventArgs e)
        {
            // Mueve el avión de lado a lado
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
                misil.Location = new Point(e.X - misil.Width / 2, this.ClientSize.Height - misil.Height);
                misil.Visible = true;
                misilDisparado = true;
                timerMisil.Start();
            }
        }

        private void MoverMisil(object sender, EventArgs e)
        {
            if (misilDisparado)
            {
                misil.Top -= velocidadMisil;

                // Verificar colisión con el avión
                if (avion.Bounds.IntersectsWith(picbxTorresGenelas.Bounds))
                {
                    timerMisil.Stop();
                    misil.Visible = false;
                    misilDisparado = false;
                    MessageBox.Show("¡Avión derribado!");
                }

                // si el misil sale de la pantalla se oculta y se reinicia
                if (misil.Top <= 0)
                {
                    timerMisil.Stop();
                    misil.Visible = false;
                    misilDisparado = false;
                }
            }
        }


        private void bttAtentar_Click(object sender, EventArgs e)
        {

        }
    }
}
