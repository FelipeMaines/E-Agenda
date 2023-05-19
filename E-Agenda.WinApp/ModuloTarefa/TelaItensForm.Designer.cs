namespace E_Agenda.WinApp.ModuloTarefa
{
    partial class TelaItensForm
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
            txtDescricao = new TextBox();
            label1 = new Label();
            label2 = new Label();
            CaixaRadiosStatus = new GroupBox();
            radioButtonPresencial = new RadioButton();
            radioButtonOnline = new RadioButton();
            label3 = new Label();
            btnAdicionar = new Button();
            btnCancelar = new Button();
            lbListaitens = new ListBox();
            CaixaRadiosStatus.SuspendLayout();
            SuspendLayout();
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescricao.Location = new Point(312, 121);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(321, 29);
            txtDescricao.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(289, 56);
            label1.Name = "label1";
            label1.Size = new Size(231, 37);
            label1.TabIndex = 1;
            label1.Text = "Adicionando Itens";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(141, 121);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 2;
            label2.Text = "Descricao Do Item";
            // 
            // CaixaRadiosStatus
            // 
            CaixaRadiosStatus.Controls.Add(radioButtonPresencial);
            CaixaRadiosStatus.Controls.Add(radioButtonOnline);
            CaixaRadiosStatus.ForeColor = SystemColors.Control;
            CaixaRadiosStatus.Location = new Point(463, 156);
            CaixaRadiosStatus.Name = "CaixaRadiosStatus";
            CaixaRadiosStatus.Size = new Size(189, 45);
            CaixaRadiosStatus.TabIndex = 40;
            CaixaRadiosStatus.TabStop = false;
            // 
            // radioButtonPresencial
            // 
            radioButtonPresencial.AutoSize = true;
            radioButtonPresencial.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonPresencial.ForeColor = SystemColors.ActiveCaptionText;
            radioButtonPresencial.Location = new Point(15, 10);
            radioButtonPresencial.Name = "radioButtonPresencial";
            radioButtonPresencial.Size = new Size(61, 29);
            radioButtonPresencial.TabIndex = 37;
            radioButtonPresencial.TabStop = true;
            radioButtonPresencial.Text = "Sim";
            radioButtonPresencial.UseVisualStyleBackColor = true;
            // 
            // radioButtonOnline
            // 
            radioButtonOnline.AutoSize = true;
            radioButtonOnline.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonOnline.ForeColor = SystemColors.ActiveCaptionText;
            radioButtonOnline.Location = new Point(82, 10);
            radioButtonOnline.Name = "radioButtonOnline";
            radioButtonOnline.Size = new Size(65, 29);
            radioButtonOnline.TabIndex = 38;
            radioButtonOnline.TabStop = true;
            radioButtonOnline.Text = "Nao";
            radioButtonOnline.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(309, 164);
            label3.Name = "label3";
            label3.Size = new Size(148, 28);
            label3.TabIndex = 41;
            label3.Text = "Esta Concluida?";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DialogResult = DialogResult.OK;
            btnAdicionar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdicionar.Location = new Point(572, 392);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(104, 46);
            btnAdicionar.TabIndex = 42;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(682, 392);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(106, 46);
            btnCancelar.TabIndex = 43;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lbListaitens
            // 
            lbListaitens.FormattingEnabled = true;
            lbListaitens.ItemHeight = 15;
            lbListaitens.Items.AddRange(new object[] { "" });
            lbListaitens.Location = new Point(309, 212);
            lbListaitens.Name = "lbListaitens";
            lbListaitens.SelectionMode = SelectionMode.MultiSimple;
            lbListaitens.Size = new Size(324, 109);
            lbListaitens.TabIndex = 44;
            // 
            // TelaItensForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbListaitens);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdicionar);
            Controls.Add(label3);
            Controls.Add(CaixaRadiosStatus);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescricao);
            Name = "TelaItensForm";
            Text = "TelaItens";
            CaixaRadiosStatus.ResumeLayout(false);
            CaixaRadiosStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescricao;
        private Label label1;
        private Label label2;
        private GroupBox CaixaRadiosStatus;
        private RadioButton radioButtonPresencial;
        private RadioButton radioButtonOnline;
        private Label label3;
        private Button btnAdicionar;
        private Button btnCancelar;
        private Panel panelRegistros;
        private ListBox lbListaitens;
    }
}