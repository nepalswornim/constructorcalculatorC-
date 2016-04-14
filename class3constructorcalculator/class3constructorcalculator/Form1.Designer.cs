namespace class3constructorcalculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstNum = new System.Windows.Forms.TextBox();
            this.txtSecondNum = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // txtFirstNum
            // 
            this.txtFirstNum.Location = new System.Drawing.Point(106, 17);
            this.txtFirstNum.Name = "txtFirstNum";
            this.txtFirstNum.Size = new System.Drawing.Size(100, 20);
            this.txtFirstNum.TabIndex = 2;
            // 
            // txtSecondNum
            // 
            this.txtSecondNum.Location = new System.Drawing.Point(106, 46);
            this.txtSecondNum.Name = "txtSecondNum";
            this.txtSecondNum.Size = new System.Drawing.Size(100, 20);
            this.txtSecondNum.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(106, 137);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Result";
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::class3constructorcalculator.Properties.Resources.clear;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.Location = new System.Drawing.Point(212, 17);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(40, 39);
            this.btnClear.TabIndex = 10;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackgroundImage = global::class3constructorcalculator.Properties.Resources.div;
            this.btnDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDiv.Location = new System.Drawing.Point(165, 78);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(40, 40);
            this.btnDiv.TabIndex = 7;
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.BackgroundImage = global::class3constructorcalculator.Properties.Resources.multi;
            this.btnMulti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMulti.Location = new System.Drawing.Point(119, 78);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(40, 40);
            this.btnMulti.TabIndex = 6;
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.BackgroundImage = global::class3constructorcalculator.Properties.Resources.minus;
            this.btnSubtraction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSubtraction.Location = new System.Drawing.Point(77, 78);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(40, 40);
            this.btnSubtraction.TabIndex = 5;
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::class3constructorcalculator.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Location = new System.Drawing.Point(33, 78);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 166);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSecondNum);
            this.Controls.Add(this.txtFirstNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstNum;
        private System.Windows.Forms.TextBox txtSecondNum;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
    }
}

