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
            btnEnviarTarefa = new Button();
            btnCancelarTarefa = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.AutoSize = true;
            txtNome.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(265, 148);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(73, 30);
            txtNome.TabIndex = 1;
            txtNome.Text = "Nome";
            // 
            // tbNomeTarefa
            // 
            tbNomeTarefa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbNomeTarefa.Location = new Point(345, 148);
            tbNomeTarefa.Name = "tbNomeTarefa";
            tbNomeTarefa.Size = new Size(166, 32);
            tbNomeTarefa.TabIndex = 2;
            // 
            // tbIdTarefa
            // 
            tbIdTarefa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbIdTarefa.Location = new Point(345, 110);
            tbIdTarefa.Name = "tbIdTarefa";
            tbIdTarefa.Size = new Size(166, 32);
            tbIdTarefa.TabIndex = 4;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            id.Location = new Point(306, 109);
            id.Name = "id";
            id.Size = new Size(32, 30);
            id.TabIndex = 3;
            id.Text = "Id";
            id.Click += id_Click;
            // 
            // tbPrioridadeTarefa
            // 
            tbPrioridadeTarefa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbPrioridadeTarefa.Location = new Point(345, 188);
            tbPrioridadeTarefa.Name = "tbPrioridadeTarefa";
            tbPrioridadeTarefa.Size = new Size(166, 32);
            tbPrioridadeTarefa.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(226, 190);
            label2.Name = "label2";
            label2.Size = new Size(113, 30);
            label2.TabIndex = 5;
            label2.Text = "Prioridade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(251, 18);
            label1.Name = "label1";
            label1.Size = new Size(298, 46);
            label1.TabIndex = 7;
            label1.Text = "Cadastro de Tarefa";
            // 
            // btnEnviarTarefa
            // 
            btnEnviarTarefa.DialogResult = DialogResult.OK;
            btnEnviarTarefa.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnviarTarefa.Location = new Point(565, 399);
            btnEnviarTarefa.Name = "btnEnviarTarefa";
            btnEnviarTarefa.Size = new Size(105, 39);
            btnEnviarTarefa.TabIndex = 8;
            btnEnviarTarefa.Text = "Enviar";
            btnEnviarTarefa.UseVisualStyleBackColor = true;
            btnEnviarTarefa.Click += btnEnviarTarefa_Click;
            // 
            // btnCancelarTarefa
            // 
            btnCancelarTarefa.DialogResult = DialogResult.Cancel;
            btnCancelarTarefa.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelarTarefa.Location = new Point(676, 399);
            btnCancelarTarefa.Name = "btnCancelarTarefa";
            btnCancelarTarefa.Size = new Size(99, 39);
            btnCancelarTarefa.TabIndex = 9;
            btnCancelarTarefa.Text = "Cancelar";
            btnCancelarTarefa.UseVisualStyleBackColor = true;
            // 
            // TelaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelarTarefa);
            Controls.Add(btnEnviarTarefa);
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
        private Button btnEnviarTarefa;
        private Button btnCancelarTarefa;
    }
}