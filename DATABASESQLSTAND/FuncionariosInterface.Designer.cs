namespace DATABASESQLSTAND
{
    partial class FuncionariosInterface
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
            button1 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(20, 19);
            button1.Margin = new Padding(5, 5, 5, 5);
            button1.Name = "button1";
            button1.Size = new Size(153, 46);
            button1.TabIndex = 0;
            button1.Text = "VOLTAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(958, 128);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Pesquisar";
            textBox1.Size = new Size(330, 39);
            textBox1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1276, 522);
            dataGridView1.TabIndex = 9;
            // 
            // button4
            // 
            button4.Location = new Point(282, 121);
            button4.Name = "button4";
            button4.Size = new Size(207, 46);
            button4.TabIndex = 8;
            button4.Text = "Adicionar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(579, 121);
            button3.Name = "button3";
            button3.Size = new Size(207, 46);
            button3.TabIndex = 7;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 121);
            button2.Name = "button2";
            button2.Size = new Size(207, 46);
            button2.TabIndex = 6;
            button2.Text = "Alterar";
            button2.UseVisualStyleBackColor = true;
            // 
            // FuncionariosInterface
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FuncionariosInterface";
            Text = "Funcionarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}