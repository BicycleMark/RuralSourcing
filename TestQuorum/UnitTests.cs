using NUnit.Framework;
using Quorum;

namespace TestQuorum
{   [TestFixture]
    public class TestSolution1
    {
        Solution1 solver;
        [SetUp]
        public void Setup()
        {
            solver = new Solution1();
        }
        //[TestCase("1 minute(s) ago")]
        [Test]
        public void Test()
        {

            Assert.AreEqual(-1,solver.Solution());
        }
    }

    /// <summary>
    /// Tests Solution 2 From Quorum Software
    /// </summary>
    public class TestSolution2
    {
        //[TestCase("1 minute(s) ago")]
        Solution2 solver ;
        [SetUp]
        public void Setup()
        {
            solver = new Solution2();
        }
        //[TestCase("1 minute(s) ago")]
        [Test]
        public void Test()
        {
            Assert.AreEqual(-1, solver.Solution());
        }
    }

    /// <summary>
    /// Tests Solution 3 From Quorum Software
    /// </summary>
    public class TestSolution3
    {
        Solution3 solver; 
        [SetUp]
        public void Setup()
        {
           solver = new Solution3();
        }
        //[TestCase("1 minute(s) ago")]
        [Test]
        public void Test()
        {
            Assert.AreEqual(-1, solver.Solution());
        }
    }
}