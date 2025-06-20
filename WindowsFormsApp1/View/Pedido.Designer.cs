namespace WindowsFormsApp1
{
    partial class Pedido
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.nombreMedicamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.tipoMedicamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxDistribuidor = new System.Windows.Forms.GroupBox();
            this.radioBtnCemefar = new System.Windows.Forms.RadioButton();
            this.radioBtnEmpsephar = new System.Windows.Forms.RadioButton();
            this.radioBtnCofarma = new System.Windows.Forms.RadioButton();
            this.checkBoxPrincipal = new System.Windows.Forms.CheckBox();
            this.checkBoxSecundaria = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.groupBoxDistribuidor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(134)))), ((int)(((byte)(34)))));
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(134)))), ((int)(((byte)(34)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(134)))), ((int)(((byte)(34)))));
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(134)))), ((int)(((byte)(34)))));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(252, 662);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(112, 35);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombreMedicamento
            // 
            this.nombreMedicamento.AccessibleName = "nombreMedicamento";
            this.nombreMedicamento.Location = new System.Drawing.Point(96, 145);
            this.nombreMedicamento.Name = "nombreMedicamento";
            this.nombreMedicamento.Size = new System.Drawing.Size(230, 26);
            this.nombreMedicamento.TabIndex = 2;
            this.nombreMedicamento.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 76);
            this.label2.TabIndex = 6;
            this.label2.Text = "Formulario de solicitud\r\nde medicamentos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(91, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del medicamento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cantidad
            // 
            this.cantidad.AccessibleName = "cantidad";
            this.cantidad.Location = new System.Drawing.Point(96, 302);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(230, 26);
            this.cantidad.TabIndex = 8;
            // 
            // tipoMedicamento
            // 
            this.tipoMedicamento.AccessibleName = "tipoMedicamento";
            this.tipoMedicamento.FormattingEnabled = true;
            this.tipoMedicamento.Items.AddRange(new object[] {
            "Analgésico",
            "Analéptico",
            "Anestésico",
            "Antiácido",
            "Antidepresivo",
            "Antibiótico"});
            this.tipoMedicamento.Location = new System.Drawing.Point(96, 223);
            this.tipoMedicamento.Name = "tipoMedicamento";
            this.tipoMedicamento.Size = new System.Drawing.Size(230, 28);
            this.tipoMedicamento.TabIndex = 9;
            this.tipoMedicamento.SelectedIndexChanged += new System.EventHandler(this.tipoMedicamento_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo de medicamento";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBoxDistribuidor
            // 
            this.groupBoxDistribuidor.Controls.Add(this.radioBtnCemefar);
            this.groupBoxDistribuidor.Controls.Add(this.radioBtnEmpsephar);
            this.groupBoxDistribuidor.Controls.Add(this.radioBtnCofarma);
            this.groupBoxDistribuidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDistribuidor.Location = new System.Drawing.Point(76, 359);
            this.groupBoxDistribuidor.Name = "groupBoxDistribuidor";
            this.groupBoxDistribuidor.Size = new System.Drawing.Size(300, 160);
            this.groupBoxDistribuidor.TabIndex = 11;
            this.groupBoxDistribuidor.TabStop = false;
            this.groupBoxDistribuidor.Text = "Nombre del distribuidor";
            this.groupBoxDistribuidor.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioBtnCemefar
            // 
            this.radioBtnCemefar.AutoSize = true;
            this.radioBtnCemefar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.radioBtnCemefar.Location = new System.Drawing.Point(14, 105);
            this.radioBtnCemefar.Name = "radioBtnCemefar";
            this.radioBtnCemefar.Size = new System.Drawing.Size(118, 29);
            this.radioBtnCemefar.TabIndex = 2;
            this.radioBtnCemefar.TabStop = true;
            this.radioBtnCemefar.Text = "Cemefar";
            this.radioBtnCemefar.UseVisualStyleBackColor = true;
            // 
            // radioBtnEmpsephar
            // 
            this.radioBtnEmpsephar.AutoSize = true;
            this.radioBtnEmpsephar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnEmpsephar.Location = new System.Drawing.Point(14, 71);
            this.radioBtnEmpsephar.Name = "radioBtnEmpsephar";
            this.radioBtnEmpsephar.Size = new System.Drawing.Size(152, 29);
            this.radioBtnEmpsephar.TabIndex = 1;
            this.radioBtnEmpsephar.TabStop = true;
            this.radioBtnEmpsephar.Text = "Empsephar ";
            this.radioBtnEmpsephar.UseVisualStyleBackColor = true;
            // 
            // radioBtnCofarma
            // 
            this.radioBtnCofarma.AutoSize = true;
            this.radioBtnCofarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.radioBtnCofarma.Location = new System.Drawing.Point(14, 37);
            this.radioBtnCofarma.Name = "radioBtnCofarma";
            this.radioBtnCofarma.Size = new System.Drawing.Size(118, 29);
            this.radioBtnCofarma.TabIndex = 0;
            this.radioBtnCofarma.TabStop = true;
            this.radioBtnCofarma.Text = "Cofarma";
            this.radioBtnCofarma.UseVisualStyleBackColor = true;
            this.radioBtnCofarma.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // checkBoxPrincipal
            // 
            this.checkBoxPrincipal.AutoSize = true;
            this.checkBoxPrincipal.Location = new System.Drawing.Point(96, 569);
            this.checkBoxPrincipal.Name = "checkBoxPrincipal";
            this.checkBoxPrincipal.Size = new System.Drawing.Size(94, 24);
            this.checkBoxPrincipal.TabIndex = 12;
            this.checkBoxPrincipal.Text = "Principal";
            this.checkBoxPrincipal.UseVisualStyleBackColor = true;
            this.checkBoxPrincipal.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxSecundaria
            // 
            this.checkBoxSecundaria.AutoSize = true;
            this.checkBoxSecundaria.Location = new System.Drawing.Point(226, 569);
            this.checkBoxSecundaria.Name = "checkBoxSecundaria";
            this.checkBoxSecundaria.Size = new System.Drawing.Size(116, 24);
            this.checkBoxSecundaria.TabIndex = 13;
            this.checkBoxSecundaria.Text = "Secundaria";
            this.checkBoxSecundaria.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sucursal";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(34)))), ((int)(((byte)(32)))));
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(34)))), ((int)(((byte)(32)))));
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(34)))), ((int)(((byte)(32)))));
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(34)))), ((int)(((byte)(32)))));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(96, 662);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(112, 35);
            this.btnBorrar.TabIndex = 15;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(245)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(454, 746);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxSecundaria);
            this.Controls.Add(this.checkBoxPrincipal);
            this.Controls.Add(this.groupBoxDistribuidor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tipoMedicamento);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreMedicamento);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label1);
            this.Name = "Pedido";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDistribuidor.ResumeLayout(false);
            this.groupBoxDistribuidor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox nombreMedicamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.ComboBox tipoMedicamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxDistribuidor;
        private System.Windows.Forms.RadioButton radioBtnCofarma;
        private System.Windows.Forms.RadioButton radioBtnCemefar;
        private System.Windows.Forms.RadioButton radioBtnEmpsephar;
        private System.Windows.Forms.CheckBox checkBoxPrincipal;
        private System.Windows.Forms.CheckBox checkBoxSecundaria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBorrar;
    }
}

