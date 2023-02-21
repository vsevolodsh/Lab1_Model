/*
 * Created by SharpDevelop.
 * User: zh-en
 * Date: 04.02.2023
 * Time: 12:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Model
{
	partial class Master
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxMasterF = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonMultipl = new System.Windows.Forms.Button();
            this.buttonSin = new System.Windows.Forms.Button();
            this.buttonCos = new System.Windows.Forms.Button();
            this.buttonLn = new System.Windows.Forms.Button();
            this.buttonStepen = new System.Windows.Forms.Button();
            this.buttonBackSp = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonParenthesesClosed = new System.Windows.Forms.Button();
            this.buttonParenthesesOpened = new System.Windows.Forms.Button();
            this.buttonArccos = new System.Windows.Forms.Button();
            this.buttonArcsin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.Control;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(83, 263);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(56, 27);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Отмена";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonCloseClick);
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOk.FlatAppearance.BorderSize = 0;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOk.Location = new System.Drawing.Point(22, 263);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(56, 27);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxMasterF
            // 
            this.textBoxMasterF.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMasterF.Location = new System.Drawing.Point(19, 4);
            this.textBoxMasterF.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMasterF.MaxLength = 80;
            this.textBoxMasterF.Name = "textBoxMasterF";
            this.textBoxMasterF.Size = new System.Drawing.Size(416, 29);
            this.textBoxMasterF.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(20, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(79, 88);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(137, 88);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(20, 128);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 38);
            this.button4.TabIndex = 6;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(79, 128);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 38);
            this.button5.TabIndex = 7;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(137, 128);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 38);
            this.button6.TabIndex = 8;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(20, 169);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 38);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Control;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.button8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button8.Location = new System.Drawing.Point(79, 169);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 38);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Control;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.button9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button9.Location = new System.Drawing.Point(137, 169);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 38);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPoint.FlatAppearance.BorderSize = 0;
            this.buttonPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPoint.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonPoint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonPoint.Location = new System.Drawing.Point(20, 210);
            this.buttonPoint.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(56, 38);
            this.buttonPoint.TabIndex = 12;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = false;
            this.buttonPoint.Click += new System.EventHandler(this.buttonPoint_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.Control;
            this.button0.FlatAppearance.BorderSize = 0;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.button0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button0.Location = new System.Drawing.Point(79, 210);
            this.button0.Margin = new System.Windows.Forms.Padding(2);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(56, 38);
            this.button0.TabIndex = 13;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPlus.FlatAppearance.BorderSize = 0;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonPlus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonPlus.Location = new System.Drawing.Point(262, 88);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(56, 38);
            this.buttonPlus.TabIndex = 14;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMinus.FlatAppearance.BorderSize = 0;
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonMinus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMinus.Location = new System.Drawing.Point(262, 128);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(56, 38);
            this.buttonMinus.TabIndex = 15;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDivision.FlatAppearance.BorderSize = 0;
            this.buttonDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivision.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonDivision.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDivision.Location = new System.Drawing.Point(262, 169);
            this.buttonDivision.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(56, 38);
            this.buttonDivision.TabIndex = 16;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.buttonDivision_Click);
            // 
            // buttonMultipl
            // 
            this.buttonMultipl.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMultipl.FlatAppearance.BorderSize = 0;
            this.buttonMultipl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultipl.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonMultipl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMultipl.Location = new System.Drawing.Point(262, 210);
            this.buttonMultipl.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMultipl.Name = "buttonMultipl";
            this.buttonMultipl.Size = new System.Drawing.Size(56, 38);
            this.buttonMultipl.TabIndex = 17;
            this.buttonMultipl.Text = "*";
            this.buttonMultipl.UseVisualStyleBackColor = false;
            this.buttonMultipl.Click += new System.EventHandler(this.buttonMultipl_Click);
            // 
            // buttonSin
            // 
            this.buttonSin.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSin.FlatAppearance.BorderSize = 0;
            this.buttonSin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSin.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonSin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSin.Location = new System.Drawing.Point(382, 88);
            this.buttonSin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(56, 38);
            this.buttonSin.TabIndex = 18;
            this.buttonSin.Text = "sin";
            this.buttonSin.UseVisualStyleBackColor = true;
            this.buttonSin.Click += new System.EventHandler(this.buttonSin_Click);
            // 
            // buttonCos
            // 
            this.buttonCos.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCos.FlatAppearance.BorderSize = 0;
            this.buttonCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCos.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonCos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCos.Location = new System.Drawing.Point(382, 128);
            this.buttonCos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.Size = new System.Drawing.Size(56, 38);
            this.buttonCos.TabIndex = 19;
            this.buttonCos.Text = "cos";
            this.buttonCos.UseVisualStyleBackColor = false;
            this.buttonCos.Click += new System.EventHandler(this.buttonCos_Click);
            // 
            // buttonLn
            // 
            this.buttonLn.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLn.FlatAppearance.BorderSize = 0;
            this.buttonLn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonLn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLn.Location = new System.Drawing.Point(382, 169);
            this.buttonLn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLn.Name = "buttonLn";
            this.buttonLn.Size = new System.Drawing.Size(56, 38);
            this.buttonLn.TabIndex = 21;
            this.buttonLn.Text = "ln";
            this.buttonLn.UseVisualStyleBackColor = false;
            this.buttonLn.Click += new System.EventHandler(this.buttonLn_Click);
            // 
            // buttonStepen
            // 
            this.buttonStepen.BackColor = System.Drawing.SystemColors.Control;
            this.buttonStepen.FlatAppearance.BorderSize = 0;
            this.buttonStepen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStepen.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonStepen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStepen.Location = new System.Drawing.Point(322, 170);
            this.buttonStepen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStepen.Name = "buttonStepen";
            this.buttonStepen.Size = new System.Drawing.Size(56, 38);
            this.buttonStepen.TabIndex = 22;
            this.buttonStepen.Text = "^";
            this.buttonStepen.UseVisualStyleBackColor = false;
            this.buttonStepen.Click += new System.EventHandler(this.buttonStepen_Click);
            // 
            // buttonBackSp
            // 
            this.buttonBackSp.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBackSp.FlatAppearance.BorderSize = 0;
            this.buttonBackSp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackSp.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonBackSp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBackSp.Location = new System.Drawing.Point(259, 37);
            this.buttonBackSp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBackSp.Name = "buttonBackSp";
            this.buttonBackSp.Size = new System.Drawing.Size(86, 38);
            this.buttonBackSp.TabIndex = 28;
            this.buttonBackSp.Text = "BackSp";
            this.buttonBackSp.UseMnemonic = false;
            this.buttonBackSp.UseVisualStyleBackColor = false;
            this.buttonBackSp.Click += new System.EventHandler(this.buttonBackSp_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.Control;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonClear.Location = new System.Drawing.Point(349, 37);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(86, 38);
            this.buttonClear.TabIndex = 29;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseMnemonic = false;
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.SystemColors.Control;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.Location = new System.Drawing.Point(144, 268);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 16);
            this.labelError.TabIndex = 30;
            // 
            // buttonParenthesesClosed
            // 
            this.buttonParenthesesClosed.BackColor = System.Drawing.SystemColors.Control;
            this.buttonParenthesesClosed.FlatAppearance.BorderSize = 0;
            this.buttonParenthesesClosed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonParenthesesClosed.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonParenthesesClosed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonParenthesesClosed.Location = new System.Drawing.Point(322, 128);
            this.buttonParenthesesClosed.Margin = new System.Windows.Forms.Padding(2);
            this.buttonParenthesesClosed.Name = "buttonParenthesesClosed";
            this.buttonParenthesesClosed.Size = new System.Drawing.Size(56, 38);
            this.buttonParenthesesClosed.TabIndex = 32;
            this.buttonParenthesesClosed.Text = ")";
            this.buttonParenthesesClosed.UseVisualStyleBackColor = false;
            this.buttonParenthesesClosed.Click += new System.EventHandler(this.buttonParenthesesClosed_Click);
            // 
            // buttonParenthesesOpened
            // 
            this.buttonParenthesesOpened.BackColor = System.Drawing.SystemColors.Control;
            this.buttonParenthesesOpened.FlatAppearance.BorderSize = 0;
            this.buttonParenthesesOpened.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonParenthesesOpened.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonParenthesesOpened.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonParenthesesOpened.Location = new System.Drawing.Point(322, 88);
            this.buttonParenthesesOpened.Margin = new System.Windows.Forms.Padding(2);
            this.buttonParenthesesOpened.Name = "buttonParenthesesOpened";
            this.buttonParenthesesOpened.Size = new System.Drawing.Size(56, 38);
            this.buttonParenthesesOpened.TabIndex = 31;
            this.buttonParenthesesOpened.Text = "(";
            this.buttonParenthesesOpened.UseVisualStyleBackColor = false;
            this.buttonParenthesesOpened.Click += new System.EventHandler(this.buttonParenthesesOpened_Click);
            // 
            // buttonArccos
            // 
            this.buttonArccos.BackColor = System.Drawing.SystemColors.Control;
            this.buttonArccos.FlatAppearance.BorderSize = 0;
            this.buttonArccos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArccos.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonArccos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonArccos.Location = new System.Drawing.Point(382, 211);
            this.buttonArccos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonArccos.Name = "buttonArccos";
            this.buttonArccos.Size = new System.Drawing.Size(56, 38);
            this.buttonArccos.TabIndex = 34;
            this.buttonArccos.Text = "arccos";
            this.buttonArccos.UseVisualStyleBackColor = false;
            this.buttonArccos.Click += new System.EventHandler(this.buttonArccos_Click);
            // 
            // buttonArcsin
            // 
            this.buttonArcsin.BackColor = System.Drawing.SystemColors.Control;
            this.buttonArcsin.FlatAppearance.BorderSize = 0;
            this.buttonArcsin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArcsin.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonArcsin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonArcsin.Location = new System.Drawing.Point(322, 211);
            this.buttonArcsin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonArcsin.Name = "buttonArcsin";
            this.buttonArcsin.Size = new System.Drawing.Size(56, 38);
            this.buttonArcsin.TabIndex = 33;
            this.buttonArcsin.Text = "arcsin";
            this.buttonArcsin.UseVisualStyleBackColor = true;
            this.buttonArcsin.Click += new System.EventHandler(this.buttonArcsin_Click);
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(487, 301);
            this.Controls.Add(this.buttonArccos);
            this.Controls.Add(this.buttonArcsin);
            this.Controls.Add(this.buttonParenthesesClosed);
            this.Controls.Add(this.buttonParenthesesOpened);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonBackSp);
            this.Controls.Add(this.buttonStepen);
            this.Controls.Add(this.buttonLn);
            this.Controls.Add(this.buttonCos);
            this.Controls.Add(this.buttonSin);
            this.Controls.Add(this.buttonMultipl);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxMasterF);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Master";
            this.Text = "Master";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonBackSp;
	//	private System.Windows.Forms.Button buttonFullRight;
	//	private System.Windows.Forms.Button buttonFullLeft;
	//	private System.Windows.Forms.Button buttonRight;
	//	private System.Windows.Forms.Button buttonLeft;
		private System.Windows.Forms.Button buttonStepen;
		private System.Windows.Forms.Button buttonLn;
		private System.Windows.Forms.Button buttonCos;
		private System.Windows.Forms.Button buttonSin;
		private System.Windows.Forms.Button buttonMultipl;
		private System.Windows.Forms.Button buttonDivision;
		private System.Windows.Forms.Button buttonMinus;
		private System.Windows.Forms.Button buttonPlus;
		private System.Windows.Forms.Button button0;
		private System.Windows.Forms.Button buttonPoint;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBoxMasterF;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonParenthesesClosed;
        private System.Windows.Forms.Button buttonParenthesesOpened;
        private System.Windows.Forms.Button buttonArccos;
        private System.Windows.Forms.Button buttonArcsin;
    }
}
