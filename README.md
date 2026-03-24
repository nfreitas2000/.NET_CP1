# Sistema de Cadastro de Produtos (C#)

## Visão Geral

Este projeto consiste em um sistema de cadastro de produtos via terminal, desenvolvido em C# com foco na aplicação de conceitos de Programação Orientada a Objetos (POO).

A aplicação permite cadastrar produtos, calcular valores automaticamente e aplicar regras de desconto com base em condições definidas.

---

## Funcionalidades

* Cadastro de produtos via terminal
* Cálculo automático do valor total
* Aplicação de desconto condicional
* Exibição detalhada dos dados do produto
* Comparação entre produtos com base no custo final

---

## Conceitos Aplicados

* Encapsulamento (atributos privados com acesso controlado)
* Classes e objetos
* Métodos de instância
* Construtores
* Lógica condicional (if/else)
* Entrada e saída de dados com Console

---

## Estrutura do Projeto

```bash
CP1/
├── Produto.cs
└── Program.cs
```

---

## Execução

1. Clone o repositório:

```bash
git clone https://github.com/seu-usuario/seu-repositorio.git
```

2. Acesse a pasta do projeto:

```bash
cd CP1
```

3. Execute o projeto:

```bash
dotnet run
```

---

## Exemplo de Uso

```bash
Cadastro de Produtos ============================
Nome: Teclado
Preço Unitário: 200
Quantidade: 30
Desconto: 10

Resumo ============================
Produto: Teclado
Preço Unitário: R$200
Quantidade: 30
Custo Total: 6000
Desconto Aplicado: 10%
Custo Final: R$5400
```

---

## Regra de Negócio

O desconto é aplicado apenas quando o valor total do produto é superior a R$5000. Caso contrário, o valor final corresponde ao valor total sem desconto.

---

## Autor

Natan Moraes
Estudante de Análise e Desenvolvimento de Sistemas (FIAP)

---
