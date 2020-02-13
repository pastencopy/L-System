/*
 *  L-System
 * 
 * 
 *   Coded by 2020-02-14 GwangSu Lee
 * 
 * Turtle Graphics : https://en.wikipedia.org/wiki/Turtle_graphics
 * L-System Rerefence : https://en.wikipedia.org/wiki/L-system
 * 
 * */
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
        FractalBinaryTree fractalBinaryTree = new FractalBinaryTree();
        FractalPlant fractalPlant = new FractalPlant();
        DragonCurve dragonCurve = new DragonCurve();

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
            if (fractalBinaryTree.ageOfTree >= 8)
            {
                MessageBox.Show("이미 최대값으로 그렸습니다.");
                return;
            }

            Graphics.FromImage(drawImage).Clear(Color.White);

            fractalBinaryTree.Grow();
            fractalBinaryTree.Draw(Graphics.FromImage(drawImage),picCanvas.Width / 2,picCanvas.Height);

            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);

            this.Text = string.Format("{0} 세대 FractalBinaryTree / (MAX:8세대)", fractalBinaryTree.ageOfTree);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Graphics.FromImage(drawImage).Clear(Color.White);

            fractalBinaryTree = new FractalBinaryTree();
            fractalPlant = new FractalPlant();
            dragonCurve = new DragonCurve();

            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fractalPlant.ageOfTree >= 7)
            {
                MessageBox.Show("이미 최대값으로 그렸습니다.");
                return;
            }

            Graphics.FromImage(drawImage).Clear(Color.White);

            fractalPlant.Grow();
            fractalPlant.Draw(Graphics.FromImage(drawImage), 50, picCanvas.Height);

            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);

            this.Text = string.Format("{0} 세대 FractalPlant / (MAX:7세대)", fractalPlant.ageOfTree);
        }

        private void btnDragonCurve_Click(object sender, EventArgs e)
        {
            if (dragonCurve.ageOfTree >= 10)
            {
                MessageBox.Show("이미 최대값으로 그렸습니다.");
                return;
            }

            Graphics.FromImage(drawImage).Clear(Color.White);

            dragonCurve.Grow();
            dragonCurve.Draw(Graphics.FromImage(drawImage), picCanvas.Width/2, picCanvas.Height/2);

            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);

            this.Text = string.Format("{0} 세대 DragonCurve / (MAX:10세대)", dragonCurve.ageOfTree);
        }
    }
}
