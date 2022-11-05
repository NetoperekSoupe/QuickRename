namespace QuickRename
{
    partial class TextureRenamecs
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label_TextureName = new System.Windows.Forms.Label();
            this.pictureBox_Texture = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox_Said = new System.Windows.Forms.ComboBox();
            this.textBox_NameTexture = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Texture)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label_TextureName);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox_Texture);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.comboBox2);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox_Said);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_NameTexture);
            this.splitContainer1.Size = new System.Drawing.Size(745, 72);
            this.splitContainer1.SplitterDistance = 168;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // label_TextureName
            // 
            this.label_TextureName.AutoSize = true;
            this.label_TextureName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_TextureName.Location = new System.Drawing.Point(73, 3);
            this.label_TextureName.Name = "label_TextureName";
            this.label_TextureName.Size = new System.Drawing.Size(35, 13);
            this.label_TextureName.TabIndex = 1;
            this.label_TextureName.Text = "label1";
            // 
            // pictureBox_Texture
            // 
            this.pictureBox_Texture.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_Texture.Name = "pictureBox_Texture";
            this.pictureBox_Texture.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_Texture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Texture.TabIndex = 0;
            this.pictureBox_Texture.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "Normal",
            "Albedo",
            "Roughness",
            "Opacity",
            "Mask"});
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "None",
            "Albedo",
            "Normal",
            "Opacity"});
            this.comboBox2.Location = new System.Drawing.Point(116, 24);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(164, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox_Said
            // 
            this.comboBox_Said.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_Said.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Said.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_Said.FormattingEnabled = true;
            this.comboBox_Said.Items.AddRange(new object[] {
            "None",
            "Prefix",
            "Suffix"});
            this.comboBox_Said.Location = new System.Drawing.Point(19, 24);
            this.comboBox_Said.Name = "comboBox_Said";
            this.comboBox_Said.Size = new System.Drawing.Size(91, 21);
            this.comboBox_Said.TabIndex = 1;
            // 
            // textBox_NameTexture
            // 
            this.textBox_NameTexture.Location = new System.Drawing.Point(286, 24);
            this.textBox_NameTexture.Name = "textBox_NameTexture";
            this.textBox_NameTexture.Size = new System.Drawing.Size(284, 20);
            this.textBox_NameTexture.TabIndex = 0;
            // 
            // TextureRenamecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.splitContainer1);
            this.Name = "TextureRenamecs";
            this.Size = new System.Drawing.Size(745, 72);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Texture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label_TextureName;
        private System.Windows.Forms.PictureBox pictureBox_Texture;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox_Said;
        private System.Windows.Forms.TextBox textBox_NameTexture;
    }
}
