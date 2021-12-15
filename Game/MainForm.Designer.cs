
namespace Game
{
    partial class MainForm
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonChooseColor = new System.Windows.Forms.Button();
            this.trackBarWidth = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChooseColor
            // 
            this.buttonChooseColor.Location = new System.Drawing.Point(688, 13);
            this.buttonChooseColor.Name = "buttonChooseColor";
            this.buttonChooseColor.Size = new System.Drawing.Size(100, 44);
            this.buttonChooseColor.TabIndex = 0;
            this.buttonChooseColor.Text = "ChooseColor";
            this.buttonChooseColor.UseVisualStyleBackColor = true;
            this.buttonChooseColor.Visible = false;
            this.buttonChooseColor.Click += new System.EventHandler(this.buttonChooseColor_Click);
            // 
            // trackBarWidth
            // 
            this.trackBarWidth.Location = new System.Drawing.Point(2, 382);
            this.trackBarWidth.Maximum = 50;
            this.trackBarWidth.Minimum = 1;
            this.trackBarWidth.Name = "trackBarWidth";
            this.trackBarWidth.Size = new System.Drawing.Size(786, 56);
            this.trackBarWidth.TabIndex = 1;
            this.trackBarWidth.Value = 1;
            this.trackBarWidth.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBarWidth);
            this.Controls.Add(this.buttonChooseColor);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonChooseColor;
        private System.Windows.Forms.TrackBar trackBarWidth;
        private System.Windows.Forms.Button button1;
    }
}

