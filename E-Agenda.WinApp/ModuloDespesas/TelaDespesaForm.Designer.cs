namespace E_Agenda.WinApp.ModuloDespesas
{
    partial class TelaDespesaForm
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
            tbDescricao = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbData = new DateTimePicker();
            cbPgto = new ComboBox();
            label4 = new Label();
            tbValor = new TextBox();
            label5 = new Label();
            btnGravar = new Button();
            button2 = new Button();
            lbCategorias = new CheckedListBox();
            SuspendLayout();
            // 
            // tbDescricao
            // 
            tbDescricao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbDescricao.Location = new Point(360, 62);
            tbDescricao.Name = "tbDescricao";
            tbDescricao.Size = new Size(190, 29);
            tbDescricao.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(259, 62);
            label1.Name = "label1";
            label1.Size = new Size(88, 24);
            label1.TabIndex = 1;
            label1.Text = "Descicao";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(212, 179);
            label2.Name = "label2";
            label2.Size = new Size(135, 24);
            label2.TabIndex = 3;
            label2.Text = "Forma de Pgto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(286, 145);
            label3.Name = "label3";
            label3.Size = new Size(47, 24);
            label3.TabIndex = 5;
            label3.Text = "Data";
            label3.Click += label3_Click;
            // 
            // tbData
            // 
            tbData.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbData.Format = DateTimePickerFormat.Short;
            tbData.Location = new Point(360, 141);
            tbData.Name = "tbData";
            tbData.Size = new Size(122, 29);
            tbData.TabIndex = 6;
            // 
            // cbPgto
            // 
            cbPgto.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbPgto.FormattingEnabled = true;
            cbPgto.Location = new Point(360, 176);
            cbPgto.Name = "cbPgto";
            cbPgto.Size = new Size(122, 32);
            cbPgto.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(286, 102);
            label4.Name = "label4";
            label4.Size = new Size(54, 24);
            label4.TabIndex = 13;
            label4.Text = "Valor";
            // 
            // tbValor
            // 
            tbValor.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbValor.Location = new Point(360, 97);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(122, 29);
            tbValor.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(272, 9);
            label5.Name = "label5";
            label5.Size = new Size(291, 31);
            label5.TabIndex = 14;
            label5.Text = "Cadastro de Despesas";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(588, 391);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(99, 47);
            btnGravar.TabIndex = 16;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click_1;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(693, 391);
            button2.Name = "button2";
            button2.Size = new Size(95, 47);
            button2.TabIndex = 17;
            button2.Text = "Cencelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // lbCategorias
            // 
            lbCategorias.FormattingEnabled = true;
            lbCategorias.Location = new Point(224, 238);
            lbCategorias.Name = "lbCategorias";
            lbCategorias.Size = new Size(339, 148);
            lbCategorias.TabIndex = 18;
            // 
            // TelaDespesaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbCategorias);
            Controls.Add(button2);
            Controls.Add(btnGravar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbValor);
            Controls.Add(cbPgto);
            Controls.Add(tbData);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbDescricao);
            Name = "TelaDespesaForm";
            Text = "TelaDespesaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDescricao;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker tbData;
        private ComboBox cbPgto;
        private Label label4;
        private TextBox tbValor;
        private Label label5;
        private Button btnGravar;
        private Button button2;
        private CheckedListBox lbCategorias;
    }
}