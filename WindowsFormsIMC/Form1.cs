namespace WindowsFormsIMC
{
    public partial class FrmIMC : Form
    {
        // variaveis Global
        float imc = 0;
        public FrmIMC()
        {
            InitializeComponent();
        }

        private float CalculoImc(float peso, float altura)
        {
            imc = peso / (altura * altura);
            return imc;
        }

        private void btIMC_Click(object sender, EventArgs e)
        {
            float peso;
            float altura;

            //checa se foi digitado algum valor válido para peso
            if (!float.TryParse(txtPeso.Text, out peso))
            {
                MessageBox.Show("Digite um peso válido");
                return;
            }
            {
                //checa se foi digitado algum valor válido para peso
                if (!float.TryParse(txtAltura.Text, out peso))
                {
                    MessageBox.Show("Digite uma altura válida");
                    return;

                }
            }
            CalculoImc(float.Parse(txtPeso.Text), float.Parse(txtAltura.Text));
            string grau;

            switch (imc)
            {
                case >= 40:
                    grau = "Obesidade III";
                    break;
                case >= 35:
                    grau = "Obesidade II";
                    break;
                case >= 30:
                    grau = "Obesidade I";
                    break;
                case >= 25:
                    grau = "Levemente acima Peso";
                    break;
                case >= 18:
                    grau = "Peso ideal";
                    break;
                default:
                    grau = "Abaixo do Peso";
                    break;
            }
            MessageBox.Show($"IMC: {imc:f2} Grau: {grau}",
                "IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            lbMensagem.Text = grau;

        }
    }
}
