/*
 * Created by SharpDevelop.
 * User: zh-en
 * Date: 04.02.2023
 * Time: 12:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Model
{
	/// <summary>
	/// Description of Master.
	/// </summary>
	public partial class Master : Form
	{
		public Master()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void buttonCloseClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
