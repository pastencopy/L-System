namespace L_System
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFractalBinaryTree = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDragonCurve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFractalBinaryTree
            // 
            this.btnFractalBinaryTree.Location = new System.Drawing.Point(896, 60);
            this.btnFractalBinaryTree.Name = "btnFractalBinaryTree";
            this.btnFractalBinaryTree.Size = new System.Drawing.Size(137, 33);
            this.btnFractalBinaryTree.TabIndex = 0;
            this.btnFractalBinaryTree.Text = "(1)Fractal Binary Tree";
            this.btnFractalBinaryTree.UseVisualStyleBackColor = true;
            this.btnFractalBinaryTree.Click += new System.EventHandler(this.btnFractalBinaryTree_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(12, 12);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(876, 709);
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(896, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 33);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "지우기";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(896, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "(2)Fractal plant";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDragonCurve
            // 
            this.btnDragonCurve.Location = new System.Drawing.Point(896, 138);
            this.btnDragonCurve.Name = "btnDragonCurve";
            this.btnDragonCurve.Size = new System.Drawing.Size(137, 33);
            this.btnDragonCurve.TabIndex = 4;
            this.btnDragonCurve.Text = "(3)Dragon curve";
            this.btnDragonCurve.UseVisualStyleBackColor = true;
            this.btnDragonCurve.Click += new System.EventHandler(this.btnDragonCurve_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 733);
            this.Controls.Add(this.btnDragonCurve);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.btnFractalBinaryTree);
            this.Name = "Form1";
            this.Text = "L-System";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFractalBinaryTree;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDragonCurve;
    }
}

