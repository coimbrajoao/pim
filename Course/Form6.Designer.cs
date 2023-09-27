namespace Course
{
    partial class Busca
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            buscar = new Button();
            label2 = new Label();
            Editar = new Button();
            excluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(508, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 27);
            textBox1.TabIndex = 4;
            // 
            // buscar
            // 
            buscar.Location = new Point(426, 33);
            buscar.Name = "buscar";
            buscar.Size = new Size(94, 29);
            buscar.TabIndex = 5;
            buscar.Text = "buscar";
            buscar.UseVisualStyleBackColor = true;
            buscar.Click += buscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 42);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 6;
            label2.Text = "Buscar Plataforma: ";
            // 
            // Editar
            // 
            Editar.Location = new Point(248, 266);
            Editar.Name = "Editar";
            Editar.Size = new Size(123, 50);
            Editar.TabIndex = 7;
            Editar.Text = "Editar";
            Editar.UseVisualStyleBackColor = true;
            Editar.Click += Editar_Click;
            // 
            // excluir
            // 
            excluir.Location = new Point(397, 266);
            excluir.Name = "excluir";
            excluir.Size = new Size(123, 50);
            excluir.TabIndex = 8;
            excluir.Text = "Excluir";
            excluir.UseVisualStyleBackColor = true;
            excluir.Click += excluir_Click;
            // 
            // Busca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 328);
            Controls.Add(excluir);
            Controls.Add(Editar);
            Controls.Add(label2);
            Controls.Add(buscar);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Busca";
            Text = "Busca de plataforma";
            Load += Busca_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button buscar;
        private Label label2;
        private Button Editar;
        private Button excluir;
    }
}