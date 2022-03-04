namespace AppControlesUI_DarienV
{
    partial class FrmControles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControles));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.chkGoogle = new System.Windows.Forms.CheckBox();
            this.chkOpera = new System.Windows.Forms.CheckBox();
            this.chkMicrosoft = new System.Windows.Forms.CheckBox();
            this.lblNavegador = new System.Windows.Forms.Label();
            this.rd800 = new System.Windows.Forms.RadioButton();
            this.rd1024 = new System.Windows.Forms.RadioButton();
            this.rd1280 = new System.Windows.Forms.RadioButton();
            this.lblResolucion = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.cmbRojo = new System.Windows.Forms.ComboBox();
            this.lblRojo = new System.Windows.Forms.Label();
            this.lblVerde = new System.Windows.Forms.Label();
            this.cmbVerde = new System.Windows.Forms.ComboBox();
            this.lblAzul = new System.Windows.Forms.Label();
            this.cmbAzul = new System.Windows.Forms.ComboBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.imgFoto = new System.Windows.Forms.PictureBox();
            this.dtpFechaNAc = new System.Windows.Forms.DateTimePicker();
            this.btnMostrarFechaNac = new System.Windows.Forms.Button();
            this.rtbBiografia = new System.Windows.Forms.RichTextBox();
            this.lblBiografia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(15, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(254, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Escriba su nombre";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNombre.Location = new System.Drawing.Point(12, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // btnMostrar
            // 
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Location = new System.Drawing.Point(313, 309);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(89, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // chkGoogle
            // 
            this.chkGoogle.AutoSize = true;
            this.chkGoogle.Location = new System.Drawing.Point(15, 125);
            this.chkGoogle.Name = "chkGoogle";
            this.chkGoogle.Size = new System.Drawing.Size(60, 17);
            this.chkGoogle.TabIndex = 3;
            this.chkGoogle.Text = "Google";
            this.chkGoogle.UseVisualStyleBackColor = true;
            // 
            // chkOpera
            // 
            this.chkOpera.AutoSize = true;
            this.chkOpera.Location = new System.Drawing.Point(15, 149);
            this.chkOpera.Name = "chkOpera";
            this.chkOpera.Size = new System.Drawing.Size(55, 17);
            this.chkOpera.TabIndex = 4;
            this.chkOpera.Text = "Opera";
            this.chkOpera.UseVisualStyleBackColor = true;
            // 
            // chkMicrosoft
            // 
            this.chkMicrosoft.AutoSize = true;
            this.chkMicrosoft.Location = new System.Drawing.Point(15, 173);
            this.chkMicrosoft.Name = "chkMicrosoft";
            this.chkMicrosoft.Size = new System.Drawing.Size(97, 17);
            this.chkMicrosoft.TabIndex = 5;
            this.chkMicrosoft.Text = "Microsoft Edge";
            this.chkMicrosoft.UseVisualStyleBackColor = true;
            // 
            // lblNavegador
            // 
            this.lblNavegador.AutoSize = true;
            this.lblNavegador.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNavegador.Location = new System.Drawing.Point(15, 104);
            this.lblNavegador.Name = "lblNavegador";
            this.lblNavegador.Size = new System.Drawing.Size(116, 13);
            this.lblNavegador.TabIndex = 6;
            this.lblNavegador.Text = "Navegador favorito";
            // 
            // rd800
            // 
            this.rd800.AutoSize = true;
            this.rd800.Location = new System.Drawing.Point(192, 125);
            this.rd800.Name = "rd800";
            this.rd800.Size = new System.Drawing.Size(71, 17);
            this.rd800.TabIndex = 7;
            this.rd800.TabStop = true;
            this.rd800.Text = "800 * 600";
            this.rd800.UseVisualStyleBackColor = true;
            // 
            // rd1024
            // 
            this.rd1024.AutoSize = true;
            this.rd1024.Location = new System.Drawing.Point(192, 149);
            this.rd1024.Name = "rd1024";
            this.rd1024.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rd1024.Size = new System.Drawing.Size(77, 17);
            this.rd1024.TabIndex = 8;
            this.rd1024.TabStop = true;
            this.rd1024.Text = "1024 * 768";
            this.rd1024.UseVisualStyleBackColor = true;
            // 
            // rd1280
            // 
            this.rd1280.AutoSize = true;
            this.rd1280.Location = new System.Drawing.Point(192, 173);
            this.rd1280.Name = "rd1280";
            this.rd1280.Size = new System.Drawing.Size(77, 17);
            this.rd1280.TabIndex = 9;
            this.rd1280.TabStop = true;
            this.rd1280.Text = "1280 * 720";
            this.rd1280.UseVisualStyleBackColor = true;
            // 
            // lblResolucion
            // 
            this.lblResolucion.AutoSize = true;
            this.lblResolucion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblResolucion.Location = new System.Drawing.Point(192, 104);
            this.lblResolucion.Name = "lblResolucion";
            this.lblResolucion.Size = new System.Drawing.Size(68, 13);
            this.lblResolucion.TabIndex = 10;
            this.lblResolucion.Text = "Resolución";
            // 
            // btnCambiar
            // 
            this.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiar.Location = new System.Drawing.Point(408, 309);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(113, 23);
            this.btnCambiar.TabIndex = 11;
            this.btnCambiar.Text = "Cambiar Resolución";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // cmbRojo
            // 
            this.cmbRojo.DisplayMember = "1,2";
            this.cmbRojo.FormattingEnabled = true;
            this.cmbRojo.Location = new System.Drawing.Point(15, 227);
            this.cmbRojo.Name = "cmbRojo";
            this.cmbRojo.Size = new System.Drawing.Size(55, 21);
            this.cmbRojo.TabIndex = 12;
            // 
            // lblRojo
            // 
            this.lblRojo.AutoSize = true;
            this.lblRojo.Location = new System.Drawing.Point(12, 208);
            this.lblRojo.Name = "lblRojo";
            this.lblRojo.Size = new System.Drawing.Size(29, 13);
            this.lblRojo.TabIndex = 13;
            this.lblRojo.Text = "Rojo";
            // 
            // lblVerde
            // 
            this.lblVerde.AutoSize = true;
            this.lblVerde.Location = new System.Drawing.Point(110, 211);
            this.lblVerde.Name = "lblVerde";
            this.lblVerde.Size = new System.Drawing.Size(35, 13);
            this.lblVerde.TabIndex = 14;
            this.lblVerde.Text = "Verde";
            // 
            // cmbVerde
            // 
            this.cmbVerde.FormattingEnabled = true;
            this.cmbVerde.Location = new System.Drawing.Point(110, 227);
            this.cmbVerde.Name = "cmbVerde";
            this.cmbVerde.Size = new System.Drawing.Size(55, 21);
            this.cmbVerde.TabIndex = 15;
            // 
            // lblAzul
            // 
            this.lblAzul.AutoSize = true;
            this.lblAzul.Location = new System.Drawing.Point(205, 210);
            this.lblAzul.Name = "lblAzul";
            this.lblAzul.Size = new System.Drawing.Size(27, 13);
            this.lblAzul.TabIndex = 16;
            this.lblAzul.Text = "Azul";
            // 
            // cmbAzul
            // 
            this.cmbAzul.FormattingEnabled = true;
            this.cmbAzul.Location = new System.Drawing.Point(208, 227);
            this.cmbAzul.Name = "cmbAzul";
            this.cmbAzul.Size = new System.Drawing.Size(52, 21);
            this.cmbAzul.TabIndex = 17;
            // 
            // btnColor
            // 
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Location = new System.Drawing.Point(313, 338);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(89, 23);
            this.btnColor.TabIndex = 18;
            this.btnColor.Text = "Cambiar Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // imgFoto
            // 
            this.imgFoto.Image = ((System.Drawing.Image)(resources.GetObject("imgFoto.Image")));
            this.imgFoto.Location = new System.Drawing.Point(308, 77);
            this.imgFoto.Name = "imgFoto";
            this.imgFoto.Size = new System.Drawing.Size(225, 211);
            this.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFoto.TabIndex = 19;
            this.imgFoto.TabStop = false;
            this.imgFoto.Click += new System.EventHandler(this.imgFoto_Click);
            // 
            // dtpFechaNAc
            // 
            this.dtpFechaNAc.Location = new System.Drawing.Point(18, 268);
            this.dtpFechaNAc.Name = "dtpFechaNAc";
            this.dtpFechaNAc.Size = new System.Drawing.Size(254, 20);
            this.dtpFechaNAc.TabIndex = 20;
            // 
            // btnMostrarFechaNac
            // 
            this.btnMostrarFechaNac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarFechaNac.Location = new System.Drawing.Point(408, 338);
            this.btnMostrarFechaNac.Name = "btnMostrarFechaNac";
            this.btnMostrarFechaNac.Size = new System.Drawing.Size(113, 23);
            this.btnMostrarFechaNac.TabIndex = 21;
            this.btnMostrarFechaNac.Text = "Mostrar Fecha";
            this.btnMostrarFechaNac.UseVisualStyleBackColor = true;
            this.btnMostrarFechaNac.Click += new System.EventHandler(this.btnMostrarFechaNac_Click);
            // 
            // rtbBiografia
            // 
            this.rtbBiografia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbBiografia.Location = new System.Drawing.Point(18, 338);
            this.rtbBiografia.Name = "rtbBiografia";
            this.rtbBiografia.Size = new System.Drawing.Size(257, 83);
            this.rtbBiografia.TabIndex = 22;
            this.rtbBiografia.Text = "";
            // 
            // lblBiografia
            // 
            this.lblBiografia.AutoSize = true;
            this.lblBiografia.Location = new System.Drawing.Point(15, 309);
            this.lblBiografia.Name = "lblBiografia";
            this.lblBiografia.Size = new System.Drawing.Size(50, 13);
            this.lblBiografia.TabIndex = 23;
            this.lblBiografia.Text = "Biografía";
            // 
            // FrmControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 440);
            this.Controls.Add(this.lblBiografia);
            this.Controls.Add(this.rtbBiografia);
            this.Controls.Add(this.btnMostrarFechaNac);
            this.Controls.Add(this.dtpFechaNAc);
            this.Controls.Add(this.imgFoto);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.cmbAzul);
            this.Controls.Add(this.lblAzul);
            this.Controls.Add(this.cmbVerde);
            this.Controls.Add(this.lblVerde);
            this.Controls.Add(this.lblRojo);
            this.Controls.Add(this.cmbRojo);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.lblResolucion);
            this.Controls.Add(this.rd1280);
            this.Controls.Add(this.rd1024);
            this.Controls.Add(this.rd800);
            this.Controls.Add(this.lblNavegador);
            this.Controls.Add(this.chkMicrosoft);
            this.Controls.Add(this.chkOpera);
            this.Controls.Add(this.chkGoogle);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Name = "FrmControles";
            this.Text = "Interfaz UI";
            this.Load += new System.EventHandler(this.FrmControles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.CheckBox chkGoogle;
        private System.Windows.Forms.CheckBox chkOpera;
        private System.Windows.Forms.CheckBox chkMicrosoft;
        private System.Windows.Forms.Label lblNavegador;
        private System.Windows.Forms.RadioButton rd800;
        private System.Windows.Forms.RadioButton rd1024;
        private System.Windows.Forms.RadioButton rd1280;
        private System.Windows.Forms.Label lblResolucion;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.ComboBox cmbRojo;
        private System.Windows.Forms.Label lblRojo;
        private System.Windows.Forms.Label lblVerde;
        private System.Windows.Forms.ComboBox cmbVerde;
        private System.Windows.Forms.Label lblAzul;
        private System.Windows.Forms.ComboBox cmbAzul;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.PictureBox imgFoto;
        private System.Windows.Forms.DateTimePicker dtpFechaNAc;
        private System.Windows.Forms.Button btnMostrarFechaNac;
        private System.Windows.Forms.RichTextBox rtbBiografia;
        private System.Windows.Forms.Label lblBiografia;
    }
}

