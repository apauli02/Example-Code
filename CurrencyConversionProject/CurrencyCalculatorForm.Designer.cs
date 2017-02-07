namespace CurrencyConversionProject
{
    partial class CurrencyCalculatorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.dollarListBox = new System.Windows.Forms.ListBox();
            this.codesToRatesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.conversionOutputLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "US Dollars:";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(34, 285);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(162, 285);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // dollarListBox
            // 
            this.dollarListBox.FormattingEnabled = true;
            this.dollarListBox.Location = new System.Drawing.Point(34, 58);
            this.dollarListBox.Name = "dollarListBox";
            this.dollarListBox.Size = new System.Drawing.Size(57, 56);
            this.dollarListBox.TabIndex = 4;
            this.dollarListBox.SelectedIndexChanged += new System.EventHandler(this.dollarListBox_SelectedIndexChanged);
            // 
            // codesToRatesListView
            // 
            this.codesToRatesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.codesToRatesListView.FullRowSelect = true;
            this.codesToRatesListView.GridLines = true;
            this.codesToRatesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.codesToRatesListView.HideSelection = false;
            this.codesToRatesListView.Location = new System.Drawing.Point(119, 58);
            this.codesToRatesListView.Name = "codesToRatesListView";
            this.codesToRatesListView.Size = new System.Drawing.Size(304, 150);
            this.codesToRatesListView.TabIndex = 5;
            this.codesToRatesListView.UseCompatibleStateImageBehavior = false;
            this.codesToRatesListView.View = System.Windows.Forms.View.Details;
            this.codesToRatesListView.SelectedIndexChanged += new System.EventHandler(this.codesToRatesListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Country Currency";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Rate";
            this.columnHeader2.Width = 100;
            // 
            // conversionOutputLabel
            // 
            this.conversionOutputLabel.AutoSize = true;
            this.conversionOutputLabel.BackColor = System.Drawing.SystemColors.Window;
            this.conversionOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.conversionOutputLabel.Location = new System.Drawing.Point(34, 235);
            this.conversionOutputLabel.Name = "conversionOutputLabel";
            this.conversionOutputLabel.Size = new System.Drawing.Size(2, 15);
            this.conversionOutputLabel.TabIndex = 2;
            this.conversionOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(348, 285);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // CurrencyCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(473, 331);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.conversionOutputLabel);
            this.Controls.Add(this.codesToRatesListView);
            this.Controls.Add(this.dollarListBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.label1);
            this.Name = "CurrencyCalculatorForm";
            this.Text = "Currency Calculator";
            this.Load += new System.EventHandler(this.CurrencyCalculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListBox dollarListBox;
        private System.Windows.Forms.ListView codesToRatesListView;
        private System.Windows.Forms.Label conversionOutputLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

