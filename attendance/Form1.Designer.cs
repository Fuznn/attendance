namespace attendance
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
            label1 = new Label();
            textBox1 = new TextBox();
            btnBrowse = new Button();
            btnCreate = new Button();
            btnLoad = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(12, 396);
            label1.Name = "label1";
            label1.Size = new Size(291, 15);
            label1.TabIndex = 0;
            label1.Text = "To start, select or create a new section or class file. ";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 414);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(521, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "Enter directory here or browse files...";
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBrowse.Location = new Point(539, 413);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(79, 24);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += button1_Click;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCreate.Location = new Point(624, 413);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(87, 24);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += button2_Click;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.Left;
            btnLoad.Location = new Point(717, 413);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(71, 24);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(btnCreate);
            Controls.Add(btnBrowse);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Attendance Taker";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnBrowse;
        private Button btnCreate;
        private Button btnLoad;
    }
}
