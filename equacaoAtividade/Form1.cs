using System;
using System.Windows.Forms;

namespace equacaoAtividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            //Verificação dos Dados

            if (txtA.Text == "" && txtB.Text == "" && txtC.Text == "")
            {
                lblMensagem.Text = "Todos os campos estão vazios";
            }

            else if (txtA.Text == "" && txtB.Text == "")
            {
                lblMensagem.Text = "Os campos A e B estão vazios!";
            }

            else if (txtB.Text == "" && txtC.Text == "")
            {
                lblMensagem.Text = "Os campos B e C estão vazios!";
            }

            else if (txtA.Text == "" && txtC.Text == "")
            {
                lblMensagem.Text = "Os campos A e C estão vazios!";
            }



            else if (txtA.Text.Length <= 0 && txtB.Text.Length > 0 && txtC.Text.Length > 0)
            {
                lblMensagem.Text = "Esta é uma equação de primeiro grau!";
            }

            else if (txtA.Text == "")
            {
                lblMensagem.Text = "O campo A está vazio!";
            }

            else if (txtB.Text == "")
            {
                lblMensagem.Text = "O campo B está vazio!";
            }

            else if (txtC.Text == "")
            {
                lblMensagem.Text = "O campo C está vazio!";
            }

            else // Realização da conta
            {
                //A, B e C
                float A = float.Parse(txtA.Text);
                float B = float.Parse(txtB.Text);
                float C = float.Parse(txtC.Text);


                //Delta
                float delta = (float)(Math.Pow(2, B) - 4 * A * C);

                if (delta < 0)
                {
                    lblMensagem.Text = "Não foi possível calcular as raízes porque o Delta é negativo";

                }

                else if (delta == 0)
                {
                    float baskara = -B / (2 * A);

                    txtX1.Text = Convert.ToString(baskara);
                    txtDelta.Text = Convert.ToString(delta);

                    lblMensagem.Text = "Cálculo concluído!";
                }
                else
                {
                    //Resultado
                    float baskara1 = (float)(-B + Math.Sqrt(delta)) / (2 * A);
                    float baskara2 = (float)(-B - Math.Sqrt(delta)) / (2 * A);

                    txtDelta.Text = Convert.ToString(delta);
                    txtX1.Text = Convert.ToString(Math.Round(baskara1, 2));
                    txtX2.Text = Convert.ToString(Math.Round(baskara2, 2));

                    lblMensagem.Text = "Cálculo concluído!";
                }
            }
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            //A, B e C
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";

            //Delta
            txtDelta.Text = "";

            //X¹
            txtX1.Text = "";

            //X²
            txtX2.Text = "";

            txtA.Focus();

            lblMensagem.Text = "Limpeza concluída!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
