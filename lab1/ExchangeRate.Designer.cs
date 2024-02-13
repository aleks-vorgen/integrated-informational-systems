namespace lab1
{
    partial class ExchangeRate
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
            this.dataCurrencyTable = new System.Windows.Forms.DataGridView();
            this.LoadData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCurrencyTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCurrencyTable
            // 
            this.dataCurrencyTable.AllowUserToAddRows = false;
            this.dataCurrencyTable.AllowUserToDeleteRows = false;
            this.dataCurrencyTable.AllowUserToResizeColumns = false;
            this.dataCurrencyTable.AllowUserToResizeRows = false;
            this.dataCurrencyTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCurrencyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCurrencyTable.Location = new System.Drawing.Point(12, 12);
            this.dataCurrencyTable.Name = "dataCurrencyTable";
            this.dataCurrencyTable.Size = new System.Drawing.Size(776, 379);
            this.dataCurrencyTable.TabIndex = 0;
            this.dataCurrencyTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCurrencyTable_CellContentClick);
            // 
            // LoadData
            // 
            this.LoadData.Location = new System.Drawing.Point(359, 415);
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(75, 23);
            this.LoadData.TabIndex = 1;
            this.LoadData.Text = "Load Data";
            this.LoadData.UseVisualStyleBackColor = true;
            this.LoadData.Click += new System.EventHandler(this.LoadData_Click);
            // 
            // ExchangeRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoadData);
            this.Controls.Add(this.dataCurrencyTable);
            this.Name = "ExchangeRate";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataCurrencyTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button LoadData;
        public System.Windows.Forms.DataGridView dataCurrencyTable;
    }
}