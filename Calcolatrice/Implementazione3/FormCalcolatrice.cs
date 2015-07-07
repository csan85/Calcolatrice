using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice.Implementazione3
{
    public partial class FormCalcolatrice : Form
    {
        public FormCalcolatrice()
        {
            InitializeComponent();

            GeneraBottoniOperazioni();
        }

        private Calcolatrice_version2 calcolatrice = new Calcolatrice_version2();

        private void GeneraBottoniOperazioni()
        {
            foreach (string operazione in this.calcolatrice.Operazioni)
            {
                Button button = new Button();
                button.Text = operazione;
                button.Size = new Size(50, 44);
                // Utilizzo anche Tag per salvare l'operazione, non mi fido della property Text perche
                // Potrei magari decidere in futuro di mettere una descrizione più estesa.
                button.Tag = operazione;
                button.Click += button_Click;

                // Utilizzo il flowLayoutPanel perche mette in automatico i bottoni uno a fianco all'altro.
                this.flowLayoutPanel.Controls.Add(button);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            // Il parametro sender è chi ha generato l'evento, in questo caso sarà il bottone che ho premuto.
            // Avendo salvato nella property Tag il tipo di operazione come stringa vado semplicemente a richiamarla.
            Button button = (Button)sender;
            string operazione = button.Tag.ToString();

            EseguiOperazione(operazione);
        }

        private void EseguiOperazione(string operazione)
        {
            try
            {
                decimal risultato = this.calcolatrice.EseguiOperazione(operazione, this.textNumero1.Value, this.textNumero2.Value);

                MostraRisultato(risultato);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Non è possibile dividere per zero.");
            }
            catch (ArgumentException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void MostraRisultato(decimal risultato)
        {
            this.labelTotale.Text = String.Format("TOTALE: {0}", risultato);
        }
    }
}
