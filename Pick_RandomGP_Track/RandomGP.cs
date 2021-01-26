using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pick_RandomGP_Track
{
    public partial class RandomGP : Form
    {
        string fullFilePath;
        public RandomGP()
        {
            InitializeComponent();
        }

        private void importTracksButton_Click(object sender, EventArgs e)
        {
            ImportTrackList();
        }

        private void exportTracksButton_Click(object sender, EventArgs e)
        {
            ExportTracksList();
        }

        private void selectTrackButton_Click(object sender, EventArgs e)
        {
            SelectRandomGPTrack();
        }

        private void addToListButton_Click(object sender, EventArgs e)
        {
            if (trackNameTextBox.Text != "" && !tracksListBox.Items.Contains(trackNameTextBox.Text))
            {
                tracksListBox.Items.Add(trackNameTextBox.Text);
                trackNameTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("You are either trying to add empty named track or the track name you entered is already in the list.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tracksListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (tracksListBox.SelectedItem.ToString() != "")
                {
                    tracksListBox.Items.RemoveAt(tracksListBox.SelectedIndex);
                }
            }
        }

        private void ImportTrackList()
        {
            string[] lines;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select The Text File That Contains Track Names";
            ofd.Filter = "Text Files (.txt)|*.txt;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fullFilePath = ofd.FileName;
                lines = File.ReadAllLines(ofd.FileName, Encoding.UTF8);
                foreach (string item in lines)
                {
                    if (item != "")
                        tracksListBox.Items.Add(item);
                }
            }
        }

        private void ExportTracksList()
        {
            string[] tracksListArray;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Select or Name The Text File That You Want To Save Tracks List On";
            sfd.Filter = "Text Files (.txt)|*.txt;";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                tracksListArray = tracksListBox.Items.OfType<string>().ToArray();
                File.WriteAllLines(sfd.FileName, tracksListArray);
            }
        }

        private void SelectRandomGPTrack()
        {
            if (tracksListBox.Items.Count > 0)
            {
                Random rn = new Random();
                int selectedIndex = rn.Next(0, tracksListBox.Items.Count);
                string selectedTrack = tracksListBox.Items[selectedIndex].ToString();
                selectedTrackLabel.Text = "Selected Track: " + selectedTrack;
                if (removeSelectedTrackCheckBox.Checked)
                {
                    tracksListBox.Items.RemoveAt(selectedIndex);
                }
                if (overwriteImportedFileCheckbox.Checked && fullFilePath != null)
                {
                    string[] tracksListArray;
                    tracksListArray = tracksListBox.Items.OfType<string>().ToArray();
                    File.WriteAllLines(fullFilePath, tracksListArray);
                }
                else if (fullFilePath == null && overwriteImportedFileCheckbox.Checked)
                {
                    MessageBox.Show("You can't overwrite without importing a track list. You need to import a track list first.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You tried to select a track from an empty list.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
