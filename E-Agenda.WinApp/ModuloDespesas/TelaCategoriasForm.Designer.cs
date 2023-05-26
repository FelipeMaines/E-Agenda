namespace E_Agenda.WinApp.ModuloDespesas
{
    partial class TelaCategoriasForm
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
            tbNome = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            tbRua = new TextBox();
            label3 = new Label();
            tbNumero = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // tbNome
            // 
            tbNome.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbNome.Location = new Point(361, 162);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(160, 32);
            tbNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(270, 162);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(544, 360);
            button1.Name = "button1";
            button1.Size = new Size(98, 43);
            button1.TabIndex = 2;
            button1.Text = "Gravar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(648, 360);
            button2.Name = "button2";
            button2.Size = new Size(98, 43);
            button2.TabIndex = 3;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(270, 211);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 5;
            label2.Text = "Rua";
            // 
            // tbRua
            // 
            tbRua.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbRua.Location = new Point(361, 211);
            tbRua.Name = "tbRua";
            tbRua.Size = new Size(160, 32);
            tbRua.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(270, 264);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 7;
            label3.Text = "Numero";
            // 
            // tbNumero
            // 
            tbNumero.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbNumero.Location = new Point(361, 261);
            tbNumero.Name = "tbNumero";
            tbNumero.Size = new Size(160, 32);
            tbNumero.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(247, 49);
            label4.Name = "label4";
            label4.Size = new Size(294, 37);
            label4.TabIndex = 8;
            label4.Text = "Cadastro de Categorias";
            // 
            // TelaCategoriasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbNumero);
            Controls.Add(label2);
            Controls.Add(tbRua);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(tbNome);
            Name = "TelaCategoriasForm";
            Text = "TelaCategoriasForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNome;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private TextBox tbRua;
        private Label label3;
        private TextBox tbNumero;
        private Label label4;
    }
}