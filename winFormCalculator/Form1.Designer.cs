namespace winFormCalculator
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
            this.txtExp = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btnMMinus = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnModulus = new System.Windows.Forms.Button();
            this.btnRoot = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtExp
            // 
            this.txtExp.BackColor = System.Drawing.SystemColors.Control;
            this.txtExp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExp.Location = new System.Drawing.Point(12, 12);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(238, 13);
            this.txtExp.TabIndex = 0;
            this.txtExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.Control;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(12, 38);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(238, 28);
            this.txtResult.TabIndex = 1;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMC
            // 
            this.btnMC.FlatAppearance.BorderSize = 0;
            this.btnMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMC.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMC.Location = new System.Drawing.Point(12, 83);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(43, 23);
            this.btnMC.TabIndex = 2;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // btnMR
            // 
            this.btnMR.FlatAppearance.BorderSize = 0;
            this.btnMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMR.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMR.Location = new System.Drawing.Point(61, 83);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(43, 23);
            this.btnMR.TabIndex = 3;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btnMPlus
            // 
            this.btnMPlus.FlatAppearance.BorderSize = 0;
            this.btnMPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMPlus.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMPlus.Location = new System.Drawing.Point(110, 83);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(43, 23);
            this.btnMPlus.TabIndex = 4;
            this.btnMPlus.Text = "M+";
            this.btnMPlus.UseVisualStyleBackColor = true;
            this.btnMPlus.Click += new System.EventHandler(this.btnMPlus_Click);
            // 
            // btnMMinus
            // 
            this.btnMMinus.FlatAppearance.BorderSize = 0;
            this.btnMMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMMinus.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMMinus.Location = new System.Drawing.Point(159, 83);
            this.btnMMinus.Name = "btnMMinus";
            this.btnMMinus.Size = new System.Drawing.Size(43, 23);
            this.btnMMinus.TabIndex = 5;
            this.btnMMinus.Text = "M-";
            this.btnMMinus.UseVisualStyleBackColor = true;
            this.btnMMinus.Click += new System.EventHandler(this.btnMMinus_Click);
            // 
            // btnMS
            // 
            this.btnMS.FlatAppearance.BorderSize = 0;
            this.btnMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMS.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMS.Location = new System.Drawing.Point(208, 83);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(43, 23);
            this.btnMS.TabIndex = 6;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = true;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btnModulus
            // 
            this.btnModulus.FlatAppearance.BorderSize = 0;
            this.btnModulus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModulus.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModulus.Location = new System.Drawing.Point(12, 125);
            this.btnModulus.Name = "btnModulus";
            this.btnModulus.Size = new System.Drawing.Size(54, 25);
            this.btnModulus.TabIndex = 7;
            this.btnModulus.Text = "%";
            this.btnModulus.UseVisualStyleBackColor = true;
            // 
            // btnRoot
            // 
            this.btnRoot.FlatAppearance.BorderSize = 0;
            this.btnRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoot.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoot.Location = new System.Drawing.Point(72, 125);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(54, 25);
            this.btnRoot.TabIndex = 8;
            this.btnRoot.Text = "√";
            this.btnRoot.UseVisualStyleBackColor = true;
            this.btnRoot.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.FlatAppearance.BorderSize = 0;
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare.Location = new System.Drawing.Point(136, 125);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(54, 25);
            this.btnSquare.TabIndex = 9;
            this.btnSquare.Text = "x2";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSqr_Click);
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.FlatAppearance.BorderSize = 0;
            this.btnReciprocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReciprocal.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReciprocal.Location = new System.Drawing.Point(196, 125);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(54, 25);
            this.btnReciprocal.TabIndex = 10;
            this.btnReciprocal.Text = "1/x";
            this.btnReciprocal.UseVisualStyleBackColor = true;
            this.btnReciprocal.Click += new System.EventHandler(this.btnRecip_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.FlatAppearance.BorderSize = 0;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivision.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDivision.Location = new System.Drawing.Point(196, 168);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(54, 27);
            this.btnDivision.TabIndex = 14;
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.FlatAppearance.BorderSize = 0;
            this.btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackSpace.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackSpace.Location = new System.Drawing.Point(136, 173);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(54, 25);
            this.btnBackSpace.TabIndex = 13;
            this.btnBackSpace.Text = "<[]";
            this.btnBackSpace.UseVisualStyleBackColor = true;
            this.btnBackSpace.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnC
            // 
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(72, 173);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(54, 25);
            this.btnC.TabIndex = 12;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.FlatAppearance.BorderSize = 0;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(12, 173);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(54, 25);
            this.btnCE.TabIndex = 11;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.FlatAppearance.BorderSize = 0;
            this.btnMultiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiple.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMultiple.Location = new System.Drawing.Point(196, 204);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(54, 59);
            this.btnMultiple.TabIndex = 18;
            this.btnMultiple.Text = "x";
            this.btnMultiple.UseVisualStyleBackColor = true;
            this.btnMultiple.Click += new System.EventHandler(this.btnMultiple_Click);
            // 
            // btn9
            // 
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn9.Location = new System.Drawing.Point(136, 204);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(54, 59);
            this.btn9.TabIndex = 17;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn8
            // 
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn8.Location = new System.Drawing.Point(72, 204);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(54, 59);
            this.btn8.TabIndex = 16;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn7
            // 
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn7.Location = new System.Drawing.Point(12, 204);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(54, 59);
            this.btn7.TabIndex = 15;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMinus.Location = new System.Drawing.Point(196, 264);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(54, 59);
            this.btnMinus.TabIndex = 22;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btn6
            // 
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn6.Location = new System.Drawing.Point(136, 264);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(54, 59);
            this.btn6.TabIndex = 21;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn5
            // 
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn5.Location = new System.Drawing.Point(72, 264);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(54, 59);
            this.btn5.TabIndex = 20;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn4
            // 
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn4.Location = new System.Drawing.Point(12, 264);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(54, 59);
            this.btn4.TabIndex = 19;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPlus.Location = new System.Drawing.Point(196, 329);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(54, 59);
            this.btnPlus.TabIndex = 26;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btn3
            // 
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn3.Location = new System.Drawing.Point(136, 329);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(54, 59);
            this.btn3.TabIndex = 25;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn2
            // 
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn2.Location = new System.Drawing.Point(72, 329);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(54, 59);
            this.btn2.TabIndex = 24;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn1
            // 
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn1.Location = new System.Drawing.Point(12, 329);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(54, 59);
            this.btn1.TabIndex = 23;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEqual.Location = new System.Drawing.Point(196, 393);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(54, 59);
            this.btnEqual.TabIndex = 30;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnDot
            // 
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDot.Location = new System.Drawing.Point(136, 393);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(54, 59);
            this.btnDot.TabIndex = 29;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btn0
            // 
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn0.Location = new System.Drawing.Point(72, 393);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(54, 59);
            this.btn0.TabIndex = 28;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.FlatAppearance.BorderSize = 0;
            this.btnPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusMinus.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPlusMinus.Location = new System.Drawing.Point(12, 393);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(54, 59);
            this.btnPlusMinus.TabIndex = 27;
            this.btnPlusMinus.Text = "±";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(265, 464);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnMultiple);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnRoot);
            this.Controls.Add(this.btnModulus);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnMMinus);
            this.Controls.Add(this.btnMPlus);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtExp);
            this.Name = "Form1";
            this.Text = "나의 계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExp;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Button btnMMinus;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnModulus;
        private System.Windows.Forms.Button btnRoot;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPlusMinus;
    }
}

