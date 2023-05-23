namespace main
{
    partial class frmAltaPokemon
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDebilidad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboDebilidad = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbPokemons = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemons)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(71, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(71, 78);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Número:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(52, 102);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlImagen.Location = new System.Drawing.Point(31, 126);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(87, 13);
            this.lblUrlImagen.TabIndex = 3;
            this.lblUrlImagen.Text = "Url de la Imagen:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(87, 150);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblDebilidad
            // 
            this.lblDebilidad.AutoSize = true;
            this.lblDebilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebilidad.Location = new System.Drawing.Point(64, 174);
            this.lblDebilidad.Name = "lblDebilidad";
            this.lblDebilidad.Size = new System.Drawing.Size(54, 13);
            this.lblDebilidad.TabIndex = 5;
            this.lblDebilidad.Text = "Debilidad:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(133, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(133, 123);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(179, 20);
            this.txtUrlImagen.TabIndex = 3;
            this.txtUrlImagen.TextChanged += new System.EventHandler(this.txtUrlImagen_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(133, 99);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(179, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(133, 75);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(179, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(133, 147);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(179, 21);
            this.cboTipo.TabIndex = 4;
            // 
            // cboDebilidad
            // 
            this.cboDebilidad.FormattingEnabled = true;
            this.cboDebilidad.Location = new System.Drawing.Point(133, 171);
            this.cboDebilidad.Name = "cboDebilidad";
            this.cboDebilidad.Size = new System.Drawing.Size(179, 21);
            this.cboDebilidad.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(95, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(201, 25);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Agrega tu Pokemon";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAceptar.Location = new System.Drawing.Point(58, 203);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(121, 32);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCancelar.Location = new System.Drawing.Point(191, 203);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 32);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pbPokemons
            // 
            this.pbPokemons.Location = new System.Drawing.Point(346, 27);
            this.pbPokemons.Name = "pbPokemons";
            this.pbPokemons.Size = new System.Drawing.Size(215, 184);
            this.pbPokemons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPokemons.TabIndex = 15;
            this.pbPokemons.TabStop = false;
            // 
            // frmAltaPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 247);
            this.Controls.Add(this.pbPokemons);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cboDebilidad);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDebilidad);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmAltaPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAltaPokemon";
            this.Load += new System.EventHandler(this.frmAltaPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDebilidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ComboBox cboDebilidad;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbPokemons;
    }
}