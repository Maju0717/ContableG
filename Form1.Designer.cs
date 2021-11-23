
namespace ContableG
{
    partial class Form1
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
            this.dtgvLibroD = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLibroD)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvLibroD
            // 
            this.dtgvLibroD.AllowUserToOrderColumns = true;
            this.dtgvLibroD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLibroD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fecha,
            this.codigo,
            this.cuenta,
            this.descripcion,
            this.debe,
            this.haber});
            this.dtgvLibroD.Location = new System.Drawing.Point(12, 25);
            this.dtgvLibroD.Name = "dtgvLibroD";
            this.dtgvLibroD.RowHeadersWidth = 62;
            this.dtgvLibroD.RowTemplate.Height = 28;
            this.dtgvLibroD.Size = new System.Drawing.Size(1063, 352);
            this.dtgvLibroD.TabIndex = 1;
            this.dtgvLibroD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLibroD_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mostrar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(890, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 37);
            this.button2.TabIndex = 23;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(729, 417);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 26);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 47);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ingrese N° de linea";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(664, 471);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(253, 44);
            this.button3.TabIndex = 26;
            this.button3.Text = "Borrar todos los asientos";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // id
            // 
            this.id.HeaderText = "N° de Linea";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 8;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 150;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.MinimumWidth = 8;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 150;
            // 
            // cuenta
            // 
            this.cuenta.HeaderText = "Cuenta";
            this.cuenta.MinimumWidth = 8;
            this.cuenta.Name = "cuenta";
            this.cuenta.ReadOnly = true;
            this.cuenta.Width = 150;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.MinimumWidth = 8;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 150;
            // 
            // debe
            // 
            this.debe.HeaderText = "Debe";
            this.debe.MinimumWidth = 8;
            this.debe.Name = "debe";
            this.debe.ReadOnly = true;
            this.debe.Width = 150;
            // 
            // haber
            // 
            this.haber.HeaderText = "Haber";
            this.haber.MinimumWidth = 8;
            this.haber.Name = "haber";
            this.haber.ReadOnly = true;
            this.haber.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 536);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgvLibroD);
            this.Name = "Form1";
            this.Text = "Libro Diario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLibroD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvLibroD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn haber;
    }
}