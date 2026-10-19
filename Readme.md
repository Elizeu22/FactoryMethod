Sistema de Pagamentos Hospitalares

Projeto desenvolvido para praticar Orientação a Objetos em C# e aplicar o padrão de projeto
Factory Method em um cenário inspirado na vida real.

🎯 Objetivo

Desenvolver um sistema que permita processar pagamentos hospitalares por diferentes métodos,
utilizando fábricas para criar os objetos de pagamento.

🏥 Contexto

Um hospital precisa oferecer diferentes formas de pagamento aos seus pacientes:

Cartão de crédito

PIX

Boleto bancário

Cada forma de pagamento possui sua própria implementação, mas todas seguem um contrato comum.

🛠️ Tecnologias

C#

.NET

Programação Orientada a Objetos (POO)

📁 Estrutura do projeto

SistemaPagamentosHospitalares/
├── Models/
│   └── Pagamento.cs
├── Interfaces/
│   └── IPagamento.cs
├── Services/
│   ├── PagamentoCartao.cs
│   ├── PagamentoPix.cs
│   ├── PagamentoBoleto.cs
│   ├── PagamentoCreator.cs
│   ├── CartaoCreator.cs
│   ├── PixCreator.cs
│   └── BoletoCreator.cs
└── Program.cs

📚 Conceitos praticados

Interfaces: definir um contrato comum para os pagamentos.

Abstração: estabelecer comportamentos essenciais sem definir todos os detalhes.

Herança: reutilizar e especializar comportamentos.

Polimorfismo: trabalhar com diferentes tipos de pagamento por meio de uma abstração comum.

Factory Method: delegar às classes específicas a responsabilidade de criar os objetos de pagamento.