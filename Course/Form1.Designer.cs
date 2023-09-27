namespace Course
{
    partial class Home
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
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            jogosToolStripMenuItem = new ToolStripMenuItem();
            novoJogoToolStripMenuItem = new ToolStripMenuItem();
            buscarPorJogoToolStripMenuItem = new ToolStripMenuItem();
            plataformaToolStripMenuItem = new ToolStripMenuItem();
            novaPlataformaToolStripMenuItem = new ToolStripMenuItem();
            buscaDePlataformaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, jogosToolStripMenuItem, plataformaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(157, 449);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(142, 24);
            homeToolStripMenuItem.Text = "Home";
            // 
            // jogosToolStripMenuItem
            // 
            jogosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoJogoToolStripMenuItem, buscarPorJogoToolStripMenuItem });
            jogosToolStripMenuItem.Name = "jogosToolStripMenuItem";
            jogosToolStripMenuItem.Size = new Size(142, 24);
            jogosToolStripMenuItem.Text = "Jogos";
            // 
            // novoJogoToolStripMenuItem
            // 
            novoJogoToolStripMenuItem.Name = "novoJogoToolStripMenuItem";
            novoJogoToolStripMenuItem.Size = new Size(197, 26);
            novoJogoToolStripMenuItem.Text = "Novo Jogo";
            novoJogoToolStripMenuItem.Click += novoJogoToolStripMenuItem_Click;
            // 
            // buscarPorJogoToolStripMenuItem
            // 
            buscarPorJogoToolStripMenuItem.Name = "buscarPorJogoToolStripMenuItem";
            buscarPorJogoToolStripMenuItem.Size = new Size(197, 26);
            buscarPorJogoToolStripMenuItem.Text = "Buscar por jogo";
            buscarPorJogoToolStripMenuItem.Click += buscarPorJogoToolStripMenuItem_Click;
            // 
            // plataformaToolStripMenuItem
            // 
            plataformaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novaPlataformaToolStripMenuItem, buscaDePlataformaToolStripMenuItem });
            plataformaToolStripMenuItem.Name = "plataformaToolStripMenuItem";
            plataformaToolStripMenuItem.Size = new Size(142, 24);
            plataformaToolStripMenuItem.Text = "Plataforma";
            // 
            // novaPlataformaToolStripMenuItem
            // 
            novaPlataformaToolStripMenuItem.Name = "novaPlataformaToolStripMenuItem";
            novaPlataformaToolStripMenuItem.Size = new Size(228, 26);
            novaPlataformaToolStripMenuItem.Text = "Nova Plataforma";
            novaPlataformaToolStripMenuItem.Click += novaPlataformaToolStripMenuItem_Click;
            // 
            // buscaDePlataformaToolStripMenuItem
            // 
            buscaDePlataformaToolStripMenuItem.Name = "buscaDePlataformaToolStripMenuItem";
            buscaDePlataformaToolStripMenuItem.Size = new Size(228, 26);
            buscaDePlataformaToolStripMenuItem.Text = "Busca de Plataforma";
            buscaDePlataformaToolStripMenuItem.Click += buscaDePlataformaToolStripMenuItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home";
            Text = "Home";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem jogosToolStripMenuItem;
        private ToolStripMenuItem novoJogoToolStripMenuItem;
        private ToolStripMenuItem buscarPorJogoToolStripMenuItem;
        private ToolStripMenuItem plataformaToolStripMenuItem;
        private ToolStripMenuItem novaPlataformaToolStripMenuItem;
        private ToolStripMenuItem buscaDePlataformaToolStripMenuItem;
    }
}