using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L_System
{
    public partial class Form1 : Form
    {
        FractalBinaryTree tree = new FractalBinaryTree();
        Bitmap drawImage;

        public Form1()
        {
            InitializeComponent();

            drawImage = new Bitmap(picCanvas.Width, picCanvas.Height);

            Graphics.FromImage(drawImage).Clear(Color.White);

            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnFractalBinaryTree_Click(object sender, EventArgs e)
        {
            if (tree.ageOfTree >= 8)
            {
                MessageBox.Show("이미 최대값으로 그렸습니다.");
                return;
            }

            Graphics.FromImage(drawImage).Clear(Color.White);

            tree.Grow();
            tree.Draw(Graphics.FromImage(drawImage),picCanvas.Width / 2,picCanvas.Height);

            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);

            this.Text = string.Format("{0} 세대 트리 / (MAX:8세대)", tree.ageOfTree);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Graphics.FromImage(drawImage).Clear(Color.White);

            tree = new FractalBinaryTree();

            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }
    }
}
