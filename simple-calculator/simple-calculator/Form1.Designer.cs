namespace simple_calculator {
    partial class Form1 {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose ( bool disposing ) {
            if (disposing && (components != null)) {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent () {
            this.lblCalcu = new System.Windows.Forms.Label( );
            this.lblResu = new System.Windows.Forms.Label( );
            this.btnNum7 = new System.Windows.Forms.Button( );
            this.btnNum8 = new System.Windows.Forms.Button( );
            this.btnZahl9 = new System.Windows.Forms.Button( );
            this.btnNum4 = new System.Windows.Forms.Button( );
            this.btnNum5 = new System.Windows.Forms.Button( );
            this.btnNum6 = new System.Windows.Forms.Button( );
            this.btnNum1 = new System.Windows.Forms.Button( );
            this.btnNum2 = new System.Windows.Forms.Button( );
            this.btnNum3 = new System.Windows.Forms.Button( );
            this.btnNum0 = new System.Windows.Forms.Button( );
            this.btnAdd = new System.Windows.Forms.Button( );
            this.btnSub = new System.Windows.Forms.Button( );
            this.btnMulti = new System.Windows.Forms.Button( );
            this.btnDivid = new System.Windows.Forms.Button( );
            this.btnEqual = new System.Windows.Forms.Button( );
            this.btnClear = new System.Windows.Forms.Button( );
            this.txtNum1 = new System.Windows.Forms.TextBox( );
            this.txtNum2 = new System.Windows.Forms.TextBox( );
            this.txtOperation = new System.Windows.Forms.TextBox( );
            this.lblResuFinal = new System.Windows.Forms.Label( );
            this.btnDot = new System.Windows.Forms.Button( );
            this.SuspendLayout( );
            // 
            // lblCalcu
            // 
            this.lblCalcu.AutoSize = true;
            this.lblCalcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0)));
            this.lblCalcu.Location = new System.Drawing.Point(51, 53);
            this.lblCalcu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalcu.Name = "lblCalcu";
            this.lblCalcu.Size = new System.Drawing.Size(150, 29);
            this.lblCalcu.TabIndex = 0;
            this.lblCalcu.Text = "Calculation:";
            // 
            // lblResu
            // 
            this.lblResu.AutoSize = true;
            this.lblResu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0)));
            this.lblResu.Location = new System.Drawing.Point(539, 53);
            this.lblResu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResu.Name = "lblResu";
            this.lblResu.Size = new System.Drawing.Size(107, 29);
            this.lblResu.TabIndex = 1;
            this.lblResu.Text = "Results:";
            // 
            // btnNum7
            // 
            this.btnNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0)));
            this.btnNum7.Location = new System.Drawing.Point(56, 167);
            this.btnNum7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(111, 53);
            this.btnNum7.TabIndex = 2;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.evntClickNum);
            // 
            // btnNum8
            // 
            this.btnNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0)));
            this.btnNum8.Location = new System.Drawing.Point(175, 167);
            this.btnNum8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(111, 53);
            this.btnNum8.TabIndex = 3;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.evntClickNum);
            // 
            // btnZahl9
            // 
            this.btnZahl9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0)));
            this.btnZahl9.Location = new System.Drawing.Point(293, 167);
            this.btnZahl9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnZahl9.Name = "btnZahl9";
            this.btnZahl9.Size = new System.Drawing.Size(111, 53);
            this.btnZahl9.TabIndex = 4;
            this.btnZahl9.Text = "9";
            this.btnZahl9.UseVisualStyleBackColor = true;
            this.btnZahl9.Click += new System.EventHandler(this.evntClickNum);
            // 
            // btnNum4
            // 
            this.btnNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0)));
            this.btnNum4.Location = new System.Drawing.Point(56, 228);
            this.btnNum4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(111, 53);
            this.btnNum4.TabIndex = 5;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.evntClickNum);
            // 
            // btnNum5
            // 
            this.btnNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0)));
            this.btnNum5.Location = new System.Drawing.Point(175, 228);
            this.btnNum5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(111, 53);
            this.btnNum5.TabIndex = 6;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.evntClickNum);
            // 
            // btnNum6
            // 
            this.btnNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0)));
            this.btnNum6.Location = new System.Drawing.Point(293, 228);
            this.btnNum6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(111, 53);
            this.btnNum6.TabIndex = 7;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.evntClickNum);
            // 
            // btnNum1
            // 
            this.btnNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0)));
            this.btnNum1.Location = new System.Drawing.Point(56, 288);
            this.btnNum1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(111, 53);
            this.btnNum1.TabIndex = 8;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.evntClickNum);
            // 
            // btnNum2
            // 
            this.btnNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0)));
            this.btnNum2.Location = new System.Drawing.Point(175, 288);
            this.btnNum2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(111, 53);
            this.btnNum2.TabIndex = 9;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.evntClickNum);
            // 
            // btnNum3
            // 
            this.btnNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0)));
            this.btnNum3.Location = new System.Drawing.Point(293, 288);
            this.btnNum3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(111, 53);
            this.btnNum3.TabIndex = 10;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.evntClickNum);
            // 
            // btnNum0
            // 
            this.btnNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0)));
            this.btnNum0.Location = new System.Drawing.Point(175, 348);
            this.btnNum0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(111, 53);
            this.btnNum0.TabIndex = 11;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.evntClickNum);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0)));
            this.btnAdd.Location = new System.Drawing.Point(544, 167);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 53);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.evntClickOperation);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0)));
            this.btnSub.Location = new System.Drawing.Point(663, 167);
            this.btnSub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(111, 53);
            this.btnSub.TabIndex = 13;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.evntClickOperation);
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0)));
            this.btnMulti.Location = new System.Drawing.Point(545, 228);
            this.btnMulti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(111, 53);
            this.btnMulti.TabIndex = 14;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.evntClickOperation);
            // 
            // btnDivid
            // 
            this.btnDivid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0)));
            this.btnDivid.Location = new System.Drawing.Point(663, 228);
            this.btnDivid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDivid.Name = "btnDivid";
            this.btnDivid.Size = new System.Drawing.Size(111, 53);
            this.btnDivid.TabIndex = 15;
            this.btnDivid.Text = "/";
            this.btnDivid.UseVisualStyleBackColor = true;
            this.btnDivid.Click += new System.EventHandler(this.evntClickOperation);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0)));
            this.btnEqual.Location = new System.Drawing.Point(545, 299);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(228, 53);
            this.btnEqual.TabIndex = 16;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0)));
            this.btnClear.Location = new System.Drawing.Point(55, 348);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 53);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(56, 107);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(111, 22);
            this.txtNum1.TabIndex = 18;
            this.txtNum1.Click += new System.EventHandler(this.txtNum1_TextChanged);
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(292, 110);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(111, 22);
            this.txtNum2.TabIndex = 19;
            this.txtNum2.Click += new System.EventHandler(this.txtNum2_TextChanged);
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            // 
            // txtOperation
            // 
            this.txtOperation.Location = new System.Drawing.Point(193, 107);
            this.txtOperation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOperation.Name = "txtOperation";
            this.txtOperation.Size = new System.Drawing.Size(69, 22);
            this.txtOperation.TabIndex = 20;
            this.txtOperation.TextChanged += new System.EventHandler(this.txtOperation_TextChanged);
            // 
            // lblResuFinal
            // 
            this.lblResuFinal.AutoSize = true;
            this.lblResuFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (( byte ) (0)));
            this.lblResuFinal.Location = new System.Drawing.Point(540, 107);
            this.lblResuFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResuFinal.Name = "lblResuFinal";
            this.lblResuFinal.Size = new System.Drawing.Size(0, 25);
            this.lblResuFinal.TabIndex = 21;
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte ) (0)));
            this.btnDot.Location = new System.Drawing.Point(295, 348);
            this.btnDot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(111, 53);
            this.btnDot.TabIndex = 22;
            this.btnDot.Text = ",";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.evntClickNum);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.lblResuFinal);
            this.Controls.Add(this.txtOperation);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDivid);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnZahl9);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.lblResu);
            this.Controls.Add(this.lblCalcu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.Label lblCalcu;
        private System.Windows.Forms.Label lblResu;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnZahl9;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDivid;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtOperation;
        private System.Windows.Forms.Label lblResuFinal;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.TextBox txtNum2;
    }
}

