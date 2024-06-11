namespace TraderBeta_02
{
    partial class WatchlistForm
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
            panel1 = new Panel();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton5 = new RadioButton();
            label1 = new Label();
            panel2 = new Panel();
            type_lbl = new Label();
            price_lbl = new Label();
            label5 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton5);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 82);
            panel1.TabIndex = 0;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Century Gothic", 10F);
            radioButton4.Location = new Point(705, 47);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(99, 23);
            radioButton4.TabIndex = 5;
            radioButton4.TabStop = true;
            radioButton4.Text = "Currencies";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Century Gothic", 10F);
            radioButton3.Location = new Point(625, 46);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(74, 23);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "Crypto";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Century Gothic", 10F);
            radioButton2.Location = new Point(550, 46);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(69, 23);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Stocks";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Century Gothic", 10F);
            radioButton1.Location = new Point(502, 46);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(42, 23);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "All";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Century Gothic", 10F);
            radioButton5.Location = new Point(810, 47);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(117, 23);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "Commodities";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(205, 26);
            label1.TabIndex = 0;
            label1.Text = "Trending Watchlist";
            // 
            // panel2
            // 
            panel2.Controls.Add(type_lbl);
            panel2.Controls.Add(price_lbl);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(952, 51);
            panel2.TabIndex = 1;
            // 
            // type_lbl
            // 
            type_lbl.AutoSize = true;
            type_lbl.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            type_lbl.ForeColor = SystemColors.ControlDarkDark;
            type_lbl.Location = new Point(623, 29);
            type_lbl.Name = "type_lbl";
            type_lbl.Size = new Size(41, 19);
            type_lbl.TabIndex = 0;
            type_lbl.Text = "Type";
            // 
            // price_lbl
            // 
            price_lbl.AutoSize = true;
            price_lbl.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            price_lbl.ForeColor = SystemColors.ControlDarkDark;
            price_lbl.Location = new Point(546, 29);
            price_lbl.Name = "price_lbl";
            price_lbl.Size = new Size(42, 19);
            price_lbl.TabIndex = 0;
            price_lbl.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(3, 29);
            label5.Name = "label5";
            label5.Size = new Size(62, 19);
            label5.TabIndex = 0;
            label5.Text = "Markets";
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(952, 442);
            panel3.TabIndex = 2;
            // 
            // WatchlistForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(952, 575);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WatchlistForm";
            Text = "WatchlistForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private RadioButton radioButton5;
        private Label label5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label type_lbl;
        private Label price_lbl;
    }
}