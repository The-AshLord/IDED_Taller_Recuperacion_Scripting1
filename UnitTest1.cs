using NUnit.Framework;
using System.Collections.Generic;
using static TallerRecuperacion1.TestMethod;

namespace TallerRecuperacion1
{
    public class Tests
    {
        //Valores de prueba:
        private readonly int[] testArr1 = { -5, 4, 10, 9, 7, 1, -30 };
        private readonly int testSize1 = 3;
        private readonly int testSum1 = 23;

        private readonly int[] testArr2 = { 2, -6, 9, 7, -15 };
        private readonly int testSize2 = 2;
        private readonly int testSum2 = 7;

        private readonly int[] testSortedArr = { -1, 0, 3, 4, 7, 10, 15, 20};
        private readonly int testSortedSize = 3;
        private readonly int testSortedSum = 82;

        //Pruebas unitarias para cada "combo" de valores

        [Test]
        public void Test1SumOfSubArrs()
        {
           
            Assert.AreEqual(testSum1,SumOfSubArrs(testArr1, testSize1));
          
        }
        [Test]
        public void Test2SumOfSubArrs()
        {

            Assert.AreEqual(testSum2, SumOfSubArrs(testArr2, testSize2));

        }
        [Test]
        public void TestSortedSumOfSubArrs()
        {

            Assert.AreEqual(testSortedSum,SumOfSubArrs(testSortedArr, testSortedSize));

        }
    }
}