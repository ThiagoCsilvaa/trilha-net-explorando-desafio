# Desafio Projeto Hospedagem

## Descrição
Projeto de gerenciamento de hospedagem em C# desenvolvido como parte do desafio da Trilha .NET.  
O sistema permite cadastrar hóspedes, suítes e reservas, calcular valores de diárias e aplicar descontos automáticos.

---

## Funcionalidades

- Cadastro de hóspedes com nome e sobrenome.
- Cadastro de suítes com tipo, capacidade e valor da diária.
- Cadastro de reservas associando hóspedes e suítes.
- Cálculo do valor total da reserva:
  - Multiplica dias reservados pelo valor da diária.
  - Aplica 10% de desconto para reservas de 10 dias ou mais.
- Validação automática de capacidade da suíte (gera exceção se exceder).

---

## Tecnologias

- C# 10
- .NET 6
- Conceitos de Orientação a Objetos:
  - Classes e objetos
  - Propriedades
  - Construtores
  - Métodos

---

## Estrutura do Projeto

DesafioProjetoHospedagem/
│
├─ Program.cs
├─ DesafioProjetoHospedagem.csproj
└─ Models/
├─ Pessoa.cs
├─ Suite.cs
└─ Reserva.cs

yaml
Copy code

---

## Como Executar

1. Clone o repositório:

```bash
git clone https://github.com/SeuUsuario/DesafioProjetoHospedagem.git

2. Acesse a pasta do projeto:
bash
Copy code
cd DesafioProjetoHospedagem

3. Rode o projeto:
bash
Copy code
dotnet run

4.O console exibirá:
Quantidade de hóspedes cadastrados

Valor da diária calculado (com desconto automático se aplicável)