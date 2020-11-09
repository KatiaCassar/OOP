namespace Lesson6_ShapesCanvas
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
            this.pnlToolBox = new System.Windows.Forms.Panel();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblShapes = new System.Windows.Forms.Label();
            this.cmbShapes = new System.Windows.Forms.ComboBox();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.pnlToolBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolBox
            // 
            this.pnlToolBox.Controls.Add(this.txtRadius);
            this.pnlToolBox.Controls.Add(this.lblRadius);
            this.pnlToolBox.Controls.Add(this.lblShapes);
            this.pnlToolBox.Controls.Add(this.cmbShapes);
            this.pnlToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBox.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlToolBox.Name = "pnlToolBox";
            this.pnlToolBox.Size = new System.Drawing.Size(1388, 185);
            this.pnlToolBox.TabIndex = 0;
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(590, 85);
            this.txtRadius.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(180, 29);
            this.txtRadius.TabIndex = 3;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(585, 54);
            this.lblRadius.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(78, 25);
            this.lblRadius.TabIndex = 2;
            this.lblRadius.Text = "Radius:";
            // 
            // lblShapes
            // 
            this.lblShapes.AutoSize = true;
            this.lblShapes.Location = new System.Drawing.Point(64, 54);
            this.lblShapes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblShapes.Name = "lblShapes";
            this.lblShapes.Size = new System.Drawing.Size(230, 25);
            this.lblShapes.TabIndex = 1;
            this.lblShapes.Text = "Choose a shape to draw:";
            // 
            // cmbShapes
            // 
            this.cmbShapes.FormattingEnabled = true;
            this.cmbShapes.Items.AddRange(new object[] {
            "Square",
            "Circle",
            "Rectangle"});
            this.cmbShapes.Location = new System.Drawing.Point(70, 83);
            this.cmbShapes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbShapes.Name = "cmbShapes";
            this.cmbShapes.Size = new System.Drawing.Size(297, 32);
            this.cmbShapes.TabIndex = 0;
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(0, 185);
            this.pnlCanvas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(1388, 692);
            this.pnlCanvas.TabIndex = 1;
            this.pnlCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 877);
            this.Controls.Add(this.pnlCanvas);
            this.Controls.Add(this.pnlToolBox);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlToolBox.ResumeLayout(false);
            this.pnlToolBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolBox;
        private System.Windows.Forms.ComboBox cmbShapes;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.Label lblShapes;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblRadius;
    }
}

