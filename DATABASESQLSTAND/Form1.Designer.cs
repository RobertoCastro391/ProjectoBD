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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label23 = new Label();
            textBox17 = new TextBox();
            label26 = new Label();
            textBox18 = new TextBox();
            label27 = new Label();
            textBox19 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox12 = new TextBox();
            label17 = new Label();
            textBox14 = new TextBox();
            label18 = new Label();
            textBox3 = new TextBox();
            label13 = new Label();
            textBox5 = new TextBox();
            label14 = new Label();
            textBox8 = new TextBox();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 192);
            dataGridView1.Margin = new Padding(6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(2288, 696);
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
            label1.Location = new Point(23, 918);
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
            label2.Location = new Point(23, 993);
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
            label3.Location = new Point(23, 1070);
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
            label4.Location = new Point(544, 918);
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
            label5.Location = new Point(544, 993);
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
            label6.Location = new Point(1106, 993);
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
            label7.Location = new Point(1106, 918);
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
            label8.Location = new Point(544, 1070);
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
            label9.Location = new Point(1689, 993);
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
            label10.Location = new Point(1689, 918);
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
            label11.Location = new Point(1106, 1070);
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
            label12.Location = new Point(1689, 1070);
            label12.Name = "label12";
            label12.Size = new Size(208, 45);
            label12.TabIndex = 41;
            label12.Text = "Observações:";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox2.Location = new Point(188, 925);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(273, 40);
            textBox2.TabIndex = 42;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox4.Location = new Point(188, 1002);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(273, 40);
            textBox4.TabIndex = 44;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox6.Location = new Point(724, 1077);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(273, 40);
            textBox6.TabIndex = 46;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox7.Location = new Point(724, 1000);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(273, 40);
            textBox7.TabIndex = 47;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox10
            // 
            textBox10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox10.Location = new Point(1331, 925);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(273, 40);
            textBox10.TabIndex = 50;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // textBox11
            // 
            textBox11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox11.Location = new Point(1914, 925);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(273, 40);
            textBox11.TabIndex = 51;
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // textBox13
            // 
            textBox13.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox13.Location = new Point(1914, 1077);
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
            comboBox2.Location = new Point(188, 1077);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(273, 40);
            comboBox2.TabIndex = 54;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(724, 925);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(273, 40);
            comboBox3.TabIndex = 55;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(1331, 1075);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(273, 40);
            comboBox4.TabIndex = 56;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // comboBox5
            // 
            comboBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(1331, 1000);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(273, 40);
            comboBox5.TabIndex = 57;
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // comboBox6
            // 
            comboBox6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(1914, 998);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(273, 40);
            comboBox6.TabIndex = 58;
            comboBox6.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(3, 5);
            label23.Name = "label23";
            label23.Size = new Size(247, 45);
            label23.TabIndex = 60;
            label23.Text = "NIF Fornecedor:";
            // 
            // textBox17
            // 
            textBox17.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox17.Location = new Point(256, 12);
            textBox17.Multiline = true;
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(273, 40);
            textBox17.TabIndex = 85;
            textBox17.TextChanged += textBox17_TextChanged;
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(600, 5);
            label26.Name = "label26";
            label26.Size = new Size(286, 45);
            label26.TabIndex = 86;
            label26.Text = "Nome Fornecedor:";
            // 
            // textBox18
            // 
            textBox18.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox18.Location = new Point(908, 12);
            textBox18.Multiline = true;
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(273, 40);
            textBox18.TabIndex = 87;
            textBox18.TextChanged += textBox18_TextChanged;
            // 
            // label27
            // 
            label27.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(1280, 5);
            label27.Name = "label27";
            label27.Size = new Size(92, 45);
            label27.TabIndex = 88;
            label27.Text = "Data:";
            // 
            // textBox19
            // 
            textBox19.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox19.Location = new Point(1382, 12);
            textBox19.Multiline = true;
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(273, 40);
            textBox19.TabIndex = 89;
            textBox19.TextChanged += textBox19_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox19);
            panel1.Controls.Add(label27);
            panel1.Controls.Add(textBox18);
            panel1.Controls.Add(label26);
            panel1.Controls.Add(textBox17);
            panel1.Controls.Add(label23);
            panel1.Location = new Point(23, 1069);
            panel1.Name = "panel1";
            panel1.Size = new Size(1669, 69);
            panel1.TabIndex = 59;
            panel1.Visible = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.Controls.Add(textBox12);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(textBox14);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(label15);
            panel2.Location = new Point(12, 1053);
            panel2.Name = "panel2";
            panel2.Size = new Size(1680, 140);
            panel2.TabIndex = 60;
            panel2.Visible = false;
            // 
            // textBox12
            // 
            textBox12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox12.Location = new Point(908, 87);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(273, 40);
            textBox12.TabIndex = 99;
            textBox12.TextChanged += textBox12_TextChanged;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(600, 80);
            label17.Name = "label17";
            label17.Size = new Size(223, 45);
            label17.TabIndex = 98;
            label17.Text = "Nome Cliente:";
            // 
            // textBox14
            // 
            textBox14.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox14.Location = new Point(256, 87);
            textBox14.Multiline = true;
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(273, 40);
            textBox14.TabIndex = 97;
            textBox14.TextChanged += textBox14_TextChanged;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(3, 80);
            label18.Name = "label18";
            label18.Size = new Size(184, 45);
            label18.TabIndex = 96;
            label18.Text = "NIF Cliente:";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox3.Location = new Point(1366, 24);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(273, 40);
            textBox3.TabIndex = 95;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(1264, 17);
            label13.Name = "label13";
            label13.Size = new Size(92, 45);
            label13.TabIndex = 94;
            label13.Text = "Data:";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox5.Location = new Point(908, 24);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(273, 40);
            textBox5.TabIndex = 93;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(600, 17);
            label14.Name = "label14";
            label14.Size = new Size(290, 45);
            label14.TabIndex = 92;
            label14.Text = "Nome Funcionário:";
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox8.Location = new Point(256, 24);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(273, 40);
            textBox8.TabIndex = 91;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(3, 17);
            label15.Name = "label15";
            label15.Size = new Size(251, 45);
            label15.TabIndex = 90;
            label15.Text = "NIF Funcionário:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2340, 1205);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label23;
        private TextBox textBox17;
        private Label label26;
        private TextBox textBox18;
        private Label label27;
        private TextBox textBox19;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox3;
        private Label label13;
        private TextBox textBox5;
        private Label label14;
        private TextBox textBox8;
        private Label label15;
        private TextBox textBox12;
        private Label label17;
        private TextBox textBox14;
        private Label label18;
    }
}