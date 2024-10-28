namespace UI
{
    partial class Form_PedidoReservar
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
            this.listBox_Golosinas = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_AgregarGolosina = new System.Windows.Forms.Button();
            this.button_QuitarGolosina = new System.Windows.Forms.Button();
            this.button_CalcularPedido = new System.Windows.Forms.Button();
            this.label_PrecioTotal = new System.Windows.Forms.Label();
            this.button_Confirmar = new System.Windows.Forms.Button();
            this.label_NombreGolosina = new System.Windows.Forms.Label();
            this.label_PrecioUnitario = new System.Windows.Forms.Label();
            this.dataGridView_Pedido = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pedido)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Golosinas
            // 
            this.listBox_Golosinas.FormattingEnabled = true;
            this.listBox_Golosinas.Location = new System.Drawing.Point(6, 19);
            this.listBox_Golosinas.Name = "listBox_Golosinas";
            this.listBox_Golosinas.Size = new System.Drawing.Size(188, 95);
            this.listBox_Golosinas.TabIndex = 0;
            this.listBox_Golosinas.SelectedIndexChanged += new System.EventHandler(this.listBox_Golosinas_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_PrecioUnitario);
            this.groupBox1.Controls.Add(this.label_NombreGolosina);
            this.groupBox1.Controls.Add(this.button_QuitarGolosina);
            this.groupBox1.Controls.Add(this.button_AgregarGolosina);
            this.groupBox1.Controls.Add(this.listBox_Golosinas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 200);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Golosinas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Confirmar);
            this.groupBox2.Controls.Add(this.dataGridView_Pedido);
            this.groupBox2.Controls.Add(this.label_PrecioTotal);
            this.groupBox2.Controls.Add(this.button_CalcularPedido);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 225);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pedido";
            // 
            // button_AgregarGolosina
            // 
            this.button_AgregarGolosina.Location = new System.Drawing.Point(119, 162);
            this.button_AgregarGolosina.Name = "button_AgregarGolosina";
            this.button_AgregarGolosina.Size = new System.Drawing.Size(75, 23);
            this.button_AgregarGolosina.TabIndex = 1;
            this.button_AgregarGolosina.Text = "Agregar";
            this.button_AgregarGolosina.UseVisualStyleBackColor = true;
            this.button_AgregarGolosina.Click += new System.EventHandler(this.button_AgregarGolosina_Click);
            // 
            // button_QuitarGolosina
            // 
            this.button_QuitarGolosina.Location = new System.Drawing.Point(6, 162);
            this.button_QuitarGolosina.Name = "button_QuitarGolosina";
            this.button_QuitarGolosina.Size = new System.Drawing.Size(75, 23);
            this.button_QuitarGolosina.TabIndex = 2;
            this.button_QuitarGolosina.Text = "Quitar";
            this.button_QuitarGolosina.UseVisualStyleBackColor = true;
            this.button_QuitarGolosina.Click += new System.EventHandler(this.button_QuitarGolosina_Click);
            // 
            // button_CalcularPedido
            // 
            this.button_CalcularPedido.Location = new System.Drawing.Point(6, 193);
            this.button_CalcularPedido.Name = "button_CalcularPedido";
            this.button_CalcularPedido.Size = new System.Drawing.Size(75, 23);
            this.button_CalcularPedido.TabIndex = 2;
            this.button_CalcularPedido.Text = "Calcular";
            this.button_CalcularPedido.UseVisualStyleBackColor = true;
            this.button_CalcularPedido.Click += new System.EventHandler(this.button_CalcularPedido_Click);
            // 
            // label_PrecioTotal
            // 
            this.label_PrecioTotal.AutoSize = true;
            this.label_PrecioTotal.Location = new System.Drawing.Point(6, 177);
            this.label_PrecioTotal.Name = "label_PrecioTotal";
            this.label_PrecioTotal.Size = new System.Drawing.Size(63, 13);
            this.label_PrecioTotal.TabIndex = 3;
            this.label_PrecioTotal.Text = "Precio total:";
            // 
            // button_Confirmar
            // 
            this.button_Confirmar.Location = new System.Drawing.Point(284, 193);
            this.button_Confirmar.Name = "button_Confirmar";
            this.button_Confirmar.Size = new System.Drawing.Size(75, 23);
            this.button_Confirmar.TabIndex = 4;
            this.button_Confirmar.Text = "Confirmar";
            this.button_Confirmar.UseVisualStyleBackColor = true;
            this.button_Confirmar.Click += new System.EventHandler(this.button_Confirmar_Click);
            // 
            // label_NombreGolosina
            // 
            this.label_NombreGolosina.AutoSize = true;
            this.label_NombreGolosina.Location = new System.Drawing.Point(6, 125);
            this.label_NombreGolosina.Name = "label_NombreGolosina";
            this.label_NombreGolosina.Size = new System.Drawing.Size(47, 13);
            this.label_NombreGolosina.TabIndex = 4;
            this.label_NombreGolosina.Text = "Nombre:";
            // 
            // label_PrecioUnitario
            // 
            this.label_PrecioUnitario.AutoSize = true;
            this.label_PrecioUnitario.Location = new System.Drawing.Point(6, 146);
            this.label_PrecioUnitario.Name = "label_PrecioUnitario";
            this.label_PrecioUnitario.Size = new System.Drawing.Size(77, 13);
            this.label_PrecioUnitario.TabIndex = 5;
            this.label_PrecioUnitario.Text = "Precio unitario:";
            // 
            // dataGridView_Pedido
            // 
            this.dataGridView_Pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Pedido.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_Pedido.MultiSelect = false;
            this.dataGridView_Pedido.Name = "dataGridView_Pedido";
            this.dataGridView_Pedido.ReadOnly = true;
            this.dataGridView_Pedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Pedido.Size = new System.Drawing.Size(353, 150);
            this.dataGridView_Pedido.TabIndex = 4;
            // 
            // Form_PedidoReservar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 242);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_PedidoReservar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "VentaGolosinas";
            this.Text = "Venta Golosinas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_PedidoReservar_FormClosing);
            this.Load += new System.EventHandler(this.Form_PedidoReservar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Golosinas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_QuitarGolosina;
        private System.Windows.Forms.Button button_AgregarGolosina;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_PrecioUnitario;
        private System.Windows.Forms.Label label_NombreGolosina;
        private System.Windows.Forms.Label label_PrecioTotal;
        private System.Windows.Forms.Button button_CalcularPedido;
        private System.Windows.Forms.Button button_Confirmar;
        private System.Windows.Forms.DataGridView dataGridView_Pedido;
    }
}