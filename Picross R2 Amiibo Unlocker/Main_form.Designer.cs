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

namespace Picross_R2_Amiibo_Unlocker
{
    partial class Main_form
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
            this.label2 = new System.Windows.Forms.Label();
            this.Amiibo_status_label = new System.Windows.Forms.Label();
            this.Unlock_Amiibo_Levels_button = new System.Windows.Forms.Button();
            this.Open_SAVEDATA_button = new System.Windows.Forms.Button();
            this.Save1_radioButton = new System.Windows.Forms.RadioButton();
            this.Save2_radioButton = new System.Windows.Forms.RadioButton();
            this.Save3_radioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Save_SAVEDATA_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "By Rohul1997";
            // 
            // Amiibo_status_label
            // 
            this.Amiibo_status_label.AutoSize = true;
            this.Amiibo_status_label.Location = new System.Drawing.Point(214, 70);
            this.Amiibo_status_label.Name = "Amiibo_status_label";
            this.Amiibo_status_label.Size = new System.Drawing.Size(155, 13);
            this.Amiibo_status_label.TabIndex = 5;
            this.Amiibo_status_label.Text = "All Amiibo Levels Not Unlocked";
            // 
            // Unlock_Amiibo_Levels_button
            // 
            this.Unlock_Amiibo_Levels_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Unlock_Amiibo_Levels_button.Enabled = false;
            this.Unlock_Amiibo_Levels_button.Location = new System.Drawing.Point(11, 65);
            this.Unlock_Amiibo_Levels_button.Name = "Unlock_Amiibo_Levels_button";
            this.Unlock_Amiibo_Levels_button.Size = new System.Drawing.Size(182, 23);
            this.Unlock_Amiibo_Levels_button.TabIndex = 3;
            this.Unlock_Amiibo_Levels_button.Text = "Unlock All Amiibo Levels";
            this.Unlock_Amiibo_Levels_button.UseVisualStyleBackColor = true;
            this.Unlock_Amiibo_Levels_button.Click += new System.EventHandler(this.Unlock_Amiibo_Levels_button_Click);
            // 
            // Open_SAVEDATA_button
            // 
            this.Open_SAVEDATA_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Open_SAVEDATA_button.Location = new System.Drawing.Point(12, 36);
            this.Open_SAVEDATA_button.Name = "Open_SAVEDATA_button";
            this.Open_SAVEDATA_button.Size = new System.Drawing.Size(181, 23);
            this.Open_SAVEDATA_button.TabIndex = 4;
            this.Open_SAVEDATA_button.Text = "Open SAVEDATA";
            this.Open_SAVEDATA_button.UseVisualStyleBackColor = true;
            this.Open_SAVEDATA_button.Click += new System.EventHandler(this.Open_SAVEDATA_button_Click);
            // 
            // Save1_radioButton
            // 
            this.Save1_radioButton.AutoSize = true;
            this.Save1_radioButton.Checked = true;
            this.Save1_radioButton.Location = new System.Drawing.Point(190, 12);
            this.Save1_radioButton.Name = "Save1_radioButton";
            this.Save1_radioButton.Size = new System.Drawing.Size(59, 17);
            this.Save1_radioButton.TabIndex = 7;
            this.Save1_radioButton.TabStop = true;
            this.Save1_radioButton.Text = "Save 1";
            this.Save1_radioButton.UseVisualStyleBackColor = true;
            this.Save1_radioButton.CheckedChanged += new System.EventHandler(this.Read_save);
            // 
            // Save2_radioButton
            // 
            this.Save2_radioButton.AutoSize = true;
            this.Save2_radioButton.Location = new System.Drawing.Point(255, 12);
            this.Save2_radioButton.Name = "Save2_radioButton";
            this.Save2_radioButton.Size = new System.Drawing.Size(59, 17);
            this.Save2_radioButton.TabIndex = 7;
            this.Save2_radioButton.Text = "Save 2";
            this.Save2_radioButton.UseVisualStyleBackColor = true;
            this.Save2_radioButton.CheckedChanged += new System.EventHandler(this.Read_save);
            // 
            // Save3_radioButton
            // 
            this.Save3_radioButton.AutoSize = true;
            this.Save3_radioButton.Location = new System.Drawing.Point(320, 12);
            this.Save3_radioButton.Name = "Save3_radioButton";
            this.Save3_radioButton.Size = new System.Drawing.Size(59, 17);
            this.Save3_radioButton.TabIndex = 7;
            this.Save3_radioButton.Text = "Save 3";
            this.Save3_radioButton.UseVisualStyleBackColor = true;
            this.Save3_radioButton.CheckedChanged += new System.EventHandler(this.Read_save);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Save Slot";
            // 
            // Save_SAVEDATA_button
            // 
            this.Save_SAVEDATA_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Save_SAVEDATA_button.Enabled = false;
            this.Save_SAVEDATA_button.Location = new System.Drawing.Point(199, 36);
            this.Save_SAVEDATA_button.Name = "Save_SAVEDATA_button";
            this.Save_SAVEDATA_button.Size = new System.Drawing.Size(181, 23);
            this.Save_SAVEDATA_button.TabIndex = 4;
            this.Save_SAVEDATA_button.Text = "Save SAVEDATA";
            this.Save_SAVEDATA_button.UseVisualStyleBackColor = true;
            this.Save_SAVEDATA_button.Click += new System.EventHandler(this.Save_SAVEDATA_button_Click);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 97);
            this.Controls.Add(this.Save3_radioButton);
            this.Controls.Add(this.Save2_radioButton);
            this.Controls.Add(this.Save1_radioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Amiibo_status_label);
            this.Controls.Add(this.Unlock_Amiibo_Levels_button);
            this.Controls.Add(this.Save_SAVEDATA_button);
            this.Controls.Add(this.Open_SAVEDATA_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main_form";
            this.Text = "Picross 3D: Round 2 Amiibo Unlocker v2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Amiibo_status_label;
        private System.Windows.Forms.Button Unlock_Amiibo_Levels_button;
        private System.Windows.Forms.Button Open_SAVEDATA_button;
        private System.Windows.Forms.RadioButton Save1_radioButton;
        private System.Windows.Forms.RadioButton Save2_radioButton;
        private System.Windows.Forms.RadioButton Save3_radioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save_SAVEDATA_button;
    }
}

