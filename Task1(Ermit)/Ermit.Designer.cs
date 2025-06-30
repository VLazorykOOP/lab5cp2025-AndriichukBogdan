namespace Task1_Ermit_
{
    partial class Ermit
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
            panel1 = new Panel();
            p1x = new TextBox();
            v1x = new TextBox();
            p2x = new TextBox();
            v2x = new TextBox();
            Point1X = new Label();
            Vector1X = new Label();
            Point2X = new Label();
            Vector2X = new Label();
            Draw = new Button();
            Clear = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Point1Y = new Label();
            v2y = new TextBox();
            p2y = new TextBox();
            v1y = new TextBox();
            p1y = new TextBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(7, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1520, 980);
            panel1.TabIndex = 0;
            // 
            // p1x
            // 
            p1x.Location = new Point(1548, 146);
            p1x.Name = "p1x";
            p1x.Size = new Size(150, 31);
            p1x.TabIndex = 1;
            // 
            // v1x
            // 
            v1x.Location = new Point(1548, 212);
            v1x.Name = "v1x";
            v1x.Size = new Size(150, 31);
            v1x.TabIndex = 2;
            // 
            // p2x
            // 
            p2x.Location = new Point(1548, 274);
            p2x.Name = "p2x";
            p2x.Size = new Size(150, 31);
            p2x.TabIndex = 3;
            // 
            // v2x
            // 
            v2x.Location = new Point(1548, 336);
            v2x.Name = "v2x";
            v2x.Size = new Size(150, 31);
            v2x.TabIndex = 4;
            // 
            // Point1X
            // 
            Point1X.AutoSize = true;
            Point1X.Location = new Point(1548, 114);
            Point1X.Name = "Point1X";
            Point1X.Size = new Size(67, 25);
            Point1X.TabIndex = 5;
            Point1X.Text = "Point 1";
            Point1X.Click += Point1_Click;
            // 
            // Vector1X
            // 
            Vector1X.AutoSize = true;
            Vector1X.Location = new Point(1548, 180);
            Vector1X.Name = "Vector1X";
            Vector1X.Size = new Size(77, 25);
            Vector1X.TabIndex = 6;
            Vector1X.Text = "Vector 1";
            // 
            // Point2X
            // 
            Point2X.AutoSize = true;
            Point2X.Location = new Point(1548, 246);
            Point2X.Name = "Point2X";
            Point2X.Size = new Size(67, 25);
            Point2X.TabIndex = 7;
            Point2X.Text = "Point 2";
            // 
            // Vector2X
            // 
            Vector2X.AutoSize = true;
            Vector2X.Location = new Point(1548, 308);
            Vector2X.Name = "Vector2X";
            Vector2X.Size = new Size(77, 25);
            Vector2X.TabIndex = 8;
            Vector2X.Text = "Vector 2";
            // 
            // Draw
            // 
            Draw.Location = new Point(1544, 430);
            Draw.Name = "Draw";
            Draw.Size = new Size(150, 31);
            Draw.TabIndex = 9;
            Draw.Text = "Draw";
            Draw.UseVisualStyleBackColor = true;
            Draw.Click += Draw_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(1732, 430);
            Clear.Name = "Clear";
            Clear.Size = new Size(150, 31);
            Clear.TabIndex = 10;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1732, 308);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 18;
            label1.Text = "Vector 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1732, 246);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 17;
            label2.Text = "Point 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1732, 180);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 16;
            label3.Text = "Vector 1";
            // 
            // Point1Y
            // 
            Point1Y.AutoSize = true;
            Point1Y.Location = new Point(1732, 114);
            Point1Y.Name = "Point1Y";
            Point1Y.Size = new Size(67, 25);
            Point1Y.TabIndex = 15;
            Point1Y.Text = "Point 1";
            // 
            // v2y
            // 
            v2y.Location = new Point(1732, 336);
            v2y.Name = "v2y";
            v2y.Size = new Size(150, 31);
            v2y.TabIndex = 14;
            // 
            // p2y
            // 
            p2y.Location = new Point(1732, 274);
            p2y.Name = "p2y";
            p2y.Size = new Size(150, 31);
            p2y.TabIndex = 13;
            // 
            // v1y
            // 
            v1y.Location = new Point(1732, 212);
            v1y.Name = "v1y";
            v1y.Size = new Size(150, 31);
            v1y.TabIndex = 12;
            // 
            // p1y
            // 
            p1y.Location = new Point(1732, 146);
            p1y.Name = "p1y";
            p1y.Size = new Size(150, 31);
            p1y.TabIndex = 11;
            // 
            // Ermit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(Vector2X);
            Controls.Add(p2x);
            Controls.Add(label1);
            Controls.Add(v2x);
            Controls.Add(label2);
            Controls.Add(Point2X);
            Controls.Add(label3);
            Controls.Add(Point1Y);
            Controls.Add(v2y);
            Controls.Add(p2y);
            Controls.Add(v1y);
            Controls.Add(p1y);
            Controls.Add(Clear);
            Controls.Add(Draw);
            Controls.Add(Vector1X);
            Controls.Add(Point1X);
            Controls.Add(v1x);
            Controls.Add(p1x);
            Controls.Add(panel1);
            Name = "Ermit";
            Text = "Ermit";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox p1x;
        private TextBox v1x;
        private TextBox p2x;
        private TextBox v2x;
        private Label Point1X;
        private Label Vector1X;
        private Label Point2X;
        private Label Vector2X;
        private Button Draw;
        private Button Clear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label Point1Y;
        private TextBox v2y;
        private TextBox p2y;
        private TextBox v1y;
        private TextBox p1y;
    }
}
