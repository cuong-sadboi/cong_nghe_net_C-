namespace DTC225180054
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            label5 = new Label();
            txtDescription = new TextBox();
            grvData = new DataGridView();
            btnAdd = new Button();
            btnLoadData = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)grvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 56);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 106);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 0;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(121, 49);
            txtId.Name = "txtId";
            txtId.Size = new Size(140, 27);
            txtId.TabIndex = 1;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(121, 98);
            txtName.Name = "txtName";
            txtName.Size = new Size(140, 27);
            txtName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 56);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 0;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(468, 110);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 0;
            label4.Text = "Price";
            label4.Click += label2_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(536, 49);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(140, 27);
            txtQuantity.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(536, 103);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(140, 27);
            txtPrice.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 176);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 0;
            label5.Text = "Description";
            label5.Click += label2_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(140, 173);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(536, 27);
            txtDescription.TabIndex = 1;
            // 
            // grvData
            // 
            grvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvData.Location = new Point(49, 229);
            grvData.Name = "grvData";
            grvData.RowHeadersWidth = 51;
            grvData.Size = new Size(680, 145);
            grvData.TabIndex = 2;
            grvData.CellContentClick += grvData_CellContentClick_1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(86, 409);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(108, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(536, 409);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(108, 29);
            btnLoadData.TabIndex = 3;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(384, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(236, 409);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(108, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnLoadData);
            Controls.Add(btnAdd);
            Controls.Add(grvData);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Nguyen Tien Cuong";
            ((System.ComponentModel.ISupportInitialize)grvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtId;
        private TextBox txtName;
        private Label label3;
        private Label label4;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Label label5;
        private TextBox txtDescription;
        private DataGridView grvData;
        private Button btnAdd;
        private Button btnLoadData;
        private Button btnDelete;
        private Button btnUpdate;
    }
}
