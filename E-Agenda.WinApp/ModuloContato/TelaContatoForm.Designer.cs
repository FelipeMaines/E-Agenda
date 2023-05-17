namespace E_Agenda.WinApp.ModuloContato
{
    partial class TelaContatoForm
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
            label2 = new Label();
            tbNomeContato = new TextBox();
            tbEmailContato = new TextBox();
            label3 = new Label();
            tbEmpresaContato = new TextBox();
            b = new Label();
            tbTelefoneContato = new TextBox();
            a = new Label();
            tbCargoContato = new TextBox();
            vd = new Label();
            label1 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            tbIdContato = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(200, 148);
            label2.Name = "label2";
            label2.Size = new Size(73, 30);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // tbNomeContato
            // 
            tbNomeContato.Anchor = AnchorStyles.None;
            tbNomeContato.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNomeContato.Location = new Point(279, 149);
            tbNomeContato.Name = "tbNomeContato";
            tbNomeContato.Size = new Size(240, 29);
            tbNomeContato.TabIndex = 2;
            // 
            // tbEmailContato
            // 
            tbEmailContato.Anchor = AnchorStyles.None;
            tbEmailContato.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmailContato.Location = new Point(278, 189);
            tbEmailContato.Name = "tbEmailContato";
            tbEmailContato.Size = new Size(249, 29);
            tbEmailContato.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(208, 189);
            label3.Name = "label3";
            label3.Size = new Size(64, 30);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // tbEmpresaContato
            // 
            tbEmpresaContato.Anchor = AnchorStyles.None;
            tbEmpresaContato.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmpresaContato.Location = new Point(634, 193);
            tbEmpresaContato.Name = "tbEmpresaContato";
            tbEmpresaContato.Size = new Size(240, 29);
            tbEmpresaContato.TabIndex = 8;
            // 
            // b
            // 
            b.Anchor = AnchorStyles.None;
            b.AutoSize = true;
            b.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            b.Location = new Point(533, 193);
            b.Name = "b";
            b.Size = new Size(96, 30);
            b.TabIndex = 7;
            b.Text = "Empresa";
            // 
            // tbTelefoneContato
            // 
            tbTelefoneContato.Anchor = AnchorStyles.None;
            tbTelefoneContato.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbTelefoneContato.Location = new Point(634, 149);
            tbTelefoneContato.Name = "tbTelefoneContato";
            tbTelefoneContato.Size = new Size(240, 29);
            tbTelefoneContato.TabIndex = 6;
            // 
            // a
            // 
            a.Anchor = AnchorStyles.None;
            a.AutoSize = true;
            a.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            a.Location = new Point(532, 149);
            a.Name = "a";
            a.Size = new Size(96, 30);
            a.TabIndex = 5;
            a.Text = "Telefone";
            // 
            // tbCargoContato
            // 
            tbCargoContato.Anchor = AnchorStyles.None;
            tbCargoContato.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbCargoContato.Location = new Point(279, 233);
            tbCargoContato.Name = "tbCargoContato";
            tbCargoContato.Size = new Size(240, 29);
            tbCargoContato.TabIndex = 10;
            // 
            // vd
            // 
            vd.Anchor = AnchorStyles.None;
            vd.AutoSize = true;
            vd.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            vd.Location = new Point(201, 233);
            vd.Name = "vd";
            vd.Size = new Size(72, 30);
            vd.TabIndex = 9;
            vd.Text = "Cargo";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(320, 28);
            label1.Name = "label1";
            label1.Size = new Size(330, 46);
            label1.TabIndex = 11;
            label1.Text = "Cadastro de Contato";
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnGravar.Location = new Point(740, 441);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(99, 41);
            btnGravar.TabIndex = 12;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(845, 441);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 41);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tbIdContato
            // 
            tbIdContato.Anchor = AnchorStyles.None;
            tbIdContato.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbIdContato.Location = new Point(571, 235);
            tbIdContato.Name = "tbIdContato";
            tbIdContato.Size = new Size(240, 29);
            tbIdContato.TabIndex = 15;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(533, 234);
            label4.Name = "label4";
            label4.Size = new Size(32, 30);
            label4.TabIndex = 14;
            label4.Text = "Id";
            // 
            // TelaContatoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 494);
            Controls.Add(tbIdContato);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(label1);
            Controls.Add(tbCargoContato);
            Controls.Add(vd);
            Controls.Add(tbEmpresaContato);
            Controls.Add(b);
            Controls.Add(tbTelefoneContato);
            Controls.Add(a);
            Controls.Add(tbEmailContato);
            Controls.Add(label3);
            Controls.Add(tbNomeContato);
            Controls.Add(label2);
            Name = "TelaContatoForm";
            Text = "TelaContatoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox tbNomeContato;
        private TextBox tbEmailContato;
        private Label label3;
        private TextBox tbEmpresaContato;
        private Label b;
        private TextBox tbTelefoneContato;
        private Label a;
        private TextBox tbCargoContato;
        private Label vd;
        private Label label1;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox tbIdContato;
        private Label label4;
    }
}