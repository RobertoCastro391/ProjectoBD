namespace DATABASESQLSTAND
{
    partial class Menu
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
            STANDS = new Button();
            CLIENTES = new Button();
            FUNCIONÁRIOS = new Button();
            FORNECEDORES = new Button();
            VEÍCULOS = new Button();
            REGISTO = new Button();
            OPÇÕES = new Button();
            SuspendLayout();
            // 
            // STANDS
            // 
            STANDS.Location = new Point(21, 98);
            STANDS.Name = "STANDS";
            STANDS.Size = new Size(169, 61);
            STANDS.TabIndex = 0;
            STANDS.Text = "STANDS";
            STANDS.UseVisualStyleBackColor = true;
            STANDS.Click += STANDS_Click;
            // 
            // CLIENTES
            // 
            CLIENTES.Location = new Point(216, 98);
            CLIENTES.Name = "CLIENTES";
            CLIENTES.Size = new Size(169, 61);
            CLIENTES.TabIndex = 1;
            CLIENTES.Text = "CLIENTES";
            CLIENTES.UseVisualStyleBackColor = true;
            CLIENTES.Click += CLIENTES_Click;
            // 
            // FUNCIONÁRIOS
            // 
            FUNCIONÁRIOS.Location = new Point(408, 98);
            FUNCIONÁRIOS.Name = "FUNCIONÁRIOS";
            FUNCIONÁRIOS.Size = new Size(169, 61);
            FUNCIONÁRIOS.TabIndex = 2;
            FUNCIONÁRIOS.Text = "FUNCIONÁRIOS";
            FUNCIONÁRIOS.UseVisualStyleBackColor = true;
            FUNCIONÁRIOS.Click += FUNCIONÁRIOS_Click;
            // 
            // FORNECEDORES
            // 
            FORNECEDORES.Location = new Point(602, 98);
            FORNECEDORES.Name = "FORNECEDORES";
            FORNECEDORES.Size = new Size(169, 61);
            FORNECEDORES.TabIndex = 3;
            FORNECEDORES.Text = "FORNECEDORES";
            FORNECEDORES.UseVisualStyleBackColor = true;
            FORNECEDORES.Click += FORNECEDORES_Click;
            // 
            // VEÍCULOS
            // 
            VEÍCULOS.Location = new Point(127, 250);
            VEÍCULOS.Name = "VEÍCULOS";
            VEÍCULOS.Size = new Size(169, 61);
            VEÍCULOS.TabIndex = 4;
            VEÍCULOS.Text = "VEÍCULOS";
            VEÍCULOS.UseVisualStyleBackColor = true;
            VEÍCULOS.Click += button1_Click;
            // 
            // REGISTO
            // 
            REGISTO.Location = new Point(314, 250);
            REGISTO.Name = "REGISTO";
            REGISTO.Size = new Size(169, 61);
            REGISTO.TabIndex = 5;
            REGISTO.Text = "REGISTO";
            REGISTO.UseVisualStyleBackColor = true;
            REGISTO.Click += REGISTO_Click;
            // 
            // OPÇÕES
            // 
            OPÇÕES.Location = new Point(511, 250);
            OPÇÕES.Name = "OPÇÕES";
            OPÇÕES.Size = new Size(169, 61);
            OPÇÕES.TabIndex = 6;
            OPÇÕES.Text = "OPÇÕES";
            OPÇÕES.UseVisualStyleBackColor = true;
            OPÇÕES.Click += OPÇÕES_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OPÇÕES);
            Controls.Add(REGISTO);
            Controls.Add(VEÍCULOS);
            Controls.Add(FORNECEDORES);
            Controls.Add(FUNCIONÁRIOS);
            Controls.Add(CLIENTES);
            Controls.Add(STANDS);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button STANDS;
        private Button CLIENTES;
        private Button FUNCIONÁRIOS;
        private Button FORNECEDORES;
        private Button VEÍCULOS;
        private Button REGISTO;
        private Button OPÇÕES;
    }
}