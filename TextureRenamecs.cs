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

namespace QuickRename
{
    public partial class TextureRenamecs : UserControl
    {
        private NameFile _nameFile;
        private string _path;


        public string PathTexture { get; set; }
        public delegate void stringChange(string name);
        public stringChange OnUpdate;
        public TextureRenamecs()
        {
            InitializeComponent();
            OnLoad();
            OnUpdate += Update;
        }
        private void OnLoad()
        {
            comboBox_Said.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
        protected override void OnHandleDestroyed(EventArgs e)
        {
            OnUpdate -= Update;
            pictureBox_Texture.Dispose();
        }
        public void Update(string path)
        {
            pictureBox_Texture.Image = Image.FromFile(path);
            label_TextureName.Text = Path.GetFileName(path);
            _path = path;
        }

        public void AcceptChange()
        {
            _nameFile.Said = comboBox_Said.Text;
            _nameFile.TypeTexture = comboBox2.Text;
            _nameFile.NameTexture = textBox_NameTexture.Text;
            _nameFile.BaseName = TextureRename.BaseNameTexture;
            pictureBox_Texture.Image.Dispose();
            string pathNew = _path.Replace(Path.GetFileNameWithoutExtension(_path), _nameFile.CombainName());
            File.Move(_path, pathNew);
            
        }
        public struct NameFile
        {
            public string Said { get; set; }
            public string TypeTexture { get; set; }
            public string NameTexture { get; set; }
            public string BaseName { get; set; }
            public string CombainName()
            {
                string name;
                if (NameTexture != String.Empty)
                    name = BaseName + "_" + NameTexture;
                else
                    name = BaseName;
                switch (Said)
                {
                    case "None":
                        break;
                    case "Prefix":
                        if (TypeTexture != "None")
                            name = TypeTexture + "_" + name;
                        break;
                    case "Suffix":
                        if (TypeTexture != "None")
                            name = name + "_" + TypeTexture;
                        break;
                    default:
                        break;
                }

                return name;
            }

        }
    }

}
