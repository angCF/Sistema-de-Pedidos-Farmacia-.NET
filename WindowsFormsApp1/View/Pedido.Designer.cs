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
            this.btnConfirmar.Location = new System.Drawing.Point(168, 430);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(56, 19);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombreMedicamento
            // 
            this.nombreMedicamento.AccessibleName = "nombreMedicamento";
            this.nombreMedicamento.Location = new System.Drawing.Point(64, 105);
            this.nombreMedicamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombreMedicamento.Name = "nombreMedicamento";
            this.nombreMedicamento.Size = new System.Drawing.Size(155, 20);
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
            this.label2.Location = new System.Drawing.Point(25, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 52);
            this.label2.TabIndex = 6;
            this.label2.Text = "Formulario de solicitud\r\nde medicamentos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(61, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del medicamento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cantidad
            // 
            this.cantidad.AccessibleName = "cantidad";
            this.cantidad.Location = new System.Drawing.Point(64, 196);
            this.cantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(155, 20);
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
            "Antibióticos"});
            this.tipoMedicamento.Location = new System.Drawing.Point(64, 154);
            this.tipoMedicamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tipoMedicamento.Name = "tipoMedicamento";
            this.tipoMedicamento.Size = new System.Drawing.Size(155, 21);
            this.tipoMedicamento.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo de medicamento";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBoxDistribuidor
            // 
            this.groupBoxDistribuidor.Controls.Add(this.radioBtnCemefar);
            this.groupBoxDistribuidor.Controls.Add(this.radioBtnEmpsephar);
            this.groupBoxDistribuidor.Controls.Add(this.radioBtnCofarma);
            this.groupBoxDistribuidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDistribuidor.Location = new System.Drawing.Point(55, 233);
            this.groupBoxDistribuidor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDistribuidor.Name = "groupBoxDistribuidor";
            this.groupBoxDistribuidor.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDistribuidor.Size = new System.Drawing.Size(185, 104);
            this.groupBoxDistribuidor.TabIndex = 11;
            this.groupBoxDistribuidor.TabStop = false;
            this.groupBoxDistribuidor.Text = "Nombre del distribuidor";
            this.groupBoxDistribuidor.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioBtnCemefar
            // 
            this.radioBtnCemefar.AutoSize = true;
            this.radioBtnCemefar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.radioBtnCemefar.Location = new System.Drawing.Point(9, 68);
            this.radioBtnCemefar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtnCemefar.Name = "radioBtnCemefar";
            this.radioBtnCemefar.Size = new System.Drawing.Size(79, 21);
            this.radioBtnCemefar.TabIndex = 2;
            this.radioBtnCemefar.TabStop = true;
            this.radioBtnCemefar.Text = "Cemefar";
            this.radioBtnCemefar.UseVisualStyleBackColor = true;
            // 
            // radioBtnEmpsephar
            // 
            this.radioBtnEmpsephar.AutoSize = true;
            this.radioBtnEmpsephar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnEmpsephar.Location = new System.Drawing.Point(9, 46);
            this.radioBtnEmpsephar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtnEmpsephar.Name = "radioBtnEmpsephar";
            this.radioBtnEmpsephar.Size = new System.Drawing.Size(102, 21);
            this.radioBtnEmpsephar.TabIndex = 1;
            this.radioBtnEmpsephar.TabStop = true;
            this.radioBtnEmpsephar.Text = "Empsephar ";
            this.radioBtnEmpsephar.UseVisualStyleBackColor = true;
            // 
            // radioBtnCofarma
            // 
            this.radioBtnCofarma.AutoSize = true;
            this.radioBtnCofarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.radioBtnCofarma.Location = new System.Drawing.Point(9, 24);
            this.radioBtnCofarma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtnCofarma.Name = "radioBtnCofarma";
            this.radioBtnCofarma.Size = new System.Drawing.Size(79, 21);
            this.radioBtnCofarma.TabIndex = 0;
            this.radioBtnCofarma.TabStop = true;
            this.radioBtnCofarma.Text = "Cofarma";
            this.radioBtnCofarma.UseVisualStyleBackColor = true;
            this.radioBtnCofarma.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // checkBoxPrincipal
            // 
            this.checkBoxPrincipal.AutoSize = true;
            this.checkBoxPrincipal.Location = new System.Drawing.Point(64, 370);
            this.checkBoxPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxPrincipal.Name = "checkBoxPrincipal";
            this.checkBoxPrincipal.Size = new System.Drawing.Size(66, 17);
            this.checkBoxPrincipal.TabIndex = 12;
            this.checkBoxPrincipal.Text = "Principal";
            this.checkBoxPrincipal.UseVisualStyleBackColor = true;
            this.checkBoxPrincipal.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxSecundaria
            // 
            this.checkBoxSecundaria.AutoSize = true;
            this.checkBoxSecundaria.Location = new System.Drawing.Point(151, 370);
            this.checkBoxSecundaria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxSecundaria.Name = "checkBoxSecundaria";
            this.checkBoxSecundaria.Size = new System.Drawing.Size(80, 17);
            this.checkBoxSecundaria.TabIndex = 13;
            this.checkBoxSecundaria.Text = "Secundaria";
            this.checkBoxSecundaria.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 339);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sucursal";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(64, 430);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(56, 19);
            this.btnBorrar.TabIndex = 15;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 485);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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

