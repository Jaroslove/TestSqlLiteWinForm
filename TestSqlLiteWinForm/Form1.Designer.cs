namespace TestSqlLiteWinForm
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.showHistory = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstInput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondInput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Output = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inGridBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(11, 34);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(11, 151);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(11, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "/";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(163, 96);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 13);
            this.resultLbl.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(470, 34);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(278, 204);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // showHistory
            // 
            this.showHistory.Location = new System.Drawing.Point(324, 34);
            this.showHistory.Name = "showHistory";
            this.showHistory.Size = new System.Drawing.Size(140, 23);
            this.showHistory.TabIndex = 6;
            this.showHistory.Text = "See the history in text";
            this.showHistory.UseVisualStyleBackColor = true;
            this.showHistory.Click += new System.EventHandler(this.showHistory_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Crimson;
            this.errorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorLabel.Location = new System.Drawing.Point(11, 178);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(64, 15);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.Text = "Not be zero";
            this.errorLabel.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.FirstInput,
            this.SecondInput,
            this.Output});
            this.dataGridView1.Location = new System.Drawing.Point(304, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 254);
            this.dataGridView1.TabIndex = 8;
            // 
            // Name
            // 
            this.Name.HeaderText = "User name";
            this.Name.Name = "Name";
            // 
            // FirstInput
            // 
            this.FirstInput.HeaderText = "First input";
            this.FirstInput.Name = "FirstInput";
            // 
            // SecondInput
            // 
            this.SecondInput.HeaderText = "Second Input";
            this.SecondInput.Name = "SecondInput";
            // 
            // Output
            // 
            this.Output.HeaderText = "Result";
            this.Output.Name = "Output";
            // 
            // inGridBtn
            // 
            this.inGridBtn.Location = new System.Drawing.Point(12, 279);
            this.inGridBtn.Name = "inGridBtn";
            this.inGridBtn.Size = new System.Drawing.Size(164, 23);
            this.inGridBtn.TabIndex = 9;
            this.inGridBtn.Text = "See the history in the Table";
            this.inGridBtn.UseVisualStyleBackColor = true;
            this.inGridBtn.Click += new System.EventHandler(this.inGridBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 545);
            this.Controls.Add(this.inGridBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.showHistory);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button showHistory;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button inGridBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Output;
    }
}

