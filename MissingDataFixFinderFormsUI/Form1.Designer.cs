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
      this.selectFolderButton = new System.Windows.Forms.Button();
      this.foundInDatabaseButNotFolderlistBox = new System.Windows.Forms.ListBox();
      this.FoundInDatabaseButNotFolderListBoxLabel = new System.Windows.Forms.Label();
      this.searchButton = new System.Windows.Forms.Button();
      this.headerLabel = new System.Windows.Forms.Label();
      this.FoundinFolderButNotDatabaseListBoxLabel = new System.Windows.Forms.Label();
      this.foundInFolderButNotDatabaselistBox = new System.Windows.Forms.ListBox();
      this.FoundInDatabaseAndFolderListBoxLabel = new System.Windows.Forms.Label();
      this.foundInFolderAndDatabaselistBox = new System.Windows.Forms.ListBox();
      this.databaseNoFolderLabel = new System.Windows.Forms.Label();
      this.folderNoDatabaseLabel = new System.Windows.Forms.Label();
      this.foundInBothLabel = new System.Windows.Forms.Label();
      this.chosenFolderLabel = new System.Windows.Forms.Label();
      this.inDatabaseLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // selectFolderButton
      // 
      this.selectFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.selectFolderButton.Location = new System.Drawing.Point(12, 55);
      this.selectFolderButton.Name = "selectFolderButton";
      this.selectFolderButton.Size = new System.Drawing.Size(121, 28);
      this.selectFolderButton.TabIndex = 0;
      this.selectFolderButton.Text = "Select Folder";
      this.selectFolderButton.UseVisualStyleBackColor = true;
      this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
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
      // FoundInDatabaseButNotFolderListBoxLabel
      // 
      this.FoundInDatabaseButNotFolderListBoxLabel.AutoSize = true;
      this.FoundInDatabaseButNotFolderListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FoundInDatabaseButNotFolderListBoxLabel.Location = new System.Drawing.Point(8, 131);
      this.FoundInDatabaseButNotFolderListBoxLabel.Name = "FoundInDatabaseButNotFolderListBoxLabel";
      this.FoundInDatabaseButNotFolderListBoxLabel.Size = new System.Drawing.Size(312, 20);
      this.FoundInDatabaseButNotFolderListBoxLabel.TabIndex = 2;
      this.FoundInDatabaseButNotFolderListBoxLabel.Text = "Found In Database But Not Folder Results";
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
      // headerLabel
      // 
      this.headerLabel.AutoSize = true;
      this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerLabel.Location = new System.Drawing.Point(12, 13);
      this.headerLabel.Name = "headerLabel";
      this.headerLabel.Size = new System.Drawing.Size(250, 26);
      this.headerLabel.TabIndex = 4;
      this.headerLabel.Text = "Find Data Fixes Not Ran";
      // 
      // FoundinFolderButNotDatabaseListBoxLabel
      // 
      this.FoundinFolderButNotDatabaseListBoxLabel.AutoSize = true;
      this.FoundinFolderButNotDatabaseListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FoundinFolderButNotDatabaseListBoxLabel.Location = new System.Drawing.Point(545, 131);
      this.FoundinFolderButNotDatabaseListBoxLabel.Name = "FoundinFolderButNotDatabaseListBoxLabel";
      this.FoundinFolderButNotDatabaseListBoxLabel.Size = new System.Drawing.Size(312, 20);
      this.FoundinFolderButNotDatabaseListBoxLabel.TabIndex = 6;
      this.FoundinFolderButNotDatabaseListBoxLabel.Text = "Found In Folder But Not Database Results";
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
      // FoundInDatabaseAndFolderListBoxLabel
      // 
      this.FoundInDatabaseAndFolderListBoxLabel.AutoSize = true;
      this.FoundInDatabaseAndFolderListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FoundInDatabaseAndFolderListBoxLabel.Location = new System.Drawing.Point(282, 317);
      this.FoundInDatabaseAndFolderListBoxLabel.Name = "FoundInDatabaseAndFolderListBoxLabel";
      this.FoundInDatabaseAndFolderListBoxLabel.Size = new System.Drawing.Size(287, 20);
      this.FoundInDatabaseAndFolderListBoxLabel.TabIndex = 8;
      this.FoundInDatabaseAndFolderListBoxLabel.Text = "Found In Folder And Database Results";
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
      // chosenFolderLabel
      // 
      this.chosenFolderLabel.AutoSize = true;
      this.chosenFolderLabel.Location = new System.Drawing.Point(140, 69);
      this.chosenFolderLabel.Name = "chosenFolderLabel";
      this.chosenFolderLabel.Size = new System.Drawing.Size(155, 13);
      this.chosenFolderLabel.TabIndex = 12;
      this.chosenFolderLabel.Text = "Please select a folder to search";
      // 
      // inDatabaseLabel
      // 
      this.inDatabaseLabel.AutoSize = true;
      this.inDatabaseLabel.Location = new System.Drawing.Point(269, 25);
      this.inDatabaseLabel.Name = "inDatabaseLabel";
      this.inDatabaseLabel.Size = new System.Drawing.Size(126, 13);
      this.inDatabaseLabel.TabIndex = 13;
      this.inDatabaseLabel.Text = "Please select a database";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(947, 585);
      this.Controls.Add(this.inDatabaseLabel);
      this.Controls.Add(this.chosenFolderLabel);
      this.Controls.Add(this.foundInBothLabel);
      this.Controls.Add(this.folderNoDatabaseLabel);
      this.Controls.Add(this.databaseNoFolderLabel);
      this.Controls.Add(this.FoundInDatabaseAndFolderListBoxLabel);
      this.Controls.Add(this.foundInFolderAndDatabaselistBox);
      this.Controls.Add(this.FoundinFolderButNotDatabaseListBoxLabel);
      this.Controls.Add(this.foundInFolderButNotDatabaselistBox);
      this.Controls.Add(this.headerLabel);
      this.Controls.Add(this.searchButton);
      this.Controls.Add(this.FoundInDatabaseButNotFolderListBoxLabel);
      this.Controls.Add(this.foundInDatabaseButNotFolderlistBox);
      this.Controls.Add(this.selectFolderButton);
      this.Name = "Form1";
      this.Text = "Missing Data Fix Finder";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.Button selectFolderButton;
    private System.Windows.Forms.ListBox foundInDatabaseButNotFolderlistBox;
    private System.Windows.Forms.Label FoundInDatabaseButNotFolderListBoxLabel;
    private System.Windows.Forms.Button searchButton;
    private System.Windows.Forms.Label headerLabel;
    private System.Windows.Forms.Label FoundinFolderButNotDatabaseListBoxLabel;
    private System.Windows.Forms.ListBox foundInFolderButNotDatabaselistBox;
    private System.Windows.Forms.Label FoundInDatabaseAndFolderListBoxLabel;
    private System.Windows.Forms.ListBox foundInFolderAndDatabaselistBox;
    private System.Windows.Forms.Label databaseNoFolderLabel;
    private System.Windows.Forms.Label folderNoDatabaseLabel;
    private System.Windows.Forms.Label foundInBothLabel;
    private System.Windows.Forms.Label chosenFolderLabel;
    private System.Windows.Forms.Label inDatabaseLabel;
  }
}

