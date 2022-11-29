namespace WindowsFormscalculette
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculate = new System.Windows.Forms.TableLayoutPanel();
            this.CEbutton = new System.Windows.Forms.Button();
            this.buttonc = new System.Windows.Forms.Button();
            this.suprbutton = new System.Windows.Forms.Button();
            this.buttondiv = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonmultipl = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonsoustr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonsigne = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonequal = new System.Windows.Forms.Button();
            this.buttonvergule = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calculate.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.calculate.ColumnCount = 4;
            this.calculate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.calculate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.calculate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.calculate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.calculate.Controls.Add(this.CEbutton, 0, 0);
            this.calculate.Controls.Add(this.buttonc, 1, 0);
            this.calculate.Controls.Add(this.suprbutton, 2, 0);
            this.calculate.Controls.Add(this.buttondiv, 3, 0);
            this.calculate.Controls.Add(this.button7, 0, 1);
            this.calculate.Controls.Add(this.button8, 1, 1);
            this.calculate.Controls.Add(this.button9, 2, 1);
            this.calculate.Controls.Add(this.buttonmultipl, 3, 1);
            this.calculate.Controls.Add(this.button4, 0, 2);
            this.calculate.Controls.Add(this.button5, 1, 2);
            this.calculate.Controls.Add(this.button6, 2, 2);
            this.calculate.Controls.Add(this.buttonsoustr, 3, 2);
            this.calculate.Controls.Add(this.button1, 0, 3);
            this.calculate.Controls.Add(this.button2, 1, 3);
            this.calculate.Controls.Add(this.button3, 2, 3);
            this.calculate.Controls.Add(this.buttonadd, 3, 3);
            this.calculate.Controls.Add(this.buttonsigne, 0, 4);
            this.calculate.Controls.Add(this.button0, 1, 4);
            this.calculate.Controls.Add(this.buttonequal, 3, 4);
            this.calculate.Controls.Add(this.buttonvergule, 2, 4);
            this.calculate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculate.Location = new System.Drawing.Point(156, 89);
            this.calculate.Margin = new System.Windows.Forms.Padding(0);
            this.calculate.Name = "calculate";
            this.calculate.RowCount = 5;
            this.calculate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.calculate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.calculate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.calculate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.calculate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.calculate.Size = new System.Drawing.Size(286, 349);
            this.calculate.TabIndex = 0;
            this.calculate.Paint += new System.Windows.Forms.PaintEventHandler(this.calculate_Paint);
            // 
            // CEbutton
            // 
            this.CEbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEbutton.Location = new System.Drawing.Point(0, 0);
            this.CEbutton.Margin = new System.Windows.Forms.Padding(0);
            this.CEbutton.Name = "CEbutton";
            this.CEbutton.Size = new System.Drawing.Size(71, 69);
            this.CEbutton.TabIndex = 0;
            this.CEbutton.Text = "CE";
            this.CEbutton.UseVisualStyleBackColor = true;
            this.CEbutton.Click += new System.EventHandler(this.CEbutton_Click);
            // 
            // buttonc
            // 
            this.buttonc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonc.Location = new System.Drawing.Point(71, 0);
            this.buttonc.Margin = new System.Windows.Forms.Padding(0);
            this.buttonc.Name = "buttonc";
            this.buttonc.Size = new System.Drawing.Size(71, 69);
            this.buttonc.TabIndex = 1;
            this.buttonc.Text = "C";
            this.buttonc.UseVisualStyleBackColor = true;
            this.buttonc.Click += new System.EventHandler(this.btnclear_click);
            // 
            // suprbutton
            // 
            this.suprbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suprbutton.Location = new System.Drawing.Point(142, 0);
            this.suprbutton.Margin = new System.Windows.Forms.Padding(0);
            this.suprbutton.Name = "suprbutton";
            this.suprbutton.Size = new System.Drawing.Size(71, 69);
            this.suprbutton.TabIndex = 2;
            this.suprbutton.Text = "supr";
            this.suprbutton.UseVisualStyleBackColor = true;
            this.suprbutton.Click += new System.EventHandler(this.suprbutton_Click);
            // 
            // buttondiv
            // 
            this.buttondiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondiv.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttondiv.Location = new System.Drawing.Point(213, 0);
            this.buttondiv.Margin = new System.Windows.Forms.Padding(0);
            this.buttondiv.Name = "buttondiv";
            this.buttondiv.Size = new System.Drawing.Size(73, 69);
            this.buttondiv.TabIndex = 3;
            this.buttondiv.Text = " /";
            this.buttondiv.UseVisualStyleBackColor = true;
            this.buttondiv.Click += new System.EventHandler(this.operateur_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(0, 69);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 69);
            this.button7.TabIndex = 4;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(71, 69);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(71, 69);
            this.button8.TabIndex = 5;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(142, 69);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(71, 69);
            this.button9.TabIndex = 6;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonmultipl
            // 
            this.buttonmultipl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmultipl.Location = new System.Drawing.Point(213, 69);
            this.buttonmultipl.Margin = new System.Windows.Forms.Padding(0);
            this.buttonmultipl.Name = "buttonmultipl";
            this.buttonmultipl.Size = new System.Drawing.Size(73, 69);
            this.buttonmultipl.TabIndex = 7;
            this.buttonmultipl.Text = "*";
            this.buttonmultipl.UseVisualStyleBackColor = true;
            this.buttonmultipl.Click += new System.EventHandler(this.operateurmultipl_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 138);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 69);
            this.button4.TabIndex = 8;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(71, 138);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 69);
            this.button5.TabIndex = 9;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(142, 138);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 69);
            this.button6.TabIndex = 10;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonsoustr
            // 
            this.buttonsoustr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsoustr.Location = new System.Drawing.Point(213, 138);
            this.buttonsoustr.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsoustr.Name = "buttonsoustr";
            this.buttonsoustr.Size = new System.Drawing.Size(73, 69);
            this.buttonsoustr.TabIndex = 11;
            this.buttonsoustr.Text = "-";
            this.buttonsoustr.UseVisualStyleBackColor = true;
            this.buttonsoustr.Click += new System.EventHandler(this.operateursoustr_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 207);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 69);
            this.button1.TabIndex = 12;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(71, 207);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 69);
            this.button2.TabIndex = 13;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(142, 207);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 69);
            this.button3.TabIndex = 14;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadd.Location = new System.Drawing.Point(213, 207);
            this.buttonadd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(73, 69);
            this.buttonadd.TabIndex = 15;
            this.buttonadd.Text = "+";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.operateuradd_Click);
            // 
            // buttonsigne
            // 
            this.buttonsigne.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonsigne.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsigne.Location = new System.Drawing.Point(0, 276);
            this.buttonsigne.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsigne.Name = "buttonsigne";
            this.buttonsigne.Size = new System.Drawing.Size(71, 73);
            this.buttonsigne.TabIndex = 16;
            this.buttonsigne.Text = "+/-";
            this.buttonsigne.UseVisualStyleBackColor = false;
            this.buttonsigne.Click += new System.EventHandler(this.buttonsigne_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(71, 276);
            this.button0.Margin = new System.Windows.Forms.Padding(0);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(71, 73);
            this.button0.TabIndex = 17;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonequal
            // 
            this.buttonequal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonequal.Location = new System.Drawing.Point(213, 276);
            this.buttonequal.Margin = new System.Windows.Forms.Padding(0);
            this.buttonequal.Name = "buttonequal";
            this.buttonequal.Size = new System.Drawing.Size(73, 73);
            this.buttonequal.TabIndex = 19;
            this.buttonequal.Text = "=";
            this.buttonequal.UseVisualStyleBackColor = false;
            this.buttonequal.Click += new System.EventHandler(this.buttonequal_Click);
            // 
            // buttonvergule
            // 
            this.buttonvergule.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonvergule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonvergule.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonvergule.Location = new System.Drawing.Point(142, 276);
            this.buttonvergule.Margin = new System.Windows.Forms.Padding(0);
            this.buttonvergule.Name = "buttonvergule";
            this.buttonvergule.Size = new System.Drawing.Size(71, 73);
            this.buttonvergule.TabIndex = 18;
            this.buttonvergule.Text = ",";
            this.buttonvergule.UseVisualStyleBackColor = false;
            this.buttonvergule.Click += new System.EventHandler(this.buttonvergule_Click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Result.Location = new System.Drawing.Point(156, 8);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(286, 88);
            this.textBox_Result.TabIndex = 1;
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Result.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Location = new System.Drawing.Point(166, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "enter your equation and press=to calculate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.calculate);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(250, 250);
            this.Name = "Form1";
            this.Text = "calculette";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.calculate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CEbutton;
        private System.Windows.Forms.Button buttonc;
        private System.Windows.Forms.Button suprbutton;
        private System.Windows.Forms.Button buttondiv;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonmultipl;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonsoustr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonsigne;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonvergule;
        private System.Windows.Forms.Button buttonequal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel calculate;
        private System.Windows.Forms.Label label3;
    }
}

