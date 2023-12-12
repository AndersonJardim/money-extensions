## Extension to convert decimal to integer

```bash
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
```

## Comandos git que usei

```bash
dotnet new gitignore
git init

git branch main
git switch main

git add --all
git commit -m "Finalizado a primeira versão"
git remote add origin https://github.com/AndersonJardim/money-extensions.git
git push -u origin main
```