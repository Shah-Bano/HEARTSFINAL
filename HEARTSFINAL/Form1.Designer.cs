namespace HEARTSFINAL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            howDoIPlayToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            DealCardsButton = new Button();
            pictureBox2 = new PictureBox();
            PlayCardButton = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { howDoIPlayToolStripMenuItem, aboutUsToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(55, 24);
            toolStripDropDownButton1.Text = "Help";
            // 
            // howDoIPlayToolStripMenuItem
            // 
            howDoIPlayToolStripMenuItem.Name = "howDoIPlayToolStripMenuItem";
            howDoIPlayToolStripMenuItem.Size = new Size(192, 26);
            howDoIPlayToolStripMenuItem.Text = "How do I play?";
            howDoIPlayToolStripMenuItem.Click += howDoIPlayToolStripMenuItem_Click;
            // 
            // aboutUsToolStripMenuItem
            // 
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Size = new Size(192, 26);
            aboutUsToolStripMenuItem.Text = "About Us";
            aboutUsToolStripMenuItem.Click += aboutUsToolStripMenuItem_Click;
            // 
            // DealCardsButton
            // 
            DealCardsButton.Location = new Point(43, 301);
            DealCardsButton.Name = "DealCardsButton";
            DealCardsButton.Size = new Size(94, 29);
            DealCardsButton.TabIndex = 1;
            DealCardsButton.Text = "Deal Cards";
            DealCardsButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(43, 152);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(94, 132);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // PlayCardButton
            // 
            PlayCardButton.Location = new Point(658, 397);
            PlayCardButton.Name = "PlayCardButton";
            PlayCardButton.Size = new Size(94, 29);
            PlayCardButton.TabIndex = 4;
            PlayCardButton.Text = "Play Card";
            PlayCardButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(PlayCardButton);
            Controls.Add(pictureBox2);
            Controls.Add(DealCardsButton);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Hearts";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem howDoIPlayToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private Button DealCardsButton;
        private PictureBox pictureBox2;
        private Button PlayCardButton;
    }
}
