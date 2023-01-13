namespace WindowsApp
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
            this.btnCrearProducto = new System.Windows.Forms.Button();
            this.btnCrearCliente = new System.Windows.Forms.Button();
            this.btnCrearEmpresa = new System.Windows.Forms.Button();
            this.btnCrearFactura = new System.Windows.Forms.Button();
            this.btnCrearRemito = new System.Windows.Forms.Button();
            this.btnCrearVendedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearProducto
            // 
            this.btnCrearProducto.Location = new System.Drawing.Point(137, 121);
            this.btnCrearProducto.Name = "btnCrearProducto";
            this.btnCrearProducto.Size = new System.Drawing.Size(162, 39);
            this.btnCrearProducto.TabIndex = 0;
            this.btnCrearProducto.Text = "Crear Producto";
            this.btnCrearProducto.UseVisualStyleBackColor = true;
            this.btnCrearProducto.Click += new System.EventHandler(this.btnCrearProducto_Click);
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.Location = new System.Drawing.Point(137, 200);
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.Size = new System.Drawing.Size(162, 39);
            this.btnCrearCliente.TabIndex = 1;
            this.btnCrearCliente.Text = "Crear Cliente";
            this.btnCrearCliente.UseVisualStyleBackColor = true;
            this.btnCrearCliente.Click += new System.EventHandler(this.btnCrearCliente_Click);
            // 
            // btnCrearEmpresa
            // 
            this.btnCrearEmpresa.Location = new System.Drawing.Point(329, 121);
            this.btnCrearEmpresa.Name = "btnCrearEmpresa";
            this.btnCrearEmpresa.Size = new System.Drawing.Size(162, 39);
            this.btnCrearEmpresa.TabIndex = 2;
            this.btnCrearEmpresa.Text = "Crear Empresa";
            this.btnCrearEmpresa.UseVisualStyleBackColor = true;
            this.btnCrearEmpresa.Click += new System.EventHandler(this.btnCrearEmpresa_Click);
            // 
            // btnCrearFactura
            // 
            this.btnCrearFactura.Location = new System.Drawing.Point(329, 200);
            this.btnCrearFactura.Name = "btnCrearFactura";
            this.btnCrearFactura.Size = new System.Drawing.Size(162, 39);
            this.btnCrearFactura.TabIndex = 3;
            this.btnCrearFactura.Text = "Crear Factura";
            this.btnCrearFactura.UseVisualStyleBackColor = true;
            this.btnCrearFactura.Click += new System.EventHandler(this.btnCrearFactura_Click);
            // 
            // btnCrearRemito
            // 
            this.btnCrearRemito.Location = new System.Drawing.Point(519, 121);
            this.btnCrearRemito.Name = "btnCrearRemito";
            this.btnCrearRemito.Size = new System.Drawing.Size(162, 39);
            this.btnCrearRemito.TabIndex = 4;
            this.btnCrearRemito.Text = "Crear Remito";
            this.btnCrearRemito.UseVisualStyleBackColor = true;
            this.btnCrearRemito.Click += new System.EventHandler(this.btnCrearRemito_Click);
            // 
            // btnCrearVendedor
            // 
            this.btnCrearVendedor.Location = new System.Drawing.Point(519, 200);
            this.btnCrearVendedor.Name = "btnCrearVendedor";
            this.btnCrearVendedor.Size = new System.Drawing.Size(162, 39);
            this.btnCrearVendedor.TabIndex = 5;
            this.btnCrearVendedor.Text = "Crear Vendedor";
            this.btnCrearVendedor.UseVisualStyleBackColor = true;
            this.btnCrearVendedor.Click += new System.EventHandler(this.btnCrearVendedor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearVendedor);
            this.Controls.Add(this.btnCrearRemito);
            this.Controls.Add(this.btnCrearFactura);
            this.Controls.Add(this.btnCrearEmpresa);
            this.Controls.Add(this.btnCrearCliente);
            this.Controls.Add(this.btnCrearProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearProducto;
        private System.Windows.Forms.Button btnCrearCliente;
        private System.Windows.Forms.Button btnCrearEmpresa;
        private System.Windows.Forms.Button btnCrearFactura;
        private System.Windows.Forms.Button btnCrearRemito;
        private System.Windows.Forms.Button btnCrearVendedor;
    }
}

