namespace Task2_Flower_
{
    partial class Flower
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
            label1 = new Label();
            label2 = new Label();
            label = new Label();
            K = new TextBox();
            Y1 = new TextBox();
            X1 = new TextBox();
            Draw = new Button();
            Clear = new Button();
            X2 = new TextBox();
            Y2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1520, 980);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1535, 30);
            label1.Name = "label1";
            label1.Size = new Size(33, 25);
            label1.TabIndex = 1;
            label1.Text = "X1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1535, 86);
            label2.Name = "label2";
            label2.Size = new Size(32, 25);
            label2.TabIndex = 2;
            label2.Text = "Y1";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(1535, 261);
            label.Name = "label";
            label.Size = new Size(78, 25);
            label.TabIndex = 0;
            label.Text = "Iteration";
            // 
            // K
            // 
            K.Location = new Point(1633, 255);
            K.Name = "K";
            K.Size = new Size(150, 31);
            K.TabIndex = 3;
            // 
            // Y1
            // 
            Y1.Location = new Point(1633, 86);
            Y1.Name = "Y1";
            Y1.Size = new Size(150, 31);
            Y1.TabIndex = 4;
            // 
            // X1
            // 
            X1.Location = new Point(1633, 27);
            X1.Name = "X1";
            X1.Size = new Size(150, 31);
            X1.TabIndex = 5;
            // 
            // Draw
            // 
            Draw.Location = new Point(1535, 344);
            Draw.Name = "Draw";
            Draw.Size = new Size(112, 34);
            Draw.TabIndex = 6;
            Draw.Text = "Draw";
            Draw.UseVisualStyleBackColor = true;
            Draw.Click += Draw_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(1690, 344);
            Clear.Name = "Clear";
            Clear.Size = new Size(112, 34);
            Clear.TabIndex = 7;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // X2
            // 
            X2.Location = new Point(1633, 138);
            X2.Name = "X2";
            X2.Size = new Size(150, 31);
            X2.TabIndex = 11;
            // 
            // Y2
            // 
            Y2.Location = new Point(1633, 197);
            Y2.Name = "Y2";
            Y2.Size = new Size(150, 31);
            Y2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1535, 197);
            label3.Name = "label3";
            label3.Size = new Size(32, 25);
            label3.TabIndex = 9;
            label3.Text = "Y2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1535, 141);
            label4.Name = "label4";
            label4.Size = new Size(33, 25);
            label4.TabIndex = 8;
            label4.Text = "X2";
            // 
            // Flower
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(X2);
            Controls.Add(Y2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(Clear);
            Controls.Add(Draw);
            Controls.Add(X1);
            Controls.Add(Y1);
            Controls.Add(K);
            Controls.Add(label);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Flower";
            Text = "Flower";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label;
        private TextBox K;
        private TextBox Y1;
        private TextBox X1;
        private Button Draw;
        private Button Clear;
        private TextBox X2;
        private TextBox Y2;
        private Label label3;
        private Label label4;
    }
}
