using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form24Primitiva : Form
    {
        int nbotones = 20;
        List<int> premiados;
        List<Button> apuestas;
        public Form24Primitiva()
        {
            apuestas = new List<Button>();
            premiados = new List<int>();
            InitializeComponent();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            apuestas.Clear();
            ResetNums();
            premiados.Clear();
        }
        
        void ResetNums()
        {
            this.groupBox1.Controls.Clear();
            int x = 20;
            int y = 50;
            for (int i = 1; i <= this.nbotones; i++)
            {
                Button boton = new Button();
                boton.Text = i.ToString();
                boton.Size = new Size(60, 60);
                boton.BackColor = Color.White;
                if (x == 320)
                {
                    x = 20;
                    y += 60;
                }
                boton.Location = new Point(x, y);
                x += 60;
                groupBox1.Controls.Add(boton);

                boton.Click += Apostar;
            }
        }

        private void Apostar(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (boton.BackColor == Color.Yellow)
            {
                boton.BackColor = Color.White;
                apuestas.Remove(boton);
            }
            else
            {
                if (apuestas.Count < 6)
                {

                    boton.BackColor = Color.Yellow;
                    apuestas.Add(boton);
                }
                else
                {
                    MessageBox.Show("Maximo de apuestas permitidas: 6");
                }
            }
            
            
        }

        private void btnsortear_Click(object sender, EventArgs e)
        {
            if (apuestas.Count < 6)
            {
                MessageBox.Show("No admitimos menos de 6 apuestas");
            }
            else if (premiados.Count > 0)
            {
                MessageBox.Show("Pruebe otra apuesta");
            }
            else
            {
                Random rnd = new Random();
                for (int i = 0; i < 6; i++)
                {
                    int num = rnd.Next(1, groupBox1.Controls.Count);
                    if (premiados.Contains(num))
                    {
                        i--;
                    }
                    else
                    {
                        premiados.Add(num);
                    }
                    
                }

                foreach (Button b in apuestas)
                {
                    if (premiados.Contains(int.Parse(b.Text)))
                    {
                        b.BackColor = Color.Green;
                    }
                    else
                    {
                        b.BackColor = Color.Yellow;
                    }
                }
                foreach(Button b in groupBox1.Controls)
                {
                    if (premiados.Contains(int.Parse(b.Text)) &&
                        b.BackColor!=Color.Green)
                    {
                        b.BackColor = Color.Red;
                    }
                }
                string numerospremiados = "";
                foreach(int num in premiados)
                {
                    numerospremiados += "["+num+"]   ";
                }
                MessageBox.Show("Los numeros premiados son: " + numerospremiados);
            }
            
        }
    }
    
}
