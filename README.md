# testesunitarios
### testes unitarios com Nunit(nome da aplicação = testeunitario)
### nome da classe = raiz

# 1 - Criar a solução 
## dotnet new sln -n testeunitario

# 2 - Criar biblioteca de classes
## dotnet new classlib -n raiz

# 3 - Criar a classe a ser testada
# 4 - Adicionar a aplicação criada dentro da Biblioteca

## dotnet sln testeunitario.sln add raiz/raiz.csproj
# 5-Criando o projeto teste 

## dotnet new nunit -n raiz.tests

# 6-Adicionar o projeto na solução 
## dotnet sln testeunitario.sln add raiz.tests/raiz.tests.proj

# 7 - Adicionar o projeto na referencia da Biblioteca
## raiz.tests/raiz.tests.csproj reference raiz/raiz.csproj