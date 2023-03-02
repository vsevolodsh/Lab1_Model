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
            if (disposing)
            {
                if (components != null)
                {
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
            this.buttonVarA = new System.Windows.Forms.Button();
            this.buttonVarE = new System.Windows.Forms.Button();
            this.buttonVarF = new System.Windows.Forms.Button();
            this.buttonVarC = new System.Windows.Forms.Button();
            this.buttonVarB = new System.Windows.Forms.Button();
            this.buttonVarD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonClose.Location = new System.Drawing.Point(103, 175);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(91, 36);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Отмена";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonCloseClick);
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.White;
            this.buttonOk.FlatAppearance.BorderSize = 0;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonOk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOk.Location = new System.Drawing.Point(10, 175);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(91, 36);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxMasterF
            // 
            this.textBoxMasterF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMasterF.Font = new System.Drawing.Font("Yu Gothic UI", 12.2F);
            this.textBoxMasterF.Location = new System.Drawing.Point(10, 10);
            this.textBoxMasterF.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMasterF.MaxLength = 80;
            this.textBoxMasterF.Name = "textBoxMasterF";
            this.textBoxMasterF.Size = new System.Drawing.Size(416, 29);
            this.textBoxMasterF.TabIndex = 2;
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.White;
            this.buttonPlus.FlatAppearance.BorderSize = 0;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonPlus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonPlus.Location = new System.Drawing.Point(242, 53);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(60, 38);
            this.buttonPlus.TabIndex = 14;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.White;
            this.buttonMinus.FlatAppearance.BorderSize = 0;
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonMinus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMinus.Location = new System.Drawing.Point(242, 93);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(60, 38);
            this.buttonMinus.TabIndex = 15;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.BackColor = System.Drawing.Color.White;
            this.buttonDivision.FlatAppearance.BorderSize = 0;
            this.buttonDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivision.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonDivision.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDivision.Location = new System.Drawing.Point(242, 133);
            this.buttonDivision.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(60, 38);
            this.buttonDivision.TabIndex = 16;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.buttonDivision_Click);
            // 
            // buttonMultipl
            // 
            this.buttonMultipl.BackColor = System.Drawing.Color.White;
            this.buttonMultipl.FlatAppearance.BorderSize = 0;
            this.buttonMultipl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultipl.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonMultipl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMultipl.Location = new System.Drawing.Point(242, 173);
            this.buttonMultipl.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMultipl.Name = "buttonMultipl";
            this.buttonMultipl.Size = new System.Drawing.Size(60, 38);
            this.buttonMultipl.TabIndex = 17;
            this.buttonMultipl.Text = "*";
            this.buttonMultipl.UseVisualStyleBackColor = false;
            this.buttonMultipl.Click += new System.EventHandler(this.buttonMultipl_Click);
            // 
            // buttonSin
            // 
            this.buttonSin.BackColor = System.Drawing.Color.White;
            this.buttonSin.FlatAppearance.BorderSize = 0;
            this.buttonSin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSin.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonSin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSin.Location = new System.Drawing.Point(366, 53);
            this.buttonSin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(60, 38);
            this.buttonSin.TabIndex = 18;
            this.buttonSin.Text = "sin";
            this.buttonSin.UseVisualStyleBackColor = false;
            this.buttonSin.Click += new System.EventHandler(this.buttonSin_Click);
            // 
            // buttonCos
            // 
            this.buttonCos.BackColor = System.Drawing.Color.White;
            this.buttonCos.FlatAppearance.BorderSize = 0;
            this.buttonCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCos.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonCos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCos.Location = new System.Drawing.Point(366, 93);
            this.buttonCos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.Size = new System.Drawing.Size(60, 38);
            this.buttonCos.TabIndex = 19;
            this.buttonCos.Text = "cos";
            this.buttonCos.UseVisualStyleBackColor = false;
            this.buttonCos.Click += new System.EventHandler(this.buttonCos_Click);
            // 
            // buttonLn
            // 
            this.buttonLn.BackColor = System.Drawing.Color.White;
            this.buttonLn.FlatAppearance.BorderSize = 0;
            this.buttonLn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonLn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLn.Location = new System.Drawing.Point(366, 133);
            this.buttonLn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLn.Name = "buttonLn";
            this.buttonLn.Size = new System.Drawing.Size(60, 38);
            this.buttonLn.TabIndex = 21;
            this.buttonLn.Text = "ln";
            this.buttonLn.UseVisualStyleBackColor = false;
            this.buttonLn.Click += new System.EventHandler(this.buttonLn_Click);
            // 
            // buttonStepen
            // 
            this.buttonStepen.BackColor = System.Drawing.Color.White;
            this.buttonStepen.FlatAppearance.BorderSize = 0;
            this.buttonStepen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStepen.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonStepen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStepen.Location = new System.Drawing.Point(304, 133);
            this.buttonStepen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStepen.Name = "buttonStepen";
            this.buttonStepen.Size = new System.Drawing.Size(60, 38);
            this.buttonStepen.TabIndex = 22;
            this.buttonStepen.Text = "^";
            this.buttonStepen.UseVisualStyleBackColor = false;
            this.buttonStepen.Click += new System.EventHandler(this.buttonStepen_Click);
            // 
            // buttonBackSp
            // 
            this.buttonBackSp.BackColor = System.Drawing.Color.White;
            this.buttonBackSp.FlatAppearance.BorderSize = 0;
            this.buttonBackSp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackSp.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonBackSp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBackSp.Location = new System.Drawing.Point(10, 53);
            this.buttonBackSp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBackSp.Name = "buttonBackSp";
            this.buttonBackSp.Size = new System.Drawing.Size(91, 36);
            this.buttonBackSp.TabIndex = 28;
            this.buttonBackSp.Text = "BackSp";
            this.buttonBackSp.UseMnemonic = false;
            this.buttonBackSp.UseVisualStyleBackColor = false;
            this.buttonBackSp.Click += new System.EventHandler(this.buttonBackSp_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.White;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonClear.Location = new System.Drawing.Point(103, 53);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(91, 36);
            this.buttonClear.TabIndex = 29;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseMnemonic = false;
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelError.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.Location = new System.Drawing.Point(10, 215);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 15);
            this.labelError.TabIndex = 30;
            // 
            // buttonParenthesesClosed
            // 
            this.buttonParenthesesClosed.BackColor = System.Drawing.Color.White;
            this.buttonParenthesesClosed.FlatAppearance.BorderSize = 0;
            this.buttonParenthesesClosed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonParenthesesClosed.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonParenthesesClosed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonParenthesesClosed.Location = new System.Drawing.Point(304, 93);
            this.buttonParenthesesClosed.Margin = new System.Windows.Forms.Padding(2);
            this.buttonParenthesesClosed.Name = "buttonParenthesesClosed";
            this.buttonParenthesesClosed.Size = new System.Drawing.Size(60, 38);
            this.buttonParenthesesClosed.TabIndex = 32;
            this.buttonParenthesesClosed.Text = ")";
            this.buttonParenthesesClosed.UseVisualStyleBackColor = false;
            this.buttonParenthesesClosed.Click += new System.EventHandler(this.buttonParenthesesClosed_Click);
            // 
            // buttonParenthesesOpened
            // 
            this.buttonParenthesesOpened.BackColor = System.Drawing.Color.White;
            this.buttonParenthesesOpened.FlatAppearance.BorderSize = 0;
            this.buttonParenthesesOpened.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonParenthesesOpened.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonParenthesesOpened.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonParenthesesOpened.Location = new System.Drawing.Point(304, 53);
            this.buttonParenthesesOpened.Margin = new System.Windows.Forms.Padding(2);
            this.buttonParenthesesOpened.Name = "buttonParenthesesOpened";
            this.buttonParenthesesOpened.Size = new System.Drawing.Size(60, 38);
            this.buttonParenthesesOpened.TabIndex = 31;
            this.buttonParenthesesOpened.Text = "(";
            this.buttonParenthesesOpened.UseVisualStyleBackColor = false;
            this.buttonParenthesesOpened.Click += new System.EventHandler(this.buttonParenthesesOpened_Click);
            // 
            // buttonArccos
            // 
            this.buttonArccos.BackColor = System.Drawing.Color.White;
            this.buttonArccos.FlatAppearance.BorderSize = 0;
            this.buttonArccos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArccos.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonArccos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonArccos.Location = new System.Drawing.Point(366, 173);
            this.buttonArccos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonArccos.Name = "buttonArccos";
            this.buttonArccos.Size = new System.Drawing.Size(60, 38);
            this.buttonArccos.TabIndex = 34;
            this.buttonArccos.Text = "arccos";
            this.buttonArccos.UseVisualStyleBackColor = false;
            this.buttonArccos.Click += new System.EventHandler(this.buttonArccos_Click);
            // 
            // buttonArcsin
            // 
            this.buttonArcsin.BackColor = System.Drawing.Color.White;
            this.buttonArcsin.FlatAppearance.BorderSize = 0;
            this.buttonArcsin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArcsin.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonArcsin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonArcsin.Location = new System.Drawing.Point(304, 173);
            this.buttonArcsin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonArcsin.Name = "buttonArcsin";
            this.buttonArcsin.Size = new System.Drawing.Size(60, 38);
            this.buttonArcsin.TabIndex = 33;
            this.buttonArcsin.Text = "arcsin";
            this.buttonArcsin.UseVisualStyleBackColor = false;
            this.buttonArcsin.Click += new System.EventHandler(this.buttonArcsin_Click);
            // 
            // buttonVarA
            // 
            this.buttonVarA.BackColor = System.Drawing.Color.White;
            this.buttonVarA.FlatAppearance.BorderSize = 0;
            this.buttonVarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVarA.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonVarA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonVarA.Location = new System.Drawing.Point(10, 93);
            this.buttonVarA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVarA.Name = "buttonVarA";
            this.buttonVarA.Size = new System.Drawing.Size(60, 38);
            this.buttonVarA.TabIndex = 35;
            this.buttonVarA.Text = "a";
            this.buttonVarA.UseVisualStyleBackColor = false;
            this.buttonVarA.Click += new System.EventHandler(this.buttonVarA_Click);
            // 
            // buttonVarE
            // 
            this.buttonVarE.BackColor = System.Drawing.Color.White;
            this.buttonVarE.FlatAppearance.BorderSize = 0;
            this.buttonVarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVarE.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonVarE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonVarE.Location = new System.Drawing.Point(72, 133);
            this.buttonVarE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVarE.Name = "buttonVarE";
            this.buttonVarE.Size = new System.Drawing.Size(60, 38);
            this.buttonVarE.TabIndex = 36;
            this.buttonVarE.Text = "e";
            this.buttonVarE.UseVisualStyleBackColor = false;
            this.buttonVarE.Click += new System.EventHandler(this.buttonVarE_Click);
            // 
            // buttonVarF
            // 
            this.buttonVarF.BackColor = System.Drawing.Color.White;
            this.buttonVarF.FlatAppearance.BorderSize = 0;
            this.buttonVarF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVarF.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonVarF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonVarF.Location = new System.Drawing.Point(134, 133);
            this.buttonVarF.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVarF.Name = "buttonVarF";
            this.buttonVarF.Size = new System.Drawing.Size(60, 38);
            this.buttonVarF.TabIndex = 37;
            this.buttonVarF.Text = "f";
            this.buttonVarF.UseVisualStyleBackColor = false;
            this.buttonVarF.Click += new System.EventHandler(this.buttonVarF_Click);
            // 
            // buttonVarC
            // 
            this.buttonVarC.BackColor = System.Drawing.Color.White;
            this.buttonVarC.FlatAppearance.BorderSize = 0;
            this.buttonVarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVarC.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonVarC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonVarC.Location = new System.Drawing.Point(134, 93);
            this.buttonVarC.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVarC.Name = "buttonVarC";
            this.buttonVarC.Size = new System.Drawing.Size(60, 38);
            this.buttonVarC.TabIndex = 38;
            this.buttonVarC.Text = "c";
            this.buttonVarC.UseVisualStyleBackColor = false;
            this.buttonVarC.Click += new System.EventHandler(this.buttonVarC_Click);
            // 
            // buttonVarB
            // 
            this.buttonVarB.BackColor = System.Drawing.Color.White;
            this.buttonVarB.FlatAppearance.BorderSize = 0;
            this.buttonVarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVarB.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonVarB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonVarB.Location = new System.Drawing.Point(72, 93);
            this.buttonVarB.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVarB.Name = "buttonVarB";
            this.buttonVarB.Size = new System.Drawing.Size(60, 38);
            this.buttonVarB.TabIndex = 39;
            this.buttonVarB.Text = "b";
            this.buttonVarB.UseVisualStyleBackColor = false;
            this.buttonVarB.Click += new System.EventHandler(this.buttonVarB_Click);
            // 
            // buttonVarD
            // 
            this.buttonVarD.BackColor = System.Drawing.Color.White;
            this.buttonVarD.FlatAppearance.BorderSize = 0;
            this.buttonVarD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVarD.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.buttonVarD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonVarD.Location = new System.Drawing.Point(10, 133);
            this.buttonVarD.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVarD.Name = "buttonVarD";
            this.buttonVarD.Size = new System.Drawing.Size(60, 38);
            this.buttonVarD.TabIndex = 40;
            this.buttonVarD.Text = "d";
            this.buttonVarD.UseVisualStyleBackColor = false;
            this.buttonVarD.Click += new System.EventHandler(this.buttonVarD_Click);
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(436, 235);
            this.Controls.Add(this.buttonVarD);
            this.Controls.Add(this.buttonVarB);
            this.Controls.Add(this.buttonVarC);
            this.Controls.Add(this.buttonVarF);
            this.Controls.Add(this.buttonVarE);
            this.Controls.Add(this.buttonVarA);
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
            this.Controls.Add(this.textBoxMasterF);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.TextBox textBoxMasterF;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonParenthesesClosed;
        private System.Windows.Forms.Button buttonParenthesesOpened;
        private System.Windows.Forms.Button buttonArccos;
        private System.Windows.Forms.Button buttonArcsin;
        private System.Windows.Forms.Button buttonVarA;
        private System.Windows.Forms.Button buttonVarE;
        private System.Windows.Forms.Button buttonVarF;
        private System.Windows.Forms.Button buttonVarC;
        private System.Windows.Forms.Button buttonVarB;
        private System.Windows.Forms.Button buttonVarD;
    }
}