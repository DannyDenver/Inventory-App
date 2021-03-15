
namespace InventoryApp
{
    partial class ProductPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PageLabel = new System.Windows.Forms.Label();
            this.AddPartButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.AllCandidatePartsDataGrid = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchPartQuery = new System.Windows.Forms.TextBox();
            this.DeleteProductAssociationButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.AssociatedPartsDataGrid = new System.Windows.Forms.DataGridView();
            this.Min = new System.Windows.Forms.NumericUpDown();
            this.Max = new System.Windows.Forms.NumericUpDown();
            this.Price = new System.Windows.Forms.NumericUpDown();
            this.Inventory = new System.Windows.Forms.NumericUpDown();
            this.ProductID = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllCandidatePartsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductID)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.Location = new System.Drawing.Point(855, 742);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(97, 37);
            this.SaveButton.TabIndex = 21;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.Location = new System.Drawing.Point(958, 742);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(97, 37);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.productCancel_button_Click);
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PageLabel.Location = new System.Drawing.Point(16, 15);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(104, 32);
            this.PageLabel.TabIndex = 22;
            this.PageLabel.Text = "Add Part";
            // 
            // AddPartButton
            // 
            this.AddPartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddPartButton.Location = new System.Drawing.Point(972, 343);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(82, 35);
            this.AddPartButton.TabIndex = 43;
            this.AddPartButton.Text = "Add";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(496, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 25);
            this.label9.TabIndex = 40;
            this.label9.Text = "All Candidate Parts";
            // 
            // AllCandidatePartsDataGrid
            // 
            this.AllCandidatePartsDataGrid.AllowUserToAddRows = false;
            this.AllCandidatePartsDataGrid.AllowUserToDeleteRows = false;
            this.AllCandidatePartsDataGrid.AllowUserToResizeColumns = false;
            this.AllCandidatePartsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllCandidatePartsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AllCandidatePartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AllCandidatePartsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.AllCandidatePartsDataGrid.Location = new System.Drawing.Point(496, 54);
            this.AllCandidatePartsDataGrid.MultiSelect = false;
            this.AllCandidatePartsDataGrid.Name = "AllCandidatePartsDataGrid";
            this.AllCandidatePartsDataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllCandidatePartsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.AllCandidatePartsDataGrid.RowTemplate.Height = 25;
            this.AllCandidatePartsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllCandidatePartsDataGrid.Size = new System.Drawing.Size(558, 273);
            this.AllCandidatePartsDataGrid.TabIndex = 39;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.Location = new System.Drawing.Point(679, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(91, 32);
            this.SearchButton.TabIndex = 47;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchPartQuery
            // 
            this.SearchPartQuery.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchPartQuery.Location = new System.Drawing.Point(776, 13);
            this.SearchPartQuery.Name = "SearchPartQuery";
            this.SearchPartQuery.Size = new System.Drawing.Size(278, 29);
            this.SearchPartQuery.TabIndex = 46;
            // 
            // DeleteProductAssociationButton
            // 
            this.DeleteProductAssociationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteProductAssociationButton.Location = new System.Drawing.Point(972, 698);
            this.DeleteProductAssociationButton.Name = "DeleteProductAssociationButton";
            this.DeleteProductAssociationButton.Size = new System.Drawing.Size(82, 35);
            this.DeleteProductAssociationButton.TabIndex = 50;
            this.DeleteProductAssociationButton.Text = "Delete";
            this.DeleteProductAssociationButton.UseVisualStyleBackColor = true;
            this.DeleteProductAssociationButton.Click += new System.EventHandler(this.DeleteProductAssociationButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(496, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 25);
            this.label6.TabIndex = 49;
            this.label6.Text = "Parts Associated with this Product";
            // 
            // AssociatedPartsDataGrid
            // 
            this.AssociatedPartsDataGrid.AllowUserToAddRows = false;
            this.AssociatedPartsDataGrid.AllowUserToDeleteRows = false;
            this.AssociatedPartsDataGrid.AllowUserToResizeColumns = false;
            this.AssociatedPartsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AssociatedPartsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.AssociatedPartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AssociatedPartsDataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.AssociatedPartsDataGrid.Location = new System.Drawing.Point(496, 409);
            this.AssociatedPartsDataGrid.MultiSelect = false;
            this.AssociatedPartsDataGrid.Name = "AssociatedPartsDataGrid";
            this.AssociatedPartsDataGrid.ReadOnly = true;
            this.AssociatedPartsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AssociatedPartsDataGrid.RowTemplate.Height = 25;
            this.AssociatedPartsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AssociatedPartsDataGrid.Size = new System.Drawing.Size(558, 273);
            this.AssociatedPartsDataGrid.TabIndex = 48;
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(351, 386);
            this.Min.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(120, 23);
            this.Min.TabIndex = 62;
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(161, 385);
            this.Max.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(120, 23);
            this.Max.TabIndex = 61;
            // 
            // Price
            // 
            this.Price.DecimalPlaces = 2;
            this.Price.Location = new System.Drawing.Point(161, 343);
            this.Price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(227, 23);
            this.Price.TabIndex = 60;
            // 
            // Inventory
            // 
            this.Inventory.Location = new System.Drawing.Point(161, 305);
            this.Inventory.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(227, 23);
            this.Inventory.TabIndex = 59;
            // 
            // ProductID
            // 
            this.ProductID.Location = new System.Drawing.Point(161, 212);
            this.ProductID.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(227, 23);
            this.ProductID.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(299, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 25);
            this.label8.TabIndex = 57;
            this.label8.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(68, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 25);
            this.label7.TabIndex = 56;
            this.label7.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(8, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 55;
            this.label5.Text = "Price / Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 54;
            this.label4.Text = "Inventory";
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(161, 254);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(227, 23);
            this.ProductName.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(54, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(85, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "ID";
            // 
            // ProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 811);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.ProductID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteProductAssociationButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AssociatedPartsDataGrid);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchPartQuery);
            this.Controls.Add(this.AddPartButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AllCandidatePartsDataGrid);
            this.Controls.Add(this.PageLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Name = "ProductPage";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.AllCandidatePartsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView AllCandidatePartsDataGrid;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchPartQuery;
        private System.Windows.Forms.Button DeleteProductAssociationButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView AssociatedPartsDataGrid;
        private System.Windows.Forms.NumericUpDown Min;
        private System.Windows.Forms.NumericUpDown Max;
        private System.Windows.Forms.NumericUpDown Price;
        private System.Windows.Forms.NumericUpDown Inventory;
        private System.Windows.Forms.NumericUpDown ProductID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}