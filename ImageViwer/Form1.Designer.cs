namespace ImageViwer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_preivious = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_addFirst = new System.Windows.Forms.Button();
            this.btn_Lastimg = new System.Windows.Forms.Button();
            this.btn_Firstimg = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(827, 628);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_preivious
            // 
            this.btn_preivious.BackColor = System.Drawing.Color.Black;
            this.btn_preivious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_preivious.Font = new System.Drawing.Font("ComicShannsMono Nerd Font", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preivious.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_preivious.Location = new System.Drawing.Point(184, 567);
            this.btn_preivious.Name = "btn_preivious";
            this.btn_preivious.Size = new System.Drawing.Size(44, 57);
            this.btn_preivious.TabIndex = 1;
            this.btn_preivious.Text = "󰒮";
            this.toolTip1.SetToolTip(this.btn_preivious, "Previous Image");
            this.btn_preivious.UseVisualStyleBackColor = false;
            this.btn_preivious.Click += new System.EventHandler(this.btn_preivious_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Black;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_next.Font = new System.Drawing.Font("ComicShannsMono Nerd Font", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_next.Location = new System.Drawing.Point(620, 566);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(44, 54);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "󰒭";
            this.toolTip1.SetToolTip(this.btn_next, "Next Image");
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Black;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("ComicShannsMono Nerd Font", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Location = new System.Drawing.Point(462, 568);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(77, 54);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "󰡼";
            this.toolTip1.SetToolTip(this.btn_add, "Add Image");
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_addFirst
            // 
            this.btn_addFirst.BackColor = System.Drawing.Color.Black;
            this.btn_addFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addFirst.Font = new System.Drawing.Font("ComicShannsMono Nerd Font", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addFirst.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_addFirst.Location = new System.Drawing.Point(300, 568);
            this.btn_addFirst.Name = "btn_addFirst";
            this.btn_addFirst.Size = new System.Drawing.Size(87, 54);
            this.btn_addFirst.TabIndex = 4;
            this.btn_addFirst.Text = " 󰡼";
            this.toolTip1.SetToolTip(this.btn_addFirst, "Add Image in Front");
            this.btn_addFirst.UseVisualStyleBackColor = false;
            this.btn_addFirst.Click += new System.EventHandler(this.btn_addFirst_Click);
            // 
            // btn_Lastimg
            // 
            this.btn_Lastimg.BackColor = System.Drawing.Color.Black;
            this.btn_Lastimg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Lastimg.Font = new System.Drawing.Font("ComicShannsMono Nerd Font", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lastimg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Lastimg.Location = new System.Drawing.Point(670, 566);
            this.btn_Lastimg.Name = "btn_Lastimg";
            this.btn_Lastimg.Size = new System.Drawing.Size(45, 54);
            this.btn_Lastimg.TabIndex = 5;
            this.btn_Lastimg.Text = "󰒬";
            this.toolTip1.SetToolTip(this.btn_Lastimg, "Last Image");
            this.btn_Lastimg.UseVisualStyleBackColor = false;
            this.btn_Lastimg.Click += new System.EventHandler(this.btn_Lastimg_Click);
            // 
            // btn_Firstimg
            // 
            this.btn_Firstimg.BackColor = System.Drawing.Color.Black;
            this.btn_Firstimg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Firstimg.Font = new System.Drawing.Font("ComicShannsMono Nerd Font", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Firstimg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Firstimg.Location = new System.Drawing.Point(133, 567);
            this.btn_Firstimg.Name = "btn_Firstimg";
            this.btn_Firstimg.Size = new System.Drawing.Size(45, 57);
            this.btn_Firstimg.TabIndex = 6;
            this.btn_Firstimg.Text = "󰒫";
            this.toolTip1.SetToolTip(this.btn_Firstimg, "First Image");
            this.btn_Firstimg.UseVisualStyleBackColor = false;
            this.btn_Firstimg.Click += new System.EventHandler(this.btn_Firstimg_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.Black;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_remove.Font = new System.Drawing.Font("ComicShannsMono Nerd Font", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_remove.Location = new System.Drawing.Point(393, 567);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(63, 55);
            this.btn_remove.TabIndex = 7;
            this.btn_remove.Text = "";
            this.toolTip1.SetToolTip(this.btn_remove, "Remove Image");
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(833, 634);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_Firstimg);
            this.Controls.Add(this.btn_Lastimg);
            this.Controls.Add(this.btn_addFirst);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_preivious);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Image Viwer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_preivious;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_addFirst;
        private System.Windows.Forms.Button btn_Lastimg;
        private System.Windows.Forms.Button btn_Firstimg;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

