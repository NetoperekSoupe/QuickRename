using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickRename
{
    public partial class TextureRename : Form
    {
        public static string BaseNameTexture { get; private set; }
        private delegate void Accept();
        private Accept onAccept;
        public TextureRename()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_BaseName_TextChanged(object sender, EventArgs e)
        {
            BaseNameTexture = textBox_BaseName.Text;
        }

        private void panel_DropTextures_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panel_DropTextures_DragDrop(object sender, DragEventArgs e)
        {
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string path in paths)
            {
                TextureRenamecs textureRenamecs = new TextureRenamecs();
                textureRenamecs.Update(path);
                onAccept += textureRenamecs.AcceptChange;
                flowLayoutPanel1.Controls.Add(textureRenamecs);
            }
        }

        private void button_Rename_Click(object sender, EventArgs e)
        {
            onAccept?.Invoke();
            foreach (TextureRenamecs cs in flowLayoutPanel1.Controls)
                onAccept -= cs.AcceptChange;
            flowLayoutPanel1.Controls.Clear();
        }
    }
}
