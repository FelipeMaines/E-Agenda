namespace E_Agenda.WinApp.ModuloCompromisso
{
    partial class TelaFiltro
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
            groupBox1 = new GroupBox();
            radioFuturo = new RadioButton();
            radioPassado = new RadioButton();
            radioTodos = new RadioButton();
            gbDatasFuturo = new GroupBox();
            tbDataFinal = new DateTimePicker();
            tbDataInicial = new DateTimePicker();
            b = new Label();
            a = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            gbDatasFuturo.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioFuturo);
            groupBox1.Controls.Add(radioPassado);
            groupBox1.Controls.Add(radioTodos);
            groupBox1.Location = new Point(234, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 141);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // radioFuturo
            // 
            radioFuturo.AutoSize = true;
            radioFuturo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioFuturo.Location = new Point(0, 108);
            radioFuturo.Name = "radioFuturo";
            radioFuturo.Size = new Size(261, 25);
            radioFuturo.TabIndex = 2;
            radioFuturo.TabStop = true;
            radioFuturo.Text = "Vizualizar Compromissos Futuros";
            radioFuturo.UseVisualStyleBackColor = true;
            // 
            // radioPassado
            // 
            radioPassado.AutoSize = true;
            radioPassado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioPassado.Location = new Point(0, 65);
            radioPassado.Name = "radioPassado";
            radioPassado.Size = new Size(271, 25);
            radioPassado.TabIndex = 1;
            radioPassado.TabStop = true;
            radioPassado.Text = "Vizualizar Compromissos Passados";
            radioPassado.UseVisualStyleBackColor = true;
            // 
            // radioTodos
            // 
            radioTodos.AutoSize = true;
            radioTodos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioTodos.Location = new Point(0, 22);
            radioTodos.Name = "radioTodos";
            radioTodos.Size = new Size(264, 25);
            radioTodos.TabIndex = 0;
            radioTodos.TabStop = true;
            radioTodos.Text = "Vizualizar todos os compromissos";
            radioTodos.UseVisualStyleBackColor = true;
            // 
            // gbDatasFuturo
            // 
            gbDatasFuturo.Controls.Add(tbDataFinal);
            gbDatasFuturo.Controls.Add(tbDataInicial);
            gbDatasFuturo.Controls.Add(b);
            gbDatasFuturo.Controls.Add(a);
            gbDatasFuturo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gbDatasFuturo.Location = new Point(130, 229);
            gbDatasFuturo.Name = "gbDatasFuturo";
            gbDatasFuturo.Size = new Size(482, 141);
            gbDatasFuturo.TabIndex = 3;
            gbDatasFuturo.TabStop = false;
            gbDatasFuturo.Text = "FIltro para compromissos futuros";
            // 
            // tbDataFinal
            // 
            tbDataFinal.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbDataFinal.Format = DateTimePickerFormat.Short;
            tbDataFinal.Location = new Point(100, 85);
            tbDataFinal.Name = "tbDataFinal";
            tbDataFinal.Size = new Size(240, 21);
            tbDataFinal.TabIndex = 37;
            // 
            // tbDataInicial
            // 
            tbDataInicial.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbDataInicial.Format = DateTimePickerFormat.Short;
            tbDataInicial.Location = new Point(103, 44);
            tbDataInicial.Name = "tbDataInicial";
            tbDataInicial.Size = new Size(240, 21);
            tbDataInicial.TabIndex = 36;
            // 
            // b
            // 
            b.Anchor = AnchorStyles.None;
            b.AutoSize = true;
            b.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            b.Location = new Point(26, 85);
            b.Name = "b";
            b.Size = new Size(63, 15);
            b.TabIndex = 35;
            b.Text = "Data Final";
            // 
            // a
            // 
            a.Anchor = AnchorStyles.None;
            a.AutoSize = true;
            a.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            a.Location = new Point(26, 44);
            a.Name = "a";
            a.Size = new Size(68, 15);
            a.TabIndex = 34;
            a.Text = "Data Inicial";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(568, 376);
            button1.Name = "button1";
            button1.Size = new Size(80, 62);
            button1.TabIndex = 4;
            button1.Text = "Filtrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(654, 376);
            button2.Name = "button2";
            button2.Size = new Size(80, 62);
            button2.TabIndex = 5;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // TelaFiltro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(gbDatasFuturo);
            Controls.Add(groupBox1);
            Name = "TelaFiltro";
            Text = "TelaFiltro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbDatasFuturo.ResumeLayout(false);
            gbDatasFuturo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioFuturo;
        private RadioButton radioPassado;
        private RadioButton radioTodos;
        private GroupBox gbDatasFuturo;
        private DateTimePicker tbDataFinal;
        private DateTimePicker tbDataInicial;
        private Label b;
        private Label a;
        private Button button1;
        private Button button2;
    }
}