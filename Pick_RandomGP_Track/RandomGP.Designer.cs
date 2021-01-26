
namespace Pick_RandomGP_Track
{
    partial class RandomGP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomGP));
            this.importTracksButton = new System.Windows.Forms.Button();
            this.tracksListBox = new System.Windows.Forms.ListBox();
            this.exportTracksButton = new System.Windows.Forms.Button();
            this.selectTrackButton = new System.Windows.Forms.Button();
            this.removeSelectedTrackCheckBox = new System.Windows.Forms.CheckBox();
            this.trackNameTextBox = new System.Windows.Forms.TextBox();
            this.addToListButton = new System.Windows.Forms.Button();
            this.selectedTrackLabel = new System.Windows.Forms.Label();
            this.overwriteImportedFileCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // importTracksButton
            // 
            this.importTracksButton.BackColor = System.Drawing.Color.Black;
            this.importTracksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importTracksButton.ForeColor = System.Drawing.SystemColors.Window;
            this.importTracksButton.Location = new System.Drawing.Point(22, 12);
            this.importTracksButton.Name = "importTracksButton";
            this.importTracksButton.Size = new System.Drawing.Size(120, 23);
            this.importTracksButton.TabIndex = 0;
            this.importTracksButton.Text = "Import GP Tracks";
            this.importTracksButton.UseVisualStyleBackColor = false;
            this.importTracksButton.Click += new System.EventHandler(this.importTracksButton_Click);
            // 
            // tracksListBox
            // 
            this.tracksListBox.BackColor = System.Drawing.Color.Black;
            this.tracksListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tracksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tracksListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.tracksListBox.FormattingEnabled = true;
            this.tracksListBox.Location = new System.Drawing.Point(22, 41);
            this.tracksListBox.Name = "tracksListBox";
            this.tracksListBox.Size = new System.Drawing.Size(120, 314);
            this.tracksListBox.TabIndex = 1;
            this.tracksListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tracksListBox_MouseClick);
            // 
            // exportTracksButton
            // 
            this.exportTracksButton.BackColor = System.Drawing.Color.Black;
            this.exportTracksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportTracksButton.ForeColor = System.Drawing.SystemColors.Window;
            this.exportTracksButton.Location = new System.Drawing.Point(22, 361);
            this.exportTracksButton.Name = "exportTracksButton";
            this.exportTracksButton.Size = new System.Drawing.Size(120, 23);
            this.exportTracksButton.TabIndex = 2;
            this.exportTracksButton.Text = "Export GP Tracks";
            this.exportTracksButton.UseVisualStyleBackColor = false;
            this.exportTracksButton.Click += new System.EventHandler(this.exportTracksButton_Click);
            // 
            // selectTrackButton
            // 
            this.selectTrackButton.BackColor = System.Drawing.Color.Black;
            this.selectTrackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectTrackButton.ForeColor = System.Drawing.SystemColors.Window;
            this.selectTrackButton.Location = new System.Drawing.Point(206, 70);
            this.selectTrackButton.Name = "selectTrackButton";
            this.selectTrackButton.Size = new System.Drawing.Size(142, 23);
            this.selectTrackButton.TabIndex = 3;
            this.selectTrackButton.Text = "Select Grand Prix Track";
            this.selectTrackButton.UseVisualStyleBackColor = false;
            this.selectTrackButton.Click += new System.EventHandler(this.selectTrackButton_Click);
            // 
            // removeSelectedTrackCheckBox
            // 
            this.removeSelectedTrackCheckBox.AutoSize = true;
            this.removeSelectedTrackCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.removeSelectedTrackCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedTrackCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.removeSelectedTrackCheckBox.Location = new System.Drawing.Point(155, 99);
            this.removeSelectedTrackCheckBox.Name = "removeSelectedTrackCheckBox";
            this.removeSelectedTrackCheckBox.Size = new System.Drawing.Size(247, 17);
            this.removeSelectedTrackCheckBox.TabIndex = 4;
            this.removeSelectedTrackCheckBox.Text = "Remove Selected Track From the List?";
            this.removeSelectedTrackCheckBox.UseVisualStyleBackColor = false;
            // 
            // trackNameTextBox
            // 
            this.trackNameTextBox.BackColor = System.Drawing.Color.Black;
            this.trackNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trackNameTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.trackNameTextBox.Location = new System.Drawing.Point(169, 41);
            this.trackNameTextBox.Name = "trackNameTextBox";
            this.trackNameTextBox.Size = new System.Drawing.Size(107, 20);
            this.trackNameTextBox.TabIndex = 5;
            // 
            // addToListButton
            // 
            this.addToListButton.BackColor = System.Drawing.Color.Black;
            this.addToListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToListButton.ForeColor = System.Drawing.SystemColors.Window;
            this.addToListButton.Location = new System.Drawing.Point(286, 41);
            this.addToListButton.Name = "addToListButton";
            this.addToListButton.Size = new System.Drawing.Size(107, 23);
            this.addToListButton.TabIndex = 6;
            this.addToListButton.Text = "Add To Tracks List";
            this.addToListButton.UseVisualStyleBackColor = false;
            this.addToListButton.Click += new System.EventHandler(this.addToListButton_Click);
            // 
            // selectedTrackLabel
            // 
            this.selectedTrackLabel.AutoSize = true;
            this.selectedTrackLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectedTrackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedTrackLabel.ForeColor = System.Drawing.Color.Gold;
            this.selectedTrackLabel.Location = new System.Drawing.Point(152, 152);
            this.selectedTrackLabel.Name = "selectedTrackLabel";
            this.selectedTrackLabel.Size = new System.Drawing.Size(0, 20);
            this.selectedTrackLabel.TabIndex = 7;
            // 
            // overwriteImportedFileCheckbox
            // 
            this.overwriteImportedFileCheckbox.AutoSize = true;
            this.overwriteImportedFileCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.overwriteImportedFileCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overwriteImportedFileCheckbox.ForeColor = System.Drawing.SystemColors.Window;
            this.overwriteImportedFileCheckbox.Location = new System.Drawing.Point(155, 122);
            this.overwriteImportedFileCheckbox.Name = "overwriteImportedFileCheckbox";
            this.overwriteImportedFileCheckbox.Size = new System.Drawing.Size(252, 17);
            this.overwriteImportedFileCheckbox.TabIndex = 8;
            this.overwriteImportedFileCheckbox.Text = "Overwrite Imported File After Selection?";
            this.overwriteImportedFileCheckbox.UseVisualStyleBackColor = false;
            // 
            // RandomGP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(405, 405);
            this.Controls.Add(this.overwriteImportedFileCheckbox);
            this.Controls.Add(this.selectedTrackLabel);
            this.Controls.Add(this.addToListButton);
            this.Controls.Add(this.trackNameTextBox);
            this.Controls.Add(this.removeSelectedTrackCheckBox);
            this.Controls.Add(this.selectTrackButton);
            this.Controls.Add(this.exportTracksButton);
            this.Controls.Add(this.tracksListBox);
            this.Controls.Add(this.importTracksButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RandomGP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Grand Prix Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button importTracksButton;
        private System.Windows.Forms.ListBox tracksListBox;
        private System.Windows.Forms.Button exportTracksButton;
        private System.Windows.Forms.Button selectTrackButton;
        private System.Windows.Forms.CheckBox removeSelectedTrackCheckBox;
        private System.Windows.Forms.TextBox trackNameTextBox;
        private System.Windows.Forms.Button addToListButton;
        private System.Windows.Forms.Label selectedTrackLabel;
        private System.Windows.Forms.CheckBox overwriteImportedFileCheckbox;
    }
}

