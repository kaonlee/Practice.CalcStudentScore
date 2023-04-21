using Practice.CalcStudentScore;

namespace Prctice.CalcStudent.Test
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test1()
		{
			var testStudent = new Student( "test", 90, 95, 33, 100 );
			double expect = (double)( 90 + 95 + 33 + 100 ) / 4;
			Assert.AreEqual( expect, testStudent.AverageScore );
		}

		[Test]
		public void Test2()
		{
			var testStudent = new Student( "test", "90", "95", "33", "100" );
			double expect = (double)( 90 + 95 + 33 + 100 ) / 4;
			Assert.AreEqual( expect, testStudent.AverageScore );

		}

		[Test]
		public void Test3()
		{
			var testStudent = new Student( "test", "90", "95", "33", "沒有考試" );
			Assert.AreEqual( -1, testStudent.Social.Score );
		}
	}
}