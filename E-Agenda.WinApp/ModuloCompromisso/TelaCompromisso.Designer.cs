﻿namespace E_Agenda.WinApp.ModuloCompromisso
{
    partial class TelaCompromisso
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
            tbIdCompromisso = new TextBox();
            label4 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            label1 = new Label();
            vd = new Label();
            b = new Label();
            a = new Label();
            tbLocalCompromisso = new TextBox();
            label3 = new Label();
            tbAssuntoCompromisso = new TextBox();
            label2 = new Label();
            tbDateTime = new DateTimePicker();
            tbHoraInicioCompromisso = new DateTimePicker();
            tbHoraFinalCompromisso = new DateTimePicker();
            radioButtonPresencial = new RadioButton();
            radioButtonOnline = new RadioButton();
            caixaRadios = new GroupBox();
            caixaRadios.SuspendLayout();
            SuspendLayout();
            // 
            // tbIdCompromisso
            // 
            tbIdCompromisso.Anchor = AnchorStyles.None;
            tbIdCompromisso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbIdCompromisso.Location = new Point(429, 234);
            tbIdCompromisso.Name = "tbIdCompromisso";
            tbIdCompromisso.Size = new Size(240, 29);
            tbIdCompromisso.TabIndex = 30;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(391, 233);
            label4.Name = "label4";
            label4.Size = new Size(32, 30);
            label4.TabIndex = 29;
            label4.Text = "Id";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(689, 397);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 41);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnGravar.Location = new Point(584, 397);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(99, 41);
            btnGravar.TabIndex = 27;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(187, 35);
            label1.Name = "label1";
            label1.Size = new Size(416, 46);
            label1.TabIndex = 26;
            label1.Text = "Cadastro de Compromisso";
            // 
            // vd
            // 
            vd.Anchor = AnchorStyles.None;
            vd.AutoSize = true;
            vd.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            vd.Location = new Point(66, 233);
            vd.Name = "vd";
            vd.Size = new Size(57, 30);
            vd.TabIndex = 24;
            vd.Text = "Data";
            // 
            // b
            // 
            b.Anchor = AnchorStyles.None;
            b.AutoSize = true;
            b.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            b.Location = new Point(391, 192);
            b.Name = "b";
            b.Size = new Size(111, 30);
            b.TabIndex = 22;
            b.Text = "Hora Final";
            // 
            // a
            // 
            a.Anchor = AnchorStyles.None;
            a.AutoSize = true;
            a.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            a.Location = new Point(390, 148);
            a.Name = "a";
            a.Size = new Size(118, 30);
            a.TabIndex = 20;
            a.Text = "Hora Inicio";
            // 
            // tbLocalCompromisso
            // 
            tbLocalCompromisso.Anchor = AnchorStyles.None;
            tbLocalCompromisso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbLocalCompromisso.Location = new Point(136, 188);
            tbLocalCompromisso.Name = "tbLocalCompromisso";
            tbLocalCompromisso.Size = new Size(249, 29);
            tbLocalCompromisso.TabIndex = 19;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(66, 188);
            label3.Name = "label3";
            label3.Size = new Size(62, 30);
            label3.TabIndex = 18;
            label3.Text = "Local";
            // 
            // tbAssuntoCompromisso
            // 
            tbAssuntoCompromisso.Anchor = AnchorStyles.None;
            tbAssuntoCompromisso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbAssuntoCompromisso.Location = new Point(137, 148);
            tbAssuntoCompromisso.Name = "tbAssuntoCompromisso";
            tbAssuntoCompromisso.Size = new Size(240, 29);
            tbAssuntoCompromisso.TabIndex = 17;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 148);
            label2.Name = "label2";
            label2.Size = new Size(89, 30);
            label2.TabIndex = 16;
            label2.Text = "Assunto";
            // 
            // tbDateTime
            // 
            tbDateTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbDateTime.Format = DateTimePickerFormat.Short;
            tbDateTime.Location = new Point(136, 234);
            tbDateTime.Name = "tbDateTime";
            tbDateTime.Size = new Size(240, 29);
            tbDateTime.TabIndex = 31;
            // 
            // tbHoraInicioCompromisso
            // 
            tbHoraInicioCompromisso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbHoraInicioCompromisso.Format = DateTimePickerFormat.Time;
            tbHoraInicioCompromisso.Location = new Point(508, 149);
            tbHoraInicioCompromisso.Name = "tbHoraInicioCompromisso";
            tbHoraInicioCompromisso.ShowUpDown = true;
            tbHoraInicioCompromisso.Size = new Size(240, 29);
            tbHoraInicioCompromisso.TabIndex = 32;
            // 
            // tbHoraFinalCompromisso
            // 
            tbHoraFinalCompromisso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbHoraFinalCompromisso.Format = DateTimePickerFormat.Time;
            tbHoraFinalCompromisso.Location = new Point(508, 199);
            tbHoraFinalCompromisso.Name = "tbHoraFinalCompromisso";
            tbHoraFinalCompromisso.ShowUpDown = true;
            tbHoraFinalCompromisso.Size = new Size(240, 29);
            tbHoraFinalCompromisso.TabIndex = 33;
            // 
            // radioButtonPresencial
            // 
            radioButtonPresencial.AutoSize = true;
            radioButtonPresencial.ForeColor = SystemColors.ActiveCaptionText;
            radioButtonPresencial.Location = new Point(11, 10);
            radioButtonPresencial.Name = "radioButtonPresencial";
            radioButtonPresencial.Size = new Size(78, 19);
            radioButtonPresencial.TabIndex = 37;
            radioButtonPresencial.TabStop = true;
            radioButtonPresencial.Text = "Presencial";
            radioButtonPresencial.UseVisualStyleBackColor = true;
            radioButtonPresencial.CheckedChanged += radioButtonPresencial_CheckedChanged;
            // 
            // radioButtonOnline
            // 
            radioButtonOnline.AutoSize = true;
            radioButtonOnline.ForeColor = SystemColors.ActiveCaptionText;
            radioButtonOnline.Location = new Point(95, 10);
            radioButtonOnline.Name = "radioButtonOnline";
            radioButtonOnline.Size = new Size(60, 19);
            radioButtonOnline.TabIndex = 38;
            radioButtonOnline.TabStop = true;
            radioButtonOnline.Text = "Online";
            radioButtonOnline.UseVisualStyleBackColor = true;
            // 
            // caixaRadios
            // 
            caixaRadios.Controls.Add(radioButtonPresencial);
            caixaRadios.Controls.Add(radioButtonOnline);
            caixaRadios.ForeColor = SystemColors.Control;
            caixaRadios.Location = new Point(94, 269);
            caixaRadios.Name = "caixaRadios";
            caixaRadios.Size = new Size(158, 36);
            caixaRadios.TabIndex = 39;
            caixaRadios.TabStop = false;
            // 
            // TelaCompromisso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(caixaRadios);
            Controls.Add(tbHoraFinalCompromisso);
            Controls.Add(tbHoraInicioCompromisso);
            Controls.Add(tbDateTime);
            Controls.Add(tbIdCompromisso);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(label1);
            Controls.Add(vd);
            Controls.Add(b);
            Controls.Add(a);
            Controls.Add(tbLocalCompromisso);
            Controls.Add(label3);
            Controls.Add(tbAssuntoCompromisso);
            Controls.Add(label2);
            Name = "TelaCompromisso";
            Text = "TelaCompromisso";
            caixaRadios.ResumeLayout(false);
            caixaRadios.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbIdCompromisso;
        private Label label4;
        private Button btnCancelar;
        private Button btnGravar;
        private Label label1;
        private Label vd;
        private Label b;
        private Label a;
        private TextBox tbLocalCompromisso;
        private Label label3;
        private TextBox tbAssuntoCompromisso;
        private Label label2;
        private DateTimePicker tbDateTime;
        private DateTimePicker tbHoraInicioCompromisso;
        private DateTimePicker tbHoraFinalCompromisso;
        private RadioButton radioButtonPresencial;
        private RadioButton radioButtonOnline;
        private GroupBox caixaRadios;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}