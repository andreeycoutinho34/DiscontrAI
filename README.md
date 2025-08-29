# DescontrAI

## Proposta do Projeto

**DescontrAI** é uma plataforma web criada para facilitar a contratação de DJs, cantores, músicos, bandas e outros profissionais do entretenimento para eventos. O objetivo do site é conectar organizadores de festas, casamentos, aniversários, eventos corporativos e sociais com artistas qualificados, tornando o processo de busca, comparação e contratação mais simples, rápido e transparente.

## Funcionalidades

- **Busca e filtro de profissionais:** Encontre DJs, cantores e artistas por estilo musical, localização, faixa de preço, avaliações, datas disponíveis e muito mais.
- **Perfil detalhado dos artistas:** Cada profissional possui uma página com informações completas, fotos, vídeos, portfólio e avaliações de clientes anteriores.
- **Sistema de contato e orçamento:** Solicite orçamento diretamente pelo site e converse com o artista antes de fechar a contratação.
- **Avaliações e recomendações:** Veja opiniões reais de outros contratantes e escolha com maior segurança.
- **Cadastro de artistas e organizadores:** Artistas podem criar e atualizar seus perfis; organizadores podem cadastrar pedidos e salvar favoritos.

## Estrutura do Projeto

```
Desktop/WebApplication1/WebApplication1/
├── Controllers/        # Lógica das rotas e das ações do backend
├── Models/             # Modelos de dados: Artista, Evento, Contratação, Avaliação, etc.
├── Views/              # (Opcional) Razor Views para páginas dinâmicas
├── wwwroot/            # Front-end estático: HTML, CSS, JS
├── Program.cs          # Inicialização da aplicação ASP.NET Core
├── appsettings.json    # Configurações do projeto
```

## Divisão das Tarefas

| Nome         | Parte Responsável                                              |
|--------------|---------------------------------------------------------------|
| **Andreey**  | Backend ASP.NET Core (Controllers, Models, integração com banco de dados, APIs) |
| **Adalberto**| Frontend: HTML, CSS, JavaScript (Layout, interatividade, responsividade) |
| **Emanuel**  | Scrum Master: organização do projeto, acompanhamento das tarefas, reuniões e documentação |

## Tecnologias Utilizadas

- **Backend:** ASP.NET Core MVC (.NET 8)
- **Frontend:** HTML, CSS, JavaScript puro (com possibilidade de integração por Razor Views e APIs)
- **Banco de Dados:** (Sugestão) SQL Server, SQLite ou outro compatível com .NET
- **Layout:** Bootstrap

## Como Executar Localmente

1. **Pré-requisitos**
    - [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
    - Editor de código (Visual Studio, VS Code, Rider, etc.)

2. **Clonar o repositório**
    ```sh
    git clone https://github.com/andreeycoutinho34/DiscontrAI.git
    cd Desktop/WebApplication1/WebApplication1
    ```

3. **Iniciar a aplicação**
    ```sh
    dotnet run
    ```
    Acesse `http://localhost:5000` no navegador.

4. **Como usar o Front-end**
    - Coloque seus arquivos `index.html`, `style.css`, `script.js` na pasta `wwwroot/`.
    - Eles serão servidos como arquivos estáticos.  
    - Para integração dinâmica, utilize Razor Views ou APIs do backend.

## Como hospedar gratuitamente no GitHub

Se seu site for apenas arquivos estáticos (HTML, CSS, JS), você pode hospedar usando o **GitHub Pages**:
1. Crie um repositório público no GitHub.
2. Coloque seus arquivos estáticos na raiz ou na pasta `/docs`.
3. Nas configurações do repositório, ative o GitHub Pages apontando para a branch e pasta desejada.
4. O site ficará acessível por um link do tipo: `https://seuusuario.github.io/seurepositorio/`

> **Atenção:** Projetos com backend (ASP.NET Core) não podem ser hospedados diretamente no GitHub Pages. Para o backend, utilize Azure, Render, Vercel, entre outros serviços gratuitos.

## Contribuição

- Para sugestões, dúvidas ou melhorias, abra uma issue ou faça um pull request.
- Artistas podem entrar em contato para se cadastrar e divulgar seu trabalho.

---

**DescontrAI** conecta você ao artista ideal para o seu evento!
