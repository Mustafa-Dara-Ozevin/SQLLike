namespace SQLLike
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
            txtLike = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            lstboxDataset = new ListBox();
            label2 = new Label();
            txtAdd = new TextBox();
            btnAdd = new Button();
            label3 = new Label();
            lstboxResult = new ListBox();
            SuspendLayout();
            // 
            // txtLike
            // 
            txtLike.Location = new Point(131, 25);
            txtLike.Name = "txtLike";
            txtLike.Size = new Size(302, 27);
            txtLike.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(77, 26);
            label1.Name = "label1";
            label1.Size = new Size(48, 28);
            label1.TabIndex = 1;
            label1.Text = "LIKE";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(475, 26);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(149, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lstboxDataset
            // 
            lstboxDataset.FormattingEnabled = true;
            lstboxDataset.Location = new Point(42, 114);
            lstboxDataset.Name = "lstboxDataset";
            lstboxDataset.Size = new Size(313, 264);
            lstboxDataset.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(142, 83);
            label2.Name = "label2";
            label2.Size = new Size(78, 28);
            label2.TabIndex = 4;
            label2.Text = "Dataset";
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(42, 397);
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(208, 27);
            txtAdd.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(276, 397);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(523, 83);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 9;
            label3.Text = "Result";
            // 
            // lstboxResult
            // 
            lstboxResult.FormattingEnabled = true;
            lstboxResult.Location = new Point(423, 114);
            lstboxResult.Name = "lstboxResult";
            lstboxResult.Size = new Size(313, 264);
            lstboxResult.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(lstboxResult);
            Controls.Add(btnAdd);
            Controls.Add(txtAdd);
            Controls.Add(label2);
            Controls.Add(lstboxDataset);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(txtLike);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLike;
        private Label label1;
        private Button btnSearch;
        private ListBox lstboxDataset;
        private Label label2;
        private TextBox txtAdd;
        private Button btnAdd;
        private Label label3;
        private ListBox lstboxResult;
    }
}
