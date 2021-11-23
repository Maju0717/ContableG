
namespace ContableG
{
    partial class Home
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
            this.dtgvLibrodiarios = new System.Windows.Forms.DataGridView();
            this.lfecha = new System.Windows.Forms.Label();
            this.textfecha = new System.Windows.Forms.TextBox();
            this.lcodigcuenta = new System.Windows.Forms.Label();
            this.textcodigo = new System.Windows.Forms.TextBox();
            this.textcuenta = new System.Windows.Forms.TextBox();
            this.lcuenta = new System.Windows.Forms.Label();
            this.textdebe = new System.Windows.Forms.TextBox();
            this.ldebe = new System.Windows.Forms.Label();
            this.texthaber = new System.Windows.Forms.TextBox();
            this.lhaber = new System.Windows.Forms.Label();
            this.bagregar = new System.Windows.Forms.Button();
            this.textdescripcion = new System.Windows.Forms.TextBox();
            this.ldescripcion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLibrodiarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvLibrodiarios
            // 
            this.dtgvLibrodiarios.AllowUserToOrderColumns = true;
            this.dtgvLibrodiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLibrodiarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Fecha,
            this.Codigo,
            this.Cuenta,
            this.Descripcion,
            this.Debe,
            this.Haber});
            this.dtgvLibrodiarios.Location = new System.Drawing.Point(2, 278);
            this.dtgvLibrodiarios.Name = "dtgvLibrodiarios";
            this.dtgvLibrodiarios.RowHeadersWidth = 62;
            this.dtgvLibrodiarios.RowTemplate.Height = 28;
            this.dtgvLibrodiarios.Size = new System.Drawing.Size(1042, 284);
            this.dtgvLibrodiarios.TabIndex = 0;
            this.dtgvLibrodiarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLibrodiarios_CellContentClick);
            // 
            // lfecha
            // 
            this.lfecha.AutoSize = true;
            this.lfecha.Location = new System.Drawing.Point(51, 21);
            this.lfecha.Name = "lfecha";
            this.lfecha.Size = new System.Drawing.Size(54, 20);
            this.lfecha.TabIndex = 1;
            this.lfecha.Text = "Fecha";
            this.lfecha.Click += new System.EventHandler(this.label1_Click);
            // 
            // textfecha
            // 
            this.textfecha.Location = new System.Drawing.Point(191, 15);
            this.textfecha.Name = "textfecha";
            this.textfecha.Size = new System.Drawing.Size(100, 26);
            this.textfecha.TabIndex = 2;
            this.textfecha.TextChanged += new System.EventHandler(this.textfecha_TextChanged);
            // 
            // lcodigcuenta
            // 
            this.lcodigcuenta.AutoSize = true;
            this.lcodigcuenta.Location = new System.Drawing.Point(51, 52);
            this.lcodigcuenta.Name = "lcodigcuenta";
            this.lcodigcuenta.Size = new System.Drawing.Size(115, 20);
            this.lcodigcuenta.TabIndex = 3;
            this.lcodigcuenta.Text = "Código Cuenta";
            // 
            // textcodigo
            // 
            this.textcodigo.Location = new System.Drawing.Point(191, 52);
            this.textcodigo.Name = "textcodigo";
            this.textcodigo.Size = new System.Drawing.Size(100, 26);
            this.textcodigo.TabIndex = 4;
            // 
            // textcuenta
            // 
            this.textcuenta.Location = new System.Drawing.Point(191, 90);
            this.textcuenta.Name = "textcuenta";
            this.textcuenta.Size = new System.Drawing.Size(100, 26);
            this.textcuenta.TabIndex = 6;
            // 
            // lcuenta
            // 
            this.lcuenta.AutoSize = true;
            this.lcuenta.Location = new System.Drawing.Point(51, 90);
            this.lcuenta.Name = "lcuenta";
            this.lcuenta.Size = new System.Drawing.Size(61, 20);
            this.lcuenta.TabIndex = 5;
            this.lcuenta.Text = "Cuenta";
            // 
            // textdebe
            // 
            this.textdebe.Location = new System.Drawing.Point(191, 172);
            this.textdebe.Name = "textdebe";
            this.textdebe.Size = new System.Drawing.Size(100, 26);
            this.textdebe.TabIndex = 8;
            this.textdebe.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ldebe
            // 
            this.ldebe.AutoSize = true;
            this.ldebe.Location = new System.Drawing.Point(51, 172);
            this.ldebe.Name = "ldebe";
            this.ldebe.Size = new System.Drawing.Size(48, 20);
            this.ldebe.TabIndex = 7;
            this.ldebe.Text = "Debe";
            this.ldebe.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // texthaber
            // 
            this.texthaber.Location = new System.Drawing.Point(191, 214);
            this.texthaber.Name = "texthaber";
            this.texthaber.Size = new System.Drawing.Size(100, 26);
            this.texthaber.TabIndex = 10;
            // 
            // lhaber
            // 
            this.lhaber.AutoSize = true;
            this.lhaber.Location = new System.Drawing.Point(51, 214);
            this.lhaber.Name = "lhaber";
            this.lhaber.Size = new System.Drawing.Size(53, 20);
            this.lhaber.TabIndex = 9;
            this.lhaber.Text = "Haber";
            this.lhaber.Click += new System.EventHandler(this.lhaber_Click);
            // 
            // bagregar
            // 
            this.bagregar.Location = new System.Drawing.Point(357, 104);
            this.bagregar.Name = "bagregar";
            this.bagregar.Size = new System.Drawing.Size(93, 51);
            this.bagregar.TabIndex = 11;
            this.bagregar.Text = "Agregar";
            this.bagregar.UseVisualStyleBackColor = true;
            this.bagregar.Click += new System.EventHandler(this.bagregar_Click);
            // 
            // textdescripcion
            // 
            this.textdescripcion.Location = new System.Drawing.Point(191, 129);
            this.textdescripcion.Name = "textdescripcion";
            this.textdescripcion.Size = new System.Drawing.Size(100, 26);
            this.textdescripcion.TabIndex = 14;
            // 
            // ldescripcion
            // 
            this.ldescripcion.AutoSize = true;
            this.ldescripcion.Location = new System.Drawing.Point(51, 125);
            this.ldescripcion.Name = "ldescripcion";
            this.ldescripcion.Size = new System.Drawing.Size(92, 20);
            this.ldescripcion.TabIndex = 13;
            this.ldescripcion.Text = "Descripción";
            this.ldescripcion.Click += new System.EventHandler(this.ldescripcion_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(598, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(384, 68);
            this.label6.TabIndex = 20;
            this.label6.Text = "Recuerde ingresar solo valores positivos";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(612, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(338, 55);
            this.label7.TabIndex = 30;
            this.label7.Text = "Debe llenar todos los campos ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // id
            // 
            this.id.HeaderText = "N° de Linea";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 8;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 150;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 150;
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta ";
            this.Cuenta.MinimumWidth = 8;
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.ReadOnly = true;
            this.Cuenta.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 150;
            // 
            // Debe
            // 
            this.Debe.HeaderText = "Debe";
            this.Debe.MinimumWidth = 8;
            this.Debe.Name = "Debe";
            this.Debe.ReadOnly = true;
            this.Debe.Width = 150;
            // 
            // Haber
            // 
            this.Haber.HeaderText = "Haber";
            this.Haber.MinimumWidth = 8;
            this.Haber.Name = "Haber";
            this.Haber.ReadOnly = true;
            this.Haber.Width = 150;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 574);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textdescripcion);
            this.Controls.Add(this.ldescripcion);
            this.Controls.Add(this.bagregar);
            this.Controls.Add(this.texthaber);
            this.Controls.Add(this.lhaber);
            this.Controls.Add(this.textdebe);
            this.Controls.Add(this.ldebe);
            this.Controls.Add(this.textcuenta);
            this.Controls.Add(this.lcuenta);
            this.Controls.Add(this.textcodigo);
            this.Controls.Add(this.lcodigcuenta);
            this.Controls.Add(this.textfecha);
            this.Controls.Add(this.lfecha);
            this.Controls.Add(this.dtgvLibrodiarios);
            this.Name = "Home";
            this.Text = "Libro Diario - Agregar";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLibrodiarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvLibrodiarios;
        private System.Windows.Forms.Label lfecha;
        private System.Windows.Forms.TextBox textfecha;
        private System.Windows.Forms.Label lcodigcuenta;
        private System.Windows.Forms.TextBox textcodigo;
        private System.Windows.Forms.TextBox textcuenta;
        private System.Windows.Forms.Label lcuenta;
        private System.Windows.Forms.TextBox textdebe;
        private System.Windows.Forms.Label ldebe;
        private System.Windows.Forms.TextBox texthaber;
        private System.Windows.Forms.Label lhaber;
        private System.Windows.Forms.Button bagregar;
        private System.Windows.Forms.TextBox textdescripcion;
        private System.Windows.Forms.Label ldescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Haber;
    }
}