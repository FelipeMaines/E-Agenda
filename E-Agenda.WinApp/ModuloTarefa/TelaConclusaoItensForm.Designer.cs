namespace E_Agenda.WinApp.ModuloTarefa
{
    partial class TelaConclusaoItensForm
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
            btnConclusao = new Button();
            lbListaitens = new CheckedListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnConclusao
            // 
            btnConclusao.DialogResult = DialogResult.OK;
            btnConclusao.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConclusao.Location = new Point(294, 319);
            btnConclusao.Name = "btnConclusao";
            btnConclusao.Size = new Size(150, 57);
            btnConclusao.TabIndex = 53;
            btnConclusao.Text = "Concluir Itens";
            btnConclusao.UseVisualStyleBackColor = true;
            btnConclusao.Click += btnConclusao_Click;
            // 
            // lbListaitens
            // 
            lbListaitens.FormattingEnabled = true;
            lbListaitens.Location = new Point(194, 118);
            lbListaitens.Name = "lbListaitens";
            lbListaitens.Size = new Size(373, 184);
            lbListaitens.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(264, 57);
            label1.Name = "label1";
            label1.Size = new Size(240, 37);
            label1.TabIndex = 48;
            label1.Text = "Conclusao de Itens";
            // 
            // TelaConclusaoItensForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConclusao);
            Controls.Add(lbListaitens);
            Controls.Add(label1);
            Name = "TelaConclusaoItensForm";
            Text = "TelaConclusaoItensForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConclusao;
        private CheckedListBox lbListaitens;
        private Label label1;
    }
}