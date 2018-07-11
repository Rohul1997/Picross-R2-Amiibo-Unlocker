/*
 *   This file is part of Picross R2 Amiibo Unlocker
 *   Copyright (C) 2016-2018 Rohul1997
 *
 *   This program is free software: you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation, version 3 of the License
 *
 *   This program is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU General Public License for more details.
 *
 *   You should have received a copy of the GNU General Public License
 *   along with this program.  If not, see <http://www.gnu.org/licenses/>.
 *
 *   Additional Terms 7.b and 7.c of GPLv3 apply to this file:
 *       * Requiring preservation of specified reasonable legal notices or
 *         author attributions in that material or in the Appropriate Legal
 *         Notices displayed by works containing it.
 *       * Prohibiting misrepresentation of the origin of that material,
 *         or requiring that modified versions of such material be marked in
 *         reasonable ways as different from the original version.
 */

using System;
using System.IO;
using System.Windows.Forms;

namespace Picross_R2_Amiibo_Unlocker
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
        }

        OpenFileDialog open = new OpenFileDialog();
        byte[] savedata;

        private void Open_SAVEDATA_button_Click(object sender, EventArgs e)
        {
            try
            {
                Save_SAVEDATA_button.Enabled = Unlock_Amiibo_Levels_button.Enabled = false;

                open.Filter = " SAVEDATA Files|SAVEDATA|All Files (*.*)|*.*";
                if (open.ShowDialog() != DialogResult.OK) return;

                savedata = File.ReadAllBytes(open.FileName);
                if (savedata.Length != 0xB278)
                {
                    MessageBox.Show("The SAVEDATA file chosen is either corrupted or invalid!", "Error!");
                    return;
                }

                Read_save(null, null);

                Save_SAVEDATA_button.Enabled = Unlock_Amiibo_Levels_button.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Invalid SAVEDATA file!\n\n{ex}", "Failed to open the file!");
            }
        }

        private void Save_SAVEDATA_button_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllBytes(open.FileName, savedata);
                MessageBox.Show($"Successfully saved to:\n{open.FileName}", "Successfully saved the file!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save onto:\n{open.FileName}\n\n{ex}", "Error!");
            }

        }

        private void Read_save(object sender, EventArgs e)
        {
            if (savedata == null) return;
            try
            {
                ushort baseOffset = 0;
                if (Save1_radioButton.Checked == true) baseOffset = 0x1AAC;
                if (Save2_radioButton.Checked == true) baseOffset = 0x55C4;
                if (Save3_radioButton.Checked == true) baseOffset = 0x913C;

                for (int i = 0; i < 9; i++)
                {
                    if (savedata[baseOffset] != 0x09)
                    {
                        Amiibo_status_label.Text = "All Amiibo Levels Not Unlocked";
                        break;
                    }
                    else
                    {
                        Amiibo_status_label.Text = "All Amiibo Levels Unlocked!";
                    }
                    baseOffset += 0x10;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to read save!\n\n{ex}", "Error!");
            }
        }

        private void Unlock_Amiibo_Levels_button_Click(object sender, EventArgs e)
        {
            try
            {
                ushort baseOffset = 0;
                if (Save1_radioButton.Checked == true) baseOffset = 0x1AAC;
                if (Save2_radioButton.Checked == true) baseOffset = 0x55C4;
                if (Save3_radioButton.Checked == true) baseOffset = 0x913C;

                for (int i = 0; i < 9; i++)
                {
                    savedata[baseOffset] = 0x09;
                    baseOffset += 0x10;
                }
                Read_save(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to unlock all amiibo levels!\n\n{ex}", "Error!");
            }
        }
    }
}
