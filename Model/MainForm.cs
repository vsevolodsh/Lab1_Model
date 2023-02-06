/*
 * Created by SharpDevelop.
 * User: zh-en
 * Date: 04.02.2023
 * Time: 12:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Model
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
	
		
		void buttonMasterFClick(object sender, EventArgs e)
		{
			Master newForm = new Master();
			newForm.Show();
			
		}
		
		void GroupBox1Enter(object sender, EventArgs e)
		{
			
		}
		
	}
}
