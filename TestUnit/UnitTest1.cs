using NUnit.Framework;
using System.Runtime.Serialization;

namespace TestUnit
{
    public class Tests
    {
            int a, b, soma, resultado;
        [SetUp]
        public void Setup()
        {

            a = 5;
            b = 6;
            soma = a * b;
            resultado = 30;
            Assert.That(soma, Is.EqualTo(resultado));

            Console.WriteLine("O valor correto é " + soma);
        }

        [Test]
        public void Test1()
        {
            a = 15;
            b = 15;
            soma = a + b;
            resultado = 30;
            Assert.That(soma, Is.EqualTo(resultado));

            Console.WriteLine("O valor correto é " + soma);
        }

        [TearDown]
        public void TearDown()
        {
            if (soma != resultado)
            {
                Console.WriteLine("O valor da soma  deve ser = " + soma);
                Console.WriteLine("O valor digitado foi = " + resultado); Assert.Fail();
            }
            else
            {
                Console.WriteLine("Valor correto");
            }
        }
    }
}