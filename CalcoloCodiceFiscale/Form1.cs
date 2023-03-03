using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcoloCodiceFiscale
{
    public partial class Form1 : Form
    {
        public string codice = "";
        public Form1()
        {
            InitializeComponent();
        }

        public void CalcolaCognome()
        {
            foreach (var c in txtCognome.Text)
            {
                if (c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u' && codice.Length < 3)
                {
                    codice += c;
                }
            }
            for (int i = 0; codice.Length < 3; i++)
            {
                if (txtCognome.Text[i] == 'a' || txtCognome.Text[i] == 'e' || txtCognome.Text[i] == 'i' || txtCognome.Text[i] == 'o' || txtCognome.Text[i] == 'u')
                {
                    codice += txtCognome.Text[i];
                }
                else codice += "x";
            }
        }

        public void CalcolaNome()
        {
            foreach (var c in txtNome.Text)
            {
                if (c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u' && codice.Length < 3)
                {
                    codice += c;
                }
            }
            for (int i = 0; codice.Length < 3; i++)
            {
                if (txtNome.Text[i] == 'a' || txtNome.Text[i] == 'e' || txtNome.Text[i] == 'i' || txtNome.Text[i] == 'o' || txtNome.Text[i] == 'u')
                {
                    codice += txtNome.Text[i];
                }
                else codice += "x";
            }
        }

        public void CalcolaData()
        {
            //Calcolo anno
            codice += datePicker.Value.Year.ToString().Substring(datePicker.Value.Year.ToString().Length - 2);
            codice += datePicker.Value.Year.ToString().Substring(datePicker.Value.Year.ToString().Length - 1);

            //Calcolo mese  "ABCDEFGHIJKLMNOPQRSTUVWXYZ" datePicker.Value.Month.ToString();
            var alf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var n = datePicker.Value.Month;
            txtCodice.Text = alf[ - 1]; 

            
        }
        private void btnCalcola_Click(object sender, EventArgs e)
        {
            CalcolaCognome();
            CalcolaNome();
            CalcolaData();
            //txtCodice.Text = codice;
        }
    }
}
