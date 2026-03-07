# 📄 InvoicePro

> Sistema de orçamentos e faturas para freelancers e pequenas empresas.

## 🚧 Status do Projeto
![Status](https://img.shields.io/badge/status-em%20desenvolvimento-yellow)
![.NET](https://img.shields.io/badge/.NET-8.0-purple)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-8.0-blue)

## ✨ Funcionalidades
- [ ] Autenticação de usuários (login e registro)
- [ ] Gestão de clientes
- [ ] Gestão de produtos e serviços
- [ ] Criação de orçamentos com itens dinâmicos
- [ ] Geração de faturas a partir de orçamentos aprovados
- [ ] Geração de PDF das faturas
- [ ] Envio de faturas por e-mail
- [ ] Dashboard com resumo financeiro

## 🛠️ Tecnologias Utilizadas
- **ASP.NET Core 8 MVC** — framework principal
- **Entity Framework Core 8** — ORM e migrações
- **SQL Server** — banco de dados
- **ASP.NET Core Identity** — autenticação e autorização
- **AutoMapper** — mapeamento entre entidades e DTOs
- **FluentValidation** — validação de formulários
- **QuestPDF** — geração de PDFs
- **MailKit** — envio de e-mails
- **Bootstrap 5** — interface responsiva

## 🏗️ Arquitetura
O projeto segue uma arquitetura em camadas:
```
InvoicePro/
├── InvoicePro.Core       # Interfaces, DTOs e constantes
├── InvoicePro.Data       # Models, DbContext e Migrations
├── InvoicePro.Services   # Regras de negócio e serviços
└── InvoicePro.Web        # Controllers, Views e configuração
```

## 🚀 Como Rodar Localmente
> Instruções completas serão adicionadas ao final do desenvolvimento.

**Pré-requisitos:**
- Visual Studio 2022
- .NET 8 SDK
- SQL Server (LocalDB ou Express)

## 👤 Autor
**Eduardo Degani**
- GitHub: [@degasdegani](https://github.com/degasdegani)
- LinkedIn: [eduardodegani](https://www.linkedin.com/in/eduardodegani/)