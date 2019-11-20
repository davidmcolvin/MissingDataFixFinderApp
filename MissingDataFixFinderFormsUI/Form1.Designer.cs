namespace MissingDataFixFinderFormsUI
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
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.button1 = new System.Windows.Forms.Button();
      this.foundInDatabaseButNotFolderlistBox = new System.Windows.Forms.ListBox();
      this.resultsLabel = new System.Windows.Forms.Label();
      this.searchButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.foundInFolderButNotDatabaselistBox = new System.Windows.Forms.ListBox();
      this.label3 = new System.Windows.Forms.Label();
      this.foundInFolderAndDatabaselistBox = new System.Windows.Forms.ListBox();
      this.databaseNoFolderLabel = new System.Windows.Forms.Label();
      this.folderNoDatabaseLabel = new System.Windows.Forms.Label();
      this.foundInBothLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.Location = new System.Drawing.Point(12, 55);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(121, 28);
      this.button1.TabIndex = 0;
      this.button1.Text = "Select Folder";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // foundInDatabaseButNotFolderlistBox
      // 
      this.foundInDatabaseButNotFolderlistBox.FormattingEnabled = true;
      this.foundInDatabaseButNotFolderlistBox.Location = new System.Drawing.Point(12, 154);
      this.foundInDatabaseButNotFolderlistBox.Name = "foundInDatabaseButNotFolderlistBox";
      this.foundInDatabaseButNotFolderlistBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.foundInDatabaseButNotFolderlistBox.Size = new System.Drawing.Size(311, 160);
      this.foundInDatabaseButNotFolderlistBox.TabIndex = 1;
      this.foundInDatabaseButNotFolderlistBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.foundInDatabaseButNotFolderlistBox_KeyDown);
      // 
      // resultsLabel
      // 
      this.resultsLabel.AutoSize = true;
      this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.resultsLabel.Location = new System.Drawing.Point(8, 131);
      this.resultsLabel.Name = "resultsLabel";
      this.resultsLabel.Size = new System.Drawing.Size(312, 20);
      this.resultsLabel.TabIndex = 2;
      this.resultsLabel.Text = "Found In Database But Not Folder Results";
      // 
      // searchButton
      // 
      this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.searchButton.Location = new System.Drawing.Point(12, 89);
      this.searchButton.Name = "searchButton";
      this.searchButton.Size = new System.Drawing.Size(120, 28);
      this.searchButton.TabIndex = 3;
      this.searchButton.Text = "Search";
      this.searchButton.UseVisualStyleBackColor = true;
      this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(250, 26);
      this.label1.TabIndex = 4;
      this.label1.Text = "Find Data Fixes Not Ran";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(545, 131);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(312, 20);
      this.label2.TabIndex = 6;
      this.label2.Text = "Found In Folder But Not Database Results";
      // 
      // foundInFolderButNotDatabaselistBox
      // 
      this.foundInFolderButNotDatabaselistBox.FormattingEnabled = true;
      this.foundInFolderButNotDatabaselistBox.Location = new System.Drawing.Point(549, 154);
      this.foundInFolderButNotDatabaselistBox.Name = "foundInFolderButNotDatabaselistBox";
      this.foundInFolderButNotDatabaselistBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.foundInFolderButNotDatabaselistBox.Size = new System.Drawing.Size(311, 160);
      this.foundInFolderButNotDatabaselistBox.TabIndex = 5;
      this.foundInFolderButNotDatabaselistBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.foundInFolderButNotDatabaselistBox_KeyDown);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(282, 317);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(287, 20);
      this.label3.TabIndex = 8;
      this.label3.Text = "Found In Folder And Database Results";
      // 
      // foundInFolderAndDatabaselistBox
      // 
      this.foundInFolderAndDatabaselistBox.FormattingEnabled = true;
      this.foundInFolderAndDatabaselistBox.Location = new System.Drawing.Point(286, 342);
      this.foundInFolderAndDatabaselistBox.Name = "foundInFolderAndDatabaselistBox";
      this.foundInFolderAndDatabaselistBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.foundInFolderAndDatabaselistBox.Size = new System.Drawing.Size(311, 160);
      this.foundInFolderAndDatabaselistBox.TabIndex = 7;
      this.foundInFolderAndDatabaselistBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.foundInFolderAndDatabaselistBox_KeyDown);
      // 
      // databaseNoFolderLabel
      // 
      this.databaseNoFolderLabel.AutoSize = true;
      this.databaseNoFolderLabel.Location = new System.Drawing.Point(327, 137);
      this.databaseNoFolderLabel.Name = "databaseNoFolderLabel";
      this.databaseNoFolderLabel.Size = new System.Drawing.Size(13, 13);
      this.databaseNoFolderLabel.TabIndex = 9;
      this.databaseNoFolderLabel.Text = "0";
      // 
      // folderNoDatabaseLabel
      // 
      this.folderNoDatabaseLabel.AutoSize = true;
      this.folderNoDatabaseLabel.Location = new System.Drawing.Point(863, 137);
      this.folderNoDatabaseLabel.Name = "folderNoDatabaseLabel";
      this.folderNoDatabaseLabel.Size = new System.Drawing.Size(13, 13);
      this.folderNoDatabaseLabel.TabIndex = 10;
      this.folderNoDatabaseLabel.Text = "0";
      // 
      // foundInBothLabel
      // 
      this.foundInBothLabel.AutoSize = true;
      this.foundInBothLabel.Location = new System.Drawing.Point(575, 322);
      this.foundInBothLabel.Name = "foundInBothLabel";
      this.foundInBothLabel.Size = new System.Drawing.Size(13, 13);
      this.foundInBothLabel.TabIndex = 11;
      this.foundInBothLabel.Text = "0";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(947, 585);
      this.Controls.Add(this.foundInBothLabel);
      this.Controls.Add(this.folderNoDatabaseLabel);
      this.Controls.Add(this.databaseNoFolderLabel);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.foundInFolderAndDatabaselistBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.foundInFolderButNotDatabaselistBox);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.searchButton);
      this.Controls.Add(this.resultsLabel);
      this.Controls.Add(this.foundInDatabaseButNotFolderlistBox);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Missing Data Fix Finder";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ListBox foundInDatabaseButNotFolderlistBox;
    private System.Windows.Forms.Label resultsLabel;
    private System.Windows.Forms.Button searchButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ListBox foundInFolderButNotDatabaselistBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ListBox foundInFolderAndDatabaselistBox;
    private System.Windows.Forms.Label databaseNoFolderLabel;
    private System.Windows.Forms.Label folderNoDatabaseLabel;
    private System.Windows.Forms.Label foundInBothLabel;
  }
}

