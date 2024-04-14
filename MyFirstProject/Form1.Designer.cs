

namespace MyFirstProject
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
            tableLayoutPanel1 = new TableLayoutPanel();
            sevenBtn = new Button();
            eightBtn = new Button();
            nineBtn = new Button();
            divsionBtn = new Button();
            plusBtn = new Button();
            zeroBtn = new Button();
            equalsBtn = new Button();
            minusBtn = new Button();
            clearBtn = new Button();
            threeBtn = new Button();
            fiveBtn = new Button();
            fourBtn = new Button();
            sixBtn = new Button();
            timesBtn = new Button();
            twoBtn = new Button();
            oneBtn = new Button();
            resultTxt = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(sevenBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(eightBtn, 1, 0);
            tableLayoutPanel1.Controls.Add(nineBtn, 2, 0);
            tableLayoutPanel1.Controls.Add(divsionBtn, 3, 0);
            tableLayoutPanel1.Controls.Add(plusBtn, 3, 2);
            tableLayoutPanel1.Controls.Add(zeroBtn, 1, 3);
            tableLayoutPanel1.Controls.Add(equalsBtn, 2, 3);
            tableLayoutPanel1.Controls.Add(minusBtn, 3, 3);
            tableLayoutPanel1.Controls.Add(clearBtn, 0, 3);
            tableLayoutPanel1.Controls.Add(threeBtn, 2, 2);
            tableLayoutPanel1.Controls.Add(fiveBtn, 1, 1);
            tableLayoutPanel1.Controls.Add(fourBtn, 0, 1);
            tableLayoutPanel1.Controls.Add(sixBtn, 2, 1);
            tableLayoutPanel1.Controls.Add(timesBtn, 3, 1);
            tableLayoutPanel1.Controls.Add(twoBtn, 1, 2);
            tableLayoutPanel1.Controls.Add(oneBtn, 0, 2);
            tableLayoutPanel1.Location = new Point(0, 82);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(679, 378);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // sevenBtn
            // 
            sevenBtn.BackColor = Color.Gray;
            sevenBtn.FlatStyle = FlatStyle.Popup;
            sevenBtn.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            sevenBtn.Location = new Point(3, 3);
            sevenBtn.Name = "sevenBtn";
            sevenBtn.Size = new Size(163, 88);
            sevenBtn.TabIndex = 0;
            sevenBtn.Text = "7";
            sevenBtn.UseVisualStyleBackColor = false;
            sevenBtn.Click += sevenBtn_Click;
            // 
            // eightBtn
            // 
            eightBtn.BackColor = Color.Gray;
            eightBtn.FlatStyle = FlatStyle.Popup;
            eightBtn.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            eightBtn.Location = new Point(172, 3);
            eightBtn.Name = "eightBtn";
            eightBtn.Size = new Size(163, 88);
            eightBtn.TabIndex = 1;
            eightBtn.Text = "8";
            eightBtn.UseVisualStyleBackColor = false;
            eightBtn.Click += eightBtn_Click;
            // 
            // nineBtn
            // 
            nineBtn.BackColor = Color.Gray;
            nineBtn.FlatStyle = FlatStyle.Popup;
            nineBtn.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            nineBtn.Location = new Point(341, 3);
            nineBtn.Name = "nineBtn";
            nineBtn.Size = new Size(163, 88);
            nineBtn.TabIndex = 2;
            nineBtn.Text = "9";
            nineBtn.UseVisualStyleBackColor = false;
            nineBtn.Click += nineBtn_Click;
            // 
            // divsionBtn
            // 
            divsionBtn.BackColor = Color.Gray;
            divsionBtn.FlatStyle = FlatStyle.Popup;
            divsionBtn.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            divsionBtn.Location = new Point(510, 3);
            divsionBtn.Name = "divsionBtn";
            divsionBtn.Size = new Size(166, 88);
            divsionBtn.TabIndex = 3;
            divsionBtn.Text = "/";
            divsionBtn.UseVisualStyleBackColor = false;
            divsionBtn.Click += divsionBtn_Click;
            // 
            // plusBtn
            // 
            plusBtn.BackColor = Color.Gray;
            plusBtn.FlatStyle = FlatStyle.Popup;
            plusBtn.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            plusBtn.Location = new Point(510, 191);
            plusBtn.Name = "plusBtn";
            plusBtn.Size = new Size(166, 88);
            plusBtn.TabIndex = 11;
            plusBtn.Text = "+";
            plusBtn.UseVisualStyleBackColor = false;
            plusBtn.Click += plusBtn_Click;
            // 
            // zeroBtn
            // 
            zeroBtn.BackColor = Color.Gray;
            zeroBtn.FlatStyle = FlatStyle.Popup;
            zeroBtn.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            zeroBtn.Location = new Point(172, 285);
            zeroBtn.Name = "zeroBtn";
            zeroBtn.Size = new Size(163, 90);
            zeroBtn.TabIndex = 13;
            zeroBtn.Text = "0";
            zeroBtn.UseVisualStyleBackColor = false;
            zeroBtn.Click += zeroBtn_Click;
            // 
            // equalsBtn
            // 
            equalsBtn.BackColor = Color.Gray;
            equalsBtn.FlatStyle = FlatStyle.Popup;
            equalsBtn.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            equalsBtn.Location = new Point(341, 285);
            equalsBtn.Name = "equalsBtn";
            equalsBtn.Size = new Size(163, 90);
            equalsBtn.TabIndex = 14;
            equalsBtn.Text = "=";
            equalsBtn.UseVisualStyleBackColor = false;
            equalsBtn.Click += equalsBtn_Click;
            // 
            // minusBtn
            // 
            minusBtn.BackColor = Color.Gray;
            minusBtn.FlatStyle = FlatStyle.Popup;
            minusBtn.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            minusBtn.Location = new Point(510, 285);
            minusBtn.Name = "minusBtn";
            minusBtn.Size = new Size(166, 90);
            minusBtn.TabIndex = 15;
            minusBtn.Text = "-";
            minusBtn.UseVisualStyleBackColor = false;
            minusBtn.Click += minusBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.Gray;
            clearBtn.FlatStyle = FlatStyle.Popup;
            clearBtn.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            clearBtn.Location = new Point(3, 285);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(163, 90);
            clearBtn.TabIndex = 16;
            clearBtn.Text = "C";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // threeBtn
            // 
            threeBtn.BackColor = Color.Gray;
            threeBtn.FlatStyle = FlatStyle.Popup;
            threeBtn.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            threeBtn.Location = new Point(341, 191);
            threeBtn.Name = "threeBtn";
            threeBtn.Size = new Size(163, 88);
            threeBtn.TabIndex = 19;
            threeBtn.Text = "3";
            threeBtn.UseVisualStyleBackColor = false;
            threeBtn.Click += threeBtn_Click;
            // 
            // fiveBtn
            // 
            fiveBtn.BackColor = Color.Gray;
            fiveBtn.FlatStyle = FlatStyle.Popup;
            fiveBtn.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            fiveBtn.Location = new Point(172, 97);
            fiveBtn.Name = "fiveBtn";
            fiveBtn.Size = new Size(163, 88);
            fiveBtn.TabIndex = 21;
            fiveBtn.Text = "5";
            fiveBtn.UseVisualStyleBackColor = false;
            fiveBtn.Click += fiveBtn_Click;
            // 
            // fourBtn
            // 
            fourBtn.BackColor = Color.Gray;
            fourBtn.FlatStyle = FlatStyle.Popup;
            fourBtn.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            fourBtn.Location = new Point(3, 97);
            fourBtn.Name = "fourBtn";
            fourBtn.Size = new Size(163, 88);
            fourBtn.TabIndex = 22;
            fourBtn.Text = "4";
            fourBtn.UseVisualStyleBackColor = false;
            fourBtn.Click += fourBtn_Click;
            // 
            // sixBtn
            // 
            sixBtn.BackColor = Color.Gray;
            sixBtn.FlatStyle = FlatStyle.Popup;
            sixBtn.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            sixBtn.Location = new Point(341, 97);
            sixBtn.Name = "sixBtn";
            sixBtn.Size = new Size(163, 88);
            sixBtn.TabIndex = 23;
            sixBtn.Text = "6";
            sixBtn.UseVisualStyleBackColor = false;
            sixBtn.Click += sixBtn_Click;
            // 
            // timesBtn
            // 
            timesBtn.BackColor = Color.Gray;
            timesBtn.FlatStyle = FlatStyle.Popup;
            timesBtn.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            timesBtn.Location = new Point(510, 97);
            timesBtn.Name = "timesBtn";
            timesBtn.Size = new Size(166, 88);
            timesBtn.TabIndex = 24;
            timesBtn.Text = "*";
            timesBtn.UseVisualStyleBackColor = false;
            timesBtn.Click += timesBtn_Click;
            // 
            // twoBtn
            // 
            twoBtn.BackColor = Color.Gray;
            twoBtn.FlatStyle = FlatStyle.Popup;
            twoBtn.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            twoBtn.Location = new Point(172, 191);
            twoBtn.Name = "twoBtn";
            twoBtn.Size = new Size(163, 88);
            twoBtn.TabIndex = 18;
            twoBtn.Text = "2";
            twoBtn.UseVisualStyleBackColor = false;
            twoBtn.Click += twoBtn_Click;
            // 
            // oneBtn
            // 
            oneBtn.BackColor = Color.Gray;
            oneBtn.FlatStyle = FlatStyle.Popup;
            oneBtn.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            oneBtn.Location = new Point(3, 191);
            oneBtn.Name = "oneBtn";
            oneBtn.Size = new Size(163, 88);
            oneBtn.TabIndex = 17;
            oneBtn.Text = "1";
            oneBtn.UseVisualStyleBackColor = false;
            oneBtn.Click += oneBtn_Click;
            // 
            // resultTxt
            // 
            resultTxt.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultTxt.Location = new Point(6, 1);
            resultTxt.Name = "resultTxt";
            resultTxt.Size = new Size(673, 78);
            resultTxt.TabIndex = 1;
            resultTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(679, 461);
            Controls.Add(resultTxt);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button sevenBtn;
        private Button eightBtn;
        private Button nineBtn;
        private Button divsionBtn;
        
        private Button timesBtn;
        
        
        
        private Button plusBtn;
        
        private Button zeroBtn;
        private Button equalsBtn;
        private Button minusBtn;
        private Button clearBtn;
        private Button oneBtn;
        private Button twoBtn;
        private Button threeBtn;
        private Button fiveBtn;
        private Button fourBtn;
        private Button sixBtn;
        private Label resultTxt;
    }
}
