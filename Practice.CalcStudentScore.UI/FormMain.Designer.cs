namespace Practice.CalcStudentScore.UI
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tbResult =  new TextBox( ) ;
			tbHss =  new TextBox( ) ;
			label5 =  new Label( ) ;
			tbSci =  new TextBox( ) ;
			label4 =  new Label( ) ;
			tbEng =  new TextBox( ) ;
			label3 =  new Label( ) ;
			tbMath =  new TextBox( ) ;
			label2 =  new Label( ) ;
			tbName =  new TextBox( ) ;
			label1 =  new Label( ) ;
			btnCheck =  new Button( ) ;
			SuspendLayout( );
			// 
			// tbResult
			// 
			tbResult.Location =  new Point( 41, 211 ) ;
			tbResult.Multiline =  true ;
			tbResult.Name =  "tbResult" ;
			tbResult.ReadOnly =  true ;
			tbResult.Size =  new Size( 321, 273 ) ;
			tbResult.TabIndex =  23 ;
			// 
			// tbHss
			// 
			tbHss.Location =  new Point( 262, 117 ) ;
			tbHss.Name =  "tbHss" ;
			tbHss.Size =  new Size( 100, 23 ) ;
			tbHss.TabIndex =  5 ;
			// 
			// label5
			// 
			label5.AutoSize =  true ;
			label5.Location =  new Point( 214, 120 ) ;
			label5.Name =  "label5" ;
			label5.Size =  new Size( 41, 15 ) ;
			label5.TabIndex =  21 ;
			label5.Text =  "Social" ;
			// 
			// tbSci
			// 
			tbSci.Location =  new Point( 89, 112 ) ;
			tbSci.Name =  "tbSci" ;
			tbSci.Size =  new Size( 100, 23 ) ;
			tbSci.TabIndex =  4 ;
			// 
			// label4
			// 
			label4.AutoSize =  true ;
			label4.Location =  new Point( 41, 115 ) ;
			label4.Name =  "label4" ;
			label4.Size =  new Size( 50, 15 ) ;
			label4.TabIndex =  19 ;
			label4.Text =  "Science" ;
			// 
			// tbEng
			// 
			tbEng.Location =  new Point( 262, 75 ) ;
			tbEng.Name =  "tbEng" ;
			tbEng.Size =  new Size( 100, 23 ) ;
			tbEng.TabIndex =  3 ;
			// 
			// label3
			// 
			label3.AutoSize =  true ;
			label3.Location =  new Point( 214, 78 ) ;
			label3.Name =  "label3" ;
			label3.Size =  new Size( 29, 15 ) ;
			label3.TabIndex =  17 ;
			label3.Text =  "Eng" ;
			// 
			// tbMath
			// 
			tbMath.Location =  new Point( 89, 75 ) ;
			tbMath.Name =  "tbMath" ;
			tbMath.Size =  new Size( 100, 23 ) ;
			tbMath.TabIndex =  1 ;
			// 
			// label2
			// 
			label2.AutoSize =  true ;
			label2.Location =  new Point( 41, 78 ) ;
			label2.Name =  "label2" ;
			label2.Size =  new Size( 37, 15 ) ;
			label2.TabIndex =  15 ;
			label2.Text =  "Math" ;
			// 
			// tbName
			// 
			tbName.Location =  new Point( 89, 29 ) ;
			tbName.Name =  "tbName" ;
			tbName.Size =  new Size( 100, 23 ) ;
			tbName.TabIndex =  0 ;
			// 
			// label1
			// 
			label1.AutoSize =  true ;
			label1.Location =  new Point( 41, 32 ) ;
			label1.Name =  "label1" ;
			label1.Size =  new Size( 42, 15 ) ;
			label1.TabIndex =  9 ;
			label1.Text =  "Name" ;
			// 
			// btnCheck
			// 
			btnCheck.Location =  new Point( 41, 166 ) ;
			btnCheck.Name =  "btnCheck" ;
			btnCheck.Size =  new Size( 75, 23 ) ;
			btnCheck.TabIndex =  6 ;
			btnCheck.Text =  "Check!" ;
			btnCheck.UseVisualStyleBackColor =  true ;
			btnCheck.Click +=  btnCheck_Click ;
			// 
			// FormMain
			// 
			AutoScaleDimensions =  new SizeF( 7F, 15F ) ;
			AutoScaleMode =  AutoScaleMode.Font ;
			ClientSize =  new Size( 436, 532 ) ;
			Controls.Add( tbResult );
			Controls.Add( tbHss );
			Controls.Add( label5 );
			Controls.Add( tbSci );
			Controls.Add( label4 );
			Controls.Add( tbEng );
			Controls.Add( label3 );
			Controls.Add( tbMath );
			Controls.Add( label2 );
			Controls.Add( tbName );
			Controls.Add( label1 );
			Controls.Add( btnCheck );
			Name =  "FormMain" ;
			Text =  "CalcScore" ;
			Load +=  Form1_Load ;
			ResumeLayout( false );
			PerformLayout( );
		}

		#endregion

		private TextBox tbResult;
		private TextBox tbHss;
		private Label label5;
		private TextBox tbSci;
		private Label label4;
		private TextBox tbEng;
		private Label label3;
		private TextBox tbMath;
		private Label label2;
		private TextBox tbName;
		private Label label1;
		private Button btnCheck;
	}
}