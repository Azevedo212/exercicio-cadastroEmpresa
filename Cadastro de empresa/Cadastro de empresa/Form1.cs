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
            try
            {
                string regime;
                string tipo;
                string porte;

                string cnpj = tx_cnpj.Text;
                string razao = tx_Razao.Text;
                string nomeFantasia = tx_nomeFantasia.Text;
                string situacao = tx_situacao.Text;
                string dataAtividade = tx_dataAtividade.Text;
                string telefone = tx_telefone.Text;
                string capital = tx_capital.Text;
                string estado = tx_estado.Text;
                string cidade = tx_cidade.Text;
                string bairro = tx_bairro.Text;
                string rua = tx_rua.Text;
                string natureza = tx_natureza.Text;
                string nomeProprietario = tx_nomeProprietario.Text;
                string cpf = tx_cpf.Text;

                if (radioButton1.Checked == true)
                {
                    regime = radioButton1.Text;
                }
                else if (radioButton2.Checked == true)
                {
                    regime = radioButton2.Text;
                }
                else
                {
                    regime = radioButton3.Text;
                }

                if (radio_filial.Checked == true)
                {
                    tipo = radio_filial.Text;
                }
                else
                {
                    tipo = radio_matriz.Text;
                }

                if (radio_pequeno.Checked == true)
                {
                    porte = radio_pequeno.Text;
                }
                else if (radio_media.Checked == true)
                {
                    porte = radio_media.Text;
                }
                else
                {
                    porte = radio_grande.Text;
                }

                MessageBox.Show("Cadastrado com sucesso!!!");
                MessageBox.Show($"INFORMAÇÕES: \n Cnpj: {cnpj} \n Razão Social: {razao} \n Nome Fantasia: {nomeFantasia} \n Situação Cadastral: {situacao} \n " +
                    $"Regime Tributário: {regime} \n Data de Início de Atividade: {dataAtividade} \n Telefone: {telefone} \n Capital Social: {capital} \n " +
                    $"Estado: {estado} \n Cidade: {cidade} \n Bairro: {bairro} \n Rua: {rua} \n Tipo: {tipo} \n Porte da Empresa: {porte} \n" +
                    $"Natureza Jurídica: {natureza} \n Nome do proprietário: {nomeProprietario} \n CPF do Proprietário: {cpf}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha todos os campos!!!" + ex.Message);
            }
            {

            }

        }
    }
}