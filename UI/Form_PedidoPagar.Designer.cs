namespace UI
{
    partial class Form_PedidoPagar
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
            this.button_PagarPedido = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_PagarPedido
            // 
            this.button_PagarPedido.Location = new System.Drawing.Point(12, 218);
            this.button_PagarPedido.Name = "button_PagarPedido";
            this.button_PagarPedido.Size = new System.Drawing.Size(184, 23);
            this.button_PagarPedido.TabIndex = 7;
            this.button_PagarPedido.Tag = "EstablecerEntradaComoEmitida";
            this.button_PagarPedido.Text = "Establecer pedido como pagado";
            this.button_PagarPedido.UseVisualStyleBackColor = true;
            this.button_PagarPedido.Click += new System.EventHandler(this.button_PagarPedido_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(830, 200);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form_PedidoPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 247);
            this.Controls.Add(this.button_PagarPedido);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_PedidoPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "PagarPedido";
            this.Text = "Pedido pagar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_PedidoPagar_FormClosing);
            this.Load += new System.EventHandler(this.Form_PedidoPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_PagarPedido;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}