namespace Cadastro_de_empresa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tx_cidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {

            Cadastro cad = new Cadastro();

            cad.Razao = tx_Razao.Text;
            cad.Tipo = "";
            cad.Porte = "";
            cad.Regime = "";
            cad.Cnpj = tx_cnpj.Text;
            cad.Razao = tx_Razao.Text;
            cad.NomeFantasia = tx_nomeFantasia.Text;
            cad.Situacao = tx_situacao.Text;
            cad.DataAtividade = tx_dataAtividade.Text;
            cad.Telefone = tx_telefone.Text;
            cad.Capital = tx_capital.Text;
            cad.Estado = tx_estado.Text;
            cad.Cidade = tx_cidade.Text;
            cad.Bairro = tx_bairro.Text;
            cad.Rua = tx_rua.Text;
            cad.Natureza = tx_natureza.Text;
            cad.NomeProprietario = tx_nomeProprietario.Text;
            cad.Cpf = tx_cpf.Text;

            if (radioButton1.Checked == true)
            {
                cad.Regime = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                cad.Regime = radioButton2.Text;
            }
            else
            {
                cad.Regime = radioButton3.Text;
            }

            if (radio_filial.Checked == true)
            {
                cad.Tipo = radio_filial.Text;
            }
            else
            {
                cad.Tipo = radio_matriz.Text;
            }

            if (radio_pequeno.Checked == true)
            {
                cad.Porte = radio_pequeno.Text;
            }
            else if (radio_media.Checked == true)
            {
                cad.Porte = radio_media.Text;
            }
            else
            {
                cad.Porte = radio_grande.Text;
            }

            if (Validar())
            {
                MessageBox.Show("Cadastrado com sucesso!!!");
                MessageBox.Show($"INFORMAÇÕES: \n Cnpj: {cad.Cnpj} \n Razão Social: {cad.Razao} \n Nome Fantasia: {cad.NomeFantasia} \n Situação Cadastral: {cad.Situacao} \n " +
                    $"Regime Tributário: {cad.Regime} \n Data de Início de Atividade: {cad.DataAtividade} \n Telefone: {cad.Telefone} \n Capital Social: {cad.Capital} \n " +
                    $"Estado: {cad.Estado} \n Cidade: {cad.Cidade} \n Bairro: {cad.Bairro} \n Rua: {cad.Rua} \n Tipo: {cad.Tipo} \n Porte da Empresa: {cad.Porte} \n" +
                    $"Natureza Jurídica: {cad.Natureza} \n Nome do proprietário: {cad.NomeProprietario} \n CPF do Proprietário: {cad.Cpf}");

                tx_nomeFantasia.Clear();
                tx_cnpj.Clear();
                tx_Razao.Clear();
                tx_estado.ResetText();
                tx_cidade.Clear();
                tx_rua.Clear();
                tx_bairro.Clear();
                tx_dataAtividade.Clear();
                tx_situacao.ResetText();
                tx_telefone.ResetText();
                tx_capital.ResetText();
                tx_nomeProprietario.Clear();
                tx_cpf.Clear();
                tx_natureza.ResetText();
            }

            else
            {
                MessageBox.Show("Formato Inválido!");
                MessageBox.Show("Preencha todos os campos!!!");
            }

        }

        public bool Validar()
        {
            bool validacao;

            if (tx_nomeFantasia.Text == "")
            {
                validacao = false;
            }
            else if (tx_dataAtividade.Text == "")
            {
                validacao = false;
            }
            else if (tx_situacao.Text == "")
            {
                validacao = false;
            }
            else if (tx_telefone.Text == "")
            {
                validacao = false;
            }
            else if (tx_capital.Text == "")
            {
                validacao = false;
            }
            else if (tx_estado.Text == "")
            {
                validacao = false;
            }
            else if (tx_cidade.Text == "")
            {
                validacao = false;
            }
            else if (tx_bairro.Text == "")
            {
                validacao = false;
            }
            else if (tx_rua.Text == "")
            {
                validacao = false;
            }
            else if (tx_natureza.Text == "")
            {
                validacao = false;
            }
            else if (tx_estado.Text == "")
            {
                validacao = false;
            }

            else if (tx_nomeProprietario.Text == "")
            {
                validacao = false;
            }
            else if (tx_cpf.Text == "")
            {
                validacao = false;
            }

            else
            {
                validacao = true;
            }

            return validacao;
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            tx_nomeFantasia.Clear();
            tx_cnpj.Clear();
            tx_Razao.Clear();
            tx_estado.ResetText();
            tx_cidade.Clear();
            tx_rua.Clear();
            tx_bairro.Clear();
            tx_dataAtividade.Clear();
            tx_situacao.ResetText();
            tx_telefone.ResetText();
            tx_capital.ResetText();
            tx_nomeProprietario.Clear();
            tx_cpf.Clear();
            tx_natureza.ResetText();
        }
    }
}