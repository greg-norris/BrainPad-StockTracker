namespace StockTracker
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
            button1 = new Button();
            stockSymbol1 = new TextBox();
            label1 = new Label();
            stockSymbol2 = new TextBox();
            stockSymbol3 = new TextBox();
            stockSymbol4 = new TextBox();
            stockSymbol5 = new TextBox();
            targetPrice1 = new TextBox();
            label2 = new Label();
            targetPrice2 = new TextBox();
            targetPrice3 = new TextBox();
            targetPrice4 = new TextBox();
            targetPrice5 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(31, 327);
            button1.Name = "button1";
            button1.Size = new Size(507, 112);
            button1.TabIndex = 0;
            button1.Text = "Start Tracking";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // stockSymbol1
            // 
            stockSymbol1.Location = new Point(31, 84);
            stockSymbol1.Name = "stockSymbol1";
            stockSymbol1.Size = new Size(232, 39);
            stockSymbol1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(270, 54);
            label1.TabIndex = 2;
            label1.Text = "Stock Symbol";
            // 
            // stockSymbol2
            // 
            stockSymbol2.Location = new Point(31, 129);
            stockSymbol2.Name = "stockSymbol2";
            stockSymbol2.Size = new Size(232, 39);
            stockSymbol2.TabIndex = 3;
            // 
            // stockSymbol3
            // 
            stockSymbol3.Location = new Point(31, 174);
            stockSymbol3.Name = "stockSymbol3";
            stockSymbol3.Size = new Size(232, 39);
            stockSymbol3.TabIndex = 4;
            // 
            // stockSymbol4
            // 
            stockSymbol4.Location = new Point(31, 219);
            stockSymbol4.Name = "stockSymbol4";
            stockSymbol4.Size = new Size(232, 39);
            stockSymbol4.TabIndex = 5;
            // 
            // stockSymbol5
            // 
            stockSymbol5.Location = new Point(31, 264);
            stockSymbol5.Name = "stockSymbol5";
            stockSymbol5.Size = new Size(232, 39);
            stockSymbol5.TabIndex = 6;
            // 
            // targetPrice1
            // 
            targetPrice1.Location = new Point(306, 84);
            targetPrice1.Name = "targetPrice1";
            targetPrice1.Size = new Size(232, 39);
            targetPrice1.TabIndex = 7;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(306, 27);
            label2.Name = "label2";
            label2.Size = new Size(270, 54);
            label2.TabIndex = 8;
            label2.Text = "Target Price";
            // 
            // targetPrice2
            // 
            targetPrice2.Location = new Point(306, 129);
            targetPrice2.Name = "targetPrice2";
            targetPrice2.Size = new Size(232, 39);
            targetPrice2.TabIndex = 9;
            // 
            // targetPrice3
            // 
            targetPrice3.Location = new Point(306, 174);
            targetPrice3.Name = "targetPrice3";
            targetPrice3.Size = new Size(232, 39);
            targetPrice3.TabIndex = 10;
            // 
            // targetPrice4
            // 
            targetPrice4.Location = new Point(306, 219);
            targetPrice4.Name = "targetPrice4";
            targetPrice4.Size = new Size(232, 39);
            targetPrice4.TabIndex = 11;
            // 
            // targetPrice5
            // 
            targetPrice5.Location = new Point(306, 264);
            targetPrice5.Name = "targetPrice5";
            targetPrice5.Size = new Size(232, 39);
            targetPrice5.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 493);
            Controls.Add(targetPrice5);
            Controls.Add(targetPrice4);
            Controls.Add(targetPrice3);
            Controls.Add(targetPrice2);
            Controls.Add(label2);
            Controls.Add(targetPrice1);
            Controls.Add(stockSymbol5);
            Controls.Add(stockSymbol4);
            Controls.Add(stockSymbol3);
            Controls.Add(stockSymbol2);
            Controls.Add(label1);
            Controls.Add(stockSymbol1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "BrainPad Stock Tracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox stockSymbol1;
        private Label label1;
        private TextBox stockSymbol2;
        private TextBox stockSymbol3;
        private TextBox stockSymbol4;
        private TextBox stockSymbol5;
        private TextBox targetPrice1;
        private Label label2;
        private TextBox targetPrice2;
        private TextBox targetPrice3;
        private TextBox targetPrice4;
        private TextBox targetPrice5;
    }
}