using System;
using System.IO;
using System.Windows.Forms;

namespace Picross_R2_Amiibo_Unlocker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog open = new OpenFileDialog();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string savedata = open.FileName;
                open.Filter = " SAVEDATA File |";
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    button2.Enabled = true;
                BinaryReader br = new BinaryReader(File.OpenRead(open.FileName));
                string amiibo = null;
                for (int i = 0x1A40; i <= 0x1ACF; i++)
                {
                    br.BaseStream.Position = i;
                    amiibo += br.ReadByte().ToString("X2");
                }
                br.Close();
                if (amiibo == "000000000000000000000000090000000000000000000000000000000900000000000000000000000000000009000000000000000000000000000000090000000000000000000000000000000900000000000000000000000000000009000000000000000000000000000000090000000000000000000000000000000900000000000000000000000000000009000000")
                label1.Text = "Amiibo Levels Unlocked";
                else label1.Text = "Amiibo Levels Locked";
            }
            catch
            {
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(File.OpenWrite(open.FileName));

            bw.BaseStream.Position = 0x1A4C;
            bw.Write(0x09);

            bw.BaseStream.Position = 0x1A5C;
            bw.Write(0x09);

            bw.BaseStream.Position = 0x1A6C;
            bw.Write(0x09);

            bw.BaseStream.Position = 0x1A7C;
            bw.Write(0x09);

            bw.BaseStream.Position = 0x1A8C;
            bw.Write(0x09);

            bw.BaseStream.Position = 0x1A9C;
            bw.Write(0x09);

            bw.BaseStream.Position = 0x1AAC;
            bw.Write(0x09);

            bw.BaseStream.Position = 0x1ABC;
            bw.Write(0x09);

            bw.BaseStream.Position = 0x1ACC;
            bw.Write(0x09);
            bw.Close();
            label1.Text = "Amiibo Levels Unlocked";
        }
    }
}
