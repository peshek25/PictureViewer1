﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewerPeshekhonova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog. If the user clicks OK, load the
            // picture that the user chose.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the picture.
            pictureBox1.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // Show the color dialog box. If the user clicks OK, change the
            // PictureBox control's background to the color the user chose.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // If the user selects the Stretch check box, 
            // change the PictureBox's
            // SizeMode property to "Stretch". If the user clears 
            // the check box, change it to "Normal".
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void растянутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
=======
=======
>>>>>>> 0e10e9e081830060f8b8dd374b1fca36d9d579c4
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
<<<<<<< HEAD
>>>>>>> 0e10e9e081830060f8b8dd374b1fca36d9d579c4
=======
>>>>>>> 0e10e9e081830060f8b8dd374b1fca36d9d579c4
        }

        private void изменитьЦветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            // Clear the picture.
            pictureBox1.Image = null;
        }

        private void удалитьФотоToolStripMenuItem_Click(object sender, EventArgs e)
        {
=======
>>>>>>> 0e10e9e081830060f8b8dd374b1fca36d9d579c4
=======
>>>>>>> 0e10e9e081830060f8b8dd374b1fca36d9d579c4
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

<<<<<<< HEAD
<<<<<<< HEAD
        private void вернутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
=======
=======
>>>>>>> 0e10e9e081830060f8b8dd374b1fca36d9d579c4
        private void удалитьФотоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear the picture.
            pictureBox1.Image = null;
<<<<<<< HEAD
>>>>>>> 0e10e9e081830060f8b8dd374b1fca36d9d579c4
=======
>>>>>>> 0e10e9e081830060f8b8dd374b1fca36d9d579c4
        }
    }
}
