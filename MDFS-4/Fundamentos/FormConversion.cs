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
    public partial class FormConversion : Form
    {
        public FormConversion()
        {
            InitializeComponent();
        }

        private void FormConversion_Load(object sender, EventArgs e)
        {
            //CONVERSION AUTOMATICA
            double mayor;
            int menor = 99;
            mayor = menor; //OK
            //menor = mayor; //NO fFUNCIONA
            Console.WriteLine(mayor);

            //CONVERSINO ENTRE PRIMITIVOS
            short menor1;
            int mayor1 = 66;
            menor1 = (short)mayor1;
            Console.WriteLine(menor1);

            //String A PRIMITIVO (parsear)
            string texto = "34567";
            int numero = int.Parse(texto);
            Console.WriteLine(numero);

            //PRIMITIVO A STRING
            int n = 563;
            string objeto = n.ToString();
            Console.WriteLine(objeto);

            //SOBRECARGA
            MessageBox.Show("Nuevo Mensaje", "Mensaje", 
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
        }
    }
}
