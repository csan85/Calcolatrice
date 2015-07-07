using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice.Implementazione1
{
    public partial class Calcolatrice : Form
    {
        public Calcolatrice()
        {
            InitializeComponent();
        }

        private void buttonAddizione_Click(object sender, EventArgs e)
        {
            //this.labelTotale.Text = String.Format("TOTALE: {0}", this.textNumero1.Value + this.textNumero2.Value);
            MostraRisultato(this.textNumero1.Value + this.textNumero2.Value);
        }

        private void MostraRisultato(decimal risultato)
        {
            MessageBox.Show(risultato.ToString(), "RISULTATO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSottrazione_Click(object sender, EventArgs e)
        {
            this.labelTotale.Text = String.Format("TOTALE: {0}", this.textNumero1.Value - this.textNumero2.Value);
        }

        private void buttonMoltiplicazione_Click(object sender, EventArgs e)
        {
            this.labelTotale.Text = String.Format("TOTALE: {0}", this.textNumero1.Value * this.textNumero2.Value);
        }

        private void buttonDivisione_Click(object sender, EventArgs e)
        {
            if (this.textNumero2.Value == 0m)
            {
                MessageBox.Show("Non è possibile dividere per zero", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.labelTotale.Text = String.Format("TOTALE: {0}", this.textNumero1.Value / this.textNumero2.Value);
            }
        }

        private void buttonPotenza_Click(object sender, EventArgs e)
        {
            double risultato = Math.Pow(Convert.ToDouble(this.textNumero1.Value), Convert.ToDouble(this.textNumero2.Value));
            this.labelTotale.Text = String.Format("TOTALE: {0}", risultato);
        }

        private void buttonRadiceQuadrata_Click(object sender, EventArgs e)
        {
            double risultato = Math.Sqrt(Convert.ToDouble(this.textNumero1.Value));
            this.labelTotale.Text = String.Format("TOTALE: {0}", risultato);
        }

        private void buttonFattoriale_Click(object sender, EventArgs e)
        {
            decimal risultato = this.textNumero1.Value;
            for (int i = 1; i < Convert.ToInt32(this.textNumero1.Value); ++i)
            {
                risultato *= i;
            }

            this.labelTotale.Text = String.Format("TOTALE: {0}", risultato);
        }
    }
}
