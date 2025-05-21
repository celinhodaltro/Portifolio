# Portfólio Pessoal - Blazor + MudBlazor

Este repositório contém meu portfólio pessoal desenvolvido com **Blazor** e **MudBlazor**, utilizando o **.NET 9**. O objetivo é apresentar meus projetos, habilidades e experiências de forma interativa e moderna.

## 🚀 Tecnologias Utilizadas

- [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor): Framework para desenvolvimento de aplicações web interativas com C#.
- [MudBlazor](https://mudblazor.com/): Biblioteca de componentes baseada no Material Design para Blazor.
- [.NET 9](https://dotnet.microsoft.com/download/dotnet/9.0): Plataforma de desenvolvimento da Microsoft.
- [CI/CD com GitHub Actions](https://docs.github.com/actions): Automatização de build e deploy contínuos.

## 🛠️ Configuração e Execução

1. **Pré-requisitos**:
   - [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
     
2. **Clonar o repositório**:
   ```bash
   git clone https://github.com/celinhodaltro/Portifolio.git
   cd Portifolio
   ```

3. **Restaurar dependências e executar**:
   ```bash
   dotnet restore
   dotnet run --project Sources/Application/Application.Main
   ```

4. **Acessar a aplicação**:
   - Abra seu navegador e acesse `https://localhost:5001` ou o endereço indicado no console.

## 📁 Estrutura do Projeto

O projeto está organizado nas seguintes pastas principais:

- **Sources/Application**: Contém a aplicação Blazor principal
  - **Application.Main**: Projeto principal com componentes, páginas e lógica da UI
- **Sources/Core**: Contém as entidades e lógica de negócio
  - **Core.Entities**: Definições das entidades principais do sistema

## 🤝 Contribuição

Contribuições são bem-vindas! Se você deseja contribuir com este projeto:

1. Faça um fork do repositório
2. Crie uma branch para sua feature (`git checkout -b feature/nova-feature`)
3. Commit suas mudanças (`git commit -m 'Adiciona nova feature'`)
4. Push para a branch (`git push origin feature/nova-feature`)
5. Abra um Pull Request

## 📝 Licença

Este projeto está sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.
