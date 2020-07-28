using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Hoplon.Collections;

namespace Hoplon.CollectionsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void deveRetornarListaComTodosItensDaChave()
        {
            NewCollection collection = new NewCollection();
            collection.Add("ano", "1979");
            collection.Add("ano", "1994");
            collection.Add("ano", "2007");
            IList<string> retorno = new List<string>();
            retorno = collection.Get("ano", 0, 4);

            IList<string> result = new List<string>();
            result.Add("1979");
            result.Add("1994");
            result.Add("2007");

            Assert.AreEqual(result.ToString(), retorno.ToString());
        }

        [TestMethod]
        public void deveRetornarListaDoPrimeiroAoPenultimo()
        {
            NewCollection collection = new NewCollection();
            collection.Add("ano", "1979");
            collection.Add("ano", "1994");
            collection.Add("ano", "2007");
            IList<string> retorno = new List<string>();
            retorno = collection.Get("ano", -1, -2);

            IList<string> result = new List<string>();
            result.Add("1979");
            result.Add("1994");

            Assert.AreEqual(result.ToString(), retorno.ToString());
        }

        [TestMethod]
        public void deveRemoverChavePassada()
        {
            NewCollection collection = new NewCollection();
            collection.Add("ano", "1979");
            collection.Add("mes", "Agosto");
            collection.Add("dia", "02");
            collection.Remove("ano");
            IList<string> retorno = new List<string>();
            retorno = collection.Get("ano", 0, 2);

            IList<string> result = new List<string>();

            Assert.AreEqual(result.ToString(), retorno.ToString());
        }

        [TestMethod]
        public void deveRetornarIndiceCorreto()
        {
            NewCollection collection = new NewCollection();
            collection.Add("ano", "1979");
            collection.Add("mes", "Agosto");
            collection.Add("ano", "2007");
            collection.Add("mes", "Fevereiro");
            collection.Add("ano", "1994");
            collection.Add("mes", "Março");
            collection.Add("ano", "2004");
            collection.Add("ano", "1978");
            long retorno = collection.IndexOf("ano", "2007");

            Assert.AreEqual(4, retorno);
        }

        [TestMethod]
        public void deveRetornarMenosUmParaValorInexistente()
        {
            NewCollection collection = new NewCollection();
            collection.Add("ano", "1979");
            collection.Add("mes", "Agosto");
            collection.Add("mes", "Fevereiro");
            long retorno = collection.IndexOf("ano", "2017");

            Assert.AreEqual(-1, retorno);
        }

        [TestMethod]
        public void deveRetornarMenosUmParaChaveInexistente()
        {
            NewCollection collection = new NewCollection();
            collection.Add("ano", "1979");
            collection.Add("mes", "Agosto");
            collection.Add("mes", "Fevereiro");
            long retorno = collection.IndexOf("dia", "02");

            Assert.AreEqual(-1, retorno);
        }
    }
}
