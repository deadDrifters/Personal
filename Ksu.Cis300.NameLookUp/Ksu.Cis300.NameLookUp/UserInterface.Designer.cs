namespace Ksu.Cis300.NameLookUp
{
    partial class UserInterface
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
            this.UxTextBox = new System.Windows.Forms.TextBox();
            this.UxFindNames = new System.Windows.Forms.Button();
            this.statList = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.frequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cumFrequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UxLoadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.UxSaveResults = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UxTextBox
            // 
            this.UxTextBox.Location = new System.Drawing.Point(12, 52);
            this.UxTextBox.Name = "UxTextBox";
            this.UxTextBox.Size = new System.Drawing.Size(379, 20);
            this.UxTextBox.TabIndex = 0;
            this.UxTextBox.TextChanged += new System.EventHandler(this.UxTextBox_TextChanged);
            // 
            // UxFindNames
            // 
            this.UxFindNames.Enabled = false;
            this.UxFindNames.Location = new System.Drawing.Point(408, 50);
            this.UxFindNames.Name = "UxFindNames";
            this.UxFindNames.Size = new System.Drawing.Size(75, 23);
            this.UxFindNames.TabIndex = 2;
            this.UxFindNames.Text = "Find Names";
            this.UxFindNames.UseVisualStyleBackColor = true;
            this.UxFindNames.Click += new System.EventHandler(this.button1_Click);
            // 
            // statList
            // 
            this.statList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.frequency,
            this.cumFrequency,
            this.rank});
            this.statList.GridLines = true;
            this.statList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.statList.Location = new System.Drawing.Point(12, 116);
            this.statList.Name = "statList";
            this.statList.Size = new System.Drawing.Size(471, 331);
            this.statList.TabIndex = 3;
            this.statList.UseCompatibleStateImageBehavior = false;
            this.statList.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 193;
            // 
            // frequency
            // 
            this.frequency.Text = "Frequency";
            this.frequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.frequency.Width = 92;
            // 
            // cumFrequency
            // 
            this.cumFrequency.Text = "Cumulative Frequency";
            this.cumFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cumFrequency.Width = 130;
            // 
            // rank
            // 
            this.rank.Text = "Rank";
            this.rank.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rank.Width = 55;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UxLoadFile,
            this.UxSaveResults});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // UxLoadFile
            // 
            this.UxLoadFile.Name = "UxLoadFile";
            this.UxLoadFile.Size = new System.Drawing.Size(138, 22);
            this.UxLoadFile.Text = "Load File";
            this.UxLoadFile.Click += new System.EventHandler(this.UxLoadFile_Click);
            // 
            // UxSaveResults
            // 
            this.UxSaveResults.Enabled = false;
            this.UxSaveResults.Name = "UxSaveResults";
            this.UxSaveResults.Size = new System.Drawing.Size(152, 22);
            this.UxSaveResults.Text = "Save Results";
            this.UxSaveResults.Click += new System.EventHandler(this.UxSaveResults_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(12, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(293, 13);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Results";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Type the beginning of the name(s) you wish to find:";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.statList);
            this.Controls.Add(this.UxFindNames);
            this.Controls.Add(this.UxTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserInterface";
            this.Text = "Name Lookup";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UxTextBox;
        private System.Windows.Forms.Button UxFindNames;
        private System.Windows.Forms.ListView statList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ColumnHeader rank;
        private System.Windows.Forms.ColumnHeader cumFrequency;
        private System.Windows.Forms.ColumnHeader frequency;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UxLoadFile;
        private System.Windows.Forms.ToolStripMenuItem UxSaveResults;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}

