namespace InventarioView
{
    partial class Inventario
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
            this.dataView = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.textProducto = new System.Windows.Forms.TextBox();
            this.textCategoria = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textPrecioMod = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(180, 1);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(431, 215);
            this.dataView.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Location = new System.Drawing.Point(478, 230);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(133, 49);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIngresar.Location = new System.Drawing.Point(28, 230);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(128, 49);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(180, 230);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(114, 49);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Location = new System.Drawing.Point(632, 230);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(136, 49);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(300, 247);
            this.txtEliminar.Multiline = true;
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(130, 32);
            this.txtEliminar.TabIndex = 8;
            // 
            // textProducto
            // 
            this.textProducto.Location = new System.Drawing.Point(28, 39);
            this.textProducto.Multiline = true;
            this.textProducto.Name = "textProducto";
            this.textProducto.Size = new System.Drawing.Size(128, 29);
            this.textProducto.TabIndex = 9;
            // 
            // textCategoria
            // 
            this.textCategoria.Location = new System.Drawing.Point(29, 113);
            this.textCategoria.Multiline = true;
            this.textCategoria.Name = "textCategoria";
            this.textCategoria.Size = new System.Drawing.Size(129, 29);
            this.textCategoria.TabIndex = 10;
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(27, 187);
            this.textPrecio.Multiline = true;
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(129, 29);
            this.textPrecio.TabIndex = 11;
            // 
            // textPrecioMod
            // 
            this.textPrecioMod.Location = new System.Drawing.Point(632, 187);
            this.textPrecioMod.Multiline = true;
            this.textPrecioMod.Name = "textPrecioMod";
            this.textPrecioMod.Size = new System.Drawing.Size(136, 29);
            this.textPrecioMod.TabIndex = 16;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(632, 114);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(136, 29);
            this.txtID.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(34, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(48, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(676, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "ID ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(662, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 28);
            this.label6.TabIndex = 22;
            this.label6.Text = "Precio";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(780, 291);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPrecioMod);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textCategoria);
            this.Controls.Add(this.textProducto);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataView);
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.TextBox textProducto;
        private System.Windows.Forms.TextBox textCategoria;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textPrecioMod;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

