using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImageViwer
{
    public partial class Form1 : Form
    {
        private class ImageNode
        {
            public string ImagePath { get; }
            public ImageNode Next { get; set; }
            public ImageNode Prev { get; set; }

            public ImageNode(string imagePath)
            {
                ImagePath = imagePath;
                Next = null;
                Prev = null;
            }
        }

        private ImageNode firstImage = null;
        private ImageNode currentImage = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void btn_preivious_Click(object sender, EventArgs e)
        {
            if (currentImage != null && currentImage.Prev != null)
            {
                currentImage = currentImage.Prev;
                DisplayImage();
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (currentImage != null && currentImage.Next != null)
            {
                currentImage = currentImage.Next;
                DisplayImage();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = ofd.FileName;
                    ImageNode newNode = new ImageNode(imagePath);

                    if (firstImage == null)
                    {
                        firstImage = newNode;
                        currentImage = newNode;
                    }
                    else
                    {
                        newNode.Prev = currentImage;
                        currentImage.Next = newNode;
                        currentImage = newNode;
                    }

                    DisplayImage();
                }
            }
        }

        private void DisplayImage()
        {
            if (currentImage != null)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(currentImage.ImagePath);
            }
        }

        private void btn_addFirst_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = ofd.FileName;
                    ImageNode newNode = new ImageNode(imagePath);

                    if (firstImage == null)
                    {
                        firstImage = newNode;
                        currentImage = newNode;
                    }
                    else
                    {
                        firstImage.Prev = newNode;
                        newNode.Next = firstImage;
                
                        firstImage = newNode;
                    }

                    DisplayImage();
                }
            }
        }

        private void btn_Firstimg_Click(object sender, EventArgs e)
        {
            if (firstImage != null)
            {
                currentImage = firstImage;
                DisplayImage();
            }
        }

        private void btn_Lastimg_Click(object sender, EventArgs e)
        {
            if (currentImage != null)
            {
                while (currentImage.Next != null)
                {
                    currentImage = currentImage.Next;
                }

                DisplayImage();
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (currentImage != null)
            {
                ImageNode prevNode = currentImage.Prev;
                ImageNode nextNode = currentImage.Next;              
                if (prevNode != null)
                {
                    prevNode.Next = nextNode;
                }
                else
                {                  
                    firstImage = nextNode;
                }

                if (nextNode != null)
                {
                    nextNode.Prev = prevNode;
                }

                currentImage = (nextNode != null) ? nextNode : prevNode;

                if (currentImage != null)
                {
                    DisplayImage();
                }
                else
                {
                    pictureBox1.Image = null;
                    MessageBox.Show("No more images in the list.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
