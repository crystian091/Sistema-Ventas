namespace SistemaVentas
{
    partial class Form2
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
            this.btnConsulta1 = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnConsulta2 = new System.Windows.Forms.Button();
            this.btnConsulta3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsulta1
            // 
            this.btnConsulta1.BackColor = System.Drawing.Color.Transparent;
            this.btnConsulta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta1.ForeColor = System.Drawing.Color.Khaki;
            this.btnConsulta1.Location = new System.Drawing.Point(99, 348);
            this.btnConsulta1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsulta1.Name = "btnConsulta1";
            this.btnConsulta1.Size = new System.Drawing.Size(108, 27);
            this.btnConsulta1.TabIndex = 0;
            this.btnConsulta1.Text = "Consulta1";
            this.btnConsulta1.UseVisualStyleBackColor = false;
            this.btnConsulta1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(9, 10);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(663, 319);
            this.dgvClientes.TabIndex = 1;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // btnConsulta2
            // 
            this.btnConsulta2.BackColor = System.Drawing.Color.Transparent;
            this.btnConsulta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta2.ForeColor = System.Drawing.Color.Khaki;
            this.btnConsulta2.Location = new System.Drawing.Point(240, 348);
            this.btnConsulta2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsulta2.Name = "btnConsulta2";
            this.btnConsulta2.Size = new System.Drawing.Size(124, 27);
            this.btnConsulta2.TabIndex = 2;
            this.btnConsulta2.Text = "Consulta 2";
            this.btnConsulta2.UseVisualStyleBackColor = false;
            this.btnConsulta2.Click += new System.EventHandler(this.btnConsulta2_Click);
            // 
            // btnConsulta3
            // 
            this.btnConsulta3.BackColor = System.Drawing.Color.Transparent;
            this.btnConsulta3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta3.ForeColor = System.Drawing.Color.Khaki;
            this.btnConsulta3.Location = new System.Drawing.Point(402, 348);
            this.btnConsulta3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsulta3.Name = "btnConsulta3";
            this.btnConsulta3.Size = new System.Drawing.Size(129, 27);
            this.btnConsulta3.TabIndex = 3;
            this.btnConsulta3.Text = "Consulta3";
            this.btnConsulta3.UseVisualStyleBackColor = false;
            this.btnConsulta3.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(683, 386);
            this.Controls.Add(this.btnConsulta3);
            this.Controls.Add(this.btnConsulta2);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnConsulta1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsulta1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnConsulta2;
        private System.Windows.Forms.Button btnConsulta3;
    }
}