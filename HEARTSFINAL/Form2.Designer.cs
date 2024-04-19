namespace HEARTSFINAL
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            textBox1Rules = new TextBox();
            SuspendLayout();
            // 
            // textBox1Rules
            // 
            textBox1Rules.Location = new Point(22, 22);
            textBox1Rules.Multiline = true;
            textBox1Rules.Name = "textBox1Rules";
            textBox1Rules.ReadOnly = true;
            textBox1Rules.Size = new Size(801, 451);
            textBox1Rules.TabIndex = 0;
            textBox1Rules.Text = resources.GetString("textBox1Rules.Text");
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 498);
            Controls.Add(textBox1Rules);
            Name = "Form2";
            Text = "Rules";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1Rules;
    }
}