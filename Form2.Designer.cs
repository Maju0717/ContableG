
namespace ContableG
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
            this.button1 = new System.Windows.Forms.Button();
            this.dtgvLibroMayor = new System.Windows.Forms.DataGridView();
            this.textIngcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textsaldo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLibroMayor)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgvLibroMayor
            // 
            this.dtgvLibroMayor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLibroMayor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fecha,
            this.codigo,
            this.cuenta,
            this.descripcion,
            this.debe,
            this.haber});
            this.dtgvLibroMayor.Location = new System.Drawing.Point(0, 12);
            this.dtgvLibroMayor.Name = "dtgvLibroMayor";
            this.dtgvLibroMayor.RowHeadersWidth = 62;
            this.dtgvLibroMayor.RowTemplate.Height = 28;
            this.dtgvLibroMayor.Size = new System.Drawing.Size(1058, 379);
            this.dtgvLibroMayor.TabIndex = 2;
            // 
            // textIngcodigo
            // 
            this.textIngcodigo.Location = new System.Drawing.Point(280, 438);
            this.textIngcodigo.Name = "textIngcodigo";
            this.textIngcodigo.Size = new System.Drawing.Size(100, 26);
            this.textIngcodigo.TabIndex = 3;
            this.textIngcodigo.TextChanged += new System.EventHandler(this.textfecha_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese número de código cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Saldo de cuenta";
            // 
            // textsaldo
            // 
            this.textsaldo.Location = new System.Drawing.Point(280, 489);
            this.textsaldo.Name = "textsaldo";
            this.textsaldo.Size = new System.Drawing.Size(100, 26);
            this.textsaldo.TabIndex = 5;
            this.textsaldo.TextChanged += new System.EventHandler(this.textsaldo_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(473, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 61);
            this.button2.TabIndex = 7;
            this.button2.Text = "Mostrar Saldo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.fecha.HeaderText = "Fechas";
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
            this.cuenta.HeaderText = "Cuentas";
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 569);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textsaldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textIngcodigo);
            this.Controls.Add(this.dtgvLibroMayor);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "LIBRO MAYOR";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLibroMayor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgvLibroMayor;
        private System.Windows.Forms.TextBox textIngcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textsaldo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn haber;
    }
}