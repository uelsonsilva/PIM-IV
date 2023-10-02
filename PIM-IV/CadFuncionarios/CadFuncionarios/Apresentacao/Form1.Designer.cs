namespace CadFuncionarios
{
    partial class frmCadFuncionarios
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
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnNovo = new Button();
            cmbSituacao = new ComboBox();
            txbNome = new TextBox();
            txbCodigo = new TextBox();
            gbBeneficios = new GroupBox();
            ckbValeAlimentacao = new CheckBox();
            ckbValeTransporte = new CheckBox();
            ckbConvenioMedico = new CheckBox();
            gbInfoFGTS = new GroupBox();
            dtpDataOpcao = new DateTimePicker();
            ckbOptNao = new CheckBox();
            ckbOptSim = new CheckBox();
            txbConta = new TextBox();
            lblConta = new Label();
            lblDataOpcao = new Label();
            lblOptante = new Label();
            gbHorario = new GroupBox();
            txbHoraSemana = new TextBox();
            txbHoraDia = new TextBox();
            txbHoraMes = new TextBox();
            txbNumCartPonto = new TextBox();
            ckbHNao = new CheckBox();
            ckbHSim = new CheckBox();
            lblHSemana = new Label();
            lblHMes = new Label();
            lblHDia = new Label();
            lblNumCartPonto = new Label();
            lblCargaHorVar = new Label();
            lblSituacao = new Label();
            lblNome = new Label();
            lblCodigo = new Label();
            gbBeneficios.SuspendLayout();
            gbInfoFGTS.SuspendLayout();
            gbHorario.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(348, 478);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 23;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(263, 478);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 22;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(174, 478);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 21;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // cmbSituacao
            // 
            cmbSituacao.FormattingEnabled = true;
            cmbSituacao.Items.AddRange(new object[] { "Ativo", "Não Ativo" });
            cmbSituacao.Location = new Point(298, 40);
            cmbSituacao.Name = "cmbSituacao";
            cmbSituacao.Size = new Size(121, 23);
            cmbSituacao.TabIndex = 20;
            // 
            // txbNome
            // 
            txbNome.Location = new Point(58, 106);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(361, 23);
            txbNome.TabIndex = 19;
            // 
            // txbCodigo
            // 
            txbCodigo.Location = new Point(64, 40);
            txbCodigo.Name = "txbCodigo";
            txbCodigo.Size = new Size(148, 23);
            txbCodigo.TabIndex = 18;
            // 
            // gbBeneficios
            // 
            gbBeneficios.Controls.Add(ckbValeAlimentacao);
            gbBeneficios.Controls.Add(ckbValeTransporte);
            gbBeneficios.Controls.Add(ckbConvenioMedico);
            gbBeneficios.Location = new Point(218, 302);
            gbBeneficios.Name = "gbBeneficios";
            gbBeneficios.Size = new Size(205, 149);
            gbBeneficios.TabIndex = 17;
            gbBeneficios.TabStop = false;
            gbBeneficios.Text = "Benefícios";
            // 
            // ckbValeAlimentacao
            // 
            ckbValeAlimentacao.AutoSize = true;
            ckbValeAlimentacao.Location = new Point(6, 109);
            ckbValeAlimentacao.Name = "ckbValeAlimentacao";
            ckbValeAlimentacao.Size = new Size(117, 19);
            ckbValeAlimentacao.TabIndex = 2;
            ckbValeAlimentacao.Text = "Vale Alimentação";
            ckbValeAlimentacao.UseVisualStyleBackColor = true;
            // 
            // ckbValeTransporte
            // 
            ckbValeTransporte.AutoSize = true;
            ckbValeTransporte.Location = new Point(6, 72);
            ckbValeTransporte.Name = "ckbValeTransporte";
            ckbValeTransporte.Size = new Size(105, 19);
            ckbValeTransporte.TabIndex = 1;
            ckbValeTransporte.Text = "Vale Transporte";
            ckbValeTransporte.UseVisualStyleBackColor = true;
            // 
            // ckbConvenioMedico
            // 
            ckbConvenioMedico.AutoSize = true;
            ckbConvenioMedico.Location = new Point(6, 32);
            ckbConvenioMedico.Name = "ckbConvenioMedico";
            ckbConvenioMedico.Size = new Size(120, 19);
            ckbConvenioMedico.TabIndex = 0;
            ckbConvenioMedico.Text = "Convênio Médico";
            ckbConvenioMedico.UseVisualStyleBackColor = true;
            // 
            // gbInfoFGTS
            // 
            gbInfoFGTS.Controls.Add(dtpDataOpcao);
            gbInfoFGTS.Controls.Add(ckbOptNao);
            gbInfoFGTS.Controls.Add(ckbOptSim);
            gbInfoFGTS.Controls.Add(txbConta);
            gbInfoFGTS.Controls.Add(lblConta);
            gbInfoFGTS.Controls.Add(lblDataOpcao);
            gbInfoFGTS.Controls.Add(lblOptante);
            gbInfoFGTS.Location = new Point(12, 302);
            gbInfoFGTS.Name = "gbInfoFGTS";
            gbInfoFGTS.Size = new Size(200, 149);
            gbInfoFGTS.TabIndex = 16;
            gbInfoFGTS.TabStop = false;
            gbInfoFGTS.Text = "Informações FGTS";
            // 
            // dtpDataOpcao
            // 
            dtpDataOpcao.Location = new Point(80, 72);
            dtpDataOpcao.Name = "dtpDataOpcao";
            dtpDataOpcao.Size = new Size(114, 23);
            dtpDataOpcao.TabIndex = 6;
            // 
            // ckbOptNao
            // 
            ckbOptNao.AutoSize = true;
            ckbOptNao.Location = new Point(111, 35);
            ckbOptNao.Name = "ckbOptNao";
            ckbOptNao.Size = new Size(48, 19);
            ckbOptNao.TabIndex = 5;
            ckbOptNao.Text = "Não";
            ckbOptNao.UseVisualStyleBackColor = true;
            // 
            // ckbOptSim
            // 
            ckbOptSim.AutoSize = true;
            ckbOptSim.Location = new Point(64, 35);
            ckbOptSim.Name = "ckbOptSim";
            ckbOptSim.Size = new Size(46, 19);
            ckbOptSim.TabIndex = 4;
            ckbOptSim.Text = "Sim";
            ckbOptSim.UseVisualStyleBackColor = true;
            // 
            // txbConta
            // 
            txbConta.Location = new Point(53, 107);
            txbConta.Name = "txbConta";
            txbConta.Size = new Size(141, 23);
            txbConta.TabIndex = 3;
            // 
            // lblConta
            // 
            lblConta.AutoSize = true;
            lblConta.Location = new Point(8, 113);
            lblConta.Name = "lblConta";
            lblConta.Size = new Size(39, 15);
            lblConta.TabIndex = 2;
            lblConta.Text = "Conta";
            // 
            // lblDataOpcao
            // 
            lblDataOpcao.AutoSize = true;
            lblDataOpcao.Location = new Point(8, 76);
            lblDataOpcao.Name = "lblDataOpcao";
            lblDataOpcao.Size = new Size(69, 15);
            lblDataOpcao.TabIndex = 1;
            lblDataOpcao.Text = "Data Opção";
            // 
            // lblOptante
            // 
            lblOptante.AutoSize = true;
            lblOptante.Location = new Point(8, 36);
            lblOptante.Name = "lblOptante";
            lblOptante.Size = new Size(50, 15);
            lblOptante.TabIndex = 0;
            lblOptante.Text = "Optante";
            // 
            // gbHorario
            // 
            gbHorario.Controls.Add(txbHoraSemana);
            gbHorario.Controls.Add(txbHoraDia);
            gbHorario.Controls.Add(txbHoraMes);
            gbHorario.Controls.Add(txbNumCartPonto);
            gbHorario.Controls.Add(ckbHNao);
            gbHorario.Controls.Add(ckbHSim);
            gbHorario.Controls.Add(lblHSemana);
            gbHorario.Controls.Add(lblHMes);
            gbHorario.Controls.Add(lblHDia);
            gbHorario.Controls.Add(lblNumCartPonto);
            gbHorario.Controls.Add(lblCargaHorVar);
            gbHorario.Location = new Point(12, 159);
            gbHorario.Name = "gbHorario";
            gbHorario.Size = new Size(411, 137);
            gbHorario.TabIndex = 15;
            gbHorario.TabStop = false;
            gbHorario.Text = "Horário";
            // 
            // txbHoraSemana
            // 
            txbHoraSemana.Location = new Point(213, 103);
            txbHoraSemana.Name = "txbHoraSemana";
            txbHoraSemana.Size = new Size(54, 23);
            txbHoraSemana.TabIndex = 10;
            // 
            // txbHoraDia
            // 
            txbHoraDia.Location = new Point(332, 103);
            txbHoraDia.Name = "txbHoraDia";
            txbHoraDia.Size = new Size(54, 23);
            txbHoraDia.TabIndex = 9;
            // 
            // txbHoraMes
            // 
            txbHoraMes.Location = new Point(72, 103);
            txbHoraMes.Name = "txbHoraMes";
            txbHoraMes.Size = new Size(54, 23);
            txbHoraMes.TabIndex = 8;
            // 
            // txbNumCartPonto
            // 
            txbNumCartPonto.Location = new Point(138, 66);
            txbNumCartPonto.Name = "txbNumCartPonto";
            txbNumCartPonto.Size = new Size(100, 23);
            txbNumCartPonto.TabIndex = 7;
            // 
            // ckbHNao
            // 
            ckbHNao.AutoSize = true;
            ckbHNao.Location = new Point(189, 27);
            ckbHNao.Name = "ckbHNao";
            ckbHNao.Size = new Size(48, 19);
            ckbHNao.TabIndex = 6;
            ckbHNao.Text = "Não";
            ckbHNao.UseVisualStyleBackColor = true;
            // 
            // ckbHSim
            // 
            ckbHSim.AutoSize = true;
            ckbHSim.Location = new Point(137, 27);
            ckbHSim.Name = "ckbHSim";
            ckbHSim.Size = new Size(46, 19);
            ckbHSim.TabIndex = 5;
            ckbHSim.Text = "Sim";
            ckbHSim.UseVisualStyleBackColor = true;
            // 
            // lblHSemana
            // 
            lblHSemana.AutoSize = true;
            lblHSemana.Location = new Point(129, 106);
            lblHSemana.Name = "lblHSemana";
            lblHSemana.Size = new Size(78, 15);
            lblHSemana.TabIndex = 4;
            lblHSemana.Text = "Hora Semana";
            // 
            // lblHMes
            // 
            lblHMes.AutoSize = true;
            lblHMes.Location = new Point(8, 106);
            lblHMes.Name = "lblHMes";
            lblHMes.Size = new Size(58, 15);
            lblHMes.TabIndex = 3;
            lblHMes.Text = "Hora Mês";
            // 
            // lblHDia
            // 
            lblHDia.AutoSize = true;
            lblHDia.Location = new Point(273, 106);
            lblHDia.Name = "lblHDia";
            lblHDia.Size = new Size(53, 15);
            lblHDia.TabIndex = 2;
            lblHDia.Text = "Hora Dia";
            // 
            // lblNumCartPonto
            // 
            lblNumCartPonto.AutoSize = true;
            lblNumCartPonto.Location = new Point(8, 69);
            lblNumCartPonto.Name = "lblNumCartPonto";
            lblNumCartPonto.Size = new Size(124, 15);
            lblNumCartPonto.TabIndex = 1;
            lblNumCartPonto.Text = "Número Cartão Ponto";
            // 
            // lblCargaHorVar
            // 
            lblCargaHorVar.AutoSize = true;
            lblCargaHorVar.Location = new Point(8, 31);
            lblCargaHorVar.Name = "lblCargaHorVar";
            lblCargaHorVar.Size = new Size(123, 15);
            lblCargaHorVar.TabIndex = 0;
            lblCargaHorVar.Text = "Carga Horária Variável";
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(240, 43);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 14;
            lblSituacao.Text = "Situação";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 109);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 13;
            lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 43);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 12;
            lblCodigo.Text = "Código";
            // 
            // frmCadFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 519);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(btnNovo);
            Controls.Add(cmbSituacao);
            Controls.Add(txbNome);
            Controls.Add(txbCodigo);
            Controls.Add(gbBeneficios);
            Controls.Add(gbInfoFGTS);
            Controls.Add(gbHorario);
            Controls.Add(lblSituacao);
            Controls.Add(lblNome);
            Controls.Add(lblCodigo);
            Name = "frmCadFuncionarios";
            Text = "Cadastro de Funcionários";
            gbBeneficios.ResumeLayout(false);
            gbBeneficios.PerformLayout();
            gbInfoFGTS.ResumeLayout(false);
            gbInfoFGTS.PerformLayout();
            gbHorario.ResumeLayout(false);
            gbHorario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnNovo;
        private ComboBox cmbSituacao;
        private TextBox txbNome;
        private TextBox txbCodigo;
        private GroupBox gbBeneficios;
        private CheckBox ckbValeAlimentacao;
        private CheckBox ckbValeTransporte;
        private CheckBox ckbConvenioMedico;
        private GroupBox gbInfoFGTS;
        private DateTimePicker dtpDataOpcao;
        private CheckBox ckbOptNao;
        private CheckBox ckbOptSim;
        private TextBox txbConta;
        private Label lblConta;
        private Label lblDataOpcao;
        private Label lblOptante;
        private GroupBox gbHorario;
        private TextBox txbHoraSemana;
        private TextBox txbHoraDia;
        private TextBox txbHoraMes;
        private TextBox txbNumCartPonto;
        private CheckBox ckbHNao;
        private CheckBox ckbHSim;
        private Label lblHSemana;
        private Label lblHMes;
        private Label lblHDia;
        private Label lblNumCartPonto;
        private Label lblCargaHorVar;
        private Label lblSituacao;
        private Label lblNome;
        private Label lblCodigo;
    }
}