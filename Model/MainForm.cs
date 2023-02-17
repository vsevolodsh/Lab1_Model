
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Model
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
        List<string> infixStringList = new List<string>();


        void buttonMasterFClick(object sender, EventArgs e)
		{
			Master newForm = new Master();
			newForm.FormClosing += (sender1, e1) =>
			{
				infixStringList = newForm.stringList;
				textBoxInfix.Text = String.Join("",infixStringList.ToArray());
			};
            newForm.Show();
			
		}
		
		void GroupBox1Enter(object sender, EventArgs e)
		{
			
		}
		
	}
}
