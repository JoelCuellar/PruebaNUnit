using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Pruebas;
using PruebaCalculadora;
using NUnit.Framework.Legacy;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            string result = Pruebas.Program.Prueba();
            ClassicAssert.AreEqual("PRUEBA", result);
        }

    }
    [TestFixture]
    public class CalculadoraTests
    {
        private Calculadora calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculadora();
        }

        [Test]
        public void Sumar_2Mas3_Retorna5()
        {
            int resultado = calc.Sumar(2, 3);
            ClassicAssert.AreEqual(5, resultado);
        }

        [TestCase(1, 2, 3)]
        [TestCase(10, 5, 15)]
        [TestCase(-1, -1, -2)]
        public void Sumar_Casos_RetornaEsperado(int a, int b, int esperado)
        {
            ClassicAssert.AreEqual(esperado, calc.Sumar(a, b));
        }

        [Test]
        public void DividirPorCero_LanzaExcepcion()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Dividir(10, 0));
        }
    }

    [TestFixture]
    public class ServicioDatosTests
    {
        [Test]
        public async Task ObtenerDatosAsync_RetornaResultado()
        {
            var servicio = new ServicioDatos();
            var resultado = await servicio.ObtenerDatosAsync();
            ClassicAssert.IsNull(resultado);
        }
    }

    [TestFixture]
    public class CasoMultiplicacion
    {
        private static object[] CasosDeMultiplicacion =
        {
            new object[] { 2, 3, 6 },
            new object[] { 5, 5, 25 },
            new object[] { -2, -3, 6 }
        };

        [Test, TestCaseSource(nameof(CasosDeMultiplicacion))]
        public void Multiplicar_DatosValidos_ResultadoEsperado(int a, int b, int resultadoEsperado)
        {
            int resultado = a * b;
            ClassicAssert.AreEqual(resultadoEsperado, resultado);
        }
    }

    [TestFixture]
    public class Lista
    {
        [Test]
        public void ListaContieneElementos()
        {
            var lista = new[] { "a", "b", "c" };
            ClassicAssert.Contains("b", lista);
        }
    }
}
