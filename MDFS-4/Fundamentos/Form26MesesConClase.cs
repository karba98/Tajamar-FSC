using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;
namespace Fundamentos
{
    public partial class Form26MesesConClase : Form
    {
        List<Mes> meses;
        public Form26MesesConClase()
        {
            InitializeComponent();
            meses = new List<Mes>();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            if (lstmeses.Items.Count > 0)
            {
                lstmeses.Items.Clear();
                meses.Clear();
                txtnombre.Text = "";
                txtmax.Text = "";
                txtminima.Text = "";
                txtmedia.Text = "";
            }
            string[] names = DateTimeFormatInfo.CurrentInfo.MonthNames;
            Mes objMes = new Mes();
            Random rnd = new Random();
            foreach(String name in names)
            {
                if (name == "")
                {

                }
                else{
                    //to upper case
                    char first_letter = name[0];
                    String letra = first_letter.ToString().ToUpper();
                    char l = letra[0];
                    String nombremes = l + name.Substring(1, name.Length-1);

                    
                    Mes mes = new Mes(nombremes,rnd.Next(10,30), rnd.Next(-5, 10));
                    lstmeses.Items.Add(mes.Nombre);
                    meses.Add(mes);
                }
            }
        }

        private void lstmeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mes mes = meses[lstmeses.SelectedIndex];
            txtnombre.Text = mes.Nombre;
            txtmax.Text = mes.Maxima.ToString()+"ºC";
            txtminima.Text = mes.Minima.ToString() + "ºC";
            txtmedia.Text = mes.Media.ToString() + "ºC";
        }
    }
}
