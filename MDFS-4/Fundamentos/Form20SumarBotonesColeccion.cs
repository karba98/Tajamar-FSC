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
    public partial class Form20SumarBotonesColeccion : Form
    {
        int sumador;
        List<Button> botones;
        public Form20SumarBotonesColeccion()
        {
            sumador = 0;
            InitializeComponent();
            botones = new List<Button>();
            NewBotones();
            GetBotones();
            AddEventSumar();


            GetBotonesDerecha();

            txtsuma.Text = "0";
            txtsumaderecha.Text = "0";
        }

        private void Form20SumarBotonesColeccion_Load(object sender, EventArgs e)
        {
            
        }

        void GetBotonesDerecha()
        {
            txtsumaderecha.Text = "0";
            Random rnd = new Random();
            foreach (Button b in this.panel1.Controls)
            {
                b.Text = rnd.Next(1, 109).ToString();
                b.Click += SumaDerecha;
            }
        }

        private void SumaDerecha(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);
            sumador = sumador + numero;
            boton.BackColor = Color.Yellow;

            //
        }

        void AddEventSumar()
        {
            foreach (Button boton in botones)
            {
                boton.Click += Sumar;
                boton.MouseEnter += ChangeColorIn;
                boton.MouseLeave += ChangeColorOut;
            }
        }

        private void ChangeColorOut(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Transparent;
        }

        private void ChangeColorIn(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.LightBlue;
        }
 

        void GetBotones()
        {
            foreach (Object obj in this.Controls)
            {
                if (obj is Button && ((Button)obj).Name!= "btngenerate" && ((Button)obj).Name != "btnreset" && ((Button)obj).Name != "btnsumar")
                {
                    botones.Add((Button)obj);
                }
            }
            
        }
        void NewBotones()
        {
            Random rnd = new Random();
            foreach (Object obj in this.Controls)
            {
                if (obj is Button && ((Button)obj).Name != "btngenerate" && ((Button)obj).Name != "btnreset" && ((Button)obj).Name != "btnsumar")
                {
                    ((Button)obj).Text = rnd.Next(1, 100).ToString(); ;
                }
            }

        }

        private void Sumar(object sender, EventArgs e)
        {
            
            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);
            int suma = (int.Parse(txtsuma.Text)) + numero;
            txtsuma.Text = suma.ToString();
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            foreach (Button btn in botones)
            {
                btn.Text = rnd.Next(1, 100).ToString(); ;
            }
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            txtsumaderecha.Text = sumador.ToString();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            foreach (Button b in this.panel1.Controls)
            {
                b.BackColor = Color.Transparent;
                sumador = 0;

            }
        }
    }
}
