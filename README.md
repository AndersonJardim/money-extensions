## Extension to convert decimal to integer

adicionado git ignore
touch README.md

mkdir MoneyExtension
cd MoneyExtension

dotnet new classlib -o MoneyExtension -f net7.0
dotnet new mstest -o MoneyExtension.Tests -f net7.0

cd..
dotnet new sln
dotnet sln add .\MoneyExtension\MoneyExtension.csproj
dotnet sln add .\MoneyExtension.Tests\MoneyExtension.Tests.csproj

cd .\MoneyExtension.Tests
dotnet add reference ..\MoneyExtension\MoneyExtension.csproj

dotnet restore
dotnet build
dotnet test
dotnet run