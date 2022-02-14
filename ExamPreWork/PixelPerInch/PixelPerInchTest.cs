using ExamPreWork;
using NUnit.Framework;

namespace PixelPerInch
{
    [TestClass()]
    public class PixelPerInchTest
    {
        [Test]
        public void PixelCalcTest1()
        {
            //arrange
            int width = 10;
            int height = 10;
            int diagnol = 10;

            double PPIExpected = 1.41;
            double diagnolExpected = 14.14;
            double dotPitchExpected = 17.9632;
            
            //act
            PixelCalc.ppi(height, width, diagnol);

            //assert
            Assert.AreEqual(PPIExpected, PixelCalc.ppiAnswer);
            Assert.AreEqual(diagnolExpected, PixelCalc.diagnolPixels);
            Assert.AreEqual(dotPitchExpected, PixelCalc.dotPitch);

        }

        [Test]
        public void PixelCalcTest2()
        {
            //arrange
            int width = 10;
            int height = 10;
            double diagnol = 5.5;

            double PPIExpected = 2.57;
            double diagnolExpected = 14.14;
            double dotPitchExpected = 9.8798;

            //act
            PixelCalc.ppi(height, width, diagnol);

            //assert
            Assert.AreEqual(PPIExpected, PixelCalc.ppiAnswer);
            Assert.AreEqual(diagnolExpected, PixelCalc.diagnolPixels);
            Assert.AreEqual(dotPitchExpected, PixelCalc.dotPitch);
        }

        [Test]
        public void PixelCalcTest3()
        {
            //arrange
            int width = 30;
            int height = 10;
            double diagnol = 5.05;

            double PPIExpected = 6.26;
            double diagnolExpected = 31.62;
            double dotPitchExpected = 4.0566;

            //act
            PixelCalc.ppi(height, width, diagnol);

            //assert
            Assert.AreEqual(PPIExpected, PixelCalc.ppiAnswer);
            Assert.AreEqual(diagnolExpected, PixelCalc.diagnolPixels);
            Assert.AreEqual(dotPitchExpected, PixelCalc.dotPitch);
        }

        [Test]
        public void PixelCalcTest4()
        {
            //arrange
            int width = 60;
            int height = 10;
            double diagnol = 8.035;

            double PPIExpected = 7.57;
            double diagnolExpected = 60.83;
            double dotPitchExpected = 3.3551;

            //act
            PixelCalc.ppi(height, width, diagnol);

            //assert
            Assert.AreEqual(PPIExpected, PixelCalc.ppiAnswer);
            Assert.AreEqual(diagnolExpected, PixelCalc.diagnolPixels);
            Assert.AreEqual(dotPitchExpected, PixelCalc.dotPitch);

        }

        [Test]
        public void PixelCalcTest5()
        {
            //arrange
            int width = 10;
            int height = 60;
            double diagnol = 20.5945;

            double PPIExpected = 2.95;
            double diagnolExpected = 60.83;
            double dotPitchExpected = 8.5994;

            //act
            PixelCalc.ppi(height, width, diagnol);

            //assert
            Assert.AreEqual(PPIExpected, PixelCalc.ppiAnswer);
            Assert.AreEqual(diagnolExpected, PixelCalc.diagnolPixels);
            Assert.AreEqual(dotPitchExpected, PixelCalc.dotPitch);

        }
    }
}