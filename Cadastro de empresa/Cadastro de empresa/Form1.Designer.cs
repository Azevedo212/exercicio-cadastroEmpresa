namespace Cadastro_de_empresa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tx_cnpj = new TextBox();
            tx_Razao = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tx_nomeFantasia = new TextBox();
            tx_situacao = new ComboBox();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox1 = new GroupBox();
            label6 = new Label();
            tx_dataAtividade = new MaskedTextBox();
            tx_telefone = new MaskedTextBox();
            label7 = new Label();
            label8 = new Label();
            tx_capital = new TextBox();
            tx_cidade = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            tx_rua = new TextBox();
            tx_bairro = new TextBox();
            radio_matriz = new RadioButton();
            radio_filial = new RadioButton();
            tx_estado = new ComboBox();
            radio_pequeno = new RadioButton();
            radio_media = new RadioButton();
            radio_grande = new RadioButton();
            groupBox2 = new GroupBox();
            tx_natureza = new ComboBox();
            label14 = new Label();
            label15 = new Label();
            tx_nomeProprietario = new TextBox();
            tx_cpf = new MaskedTextBox();
            label16 = new Label();
            bt_cadastrar = new Button();
            groupBox3 = new GroupBox();
            bt_cancelar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(287, 42);
            label1.Name = "label1";
            label1.Size = new Size(240, 32);
            label1.TabIndex = 0;
            label1.Text = "Cadastro Empresa";
            label1.Click += label1_Click;
            // 
            // tx_cnpj
            // 
            tx_cnpj.Location = new Point(98, 185);
            tx_cnpj.Name = "tx_cnpj";
            tx_cnpj.Size = new Size(146, 23);
            tx_cnpj.TabIndex = 1;
            // 
            // tx_Razao
            // 
            tx_Razao.Location = new Point(99, 258);
            tx_Razao.Name = "tx_Razao";
            tx_Razao.Size = new Size(145, 23);
            tx_Razao.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(98, 167);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 3;
            label2.Text = "Cnpj";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(98, 240);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 4;
            label3.Text = "Razão Social";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(98, 109);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 5;
            label4.Text = "Nome Fantasia";
            // 
            // tx_nomeFantasia
            // 
            tx_nomeFantasia.Location = new Point(99, 127);
            tx_nomeFantasia.Name = "tx_nomeFantasia";
            tx_nomeFantasia.Size = new Size(171, 23);
            tx_nomeFantasia.TabIndex = 6;
            // 
            // tx_situacao
            // 
            tx_situacao.FormattingEnabled = true;
            tx_situacao.Items.AddRange(new object[] { "Ativa", "Nula", "Suspensa", "Inapta", "Baixada" });
            tx_situacao.Location = new Point(555, 127);
            tx_situacao.Name = "tx_situacao";
            tx_situacao.Size = new Size(121, 23);
            tx_situacao.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(555, 109);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 8;
            label5.Text = "Situação Cadastral";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(20, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(116, 19);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Simples Nacional";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(157, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(115, 19);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Lucro Presumido";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(300, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(80, 19);
            radioButton3.TabIndex = 12;
            radioButton3.TabStop = true;
            radioButton3.Text = "Lucro Real";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(350, 167);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 58);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Regime Tributário";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(361, 109);
            label6.Name = "label6";
            label6.Size = new Size(136, 15);
            label6.TabIndex = 14;
            label6.Text = "Data Início de Atividade";
            // 
            // tx_dataAtividade
            // 
            tx_dataAtividade.Location = new Point(373, 127);
            tx_dataAtividade.Mask = "00/00/0000";
            tx_dataAtividade.Name = "tx_dataAtividade";
            tx_dataAtividade.Size = new Size(120, 23);
            tx_dataAtividade.TabIndex = 15;
            // 
            // tx_telefone
            // 
            tx_telefone.Location = new Point(373, 258);
            tx_telefone.Mask = "(00) 0000-0000";
            tx_telefone.Name = "tx_telefone";
            tx_telefone.Size = new Size(100, 23);
            tx_telefone.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(373, 240);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 17;
            label7.Text = "Telefone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(541, 240);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 18;
            label8.Text = "Capital Social";
            // 
            // tx_capital
            // 
            tx_capital.Location = new Point(541, 258);
            tx_capital.Name = "tx_capital";
            tx_capital.Size = new Size(100, 23);
            tx_capital.TabIndex = 19;
            // 
            // tx_cidade
            // 
            tx_cidade.Location = new Point(240, 334);
            tx_cidade.Name = "tx_cidade";
            tx_cidade.Size = new Size(100, 23);
            tx_cidade.TabIndex = 20;
            tx_cidade.TextChanged += tx_cidade_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(240, 316);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 22;
            label10.Text = "Cidade";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(99, 316);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 23;
            label11.Text = "Estado";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(98, 372);
            label12.Name = "label12";
            label12.Size = new Size(28, 15);
            label12.TabIndex = 24;
            label12.Text = "Rua";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(240, 372);
            label13.Name = "label13";
            label13.Size = new Size(39, 15);
            label13.TabIndex = 25;
            label13.Text = "Bairro";
            // 
            // tx_rua
            // 
            tx_rua.Location = new Point(98, 390);
            tx_rua.Name = "tx_rua";
            tx_rua.Size = new Size(100, 23);
            tx_rua.TabIndex = 27;
            // 
            // tx_bairro
            // 
            tx_bairro.Location = new Point(240, 390);
            tx_bairro.Name = "tx_bairro";
            tx_bairro.Size = new Size(100, 23);
            tx_bairro.TabIndex = 28;
            // 
            // radio_matriz
            // 
            radio_matriz.AutoSize = true;
            radio_matriz.Location = new Point(24, 18);
            radio_matriz.Name = "radio_matriz";
            radio_matriz.Size = new Size(58, 19);
            radio_matriz.TabIndex = 30;
            radio_matriz.TabStop = true;
            radio_matriz.Text = "Matriz";
            radio_matriz.UseVisualStyleBackColor = true;
            radio_matriz.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radio_filial
            // 
            radio_filial.AutoSize = true;
            radio_filial.Location = new Point(103, 18);
            radio_filial.Name = "radio_filial";
            radio_filial.Size = new Size(49, 19);
            radio_filial.TabIndex = 31;
            radio_filial.TabStop = true;
            radio_filial.Text = "Filial";
            radio_filial.UseVisualStyleBackColor = true;
            radio_filial.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // tx_estado
            // 
            tx_estado.FormattingEnabled = true;
            tx_estado.Items.AddRange(new object[] { "Acre (AC)", "Alagoas (AL)", "Amapá (AP)", "Amazonas (AM)", "Bahia (BA)", "Ceará (CE)", "Distrito Federal (DF)", "Espírito Santo (ES)", "Goiás (GO)", "Maranhão (MA)", "Mato Grosso (MT)", "Mato Grosso do Sul (MS)", "Minas Gerais (MG)", "Pará (PA)", "Paraíba (PB)", "Paraná (PR)", "Pernambuco (PE)", "Piauí (PI)", "Rio de Janeiro (RJ)", "Rio Grande do Norte (RN)", "Rio Grande do Sul (RS)", "Rondônia (RO)", "Roraima (RR)", "Santa Catarina (SC)", "São Paulo (SP)", "Sergipe (SE)", "Tocantins (TO)" });
            tx_estado.Location = new Point(99, 334);
            tx_estado.Name = "tx_estado";
            tx_estado.Size = new Size(101, 23);
            tx_estado.TabIndex = 32;
            // 
            // radio_pequeno
            // 
            radio_pequeno.AutoSize = true;
            radio_pequeno.Location = new Point(6, 38);
            radio_pequeno.Name = "radio_pequeno";
            radio_pequeno.Size = new Size(71, 19);
            radio_pequeno.TabIndex = 34;
            radio_pequeno.TabStop = true;
            radio_pequeno.Text = "Pequena";
            radio_pequeno.UseVisualStyleBackColor = true;
            // 
            // radio_media
            // 
            radio_media.AutoSize = true;
            radio_media.Location = new Point(96, 38);
            radio_media.Name = "radio_media";
            radio_media.Size = new Size(58, 19);
            radio_media.TabIndex = 35;
            radio_media.TabStop = true;
            radio_media.Text = "Média";
            radio_media.UseVisualStyleBackColor = true;
            // 
            // radio_grande
            // 
            radio_grande.AutoSize = true;
            radio_grande.Location = new Point(175, 38);
            radio_grande.Name = "radio_grande";
            radio_grande.Size = new Size(63, 19);
            radio_grande.TabIndex = 36;
            radio_grande.TabStop = true;
            radio_grande.Text = "Grande";
            radio_grande.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radio_pequeno);
            groupBox2.Controls.Add(radio_grande);
            groupBox2.Controls.Add(radio_media);
            groupBox2.Location = new Point(413, 360);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(263, 66);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "Porte da Empresa";
            // 
            // tx_natureza
            // 
            tx_natureza.FormattingEnabled = true;
            tx_natureza.Items.AddRange(new object[] { "EI - Empresário Individual", "MEI - Microempreendedor Individual", "Sociedade Anônima" });
            tx_natureza.Location = new Point(99, 447);
            tx_natureza.Name = "tx_natureza";
            tx_natureza.Size = new Size(121, 23);
            tx_natureza.TabIndex = 38;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(99, 429);
            label14.Name = "label14";
            label14.Size = new Size(97, 15);
            label14.TabIndex = 39;
            label14.Text = "Natureza Jurídica";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(321, 429);
            label15.Name = "label15";
            label15.Size = new Size(105, 15);
            label15.TabIndex = 40;
            label15.Text = "Nome Proprietário";
            // 
            // tx_nomeProprietario
            // 
            tx_nomeProprietario.Location = new Point(321, 447);
            tx_nomeProprietario.Name = "tx_nomeProprietario";
            tx_nomeProprietario.Size = new Size(171, 23);
            tx_nomeProprietario.TabIndex = 41;
            // 
            // tx_cpf
            // 
            tx_cpf.Location = new Point(561, 447);
            tx_cpf.Mask = "000.000.000-00";
            tx_cpf.Name = "tx_cpf";
            tx_cpf.Size = new Size(100, 23);
            tx_cpf.TabIndex = 42;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(568, 429);
            label16.Name = "label16";
            label16.Size = new Size(108, 15);
            label16.TabIndex = 43;
            label16.Text = "Cpf do Proprietário";
            // 
            // bt_cadastrar
            // 
            bt_cadastrar.Location = new Point(650, 499);
            bt_cadastrar.Name = "bt_cadastrar";
            bt_cadastrar.Size = new Size(119, 45);
            bt_cadastrar.TabIndex = 44;
            bt_cadastrar.Text = "Cadastrar";
            bt_cadastrar.UseVisualStyleBackColor = true;
            bt_cadastrar.Click += bt_cadastrar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radio_matriz);
            groupBox3.Controls.Add(radio_filial);
            groupBox3.Location = new Point(419, 297);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 46);
            groupBox3.TabIndex = 45;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tipo";
            // 
            // bt_cancelar
            // 
            bt_cancelar.Location = new Point(522, 499);
            bt_cancelar.Name = "bt_cancelar";
            bt_cancelar.Size = new Size(97, 45);
            bt_cancelar.TabIndex = 46;
            bt_cancelar.Text = "Cancelar";
            bt_cancelar.UseVisualStyleBackColor = true;
            bt_cancelar.Click += bt_cancelar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 556);
            Controls.Add(bt_cancelar);
            Controls.Add(groupBox3);
            Controls.Add(bt_cadastrar);
            Controls.Add(label16);
            Controls.Add(tx_cpf);
            Controls.Add(tx_nomeProprietario);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(tx_natureza);
            Controls.Add(groupBox2);
            Controls.Add(tx_estado);
            Controls.Add(tx_bairro);
            Controls.Add(tx_rua);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(tx_cidade);
            Controls.Add(tx_capital);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(tx_telefone);
            Controls.Add(tx_dataAtividade);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(tx_situacao);
            Controls.Add(tx_nomeFantasia);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tx_Razao);
            Controls.Add(tx_cnpj);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tx_cnpj;
        private TextBox tx_Razao;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tx_nomeFantasia;
        private ComboBox tx_situacao;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox1;
        private Label label6;
        private MaskedTextBox tx_dataAtividade;
        private MaskedTextBox tx_telefone;
        private Label label7;
        private Label label8;
        private TextBox tx_capital;
        private TextBox tx_cidade;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox tx_rua;
        private TextBox tx_bairro;
        private RadioButton radio_matriz;
        private RadioButton radio_filial;
        private ComboBox tx_estado;
        private RadioButton radio_pequeno;
        private RadioButton radio_media;
        private RadioButton radio_grande;
        private GroupBox groupBox2;
        private ComboBox tx_natureza;
        private Label label14;
        private Label label15;
        private TextBox tx_nomeProprietario;
        private MaskedTextBox tx_cpf;
        private Label label16;
        private Button bt_cadastrar;
        private GroupBox groupBox3;
        private Button bt_cancelar;
    }
}