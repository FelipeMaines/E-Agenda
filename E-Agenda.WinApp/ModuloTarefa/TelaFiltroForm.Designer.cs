namespace E_Agenda.WinApp.ModuloTarefa
{
    partial class TelaFiltroForm
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
            button2 = new Button();
            btnFiltrar = new Button();
            gbOpcoes = new GroupBox();
            radioTarefas = new RadioButton();
            radioAberto = new RadioButton();
            radioConcluido = new RadioButton();
            radioTodos = new RadioButton();
            gbOpcoes.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(372, 251);
            button2.Name = "button2";
            button2.Size = new Size(80, 62);
            button2.TabIndex = 9;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            btnFiltrar.DialogResult = DialogResult.OK;
            btnFiltrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFiltrar.Location = new Point(286, 251);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(80, 62);
            btnFiltrar.TabIndex = 8;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // gbOpcoes
            // 
            gbOpcoes.Controls.Add(radioTarefas);
            gbOpcoes.Controls.Add(radioAberto);
            gbOpcoes.Controls.Add(radioConcluido);
            gbOpcoes.Controls.Add(radioTodos);
            gbOpcoes.Location = new Point(259, 82);
            gbOpcoes.Name = "gbOpcoes";
            gbOpcoes.Size = new Size(279, 163);
            gbOpcoes.TabIndex = 6;
            gbOpcoes.TabStop = false;
            // 
            // radioTarefas
            // 
            radioTarefas.AutoSize = true;
            radioTarefas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioTarefas.Location = new Point(0, 106);
            radioTarefas.Name = "radioTarefas";
            radioTarefas.Size = new Size(204, 25);
            radioTarefas.TabIndex = 3;
            radioTarefas.TabStop = true;
            radioTarefas.Text = "Voltar a pagina de tarefas";
            radioTarefas.UseVisualStyleBackColor = true;
            // 
            // radioAberto
            // 
            radioAberto.AutoSize = true;
            radioAberto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioAberto.Location = new Point(0, 75);
            radioAberto.Name = "radioAberto";
            radioAberto.Size = new Size(221, 25);
            radioAberto.TabIndex = 2;
            radioAberto.TabStop = true;
            radioAberto.Text = "Vizualizar tarefas em aberto";
            radioAberto.UseVisualStyleBackColor = true;
            // 
            // radioConcluido
            // 
            radioConcluido.AutoSize = true;
            radioConcluido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioConcluido.Location = new Point(0, 44);
            radioConcluido.Name = "radioConcluido";
            radioConcluido.Size = new Size(224, 25);
            radioConcluido.TabIndex = 1;
            radioConcluido.TabStop = true;
            radioConcluido.Text = "Vizualizar tarefas concluidos";
            radioConcluido.UseVisualStyleBackColor = true;
            // 
            // radioTodos
            // 
            radioTodos.AutoSize = true;
            radioTodos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioTodos.Location = new Point(0, 13);
            radioTodos.Name = "radioTodos";
            radioTodos.Size = new Size(207, 25);
            radioTodos.TabIndex = 0;
            radioTodos.TabStop = true;
            radioTodos.Text = "Vizualizar todas as tarefas";
            radioTodos.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btnFiltrar);
            Controls.Add(gbOpcoes);
            Name = "TelaFiltroForm";
            Text = "TelaFiltroForm";
            gbOpcoes.ResumeLayout(false);
            gbOpcoes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button btnFiltrar;
        private GroupBox gbOpcoes;
        private RadioButton radioAberto;
        private RadioButton radioConcluido;
        private RadioButton radioTodos;
        private RadioButton radioTarefas;
    }
}