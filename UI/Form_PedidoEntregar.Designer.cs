namespace UI
{
    partial class Form_PedidoEntregar
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
            this.button_EntregarPedido = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_EntregarPedido
            // 
            this.button_EntregarPedido.Location = new System.Drawing.Point(12, 218);
            this.button_EntregarPedido.Name = "button_EntregarPedido";
            this.button_EntregarPedido.Size = new System.Drawing.Size(184, 23);
            this.button_EntregarPedido.TabIndex = 5;
            this.button_EntregarPedido.Tag = "EstablecerEntradaComoEmitida";
            this.button_EntregarPedido.Text = "Establecer pedido como entregado";
            this.button_EntregarPedido.UseVisualStyleBackColor = true;
            this.button_EntregarPedido.Click += new System.EventHandler(this.button_EntregarPedido_Click);
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
            this.dataGridView1.TabIndex = 4;
            // 
            // Form_PedidoEntregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 247);
            this.Controls.Add(this.button_EntregarPedido);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_PedidoEntregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "EntregarPedido";
            this.Text = "Entregar pedido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_PedidoEntregar_FormClosing);
            this.Load += new System.EventHandler(this.Form_PedidoEntregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_EntregarPedido;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}