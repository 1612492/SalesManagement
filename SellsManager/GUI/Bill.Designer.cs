namespace SellsManager.GUI
{
    partial class Bill
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grvBill = new System.Windows.Forms.DataGridView();
            this.grvPro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPro)).BeginInit();
            this.SuspendLayout();
            // 
            // grvBill
            // 
            this.grvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvBill.Location = new System.Drawing.Point(30, 87);
            this.grvBill.Name = "grvBill";
            this.grvBill.RowTemplate.Height = 24;
            this.grvBill.Size = new System.Drawing.Size(558, 520);
            this.grvBill.TabIndex = 0;
            this.grvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvBill_CellClick);
            // 
            // grvPro
            // 
            this.grvPro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPro.Location = new System.Drawing.Point(644, 87);
            this.grvPro.Name = "grvPro";
            this.grvPro.RowTemplate.Height = 24;
            this.grvPro.Size = new System.Drawing.Size(558, 520);
            this.grvPro.TabIndex = 0;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grvPro);
            this.Controls.Add(this.grvBill);
            this.Name = "Bill";
            this.Size = new System.Drawing.Size(1259, 671);
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvBill;
        private System.Windows.Forms.DataGridView grvPro;
    }
}
