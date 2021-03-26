namespace EntityFramework
{
    partial class Form1
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
            this.gpbUpdate = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxStockAmountU = new System.Windows.Forms.TextBox();
            this.lblStockAmountU = new System.Windows.Forms.Label();
            this.tbxUnitPriceU = new System.Windows.Forms.TextBox();
            this.lblUnitPriceU = new System.Windows.Forms.Label();
            this.tbxNameU = new System.Windows.Forms.TextBox();
            this.lblNameU = new System.Windows.Forms.Label();
            this.gpbAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.gpbUpdate.SuspendLayout();
            this.gpbAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbUpdate
            // 
            this.gpbUpdate.Controls.Add(this.btnDelete);
            this.gpbUpdate.Controls.Add(this.btnUpdate);
            this.gpbUpdate.Controls.Add(this.tbxStockAmountU);
            this.gpbUpdate.Controls.Add(this.lblStockAmountU);
            this.gpbUpdate.Controls.Add(this.tbxUnitPriceU);
            this.gpbUpdate.Controls.Add(this.lblUnitPriceU);
            this.gpbUpdate.Controls.Add(this.tbxNameU);
            this.gpbUpdate.Controls.Add(this.lblNameU);
            this.gpbUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpbUpdate.Location = new System.Drawing.Point(412, 286);
            this.gpbUpdate.Name = "gpbUpdate";
            this.gpbUpdate.Size = new System.Drawing.Size(303, 211);
            this.gpbUpdate.TabIndex = 9;
            this.gpbUpdate.TabStop = false;
            this.gpbUpdate.Text = "  Update A Product  ";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(136, 180);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(136, 151);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // tbxStockAmountU
            // 
            this.tbxStockAmountU.Location = new System.Drawing.Point(136, 114);
            this.tbxStockAmountU.Name = "tbxStockAmountU";
            this.tbxStockAmountU.Size = new System.Drawing.Size(130, 22);
            this.tbxStockAmountU.TabIndex = 5;
            // 
            // lblStockAmountU
            // 
            this.lblStockAmountU.AutoSize = true;
            this.lblStockAmountU.Location = new System.Drawing.Point(26, 117);
            this.lblStockAmountU.Name = "lblStockAmountU";
            this.lblStockAmountU.Size = new System.Drawing.Size(90, 16);
            this.lblStockAmountU.TabIndex = 4;
            this.lblStockAmountU.Text = "Stock Amount";
            // 
            // tbxUnitPriceU
            // 
            this.tbxUnitPriceU.Location = new System.Drawing.Point(136, 76);
            this.tbxUnitPriceU.Name = "tbxUnitPriceU";
            this.tbxUnitPriceU.Size = new System.Drawing.Size(130, 22);
            this.tbxUnitPriceU.TabIndex = 3;
            // 
            // lblUnitPriceU
            // 
            this.lblUnitPriceU.AutoSize = true;
            this.lblUnitPriceU.Location = new System.Drawing.Point(26, 79);
            this.lblUnitPriceU.Name = "lblUnitPriceU";
            this.lblUnitPriceU.Size = new System.Drawing.Size(65, 16);
            this.lblUnitPriceU.TabIndex = 2;
            this.lblUnitPriceU.Text = "Unit Price";
            // 
            // tbxNameU
            // 
            this.tbxNameU.Location = new System.Drawing.Point(136, 36);
            this.tbxNameU.Name = "tbxNameU";
            this.tbxNameU.Size = new System.Drawing.Size(130, 22);
            this.tbxNameU.TabIndex = 1;
            // 
            // lblNameU
            // 
            this.lblNameU.AutoSize = true;
            this.lblNameU.Location = new System.Drawing.Point(26, 39);
            this.lblNameU.Name = "lblNameU";
            this.lblNameU.Size = new System.Drawing.Size(45, 16);
            this.lblNameU.TabIndex = 0;
            this.lblNameU.Text = "Name";
            // 
            // gpbAdd
            // 
            this.gpbAdd.Controls.Add(this.btnAdd);
            this.gpbAdd.Controls.Add(this.tbxStockAmount);
            this.gpbAdd.Controls.Add(this.lblStockAmount);
            this.gpbAdd.Controls.Add(this.tbxUnitPrice);
            this.gpbAdd.Controls.Add(this.lblUnitPrice);
            this.gpbAdd.Controls.Add(this.tbxName);
            this.gpbAdd.Controls.Add(this.lblName);
            this.gpbAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpbAdd.Location = new System.Drawing.Point(92, 286);
            this.gpbAdd.Name = "gpbAdd";
            this.gpbAdd.Size = new System.Drawing.Size(303, 211);
            this.gpbAdd.TabIndex = 8;
            this.gpbAdd.TabStop = false;
            this.gpbAdd.Text = "  Add A Product  ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(136, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(136, 114);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(130, 22);
            this.tbxStockAmount.TabIndex = 5;
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(26, 117);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(90, 16);
            this.lblStockAmount.TabIndex = 4;
            this.lblStockAmount.Text = "Stock Amount";
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(136, 76);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(130, 22);
            this.tbxUnitPrice.TabIndex = 3;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(26, 79);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(65, 16);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(136, 36);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(130, 22);
            this.tbxName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(92, 55);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(623, 213);
            this.dgwProducts.TabIndex = 7;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearch.Location = new System.Drawing.Point(548, 19);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(130, 22);
            this.tbxSearch.TabIndex = 10;
            this.tbxSearch.TextChanged += new System.EventHandler(this.TbxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearch.Location = new System.Drawing.Point(477, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(51, 16);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 516);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.gpbUpdate);
            this.Controls.Add(this.gpbAdd);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbUpdate.ResumeLayout(false);
            this.gpbUpdate.PerformLayout();
            this.gpbAdd.ResumeLayout(false);
            this.gpbAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxStockAmountU;
        private System.Windows.Forms.Label lblStockAmountU;
        private System.Windows.Forms.TextBox tbxUnitPriceU;
        private System.Windows.Forms.Label lblUnitPriceU;
        private System.Windows.Forms.TextBox tbxNameU;
        private System.Windows.Forms.Label lblNameU;
        private System.Windows.Forms.GroupBox gpbAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}

