# 📈 Application Performance Optimization

Este é um projeto básico em **.NET** criado com o objetivo de estudar e experimentar técnicas de **otimização de performance**, incluindo uso de CPU, memória e programação assíncrona com `async/await`.

---

## 🚀 Objetivo

O projeto serve como laboratório para:
- Explorar boas práticas de **performance em aplicações .NET**.
- Medir e analisar consumo de **CPU e memória**.
- Testar cenários de **programação assíncrona** utilizando `async/await`.
- Entender impactos de diferentes implementações no desempenho.

---

## 🛠️ Estrutura do Projeto

O projeto é simples e contém apenas três camadas principais:

- **Domain**  
  Contém as entidades e regras de negócio básicas.

- **Service**  
  Implementa a lógica principal e operações que serão analisadas em termos de performance.

- **Controller**  
  Exposição via API para interagir com os serviços e executar testes de desempenho.

---

## ⚙️ Tecnologias Utilizadas

- [.NET 8+](https://dotnet.microsoft.com/)  
- `async/await` para programação assíncrona  
- Ferramentas de profiling (ex.: BenchmarkDotNet) – opcionais para estudo

---

## ▶️ Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/seuusuario/application-performance-optimization.git
