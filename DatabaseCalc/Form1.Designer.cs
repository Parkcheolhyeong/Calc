namespace DatabaseCalc
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.opTextBox = new System.Windows.Forms.TextBox();
            this.btn_mc = new System.Windows.Forms.Button();
            this.btn_ms = new System.Windows.Forms.Button();
            this.btn_mr = new System.Windows.Forms.Button();
            this.btn_m_minus = new System.Windows.Forms.Button();
            this.btn_m_plus = new System.Windows.Forms.Button();
            this.btn_backspace = new System.Windows.Forms.Button();
            this.btn_ce = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_sign = new System.Windows.Forms.Button();
            this.btn_root = new System.Windows.Forms.Button();
            this.btn_num7 = new System.Windows.Forms.Button();
            this.btn_num8 = new System.Windows.Forms.Button();
            this.btn_num9 = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_div_rest = new System.Windows.Forms.Button();
            this.btn_num4 = new System.Windows.Forms.Button();
            this.btn_num5 = new System.Windows.Forms.Button();
            this.btn_num6 = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_fract = new System.Windows.Forms.Button();
            this.btn_num1 = new System.Windows.Forms.Button();
            this.btn_num2 = new System.Windows.Forms.Button();
            this.btn_num3 = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.btn_num0 = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numTextBox
            // 
            this.numTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numTextBox.Location = new System.Drawing.Point(37, 33);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(259, 21);
            this.numTextBox.TabIndex = 0;
            this.numTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // opTextBox
            // 
            this.opTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.opTextBox.Location = new System.Drawing.Point(37, 51);
            this.opTextBox.Name = "opTextBox";
            this.opTextBox.Size = new System.Drawing.Size(259, 21);
            this.opTextBox.TabIndex = 1;
            this.opTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_mc
            // 
            this.btn_mc.Location = new System.Drawing.Point(38, 78);
            this.btn_mc.Name = "btn_mc";
            this.btn_mc.Size = new System.Drawing.Size(47, 29);
            this.btn_mc.TabIndex = 2;
            this.btn_mc.Text = "MC";
            this.btn_mc.UseVisualStyleBackColor = true;
            // 
            // btn_ms
            // 
            this.btn_ms.Location = new System.Drawing.Point(144, 78);
            this.btn_ms.Name = "btn_ms";
            this.btn_ms.Size = new System.Drawing.Size(47, 29);
            this.btn_ms.TabIndex = 3;
            this.btn_ms.Text = "MS";
            this.btn_ms.UseVisualStyleBackColor = true;
            // 
            // btn_mr
            // 
            this.btn_mr.Location = new System.Drawing.Point(91, 78);
            this.btn_mr.Name = "btn_mr";
            this.btn_mr.Size = new System.Drawing.Size(47, 29);
            this.btn_mr.TabIndex = 4;
            this.btn_mr.Text = "MR";
            this.btn_mr.UseVisualStyleBackColor = true;
            // 
            // btn_m_minus
            // 
            this.btn_m_minus.Location = new System.Drawing.Point(250, 78);
            this.btn_m_minus.Name = "btn_m_minus";
            this.btn_m_minus.Size = new System.Drawing.Size(47, 29);
            this.btn_m_minus.TabIndex = 5;
            this.btn_m_minus.Text = "M-";
            this.btn_m_minus.UseVisualStyleBackColor = true;
            // 
            // btn_m_plus
            // 
            this.btn_m_plus.Location = new System.Drawing.Point(197, 78);
            this.btn_m_plus.Name = "btn_m_plus";
            this.btn_m_plus.Size = new System.Drawing.Size(47, 29);
            this.btn_m_plus.TabIndex = 6;
            this.btn_m_plus.Text = "M+";
            this.btn_m_plus.UseVisualStyleBackColor = true;
            // 
            // btn_backspace
            // 
            this.btn_backspace.Location = new System.Drawing.Point(38, 113);
            this.btn_backspace.Name = "btn_backspace";
            this.btn_backspace.Size = new System.Drawing.Size(47, 29);
            this.btn_backspace.TabIndex = 7;
            this.btn_backspace.Text = "<-";
            this.btn_backspace.UseVisualStyleBackColor = true;
            this.btn_backspace.Click += new System.EventHandler(this.singButtonClick);
            // 
            // btn_ce
            // 
            this.btn_ce.Location = new System.Drawing.Point(91, 113);
            this.btn_ce.Name = "btn_ce";
            this.btn_ce.Size = new System.Drawing.Size(47, 29);
            this.btn_ce.TabIndex = 8;
            this.btn_ce.Text = "CE";
            this.btn_ce.UseVisualStyleBackColor = true;
            this.btn_ce.Click += new System.EventHandler(this.op2_ButtonClick);
            // 
            // btn_c
            // 
            this.btn_c.Location = new System.Drawing.Point(144, 113);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(47, 29);
            this.btn_c.TabIndex = 9;
            this.btn_c.Text = "C";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.op_ButtonClick);
            // 
            // btn_sign
            // 
            this.btn_sign.Location = new System.Drawing.Point(197, 113);
            this.btn_sign.Name = "btn_sign";
            this.btn_sign.Size = new System.Drawing.Size(47, 29);
            this.btn_sign.TabIndex = 10;
            this.btn_sign.Text = "±";
            this.btn_sign.UseVisualStyleBackColor = true;
            this.btn_sign.Click += new System.EventHandler(this.singButtonClick);
            // 
            // btn_root
            // 
            this.btn_root.Location = new System.Drawing.Point(250, 113);
            this.btn_root.Name = "btn_root";
            this.btn_root.Size = new System.Drawing.Size(47, 29);
            this.btn_root.TabIndex = 11;
            this.btn_root.Text = "√";
            this.btn_root.UseVisualStyleBackColor = true;
            this.btn_root.Click += new System.EventHandler(this.op2_ButtonClick);
            // 
            // btn_num7
            // 
            this.btn_num7.Location = new System.Drawing.Point(37, 148);
            this.btn_num7.Name = "btn_num7";
            this.btn_num7.Size = new System.Drawing.Size(47, 29);
            this.btn_num7.TabIndex = 12;
            this.btn_num7.Text = "7";
            this.btn_num7.UseVisualStyleBackColor = true;
            this.btn_num7.Click += new System.EventHandler(this.num_ButtonClick);
            // 
            // btn_num8
            // 
            this.btn_num8.Location = new System.Drawing.Point(91, 148);
            this.btn_num8.Name = "btn_num8";
            this.btn_num8.Size = new System.Drawing.Size(47, 29);
            this.btn_num8.TabIndex = 13;
            this.btn_num8.Text = "8";
            this.btn_num8.UseVisualStyleBackColor = true;
            this.btn_num8.Click += new System.EventHandler(this.num_ButtonClick);
            // 
            // btn_num9
            // 
            this.btn_num9.Location = new System.Drawing.Point(144, 148);
            this.btn_num9.Name = "btn_num9";
            this.btn_num9.Size = new System.Drawing.Size(47, 29);
            this.btn_num9.TabIndex = 14;
            this.btn_num9.Text = "9";
            this.btn_num9.UseVisualStyleBackColor = true;
            this.btn_num9.Click += new System.EventHandler(this.num_ButtonClick);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(197, 148);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(47, 29);
            this.btn_div.TabIndex = 15;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.op_ButtonClick);
            // 
            // btn_div_rest
            // 
            this.btn_div_rest.Location = new System.Drawing.Point(250, 148);
            this.btn_div_rest.Name = "btn_div_rest";
            this.btn_div_rest.Size = new System.Drawing.Size(47, 29);
            this.btn_div_rest.TabIndex = 16;
            this.btn_div_rest.Text = "%";
            this.btn_div_rest.UseVisualStyleBackColor = true;
            this.btn_div_rest.Click += new System.EventHandler(this.op_ButtonClick);
            // 
            // btn_num4
            // 
            this.btn_num4.Location = new System.Drawing.Point(38, 183);
            this.btn_num4.Name = "btn_num4";
            this.btn_num4.Size = new System.Drawing.Size(47, 29);
            this.btn_num4.TabIndex = 17;
            this.btn_num4.Text = "4";
            this.btn_num4.UseVisualStyleBackColor = true;
            this.btn_num4.Click += new System.EventHandler(this.num_ButtonClick);
            // 
            // btn_num5
            // 
            this.btn_num5.Location = new System.Drawing.Point(91, 183);
            this.btn_num5.Name = "btn_num5";
            this.btn_num5.Size = new System.Drawing.Size(47, 29);
            this.btn_num5.TabIndex = 18;
            this.btn_num5.Text = "5";
            this.btn_num5.UseVisualStyleBackColor = true;
            this.btn_num5.Click += new System.EventHandler(this.num_ButtonClick);
            // 
            // btn_num6
            // 
            this.btn_num6.Location = new System.Drawing.Point(144, 183);
            this.btn_num6.Name = "btn_num6";
            this.btn_num6.Size = new System.Drawing.Size(47, 29);
            this.btn_num6.TabIndex = 19;
            this.btn_num6.Text = "6";
            this.btn_num6.UseVisualStyleBackColor = true;
            this.btn_num6.Click += new System.EventHandler(this.num_ButtonClick);
            // 
            // btn_mul
            // 
            this.btn_mul.Location = new System.Drawing.Point(197, 183);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(47, 29);
            this.btn_mul.TabIndex = 20;
            this.btn_mul.Text = "*";
            this.btn_mul.UseVisualStyleBackColor = true;
            this.btn_mul.Click += new System.EventHandler(this.op_ButtonClick);
            // 
            // btn_fract
            // 
            this.btn_fract.Location = new System.Drawing.Point(250, 183);
            this.btn_fract.Name = "btn_fract";
            this.btn_fract.Size = new System.Drawing.Size(47, 29);
            this.btn_fract.TabIndex = 21;
            this.btn_fract.Text = "1/x";
            this.btn_fract.UseVisualStyleBackColor = true;
            this.btn_fract.Click += new System.EventHandler(this.op2_ButtonClick);
            // 
            // btn_num1
            // 
            this.btn_num1.Location = new System.Drawing.Point(38, 218);
            this.btn_num1.Name = "btn_num1";
            this.btn_num1.Size = new System.Drawing.Size(47, 29);
            this.btn_num1.TabIndex = 22;
            this.btn_num1.Text = "1";
            this.btn_num1.UseVisualStyleBackColor = true;
            this.btn_num1.Click += new System.EventHandler(this.num_ButtonClick);
            // 
            // btn_num2
            // 
            this.btn_num2.Location = new System.Drawing.Point(91, 218);
            this.btn_num2.Name = "btn_num2";
            this.btn_num2.Size = new System.Drawing.Size(47, 29);
            this.btn_num2.TabIndex = 23;
            this.btn_num2.Text = "2";
            this.btn_num2.UseVisualStyleBackColor = true;
            this.btn_num2.Click += new System.EventHandler(this.num_ButtonClick);
            // 
            // btn_num3
            // 
            this.btn_num3.Location = new System.Drawing.Point(144, 218);
            this.btn_num3.Name = "btn_num3";
            this.btn_num3.Size = new System.Drawing.Size(47, 29);
            this.btn_num3.TabIndex = 24;
            this.btn_num3.Text = "3";
            this.btn_num3.UseVisualStyleBackColor = true;
            this.btn_num3.Click += new System.EventHandler(this.num_ButtonClick);
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(197, 218);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(47, 29);
            this.btn_minus.TabIndex = 25;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.op_ButtonClick);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(250, 218);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(47, 64);
            this.button25.TabIndex = 26;
            this.button25.Text = "=";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.op_ButtonClick);
            // 
            // btn_num0
            // 
            this.btn_num0.Location = new System.Drawing.Point(38, 253);
            this.btn_num0.Name = "btn_num0";
            this.btn_num0.Size = new System.Drawing.Size(100, 29);
            this.btn_num0.TabIndex = 27;
            this.btn_num0.Text = "0";
            this.btn_num0.UseVisualStyleBackColor = true;
            this.btn_num0.Click += new System.EventHandler(this.num_ButtonClick);
            // 
            // btn_dot
            // 
            this.btn_dot.Location = new System.Drawing.Point(144, 253);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(47, 29);
            this.btn_dot.TabIndex = 29;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = true;
            this.btn_dot.Click += new System.EventHandler(this.num_ButtonClick);
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(197, 253);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(47, 29);
            this.btn_plus.TabIndex = 30;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.op_ButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 315);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_dot);
            this.Controls.Add(this.btn_num0);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_num3);
            this.Controls.Add(this.btn_num2);
            this.Controls.Add(this.btn_num1);
            this.Controls.Add(this.btn_fract);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_num6);
            this.Controls.Add(this.btn_num5);
            this.Controls.Add(this.btn_num4);
            this.Controls.Add(this.btn_div_rest);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_num9);
            this.Controls.Add(this.btn_num8);
            this.Controls.Add(this.btn_num7);
            this.Controls.Add(this.btn_root);
            this.Controls.Add(this.btn_sign);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.btn_ce);
            this.Controls.Add(this.btn_backspace);
            this.Controls.Add(this.btn_m_plus);
            this.Controls.Add(this.btn_m_minus);
            this.Controls.Add(this.btn_mr);
            this.Controls.Add(this.btn_ms);
            this.Controls.Add(this.btn_mc);
            this.Controls.Add(this.opTextBox);
            this.Controls.Add(this.numTextBox);
            this.Name = "Form1";
            this.Text = "WindowsCalc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.TextBox opTextBox;
        private System.Windows.Forms.Button btn_mc;
        private System.Windows.Forms.Button btn_ms;
        private System.Windows.Forms.Button btn_mr;
        private System.Windows.Forms.Button btn_m_minus;
        private System.Windows.Forms.Button btn_m_plus;
        private System.Windows.Forms.Button btn_backspace;
        private System.Windows.Forms.Button btn_ce;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_sign;
        private System.Windows.Forms.Button btn_root;
        private System.Windows.Forms.Button btn_num7;
        private System.Windows.Forms.Button btn_num8;
        private System.Windows.Forms.Button btn_num9;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_div_rest;
        private System.Windows.Forms.Button btn_num4;
        private System.Windows.Forms.Button btn_num5;
        private System.Windows.Forms.Button btn_num6;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_fract;
        private System.Windows.Forms.Button btn_num1;
        private System.Windows.Forms.Button btn_num2;
        private System.Windows.Forms.Button btn_num3;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button btn_num0;
        private System.Windows.Forms.Button btn_dot;
        private System.Windows.Forms.Button btn_plus;
    }
}

