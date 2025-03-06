using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eleicao
{
    public partial class Form1: Form
    {

        // Variáveis para armazenar os votos dos participantes
        private int votosParticipante1 = 0;
        private int votosParticipante2 = 0;
        private int votosParticipante3 = 0;
        private int votosParticipante4 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtpainel_Click(object sender, EventArgs e)
        {

        }

        // Evento para votar no Participante 1 (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            votosParticipante1++;
            AtualizarVotos();
        }

        // Evento para votar no Participante 2 (btnc2)
        private void btnc2_Click(object sender, EventArgs e)
        {
            votosParticipante2++;
            AtualizarVotos();
        }

        // Evento para votar no Participante 3 (btnc3)
        private void btnc3_Click(object sender, EventArgs e)
        {
            votosParticipante3++;
            AtualizarVotos();
        }

        // Evento para votar no Participante 4 (button4)
        private void button4_Click(object sender, EventArgs e)
        {
            votosParticipante4++;
            AtualizarVotos();
        }

        private void AtualizarVotos()
        {
            // Atualiza as contagens de votos no rótulo
            lblResul1.Text = "\nGloxínia: " + votosParticipante1.ToString();
            lblResul1.Text = "\nDália: " + votosParticipante2.ToString();
            lblResul1.Text += "\nHarlequin: " + votosParticipante3.ToString();
            lblResul1.Text += "\nNasiens: " + votosParticipante4.ToString();
        }

    }
}
