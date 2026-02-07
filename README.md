# 💳 Validador de Cartão de Crédito com GitHub Copilot

## 📋 Sumário Executivo
Este projeto foi desenvolvido como parte do bootcamp **TIVIT - .NET com GitHub Copilot** na DIO. O objetivo é criar um middleware capaz de identificar bandeiras de cartão de crédito e validar sua integridade matemática, simulando uma necessidade real de e-commerce (controle de bônus, cashback e impostos) sem armazenar dados sensíveis.

## 🚀 Tecnologias e Ferramentas
* **Linguagem:** C# (.NET)
* **IA Assistente:** GitHub Copilot (via Codespaces)
* **Técnicas:** Prompt Engineering, Expressões Regulares (Regex) e Algoritmo de Luhn.

## 🧠 Metodologia de Desenvolvimento
O desenvolvimento foi guiado por **IA-Assisted Development**:
1.  **Prompt Engineering:** Utilização de comandos estratégicos para gerar padrões de Regex complexos para bandeiras como Visa, Mastercard, Amex e Elo.
2.  **Algoritmo de Luhn:** Implementação assistida para garantir a validade matemática do número antes da identificação da bandeira.
3.  **Análise Crítica:** Revisão humana do código gerado pela IA para garantir segurança e modularidade.

## 🛠️ Funcionalidades
- [x] Identificação automática de bandeiras.
- [x] Validação via Algoritmo de Luhn.
- [x] Interface simples e expansível para novas bandeiras.

## 📖 Como funciona
O sistema recebe o número do cartão, remove caracteres não numéricos e passa por duas camadas:
1.  **Validação Matemática:** O número é real? (Luhn).
2.  **Identificação de Padrão:** Qual a bandeira baseada no prefixo? (Regex).

---
*Projeto desenvolvido por Paulo durante o Bootcamp TIVIT/DIO - 2026.*
