namespace AplicacionWindows
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBoxVehiculo = new System.Windows.Forms.TextBox();
            this.cbxCodigoVehiculo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxEmpleado = new System.Windows.Forms.TextBox();
            this.cbxCodEmpleado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtimePkFecha = new System.Windows.Forms.DateTimePicker();
            this.dtGridViajes = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtimePkFecha);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTROS DE BUSQUEDA";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(583, 97);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(211, 26);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar!";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(615, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "FECHA DE SELECCION : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBoxVehiculo);
            this.groupBox3.Controls.Add(this.cbxCodigoVehiculo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(296, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 142);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion vehiculo";
            // 
            // txtBoxVehiculo
            // 
            this.txtBoxVehiculo.Location = new System.Drawing.Point(6, 52);
            this.txtBoxVehiculo.Multiline = true;
            this.txtBoxVehiculo.Name = "txtBoxVehiculo";
            this.txtBoxVehiculo.ReadOnly = true;
            this.txtBoxVehiculo.Size = new System.Drawing.Size(269, 84);
            this.txtBoxVehiculo.TabIndex = 3;
            // 
            // cbxCodigoVehiculo
            // 
            this.cbxCodigoVehiculo.FormattingEnabled = true;
            this.cbxCodigoVehiculo.Location = new System.Drawing.Point(141, 19);
            this.cbxCodigoVehiculo.Name = "cbxCodigoVehiculo";
            this.cbxCodigoVehiculo.Size = new System.Drawing.Size(134, 21);
            this.cbxCodigoVehiculo.TabIndex = 0;
            this.cbxCodigoVehiculo.SelectedValueChanged += new System.EventHandler(this.cbxCodigoVehiculo_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "CODIGO VEHICULO :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxEmpleado);
            this.groupBox2.Controls.Add(this.cbxCodEmpleado);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(9, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 142);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion empleado";
            // 
            // txtBoxEmpleado
            // 
            this.txtBoxEmpleado.Location = new System.Drawing.Point(6, 52);
            this.txtBoxEmpleado.Multiline = true;
            this.txtBoxEmpleado.Name = "txtBoxEmpleado";
            this.txtBoxEmpleado.ReadOnly = true;
            this.txtBoxEmpleado.Size = new System.Drawing.Size(269, 84);
            this.txtBoxEmpleado.TabIndex = 2;
            // 
            // cbxCodEmpleado
            // 
            this.cbxCodEmpleado.FormattingEnabled = true;
            this.cbxCodEmpleado.Location = new System.Drawing.Point(142, 19);
            this.cbxCodEmpleado.Name = "cbxCodEmpleado";
            this.cbxCodEmpleado.Size = new System.Drawing.Size(132, 21);
            this.cbxCodEmpleado.TabIndex = 0;
            this.cbxCodEmpleado.SelectedValueChanged += new System.EventHandler(this.cbxCodEmpleado_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CODIGO EMPLEADO:";
            // 
            // dtimePkFecha
            // 
            this.dtimePkFecha.Location = new System.Drawing.Point(583, 71);
            this.dtimePkFecha.Name = "dtimePkFecha";
            this.dtimePkFecha.Size = new System.Drawing.Size(211, 20);
            this.dtimePkFecha.TabIndex = 4;
            // 
            // dtGridViajes
            // 
            this.dtGridViajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViajes.Location = new System.Drawing.Point(12, 188);
            this.dtGridViajes.Name = "dtGridViajes";
            this.dtGridViajes.Size = new System.Drawing.Size(804, 350);
            this.dtGridViajes.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 560);
            this.Controls.Add(this.dtGridViajes);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente Entregando SAS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBoxVehiculo;
        private System.Windows.Forms.ComboBox cbxCodigoVehiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxEmpleado;
        private System.Windows.Forms.ComboBox cbxCodEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtimePkFecha;
        private System.Windows.Forms.DataGridView dtGridViajes;
    }
}

