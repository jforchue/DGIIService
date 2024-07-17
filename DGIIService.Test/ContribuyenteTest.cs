using DGIIService.Application;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DGIIService.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DGIIService.Test
{
    [TestClass()]
    public class ContribuyenteTest
    {
        ContribuyenteRepository contribuyenteRepository = new ContribuyenteRepository();

        [TestMethod()]
        public void VerificarFormatosRNC()
        {
            var list = contribuyenteRepository.Get();
            Regex regex = new Regex("^(?:\\d{3}-\\d{7}-\\d{1}|\\d{11})$");
            Assert.IsFalse(list.Any(x => !regex.IsMatch(x.RncCedula)));
        }

        [TestMethod()]
        public void VerificarFormatosNCF()
        {
            bool formatoIncorrecto = true;
            var list = contribuyenteRepository.Get();
            Regex regex = new Regex("^[ABEGCDHF][0-9]{10}$");

            foreach (var i in list)
            {
                var list2 = contribuyenteRepository.GetContribuyenteNCFList(i.Id);
                formatoIncorrecto = list2.Any(x => !regex.IsMatch(x.NCF));

                if (formatoIncorrecto)
                    break;
            }


            Assert.IsFalse(formatoIncorrecto);
        }

        [TestMethod()]
        public void GetNCFList()
        {
            var list = contribuyenteRepository.GetContribuyenteNCFList(10);
            Assert.IsTrue(list.Count > 0);
        }
    }
}