# Desafio Back-end Meta

## 💻 Projeto
Desafio de back-end proposto pela Meta, que consiste em criar uma web api em C# para cadastrar, alterar, remover e consultar contatos.

---

## 🚀 Tecnologias

- [C#]
- [.NET Core 3.1]
- [EntityFramework Core 3.1][EntityFramework]
- [AutoMapper]
- [SQL Server]


---
## ℹ Como usar
Para clonar e usar o projeto, você precisará ter na sua máquina o [Git], [.NET Core 3.1] e o [Sql Server] instalados.

Após isso, será necessário rodar as migrations
```bash
  # Clone esse repositório
  $ git clone https://github.com/ptkribeiro/Meta.Backend.git

  # Navegue até o repositório
  cd Meta.Backend/Meta.Backend

  # Restore
  dotnet restore
  
  # Rode as migrations
  dotnet ef database update

  # Inicie o servidor
  dotnet run

```

O servidor será iniciado no endereço http://localhost:5000 e https://localhost:5001

[C#]: https://docs.microsoft.com/pt-br/dotnet/csharp/
[.NET Core 3.1]: https://dotnet.microsoft.com/download/dotnet/3.1
[EntityFramework]: https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/5.0.3
[AutoMapper]: https://www.nuget.org/packages/AutoMapper.Extensions.Microsoft.DependencyInjection/
[SQL Server]: https://www.microsoft.com/pt-br/sql-server/sql-server-downloads?SilentAuth=1&wa=wsignin1.0
[Git]: https://git-scm.com/