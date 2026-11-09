using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Cifrariodicesare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_n1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_criptaggio.Text) && string.IsNullOrWhiteSpace(txt_chiave.Text))
            {
                MessageBox.Show("Attenzione! I campi di testo sono vuoti", "ATTENZIONE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_criptaggio.Text))
            {

                MessageBox.Show("Attenzione! Il campo di testo è vuoto", "ATTENZIONE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else if (string.IsNullOrWhiteSpace(txt_chiave.Text))
            {

                MessageBox.Show("Attenzione! Il campo della chiave è vuoto", "ATTENZIONE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            string testocriptaggio = txt_criptaggio.Text;
            int chiave = Convert.ToInt32(txt_chiave.Text);
            chiave = chiave % 26;
            string risultato = "";
            for (int i = 0; i < testocriptaggio.Length; i++)
            {
                char carattere = testocriptaggio[i];


                if (carattere >= 'A' && carattere <= 'Z')
                {
                    char letterasuccessiva = (char)(carattere + chiave);
                    if (letterasuccessiva > 'Z')
                    {
                        letterasuccessiva = (char)(letterasuccessiva - 26);
                    }
                    risultato = risultato + letterasuccessiva;
                }
                else if (carattere >= 'a' && carattere <= 'z')
                {
                    char letterasuccessiva = (char)(carattere + chiave);
                    if (letterasuccessiva > 'z')
                    {
                        letterasuccessiva = (char)(letterasuccessiva - 26);
                    }
                    risultato = risultato + letterasuccessiva;
                }
                else
                {
                    risultato = risultato + carattere;
                }
            }
            lbl_risultato1.Text = ("RISULTATO: " + risultato);
        }

        private void btn_n2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_decriptaggio.Text) && string.IsNullOrWhiteSpace(txt_chiave.Text))
            {
                MessageBox.Show("Attenzione! I campi di testo sono vuoti", "ATTENZIONE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_decriptaggio.Text))
            {

                MessageBox.Show("Attenzione! Il campo di testo è vuoto", "ATTENZIONE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else if (string.IsNullOrWhiteSpace(txt_chiave.Text))
            {

                MessageBox.Show("Attenzione! Il campo della chiave è vuoto", "ATTENZIONE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            string testodecriptaggio = txt_decriptaggio.Text;
            int chiave = Convert.ToInt32(txt_chiave.Text);
            chiave = chiave % 26;
            string risultato = "";
            for (int i = 0; i < testodecriptaggio.Length; i++)
            {
                char carattere = testodecriptaggio[i];


                if (carattere >= 'A' && carattere <= 'Z')
                {
                    char letterasuccessiva = (char)(carattere - chiave);
                    if (letterasuccessiva > 'Z')
                    {
                        letterasuccessiva = (char)(letterasuccessiva - 26);
                    }
                    risultato = risultato + letterasuccessiva;
                }
                else if (carattere >= 'a' && carattere <= 'z')
                {
                    char letterasuccessiva = (char)(carattere - chiave);
                    if (letterasuccessiva > 'z')
                    {
                        letterasuccessiva = (char)(letterasuccessiva - 26);
                    }
                    risultato = risultato + letterasuccessiva;
                }
                else
                {
                    risultato = risultato + carattere;
                }
            }
            lbl_risultato2.Text = ("RISULTATO: " + risultato);
        }

        
    }     
}
