using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;

namespace DATABASESQLSTAND
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
            dataGridView1 = new DataGridView();
            Voltar = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 218);
            dataGridView1.Margin = new Padding(6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1793, 556);
            dataGridView1.TabIndex = 1;
            // 
            // Voltar
            // 
            Voltar.Location = new Point(23, 35);
            Voltar.Margin = new Padding(5);
            Voltar.Name = "Voltar";
            Voltar.Size = new Size(153, 46);
            Voltar.TabIndex = 2;
            Voltar.Text = "VOLTAR";
            Voltar.UseVisualStyleBackColor = true;
            Voltar.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(384, 115);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(171, 69);
            button1.TabIndex = 3;
            button1.Text = "Comprados";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(564, 115);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(171, 69);
            button2.TabIndex = 4;
            button2.Text = "Vendidos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(203, 115);
            button3.Margin = new Padding(5);
            button3.Name = "button3";
            button3.Size = new Size(171, 69);
            button3.TabIndex = 5;
            button3.Text = "Em Stock";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(744, 115);
            button4.Margin = new Padding(5);
            button4.Name = "button4";
            button4.Size = new Size(171, 69);
            button4.TabIndex = 6;
            button4.Text = "Retomas";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1531, 128);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Procura";
            textBox1.Size = new Size(285, 39);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button6
            // 
            button6.Location = new Point(23, 115);
            button6.Margin = new Padding(5);
            button6.Name = "button6";
            button6.Size = new Size(171, 69);
            button6.TabIndex = 9;
            button6.Text = "Todos";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1845, 817);
            Controls.Add(button6);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Voltar);
            Controls.Add(dataGridView1);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Veículos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button Voltar;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Button button5;
        private Button button6;
    }
}