namespace WindowsFormsApp
{
    partial class CadastroAgenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.labelEndereço = new System.Windows.Forms.Label();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.labelemail = new System.Windows.Forms.Label();
            this.listViewAgenda = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Endereço = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(92, 41);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(147, 38);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(352, 20);
            this.tbNome.TabIndex = 1;
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(147, 80);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(352, 20);
            this.tbEndereco.TabIndex = 3;
            // 
            // labelEndereço
            // 
            this.labelEndereço.AutoSize = true;
            this.labelEndereço.Location = new System.Drawing.Point(92, 83);
            this.labelEndereço.Name = "labelEndereço";
            this.labelEndereço.Size = new System.Drawing.Size(53, 13);
            this.labelEndereço.TabIndex = 2;
            this.labelEndereço.Text = "Endereço";
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(147, 117);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(352, 20);
            this.tbTelefone.TabIndex = 5;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(92, 120);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(49, 13);
            this.labelTelefone.TabIndex = 4;
            this.labelTelefone.Text = "Telefone";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(147, 157);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(352, 20);
            this.tbEmail.TabIndex = 7;
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Location = new System.Drawing.Point(92, 160);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(35, 13);
            this.labelemail.TabIndex = 6;
            this.labelemail.Text = "E-mail";
            // 
            // listViewAgenda
            // 
            this.listViewAgenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Endereço,
            this.Telefone,
            this.email});
            this.listViewAgenda.HideSelection = false;
            this.listViewAgenda.Location = new System.Drawing.Point(21, 222);
            this.listViewAgenda.MultiSelect = false;
            this.listViewAgenda.Name = "listViewAgenda";
            this.listViewAgenda.Size = new System.Drawing.Size(745, 148);
            this.listViewAgenda.TabIndex = 8;
            this.listViewAgenda.UseCompatibleStateImageBehavior = false;
            this.listViewAgenda.View = System.Windows.Forms.View.Details;
            this.listViewAgenda.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvAgenda_ColumnClick);
            this.listViewAgenda.SelectedIndexChanged += new System.EventHandler(this.lvAgenda_SelectedIndexChanged);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 150;
            // 
            // Endereço
            // 
            this.Endereço.Text = "Endereço";
            this.Endereço.Width = 211;
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            this.Telefone.Width = 152;
            // 
            // email
            // 
            this.email.Text = "E-mail";
            this.email.Width = 227;
            // 
            // button1
            // 
            this.button1.Image = global::WindowsFormsApp.Properties.Resources.edit;
            this.button1.Location = new System.Drawing.Point(673, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 59);
            this.button1.TabIndex = 13;
            this.button1.Text = "Salvar Edição";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Image = global::WindowsFormsApp.Properties.Resources.deletar;
            this.buttonExcluir.Location = new System.Drawing.Point(702, 27);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(64, 59);
            this.buttonExcluir.TabIndex = 12;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Image = global::WindowsFormsApp.Properties.Resources.selecionar;
            this.buttonEditar.Location = new System.Drawing.Point(546, 111);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(93, 59);
            this.buttonEditar.TabIndex = 11;
            this.buttonEditar.Text = "Selecionar";
            this.buttonEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Image = global::WindowsFormsApp.Properties.Resources.save;
            this.buttonSalvar.Location = new System.Drawing.Point(623, 27);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(63, 59);
            this.buttonSalvar.TabIndex = 10;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // buttonNovo
            // 
            this.buttonNovo.Image = global::WindowsFormsApp.Properties.Resources.add;
            this.buttonNovo.Location = new System.Drawing.Point(546, 27);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(62, 59);
            this.buttonNovo.TabIndex = 9;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // CadastroAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.listViewAgenda);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.labelEndereço);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.labelNome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroAgenda";
            this.Text = "Agenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label labelEndereço;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.ListView listViewAgenda;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Endereço;
        private System.Windows.Forms.ColumnHeader Telefone;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button button1;
    }
}