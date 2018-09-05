using System;
using NUnit.Framework;
using LapTrinhHam;
using HuongThaoCore;

namespace NUnitDemo
{
    [TestFixture]
    public class DemoTest
    {
        [Test]
        public void TestCase1()
        {
            int a = HuongThaoCore.HTCommon.TinhTongChuSo(134);
            Assert.AreEqual(8, a);
        }
        [Test]
        public void TestCase2()
        {
            int a = HuongThaoCore.HTCommon.TinhTongChuSo(40001);
            Assert.AreEqual(5, a);
        }
        [Test]
        public void TestCase3()
        {
            double a = HuongThaoCore.HTCommon.LyThua(2, 4);
            Assert.AreEqual(16, a);
        }
        [Test]
        public void TestCase4()
        {
            double a = HuongThaoCore.HTCommon.LyThua(3, 2);
            Assert.AreEqual(9, a);
        }
        [Test]
        public void TestCase5()
        {
            DateTime date = new DateTime(1990, 2, 2);
            double a = HuongThaoCore.HTCommon.TinhTuoi(date);
            Assert.AreEqual(28, a);
        }
    }
}
