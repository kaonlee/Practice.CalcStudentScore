using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice.CalcStudentScore.UI
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent( );
		}

		private void Form1_Load( object sender, EventArgs e )
		{

		}

		private void btnCheck_Click( object sender, EventArgs e )
		{
			string name = tbName.Text;
			string math = tbMath.Text;
			string eng = tbEng.Text;
			string sci = tbSci.Text;
			string hss = tbHss.Text;

			var student = new Student( name, math, eng, sci, hss );

			tbResult.Text = student.PrintStudentScore( );
		}
	}
}
