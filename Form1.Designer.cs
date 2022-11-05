namespace QuickRename
{
    partial class TextureRename
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextureRename));
            this.panel_DropTextures = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_BaseName = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Rename = new System.Windows.Forms.Button();
            this.panel_DropTextures.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_DropTextures
            // 
            this.panel_DropTextures.AllowDrop = true;
            this.panel_DropTextures.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_DropTextures.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_DropTextures.Controls.Add(this.label1);
            this.panel_DropTextures.Location = new System.Drawing.Point(12, 12);
            this.panel_DropTextures.Name = "panel_DropTextures";
            this.panel_DropTextures.Size = new System.Drawing.Size(179, 179);
            this.panel_DropTextures.TabIndex = 0;
            this.panel_DropTextures.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DropTextures_DragDrop);
            this.panel_DropTextures.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DropTextures_DragEnter);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 179);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drope\r\nTextures\r\nHere";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(197, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Base Name Textures:";
            // 
            // textBox_BaseName
            // 
            this.textBox_BaseName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_BaseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_BaseName.Location = new System.Drawing.Point(312, 24);
            this.textBox_BaseName.Name = "textBox_BaseName";
            this.textBox_BaseName.Size = new System.Drawing.Size(219, 20);
            this.textBox_BaseName.TabIndex = 2;
            this.textBox_BaseName.TextChanged += new System.EventHandler(this.textBox_BaseName_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(197, 55);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(752, 383);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // button_Rename
            // 
            this.button_Rename.BackColor = System.Drawing.Color.Snow;
            this.button_Rename.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Rename.Location = new System.Drawing.Point(874, 22);
            this.button_Rename.Name = "button_Rename";
            this.button_Rename.Size = new System.Drawing.Size(75, 23);
            this.button_Rename.TabIndex = 4;
            this.button_Rename.Text = "Rename";
            this.button_Rename.UseVisualStyleBackColor = false;
            this.button_Rename.Click += new System.EventHandler(this.button_Rename_Click);
            // 
            // TextureRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(961, 450);
            this.Controls.Add(this.button_Rename);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBox_BaseName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_DropTextures);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextureRename";
            this.Text = "Texture Rename";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_DropTextures.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_DropTextures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_BaseName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_Rename;
    }
}

