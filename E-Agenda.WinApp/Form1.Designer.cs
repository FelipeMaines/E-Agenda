namespace E_Agenda.WinApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            contatosMenuItem = new ToolStripMenuItem();
            tarefasMenuItem = new ToolStripMenuItem();
            compromissosMenuItem = new ToolStripMenuItem();
            despesasToolStripMenuItem = new ToolStripMenuItem();
            despesasToolStripMenuItem1 = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            relatoriosToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            rodaPe = new ToolStripStatusLabel();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolStrip1 = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            btnFiltro = new ToolStripButton();
            btnAdiconarItem = new ToolStripButton();
            btnConcluirItens = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            labelTipoCadastro = new ToolStripLabel();
            panelRegistros = new Panel();
            menuStrip.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.InactiveCaption;
            menuStrip.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, relatoriosToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(664, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contatosMenuItem, tarefasMenuItem, compromissosMenuItem, despesasToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // contatosMenuItem
            // 
            contatosMenuItem.Name = "contatosMenuItem";
            contatosMenuItem.Size = new Size(154, 22);
            contatosMenuItem.Text = "Contatos";
            contatosMenuItem.Click += contatosMenuItem_Click;
            // 
            // tarefasMenuItem
            // 
            tarefasMenuItem.Name = "tarefasMenuItem";
            tarefasMenuItem.Size = new Size(154, 22);
            tarefasMenuItem.Text = "Tarefas";
            tarefasMenuItem.Click += tarefasMenuItem_Click;
            // 
            // compromissosMenuItem
            // 
            compromissosMenuItem.Name = "compromissosMenuItem";
            compromissosMenuItem.Size = new Size(154, 22);
            compromissosMenuItem.Text = "Compromissos";
            compromissosMenuItem.Click += compromissosMenuItem_Click;
            // 
            // despesasToolStripMenuItem
            // 
            despesasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { despesasToolStripMenuItem1, categoriasToolStripMenuItem });
            despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            despesasToolStripMenuItem.Size = new Size(154, 22);
            despesasToolStripMenuItem.Text = "Despesas";
            // 
            // despesasToolStripMenuItem1
            // 
            despesasToolStripMenuItem1.Name = "despesasToolStripMenuItem1";
            despesasToolStripMenuItem1.Size = new Size(130, 22);
            despesasToolStripMenuItem1.Text = "Despesas";
            despesasToolStripMenuItem1.Click += despesasToolStripMenuItem1_Click;
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(130, 22);
            categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // relatoriosToolStripMenuItem
            // 
            relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            relatoriosToolStripMenuItem.Size = new Size(71, 20);
            relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.GradientActiveCaption;
            statusStrip1.Items.AddRange(new ToolStripItem[] { rodaPe });
            statusStrip1.Location = new Point(0, 440);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(664, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // rodaPe
            // 
            rodaPe.Name = "rodaPe";
            rodaPe.Size = new Size(118, 17);
            rodaPe.Text = "toolStripStatusLabel1";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ButtonHighlight;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, btnFiltro, btnAdiconarItem, btnConcluirItens, toolStripSeparator1, labelTipoCadastro });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(664, 37);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.BackColor = SystemColors.ActiveCaption;
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Image = Properties.Resources.add_FILL0_wght400_GRAD0_opsz24;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(7);
            btnInserir.Size = new Size(34, 34);
            btnInserir.Text = "toolStripButton1";
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = Properties.Resources.edit_FILL0_wght400_GRAD0_opsz24;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(7);
            btnEditar.Size = new Size(34, 34);
            btnEditar.Text = "toolStripButton2";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = SystemColors.ActiveCaption;
            btnExcluir.BackgroundImageLayout = ImageLayout.Center;
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = Properties.Resources.delete_FILL0_wght400_GRAD0_opsz24;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(7);
            btnExcluir.Size = new Size(34, 34);
            btnExcluir.Text = "toolStripButton3";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnFiltro
            // 
            btnFiltro.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFiltro.Image = Properties.Resources.filter_alt_FILL0_wght400_GRAD0_opsz24;
            btnFiltro.ImageTransparentColor = Color.Magenta;
            btnFiltro.Margin = new Padding(7);
            btnFiltro.Name = "btnFiltro";
            btnFiltro.Size = new Size(23, 23);
            btnFiltro.Text = "toolStripButton1";
            btnFiltro.ToolTipText = "toolStripButton4";
            btnFiltro.Click += toolStripbtnFiltro_Click;
            // 
            // btnAdiconarItem
            // 
            btnAdiconarItem.BackColor = SystemColors.ActiveCaption;
            btnAdiconarItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdiconarItem.Image = Properties.Resources.note_add_FILL0_wght400_GRAD0_opsz24;
            btnAdiconarItem.ImageTransparentColor = Color.Magenta;
            btnAdiconarItem.Name = "btnAdiconarItem";
            btnAdiconarItem.Padding = new Padding(7);
            btnAdiconarItem.Size = new Size(34, 34);
            btnAdiconarItem.Text = "toolStripButton1";
            btnAdiconarItem.ToolTipText = "toolStripButton5";
            btnAdiconarItem.Click += btnAdicionaItens_Click_1;
            // 
            // btnConcluirItens
            // 
            btnConcluirItens.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnConcluirItens.Image = Properties.Resources.check_FILL0_wght400_GRAD0_opsz24;
            btnConcluirItens.ImageTransparentColor = Color.Magenta;
            btnConcluirItens.Margin = new Padding(0);
            btnConcluirItens.Name = "btnConcluirItens";
            btnConcluirItens.Padding = new Padding(7);
            btnConcluirItens.Size = new Size(34, 37);
            btnConcluirItens.Text = "toolStripButton1";
            btnConcluirItens.ToolTipText = "toolStripButton6";
            btnConcluirItens.Click += btnConcluirItens_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 37);
            // 
            // labelTipoCadastro
            // 
            labelTipoCadastro.BackColor = SystemColors.ControlDark;
            labelTipoCadastro.Name = "labelTipoCadastro";
            labelTipoCadastro.Size = new Size(77, 34);
            labelTipoCadastro.Text = "TipoCadastro";
            // 
            // panelRegistros
            // 
            panelRegistros.BackColor = SystemColors.ActiveCaption;
            panelRegistros.BorderStyle = BorderStyle.FixedSingle;
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 61);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(664, 379);
            panelRegistros.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 462);
            Controls.Add(panelRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Agenda 1.0";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem contatosMenuItem;
        private ToolStripMenuItem tarefasMenuItem;
        private ToolStripMenuItem compromissosMenuItem;
        private ToolStripMenuItem despesasToolStripMenuItem;
        private ToolStripMenuItem despesasToolStripMenuItem1;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem relatoriosToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel rodaPe;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolStrip toolStrip1;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private Panel panelRegistros;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel labelTipoCadastro;
        private ToolStripButton btnFiltro;
        private ToolStripButton btnAdiconarItem;
        private ToolStripButton btnConcluirItens;
    }
}