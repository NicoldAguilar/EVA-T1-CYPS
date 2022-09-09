using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalidadT1;

namespace T1Test
{
    public class RomanGeneratorTest
    {
        //Prueba 1: 0->Error
        [Test]
        public void RegresaRomano()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(0);
            Assert.AreEqual("Error", ob);
        }

        //Prueba 2: 15 -> XV
        [Test]
        public void RegresaRomano2()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(15);
            Assert.AreEqual("XV", ob);
        }

        //Prueba 3: 205 -> CCV
        [Test]
        public void RegresaRomano3()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(205);
            Assert.AreEqual("CCV", ob);
        }

        //Prueba 4: 512 -> DXII
        [Test]
        public void RegresaRomano4()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(512);
            Assert.AreEqual("DXII", ob);
        }

        //Prueba 5: 723 -> DCCXXIII
        [Test]
        public void RegresaRomano5()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(723);
            Assert.AreEqual("DCCXXIII", ob);
        }

        //Prueba 6: 52 -> LII
        [Test]
        public void RegresaRomano6()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(52);
            Assert.AreEqual("LII", ob);
        }

        //Prueba 7: 870 -> DCCCLXX
        [Test]
        public void RegresaRomano7()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(7);
            Assert.AreEqual("VII", ob);
        }

        //Prueba 8: 7 -> VIII
        [Test]
        public void RegresaRomano8()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(7);
            Assert.AreEqual("VII", ob);
        }

        //Prueba 9: 15 -> DCLVII
        [Test]
        public void RegresaRomano9()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(656);
            Assert.AreEqual("DCLVI", ob);
        }

        //Prueba 10: 63 -> LCIII
        [Test]
        public void RegresaRomano10()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(63);
            Assert.AreEqual("LXIII", ob);
        }

        //Prueba 11: 89 -> LCCCIX
        [Test]
        public void RegresaRomano11()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(89);
            Assert.AreEqual("LXXXIX", ob);
        }

        //Prueba 12: 15 -> XV
        [Test]
        public void RegresaRomano12()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(173);
            Assert.AreEqual("CLXXIII", ob);
        }

        //Prueba 13: 75 -> LCCV
        [Test]
        public void RegresaRomano13()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(75);
            Assert.AreEqual("LXXV", ob);
        }

        //Prueba 14: 550 -> XV
        [Test]
        public void RegresaRomano14()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(550);
            Assert.AreEqual("DL", ob);
        }

        //Prueba 15: 736 -> DCCXXXVI
        [Test]
        public void RegresaRomano15()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(736);
            Assert.AreEqual("DCCXXXVI", ob);
        }

        //Prueba 16: 203 -> CCIII
        [Test]
        public void RegresaRomano16()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(203);
            Assert.AreEqual("CCIII", ob);
        }

        //Prueba 17: 28 -> XXVIII
        [Test]
        public void RegresaRomano17()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(28);
            Assert.AreEqual("XXVIII", ob);
        }

        //Prueba 18: 83 -> LXXXIII 
        [Test]
        public void RegresaRomano18()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(83);
            Assert.AreEqual("LXXXIII", ob);
        }

        //Prueba 19: 44 -> XLIV
        [Test]
        public void RegresaRomano19()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(44);
            Assert.AreEqual("XLIV", ob);
        }

        //Prueba 20: 56 -> LVI
        [Test]
        public void RegresaRomano20()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(56);
            Assert.AreEqual("LVI", ob);
        }

        //Prueba 21: 501 -> DI
        [Test]
        public void RegresaRomano21()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(501);
            Assert.AreEqual("DI", ob);
        }

        //Prueba 22: 1001 -> DDI
        [Test]
        public void RegresaRomano22()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(1001);
            Assert.AreEqual("Error", ob);
        }

        //Prueba 23: 39 -> XXXIX
        [Test]
        public void RegresaRomano23()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(39);
            Assert.AreEqual("XXXIX", ob);
        }

        //Prueba 24: 115 -> CXV
        [Test]
        public void RegresaRomano24()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(115);
            Assert.AreEqual("CXV", ob);
        }

        //Prueba 25: 18 -> XVIII
        [Test]
        public void RegresaRomano25()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(18);
            Assert.AreEqual("XVIII", ob);
        }

        //TESTER
        [Test]
        public void RegresaRomano26()
        {
            var romano = new RomanoGenerator();
            var ob = romano.GetRomano(923);
            Assert.AreEqual("CMXXIII", ob);
        }
    }
}
