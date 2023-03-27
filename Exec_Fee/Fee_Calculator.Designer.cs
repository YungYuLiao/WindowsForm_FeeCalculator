namespace Exec_Fee
{
	partial class frmFee
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.lblAge = new System.Windows.Forms.Label();
			this.lblGender = new System.Windows.Forms.Label();
			this.lblResult = new System.Windows.Forms.Label();
			this.Calbtn = new System.Windows.Forms.Button();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.rdoMale = new System.Windows.Forms.RadioButton();
			this.rdoFemale = new System.Windows.Forms.RadioButton();
			this.grpMember = new System.Windows.Forms.GroupBox();
			this.grpCalc = new System.Windows.Forms.GroupBox();
			this.grpMember.SuspendLayout();
			this.grpCalc.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblAge
			// 
			this.lblAge.AutoSize = true;
			this.lblAge.Location = new System.Drawing.Point(7, 35);
			this.lblAge.Name = "lblAge";
			this.lblAge.Size = new System.Drawing.Size(34, 16);
			this.lblAge.TabIndex = 0;
			this.lblAge.Text = "年齡:";
			// 
			// lblGender
			// 
			this.lblGender.AutoSize = true;
			this.lblGender.Location = new System.Drawing.Point(154, 35);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(34, 16);
			this.lblGender.TabIndex = 1;
			this.lblGender.Text = "性別:";
			// 
			// lblResult
			// 
			this.lblResult.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblResult.Location = new System.Drawing.Point(11, 27);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(271, 59);
			this.lblResult.TabIndex = 2;
			this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Calbtn
			// 
			this.Calbtn.Location = new System.Drawing.Point(45, 66);
			this.Calbtn.Name = "Calbtn";
			this.Calbtn.Size = new System.Drawing.Size(75, 23);
			this.Calbtn.TabIndex = 4;
			this.Calbtn.Text = "計算";
			this.Calbtn.UseVisualStyleBackColor = true;
			this.Calbtn.Click += new System.EventHandler(this.Calbtn_Click);
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(45, 32);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(100, 23);
			this.txtInput.TabIndex = 5;
			// 
			// rdoMale
			// 
			this.rdoMale.AutoSize = true;
			this.rdoMale.Location = new System.Drawing.Point(198, 33);
			this.rdoMale.Name = "rdoMale";
			this.rdoMale.Size = new System.Drawing.Size(37, 20);
			this.rdoMale.TabIndex = 6;
			this.rdoMale.TabStop = true;
			this.rdoMale.Text = "男";
			this.rdoMale.UseVisualStyleBackColor = true;
			// 
			// rdoFemale
			// 
			this.rdoFemale.AutoSize = true;
			this.rdoFemale.Location = new System.Drawing.Point(245, 33);
			this.rdoFemale.Name = "rdoFemale";
			this.rdoFemale.Size = new System.Drawing.Size(37, 20);
			this.rdoFemale.TabIndex = 7;
			this.rdoFemale.TabStop = true;
			this.rdoFemale.Text = "女";
			this.rdoFemale.UseVisualStyleBackColor = true;
			// 
			// grpMember
			// 
			this.grpMember.Controls.Add(this.lblAge);
			this.grpMember.Controls.Add(this.txtInput);
			this.grpMember.Controls.Add(this.rdoFemale);
			this.grpMember.Controls.Add(this.lblGender);
			this.grpMember.Controls.Add(this.rdoMale);
			this.grpMember.Controls.Add(this.Calbtn);
			this.grpMember.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.grpMember.Location = new System.Drawing.Point(12, 12);
			this.grpMember.Name = "grpMember";
			this.grpMember.Size = new System.Drawing.Size(301, 100);
			this.grpMember.TabIndex = 8;
			this.grpMember.TabStop = false;
			this.grpMember.Text = "客戶資訊";
			// 
			// grpCalc
			// 
			this.grpCalc.Controls.Add(this.lblResult);
			this.grpCalc.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.grpCalc.Location = new System.Drawing.Point(12, 118);
			this.grpCalc.Name = "grpCalc";
			this.grpCalc.Size = new System.Drawing.Size(298, 100);
			this.grpCalc.TabIndex = 9;
			this.grpCalc.TabStop = false;
			this.grpCalc.Text = "計算結果";
			// 
			// frmFee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(326, 237);
			this.Controls.Add(this.grpCalc);
			this.Controls.Add(this.grpMember);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmFee";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "車資計算機";
			this.grpMember.ResumeLayout(false);
			this.grpMember.PerformLayout();
			this.grpCalc.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblAge;
		private System.Windows.Forms.Label lblGender;
		private System.Windows.Forms.Button Calbtn;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.RadioButton rdoMale;
		private System.Windows.Forms.RadioButton rdoFemale;
		private System.Windows.Forms.GroupBox grpMember;
		private System.Windows.Forms.GroupBox grpCalc;
		private System.Windows.Forms.Label lblResult;
	}
}

