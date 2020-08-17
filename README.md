# TESTESUNITARIOS C# 

### testes unitarios com Nunit(nome da aplicação = testeunitario)
### nome da classe = raiz

# 1 - Criar a solução 
## dotnet new sln -n testeunitario

# 2 - Criar biblioteca de classes
## dotnet new classlib -n raiz

# 3 - Criar a classe a ser testada

<!-- using System;

namespace Raiz
{
    public class RaizQuadrada
    {
        public int calcularaizquadrada(int numero1) => Math.Sqrt(numero1);

    }
} -->

# 4 - Adicionar a aplicação criada dentro da Biblioteca
## dotnet sln testeunitario.sln add raiz/raiz.csproj

# 5-Criando o projeto teste 
## dotnet new nunit -n raiz.tests

# 6-Adicionar o projeto na solução 
## dotnet sln testeunitario.sln add raiz.tests/raiz.tests.proj

# 7 - Adicionar o projeto na referencia da Biblioteca
## raiz.tests/raiz.tests.csproj reference raiz/raiz.csproj

# Para testar a solução para
# dotnet test (nome do arquivo.tests)

<!-- Unitest1

using NUnit.Framework;
using raiz;

namespace raiz.tests

{
    [TestFixture]
    public class CalculaRaiz

    {
        [Test]
        public void Test1 () 
        {
            RaizQuadrada r = new RaizQuadrada ();
            var result = r.CalcRaiz (16);
            Assert.That (4, Is.EqualTo (result));
        }

    }

} -->