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

namespace Fundamentos
{
    public partial class Form22PractTemperaturas : Form
    {
        List<int> temperaturas;
        public Form22PractTemperaturas()
        {
            InitializeComponent();
            temperaturas = new List<int>();
            newMonths();
        }
        void newMonths()
        {
            lstmonths.Items.Clear();
            string[] names = DateTimeFormatInfo.CurrentInfo.MonthNames;
            this.lstmonths.Items.AddRange(names);
            lstmonths.Items.RemoveAt(lstmonths.Items.Count - 1);

            txtmedia.Text = "";
            txtmin.Text = "";
            txtmax.Text = "";
        }

        private void btnmeses_Click(object sender, EventArgs e)
        {
            temperaturas.Clear();
            newMonths();
            Random rnd = new Random();
            for(int i=0;i<lstmonths.Items.Count;i++)
            {
                int temp = rnd.Next(-10, 30);
                lstmonths.Items[i] += " "+temp.ToString()+"ºC";
                temperaturas.Add(temp);
            }
        }

        private void btndatos_Click(object sender, EventArgs e)
        {
            try
            {
                txtmax.Text = temperaturas.Max().ToString()+"ºC";
                txtmin.Text = temperaturas.Min().ToString() + "ºC";
                txtmedia.Text = ((int)temperaturas.Average()).ToString() + "ºC";
            }catch(Exception ex) { }

        }
    }
}
