﻿namespace WindowsFormsApp
{
    partial class CadastroFuncionario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelSalario = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelAdicional = new System.Windows.Forms.Label();
            this.labelLiq = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.tbDesconto = new System.Windows.Forms.TextBox();
            this.tbAdicional = new System.Windows.Forms.TextBox();
            this.tbLiquido = new System.Windows.Forms.TextBox();
            this.cbDesconto = new System.Windows.Forms.CheckBox();
            this.lvListaFuncionarios = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SalarioBruto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Desconto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adicional = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SalarioLiquido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExcluir = new System.Windows.Forms.Button();
            this.tbCPF = new System.Windows.Forms.MaskedTextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.tbBonus = new System.Windows.Forms.TextBox();
            this.labelLiquidoBonus = new System.Windows.Forms.Label();
            this.tbCargo = new System.Windows.Forms.TextBox();
            this.labelCargo = new System.Windows.Forms.Label();
            this.chLiquidoBonus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(41, 21);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 13;
            this.labelNome.Text = "Nome:";
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(37, 95);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(42, 13);
            this.labelSalario.TabIndex = 16;
            this.labelSalario.Text = "Salário:";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(23, 122);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(56, 13);
            this.labelDesc.TabIndex = 17;
            this.labelDesc.Text = "Desconto:";
            // 
            // labelAdicional
            // 
            this.labelAdicional.AutoSize = true;
            this.labelAdicional.Location = new System.Drawing.Point(25, 148);
            this.labelAdicional.Name = "labelAdicional";
            this.labelAdicional.Size = new System.Drawing.Size(53, 13);
            this.labelAdicional.TabIndex = 3;
            this.labelAdicional.Text = "Adicional:";
            // 
            // labelLiq
            // 
            this.labelLiq.AutoSize = true;
            this.labelLiq.Location = new System.Drawing.Point(337, 118);
            this.labelLiq.Name = "labelLiq";
            this.labelLiq.Size = new System.Drawing.Size(46, 13);
            this.labelLiq.TabIndex = 4;
            this.labelLiq.Text = "Líquido:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(150, 193);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(189, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(85, 13);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(404, 20);
            this.tbNome.TabIndex = 0;
            // 
            // tbSalario
            // 
            this.tbSalario.Location = new System.Drawing.Point(85, 90);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(100, 20);
            this.tbSalario.TabIndex = 3;
            this.tbSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSalario.Leave += new System.EventHandler(this.TbSalario_Leave);
            // 
            // tbDesconto
            // 
            this.tbDesconto.Location = new System.Drawing.Point(85, 116);
            this.tbDesconto.Name = "tbDesconto";
            this.tbDesconto.Size = new System.Drawing.Size(100, 20);
            this.tbDesconto.TabIndex = 4;
            this.tbDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDesconto.Leave += new System.EventHandler(this.TbDesconto_Leave);
            // 
            // tbAdicional
            // 
            this.tbAdicional.Location = new System.Drawing.Point(85, 139);
            this.tbAdicional.Name = "tbAdicional";
            this.tbAdicional.Size = new System.Drawing.Size(100, 20);
            this.tbAdicional.TabIndex = 6;
            this.tbAdicional.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbAdicional.Leave += new System.EventHandler(this.TbAdicional_Leave);
            // 
            // tbLiquido
            // 
            this.tbLiquido.Location = new System.Drawing.Point(389, 113);
            this.tbLiquido.Name = "tbLiquido";
            this.tbLiquido.Size = new System.Drawing.Size(100, 20);
            this.tbLiquido.TabIndex = 7;
            this.tbLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbDesconto
            // 
            this.cbDesconto.AutoSize = true;
            this.cbDesconto.Location = new System.Drawing.Point(192, 118);
            this.cbDesconto.Name = "cbDesconto";
            this.cbDesconto.Size = new System.Drawing.Size(96, 17);
            this.cbDesconto.TabIndex = 5;
            this.cbDesconto.Text = "Sem Desconto";
            this.cbDesconto.UseVisualStyleBackColor = true;
            this.cbDesconto.CheckStateChanged += new System.EventHandler(this.CbDesconto_CheckStateChanged);
            // 
            // lvListaFuncionarios
            // 
            this.lvListaFuncionarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Cpf,
            this.SalarioBruto,
            this.Desconto,
            this.Adicional,
            this.SalarioLiquido,
            this.chLiquidoBonus,
            this.cargo});
            this.lvListaFuncionarios.FullRowSelect = true;
            this.lvListaFuncionarios.GridLines = true;
            this.lvListaFuncionarios.HideSelection = false;
            this.lvListaFuncionarios.LabelEdit = true;
            this.lvListaFuncionarios.Location = new System.Drawing.Point(30, 238);
            this.lvListaFuncionarios.MultiSelect = false;
            this.lvListaFuncionarios.Name = "lvListaFuncionarios";
            this.lvListaFuncionarios.Size = new System.Drawing.Size(581, 97);
            this.lvListaFuncionarios.TabIndex = 12;
            this.lvListaFuncionarios.UseCompatibleStateImageBehavior = false;
            this.lvListaFuncionarios.View = System.Windows.Forms.View.Details;
            this.lvListaFuncionarios.SelectedIndexChanged += new System.EventHandler(this.LvListaFuncionarios_SelectedIndexChanged);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 79;
            // 
            // Cpf
            // 
            this.Cpf.Text = "CPF";
            this.Cpf.Width = 89;
            // 
            // SalarioBruto
            // 
            this.SalarioBruto.Text = "Salario Bruto";
            this.SalarioBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SalarioBruto.Width = 73;
            // 
            // Desconto
            // 
            this.Desconto.Text = "Desconto";
            this.Desconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Adicional
            // 
            this.Adicional.Text = "Adicional";
            this.Adicional.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SalarioLiquido
            // 
            this.SalarioLiquido.Text = "Salario Liquido";
            this.SalarioLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SalarioLiquido.Width = 85;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(414, 341);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(85, 64);
            this.tbCPF.Mask = "000.000.000-00";
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(100, 20);
            this.tbCPF.TabIndex = 2;
            this.tbCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(41, 67);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(30, 13);
            this.labelCPF.TabIndex = 15;
            this.labelCPF.Text = "CPF:";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOrdenar.Location = new System.Drawing.Point(265, 341);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(143, 23);
            this.btnOrdenar.TabIndex = 10;
            this.btnOrdenar.Text = "Ordenar Lista (por Nome)";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.BtnOrdenar_Click);
            // 
            // tbBonus
            // 
            this.tbBonus.Location = new System.Drawing.Point(389, 139);
            this.tbBonus.Name = "tbBonus";
            this.tbBonus.Size = new System.Drawing.Size(100, 20);
            this.tbBonus.TabIndex = 8;
            this.tbBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelLiquidoBonus
            // 
            this.labelLiquidoBonus.AutoSize = true;
            this.labelLiquidoBonus.Location = new System.Drawing.Point(315, 146);
            this.labelLiquidoBonus.Name = "labelLiquidoBonus";
            this.labelLiquidoBonus.Size = new System.Drawing.Size(68, 13);
            this.labelLiquidoBonus.TabIndex = 19;
            this.labelLiquidoBonus.Text = "Líq. + Bonus";
            // 
            // tbCargo
            // 
            this.tbCargo.Location = new System.Drawing.Point(85, 38);
            this.tbCargo.Name = "tbCargo";
            this.tbCargo.Size = new System.Drawing.Size(203, 20);
            this.tbCargo.TabIndex = 1;
            this.tbCargo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbCargo_MouseMove);
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Location = new System.Drawing.Point(41, 45);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(38, 13);
            this.labelCargo.TabIndex = 14;
            this.labelCargo.Text = "Cargo:";
            // 
            // chLiquidoBonus
            // 
            this.chLiquidoBonus.Text = "Líq. + Bonus";
            this.chLiquidoBonus.Width = 74;
            // 
            // cargo
            // 
            this.cargo.Text = "Cargo";
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(623, 371);
            this.Controls.Add(this.tbCargo);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.labelLiquidoBonus);
            this.Controls.Add(this.tbBonus);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lvListaFuncionarios);
            this.Controls.Add(this.cbDesconto);
            this.Controls.Add(this.tbLiquido);
            this.Controls.Add(this.tbAdicional);
            this.Controls.Add(this.tbDesconto);
            this.Controls.Add(this.tbSalario);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.labelLiq);
            this.Controls.Add(this.labelAdicional);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.labelNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionário";
            this.Load += new System.EventHandler(this.MinhaJanela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelAdicional;
        private System.Windows.Forms.Label labelLiq;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.TextBox tbDesconto;
        private System.Windows.Forms.TextBox tbAdicional;
        private System.Windows.Forms.TextBox tbLiquido;
        private System.Windows.Forms.CheckBox cbDesconto;
        private System.Windows.Forms.ListView lvListaFuncionarios;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader SalarioBruto;
        private System.Windows.Forms.ColumnHeader Desconto;
        private System.Windows.Forms.ColumnHeader Adicional;
        private System.Windows.Forms.ColumnHeader SalarioLiquido;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.MaskedTextBox tbCPF;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.ColumnHeader Cpf;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.TextBox tbBonus;
        private System.Windows.Forms.Label labelLiquidoBonus;
        private System.Windows.Forms.TextBox tbCargo;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.ColumnHeader chLiquidoBonus;
        private System.Windows.Forms.ColumnHeader cargo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

