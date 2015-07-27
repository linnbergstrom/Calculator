namespace Calculator
{
	partial class Calculator
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
			this.btnSum = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnBackspace = new System.Windows.Forms.Button();
			this.btnDiv = new System.Windows.Forms.Button();
			this.btnMulti = new System.Windows.Forms.Button();
			this.btnSubtr = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btn07 = new System.Windows.Forms.Button();
			this.btn08 = new System.Windows.Forms.Button();
			this.btn09 = new System.Windows.Forms.Button();
			this.btn06 = new System.Windows.Forms.Button();
			this.btn05 = new System.Windows.Forms.Button();
			this.btn04 = new System.Windows.Forms.Button();
			this.btnDeci = new System.Windows.Forms.Button();
			this.btn00 = new System.Windows.Forms.Button();
			this.btn03 = new System.Windows.Forms.Button();
			this.btn02 = new System.Windows.Forms.Button();
			this.btn01 = new System.Windows.Forms.Button();
			this.inputBox = new System.Windows.Forms.TextBox();
			this.topBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnSum
			// 
			this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSum.Location = new System.Drawing.Point(164, 115);
			this.btnSum.Name = "btnSum";
			this.btnSum.Size = new System.Drawing.Size(101, 42);
			this.btnSum.TabIndex = 89;
			this.btnSum.Text = "=";
			this.btnSum.UseVisualStyleBackColor = true;
			this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(67, 115);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(90, 42);
			this.btnClear.TabIndex = 88;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnBackspace
			// 
			this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBackspace.Location = new System.Drawing.Point(19, 115);
			this.btnBackspace.Name = "btnBackspace";
			this.btnBackspace.Size = new System.Drawing.Size(42, 42);
			this.btnBackspace.TabIndex = 87;
			this.btnBackspace.Text = "<-";
			this.btnBackspace.UseVisualStyleBackColor = true;
			this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
			// 
			// btnDiv
			// 
			this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDiv.Location = new System.Drawing.Point(164, 307);
			this.btnDiv.Name = "btnDiv";
			this.btnDiv.Size = new System.Drawing.Size(100, 42);
			this.btnDiv.TabIndex = 86;
			this.btnDiv.Tag = "/";
			this.btnDiv.Text = "Divide";
			this.btnDiv.UseVisualStyleBackColor = true;
			this.btnDiv.Click += new System.EventHandler(this.Operator_Click);
			// 
			// btnMulti
			// 
			this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMulti.Location = new System.Drawing.Point(164, 259);
			this.btnMulti.Name = "btnMulti";
			this.btnMulti.Size = new System.Drawing.Size(100, 42);
			this.btnMulti.TabIndex = 85;
			this.btnMulti.Tag = "*";
			this.btnMulti.Text = "Multiply";
			this.btnMulti.UseVisualStyleBackColor = true;
			this.btnMulti.Click += new System.EventHandler(this.Operator_Click);
			// 
			// btnSubtr
			// 
			this.btnSubtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubtr.Location = new System.Drawing.Point(164, 211);
			this.btnSubtr.Name = "btnSubtr";
			this.btnSubtr.Size = new System.Drawing.Size(100, 42);
			this.btnSubtr.TabIndex = 84;
			this.btnSubtr.Tag = "-";
			this.btnSubtr.Text = "Subtract";
			this.btnSubtr.UseVisualStyleBackColor = true;
			this.btnSubtr.Click += new System.EventHandler(this.Operator_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(163, 164);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(101, 42);
			this.btnAdd.TabIndex = 83;
			this.btnAdd.Tag = "+";
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.Operator_Click);
			// 
			// btn07
			// 
			this.btn07.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn07.Location = new System.Drawing.Point(19, 163);
			this.btn07.Name = "btn07";
			this.btn07.Size = new System.Drawing.Size(42, 42);
			this.btn07.TabIndex = 82;
			this.btn07.Text = "7";
			this.btn07.UseVisualStyleBackColor = true;
			this.btn07.Click += new System.EventHandler(this.NumberClicked);
			// 
			// btn08
			// 
			this.btn08.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn08.Location = new System.Drawing.Point(67, 163);
			this.btn08.Name = "btn08";
			this.btn08.Size = new System.Drawing.Size(42, 42);
			this.btn08.TabIndex = 81;
			this.btn08.Text = "8";
			this.btn08.UseVisualStyleBackColor = true;
			this.btn08.Click += new System.EventHandler(this.NumberClicked);
			// 
			// btn09
			// 
			this.btn09.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn09.Location = new System.Drawing.Point(115, 163);
			this.btn09.Name = "btn09";
			this.btn09.Size = new System.Drawing.Size(42, 42);
			this.btn09.TabIndex = 80;
			this.btn09.Text = "9";
			this.btn09.UseVisualStyleBackColor = true;
			this.btn09.Click += new System.EventHandler(this.NumberClicked);
			// 
			// btn06
			// 
			this.btn06.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn06.Location = new System.Drawing.Point(115, 211);
			this.btn06.Name = "btn06";
			this.btn06.Size = new System.Drawing.Size(42, 42);
			this.btn06.TabIndex = 79;
			this.btn06.Text = "6";
			this.btn06.UseVisualStyleBackColor = true;
			this.btn06.Click += new System.EventHandler(this.NumberClicked);
			// 
			// btn05
			// 
			this.btn05.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn05.Location = new System.Drawing.Point(67, 211);
			this.btn05.Name = "btn05";
			this.btn05.Size = new System.Drawing.Size(42, 42);
			this.btn05.TabIndex = 78;
			this.btn05.Text = "5";
			this.btn05.UseVisualStyleBackColor = true;
			this.btn05.Click += new System.EventHandler(this.NumberClicked);
			// 
			// btn04
			// 
			this.btn04.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn04.Location = new System.Drawing.Point(19, 211);
			this.btn04.Name = "btn04";
			this.btn04.Size = new System.Drawing.Size(42, 42);
			this.btn04.TabIndex = 77;
			this.btn04.Text = "4";
			this.btn04.UseVisualStyleBackColor = true;
			this.btn04.Click += new System.EventHandler(this.NumberClicked);
			// 
			// btnDeci
			// 
			this.btnDeci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeci.Location = new System.Drawing.Point(115, 307);
			this.btnDeci.Name = "btnDeci";
			this.btnDeci.Size = new System.Drawing.Size(42, 42);
			this.btnDeci.TabIndex = 76;
			this.btnDeci.UseVisualStyleBackColor = true;
			this.btnDeci.Click += new System.EventHandler(this.btnDeci_Click);
			// 
			// btn00
			// 
			this.btn00.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn00.Location = new System.Drawing.Point(19, 307);
			this.btn00.Name = "btn00";
			this.btn00.Size = new System.Drawing.Size(90, 42);
			this.btn00.TabIndex = 75;
			this.btn00.Text = "0";
			this.btn00.UseVisualStyleBackColor = true;
			this.btn00.Click += new System.EventHandler(this.NumberClicked);
			// 
			// btn03
			// 
			this.btn03.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn03.Location = new System.Drawing.Point(115, 259);
			this.btn03.Name = "btn03";
			this.btn03.Size = new System.Drawing.Size(42, 42);
			this.btn03.TabIndex = 74;
			this.btn03.Text = "3";
			this.btn03.UseVisualStyleBackColor = true;
			this.btn03.Click += new System.EventHandler(this.NumberClicked);
			// 
			// btn02
			// 
			this.btn02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn02.Location = new System.Drawing.Point(67, 259);
			this.btn02.Name = "btn02";
			this.btn02.Size = new System.Drawing.Size(42, 42);
			this.btn02.TabIndex = 73;
			this.btn02.Text = "2";
			this.btn02.UseVisualStyleBackColor = true;
			this.btn02.Click += new System.EventHandler(this.NumberClicked);
			// 
			// btn01
			// 
			this.btn01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn01.Location = new System.Drawing.Point(19, 259);
			this.btn01.Name = "btn01";
			this.btn01.Size = new System.Drawing.Size(42, 42);
			this.btn01.TabIndex = 72;
			this.btn01.Text = "1";
			this.btn01.UseVisualStyleBackColor = true;
			this.btn01.Click += new System.EventHandler(this.NumberClicked);
			// 
			// inputBox
			// 
			this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputBox.Location = new System.Drawing.Point(67, 46);
			this.inputBox.Name = "inputBox";
			this.inputBox.Size = new System.Drawing.Size(197, 35);
			this.inputBox.TabIndex = 71;
			this.inputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
			// 
			// topBox
			// 
			this.topBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.topBox.Location = new System.Drawing.Point(67, 13);
			this.topBox.Name = "topBox";
			this.topBox.ReadOnly = true;
			this.topBox.Size = new System.Drawing.Size(197, 26);
			this.topBox.TabIndex = 90;
			// 
			// Calculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 499);
			this.Controls.Add(this.btnSum);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnBackspace);
			this.Controls.Add(this.btnDiv);
			this.Controls.Add(this.btnMulti);
			this.Controls.Add(this.btnSubtr);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btn07);
			this.Controls.Add(this.btn08);
			this.Controls.Add(this.btn09);
			this.Controls.Add(this.btn06);
			this.Controls.Add(this.btn05);
			this.Controls.Add(this.btn04);
			this.Controls.Add(this.btnDeci);
			this.Controls.Add(this.btn00);
			this.Controls.Add(this.btn03);
			this.Controls.Add(this.btn02);
			this.Controls.Add(this.btn01);
			this.Controls.Add(this.inputBox);
			this.Controls.Add(this.topBox);
			this.Name = "Calculator";
			this.Text = "Calculator";
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSum;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnBackspace;
		private System.Windows.Forms.Button btnDiv;
		private System.Windows.Forms.Button btnMulti;
		private System.Windows.Forms.Button btnSubtr;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btn07;
		private System.Windows.Forms.Button btn08;
		private System.Windows.Forms.Button btn09;
		private System.Windows.Forms.Button btn06;
		private System.Windows.Forms.Button btn05;
		private System.Windows.Forms.Button btn04;
		private System.Windows.Forms.Button btnDeci;
		private System.Windows.Forms.Button btn00;
		private System.Windows.Forms.Button btn03;
		private System.Windows.Forms.Button btn02;
		private System.Windows.Forms.Button btn01;
		private System.Windows.Forms.TextBox inputBox;
		private System.Windows.Forms.TextBox topBox;
	}
}