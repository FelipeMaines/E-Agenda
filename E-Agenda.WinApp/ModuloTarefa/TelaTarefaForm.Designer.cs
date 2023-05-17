namespace E_Agenda.WinApp.ModuloTarefa
{
    partial class TelaTarefaForm
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
            txtNome = new Label();
            tbNomeTarefa = new TextBox();
            tbIdTarefa = new TextBox();
            id = new Label();
            tbPrioridadeTarefa = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.AutoSize = true;
            txtNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(230, 113);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(63, 25);
            txtNome.TabIndex = 1;
            txtNome.Text = "Nome";
            // 
            // tbNomeTarefa
            // 
            tbNomeTarefa.Location = new Point(304, 115);
            tbNomeTarefa.Name = "tbNomeTarefa";
            tbNomeTarefa.Size = new Size(166, 23);
            tbNomeTarefa.TabIndex = 2;
            // 
            // tbIdTarefa
            // 
            tbIdTarefa.Location = new Point(304, 77);
            tbIdTarefa.Name = "tbIdTarefa";
            tbIdTarefa.Size = new Size(84, 23);
            tbIdTarefa.TabIndex = 4;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            id.Location = new Point(265, 72);
            id.Name = "id";
            id.Size = new Size(28, 25);
            id.TabIndex = 3;
            id.Text = "Id";
            id.Click += id_Click;
            // 
            // tbPrioridadeTarefa
            // 
            tbPrioridadeTarefa.Location = new Point(304, 155);
            tbPrioridadeTarefa.Name = "tbPrioridadeTarefa";
            tbPrioridadeTarefa.Size = new Size(119, 23);
            tbPrioridadeTarefa.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(198, 155);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 5;
            label2.Text = "Prioridade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(274, 9);
            label1.Name = "label1";
            label1.Size = new Size(237, 37);
            label1.TabIndex = 7;
            label1.Text = "Cadastro de Tarefa";
            // 
            // TelaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(tbPrioridadeTarefa);
            Controls.Add(label2);
            Controls.Add(tbIdTarefa);
            Controls.Add(id);
            Controls.Add(tbNomeTarefa);
            Controls.Add(txtNome);
            Name = "TelaTarefaForm";
            Text = "TelaTarefaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtNome;
        private TextBox tbNomeTarefa;
        private TextBox tbIdTarefa;
        private Label id;
        private TextBox tbPrioridadeTarefa;
        private Label label2;
        private Label label1;
    }
}