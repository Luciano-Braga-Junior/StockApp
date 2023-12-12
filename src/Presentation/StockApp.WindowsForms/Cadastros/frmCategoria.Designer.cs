namespace StockApp.WindowsForms.Cadastros
{
    partial class frmCategoria
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
            gbCadastrarCategoria = new GroupBox();
            lblNome = new Label();
            btnSalvar = new Button();
            chkStatus = new CheckBox();
            txtNome = new TextBox();
            gbCadastrarCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // gbCadastrarCategoria
            // 
            gbCadastrarCategoria.Controls.Add(lblNome);
            gbCadastrarCategoria.Controls.Add(btnSalvar);
            gbCadastrarCategoria.Controls.Add(chkStatus);
            gbCadastrarCategoria.Controls.Add(txtNome);
            gbCadastrarCategoria.Location = new Point(34, 12);
            gbCadastrarCategoria.Name = "gbCadastrarCategoria";
            gbCadastrarCategoria.Size = new Size(245, 112);
            gbCadastrarCategoria.TabIndex = 0;
            gbCadastrarCategoria.TabStop = false;
            gbCadastrarCategoria.Text = "Cadastrar Categoria";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(6, 19);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(157, 80);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Location = new Point(121, 39);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(54, 19);
            chkStatus.TabIndex = 1;
            chkStatus.Text = "Ativo";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbCadastrarCategoria);
            Name = "frmCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategoria";
            gbCadastrarCategoria.ResumeLayout(false);
            gbCadastrarCategoria.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbCadastrarCategoria;
        private Label lblNome;
        private Button btnSalvar;
        private CheckBox chkStatus;
        private TextBox txtNome;
    }
}