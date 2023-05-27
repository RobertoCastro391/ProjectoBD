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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            Voltar = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            button6 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox13 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
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
            dataGridView1.Size = new Size(2288, 631);
            dataGridView1.TabIndex = 1;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
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
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(1976, 128);
            textBox1.Margin = new Padding(5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Procura";
            textBox1.Size = new Size(335, 40);
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
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Matricula", "Marca", "Modelo", "Cor", "Cilindrada", "Ano", "Quilometros", "Combustivel", "Categoria", "Preco_Anunciado", "Nome", "Observações" });
            comboBox1.Location = new Point(1632, 128);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(327, 40);
            comboBox1.TabIndex = 29;
            comboBox1.Text = "Filtrar";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 881);
            label1.Name = "label1";
            label1.Size = new Size(159, 45);
            label1.TabIndex = 30;
            label1.Text = "Matrícula:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 956);
            label2.Name = "label2";
            label2.Size = new Size(114, 45);
            label2.TabIndex = 31;
            label2.Text = "Marca:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 1033);
            label3.Name = "label3";
            label3.Size = new Size(138, 45);
            label3.TabIndex = 32;
            label3.Text = "Modelo:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(544, 881);
            label4.Name = "label4";
            label4.Size = new Size(77, 45);
            label4.TabIndex = 33;
            label4.Text = "Cor:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(544, 956);
            label5.Name = "label5";
            label5.Size = new Size(170, 45);
            label5.TabIndex = 34;
            label5.Text = "Cilindrada:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1106, 956);
            label6.Name = "label6";
            label6.Size = new Size(204, 45);
            label6.TabIndex = 35;
            label6.Text = "Combustível:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1106, 881);
            label7.Name = "label7";
            label7.Size = new Size(204, 45);
            label7.TabIndex = 36;
            label7.Text = "Quilómetros:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(544, 1033);
            label8.Name = "label8";
            label8.Size = new Size(85, 45);
            label8.TabIndex = 37;
            label8.Text = "Ano:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(1689, 956);
            label9.Name = "label9";
            label9.Size = new Size(204, 45);
            label9.TabIndex = 38;
            label9.Text = "Nome Stand:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(1689, 881);
            label10.Name = "label10";
            label10.Size = new Size(107, 45);
            label10.TabIndex = 39;
            label10.Text = "Preço:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(1106, 1033);
            label11.Name = "label11";
            label11.Size = new Size(164, 45);
            label11.TabIndex = 40;
            label11.Text = "Categoria:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(1689, 1033);
            label12.Name = "label12";
            label12.Size = new Size(208, 45);
            label12.TabIndex = 41;
            label12.Text = "Observações:";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox2.Location = new Point(188, 888);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(273, 40);
            textBox2.TabIndex = 42;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox4.Location = new Point(188, 1040);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(273, 40);
            textBox4.TabIndex = 44;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox6.Location = new Point(724, 1040);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(273, 40);
            textBox6.TabIndex = 46;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox7.Location = new Point(724, 963);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(273, 40);
            textBox7.TabIndex = 47;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox10
            // 
            textBox10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox10.Location = new Point(1331, 888);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(273, 40);
            textBox10.TabIndex = 50;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // textBox11
            // 
            textBox11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox11.Location = new Point(1914, 888);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(273, 40);
            textBox11.TabIndex = 51;
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // textBox13
            // 
            textBox13.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox13.Location = new Point(1914, 1040);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(397, 88);
            textBox13.TabIndex = 53;
            textBox13.TextChanged += textBox13_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(188, 961);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(273, 40);
            comboBox2.TabIndex = 54;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(724, 888);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(273, 40);
            comboBox3.TabIndex = 55;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(1331, 1038);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(273, 40);
            comboBox4.TabIndex = 56;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // comboBox5
            // 
            comboBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(1331, 963);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(273, 40);
            comboBox5.TabIndex = 57;
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // comboBox6
            // 
            comboBox6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(1914, 961);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(273, 40);
            comboBox6.TabIndex = 58;
            comboBox6.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2340, 1140);
            Controls.Add(comboBox6);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(textBox13);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button6);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Voltar);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox13;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
    }
}