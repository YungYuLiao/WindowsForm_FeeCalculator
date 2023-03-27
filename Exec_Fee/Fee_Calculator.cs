using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec_Fee
{
	public partial class frmFee : Form
	{
		public frmFee()
		{
			InitializeComponent();
		}

		private void Calbtn_Click(object sender, EventArgs e)
		{
			//輸入年齡
			int age;
			try
			{
				age = GetAge();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//取得性別
			bool gender;
			try
			{
				 gender = Gender;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//計算車資及獲得原因
			string result = Calc(age, gender);
			//呈現結果
			lblResult.Text = result;
		}

		private string Calc(int age, bool gender)
		{
			int fee;
			string msg = string.Empty;

			//設定年齡上下限
			const int child = 3;
			const int oldMan = 70;
			const int oldWoman = 60;

			//設定車資
			const int childFee = 0;
			const int oldManFee = 2;
			const int oldWomanFee = 3;
			const int standardFee = 15;

			if (age <= child )
			{
				 fee = childFee;
				 msg = $"未滿{child}歲";
			}
			else if (age >= oldMan && gender == true)
			{
				fee = oldManFee;
				msg = $"超過{oldMan}歲男性";
			}
			else if (age >= oldWoman && gender == false)
			{
				fee = oldWomanFee;
				msg = $"超過{oldWoman}歲女性";
			}
			else { fee = standardFee; msg = "年齡不符優惠標準"; }
			return $"車資: {fee} \r\n原因: {msg}";
		}

		private bool Gender
		{
			get 
			{ if (rdoMale.Checked) return true;
			  if (rdoFemale.Checked) return false;
			  throw new Exception("請選擇性別!");
			}
			
        }
		private int GetAge()
		{
			string input = txtInput.Text;

			//判斷是否輸入數字
			bool isInt = int.TryParse(input, out int age);
			if (isInt == false)
			{
				throw new Exception("請輸入數值");
			}
			if (age<0)
			{
				throw new Exception("年齡不可小於0");
			}
			return age; 
		}

	}
}
