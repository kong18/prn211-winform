namespace BOOKSTORE_CONGNTT
{
    partial class BookManagementForm
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
            dataGridView1 = new DataGridView();
            btnExit = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            txtId = new TextBox();
            lblBookName = new Label();
            lblBookId = new Label();
            lblDescription = new Label();
            lblReleaseDate = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblAuthor = new Label();
            lblBookCategory = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtAuthor = new TextBox();
            cboBookCategoryId = new ComboBox();
            btnSearch = new Button();
            txtKeyword = new TextBox();
            dtpReleaseDate = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 400);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(917, 275);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += ViewProduct;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(446, 336);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(182, 336);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(310, 336);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(49, 336);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(172, 116);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 5;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Location = new Point(49, 157);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(83, 20);
            lblBookName.TabIndex = 6;
            lblBookName.Text = "BookName";
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Location = new Point(51, 116);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(56, 20);
            lblBookId.TabIndex = 7;
            lblBookId.Text = "BookId";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(51, 206);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Description";
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.AutoSize = true;
            lblReleaseDate.Location = new Point(49, 250);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(92, 20);
            lblReleaseDate.TabIndex = 9;
            lblReleaseDate.Text = "ReleaseDate";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(475, 164);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 11;
            lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(475, 116);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(65, 20);
            lblQuantity.TabIndex = 12;
            lblQuantity.Text = "Quantity";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(475, 257);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(54, 20);
            lblAuthor.TabIndex = 13;
            lblAuthor.Text = "Author";
            // 
            // lblBookCategory
            // 
            lblBookCategory.AutoSize = true;
            lblBookCategory.Location = new Point(475, 216);
            lblBookCategory.Name = "lblBookCategory";
            lblBookCategory.Size = new Size(103, 20);
            lblBookCategory.TabIndex = 14;
            lblBookCategory.Text = "BookCategory";
            // 
            // txtName
            // 
            txtName.Location = new Point(172, 157);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 15;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(172, 199);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 16;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(605, 109);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 17;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(605, 164);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 18;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(605, 257);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(125, 27);
            txtAuthor.TabIndex = 19;
            // 
            // cboBookCategoryId
            // 
            cboBookCategoryId.FormattingEnabled = true;
            cboBookCategoryId.Location = new Point(605, 213);
            cboBookCategoryId.Name = "cboBookCategoryId";
            cboBookCategoryId.Size = new Size(151, 28);
            cboBookCategoryId.TabIndex = 20;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(652, 336);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(776, 338);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(238, 27);
            txtKeyword.TabIndex = 22;
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.CustomFormat = "dd/MM/yyyy";
            dtpReleaseDate.Format = DateTimePickerFormat.Custom;
            dtpReleaseDate.Location = new Point(172, 250);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(125, 27);
            dtpReleaseDate.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(49, 27);
            label1.Name = "label1";
            label1.Size = new Size(268, 31);
            label1.TabIndex = 24;
            label1.Text = "BookManagementForm";
            // 
            // BookManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 687);
            Controls.Add(label1);
            Controls.Add(dtpReleaseDate);
            Controls.Add(txtKeyword);
            Controls.Add(btnSearch);
            Controls.Add(cboBookCategoryId);
            Controls.Add(txtAuthor);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(lblBookCategory);
            Controls.Add(lblAuthor);
            Controls.Add(lblQuantity);
            Controls.Add(lblPrice);
            Controls.Add(lblReleaseDate);
            Controls.Add(lblDescription);
            Controls.Add(lblBookId);
            Controls.Add(lblBookName);
            Controls.Add(txtId);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnExit);
            Controls.Add(dataGridView1);
            Name = "BookManagementForm";
            Text = "BookManagement";
            Load += BookManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnExit;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtId;
        private Label lblBookName;
        private Label lblBookId;
        private Label lblDescription;
        private Label lblReleaseDate;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblAuthor;
        private Label lblBookCategory;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtAuthor;
        private ComboBox cboBookCategoryId;
        private Button btnSearch;
        private TextBox txtKeyword;
        private DateTimePicker dtpReleaseDate;
        private Label label1;
    }
}