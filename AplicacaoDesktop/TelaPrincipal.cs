using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoDesktop
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();

            txtTextoDigitado.Select();
        }

        public void AtualizaTela(string TextoDigitado)
        {
            txtTamanhoTexto.Text = ContadorDeLetras(TextoDigitado).ToString();
            txtTotalPalavras.Text =  ContadorDePalavras(TextoDigitado).ToString();
            txtTotalBuracos.Text = ContadorDeBuracos(TextoDigitado).ToString();
        }

        public static int ContadorDeLetras(string PalavraDigitada)
        {
            int Contador = 0;

            for (int i = 0; i < PalavraDigitada.Length; i++)
            {
                if (Char.IsLetterOrDigit(PalavraDigitada[i]) || Char.IsWhiteSpace(PalavraDigitada[i]))
                {
                    Contador++;
                }
            }

            return Contador;
        }
        public static int ContadorDePalavras(string PalavraDigitada)
        {
            int Contador = 1;

            for (int i = 0; i < PalavraDigitada.Length; i++)
            {
                if (Char.IsWhiteSpace(PalavraDigitada[i]))
                {
                    Contador++;
                }
            }

            return Contador;
        }
        public static int ContadorDeBuracos(string PalavraDigitada)
        {
            int Contador = 0;

            for (int i = 0; i < PalavraDigitada.Length; i++)
            {
                if (
                    PalavraDigitada[i] == 'A' ||
                    PalavraDigitada[i] == 'D' ||
                    PalavraDigitada[i] == 'O' ||
                    PalavraDigitada[i] == 'P' ||
                    PalavraDigitada[i] == 'Q' ||
                    PalavraDigitada[i] == 'R' ||
                    PalavraDigitada[i] == 'a' ||
                    PalavraDigitada[i] == 'b' ||
                    PalavraDigitada[i] == 'd' ||
                    PalavraDigitada[i] == 'e' ||
                    PalavraDigitada[i] == 'g' ||
                    PalavraDigitada[i] == 'o' ||
                    PalavraDigitada[i] == 'p' ||
                    PalavraDigitada[i] == 'q'

                    )
                    Contador++;
                else if (PalavraDigitada[i] == 'B')
                {
                    Contador += 2;
                }
            }

            return Contador;
        }

        private void txtTextoDigitado_TextChanged(object sender, EventArgs e)
        {
            AtualizaTela(txtTextoDigitado.Text);
        }
    }
}
