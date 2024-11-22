# Modelo de Arquitetura em Camadas com Clean Architecture

Este repositório apresenta um **modelo de arquitetura em camadas** baseado nos princípios da **Clean Architecture**. Ele foi projetado para demonstrar como estruturar projetos de software de forma organizada, seguindo as boas práticas de desenvolvimento.

## Objetivo

O objetivo deste modelo é servir como referência para projetos que necessitam de uma arquitetura escalável, testável e de fácil manutenção. Ele é separado em **quatro camadas principais**, além da camada de API.

![image](https://github.com/user-attachments/assets/2b9367c3-6a3d-47a7-bbd3-95d3e7cafdea)


---

## Camadas da Arquitetura

![image](https://github.com/user-attachments/assets/f5625a7a-fe3d-4ed5-b740-20a7f1a52052)


### 1. **Application**
- **Responsabilidade**: Contém a lógica de aplicação e os **casos de uso**.  
- **Função**: Coordena o fluxo de dados entre as camadas **Domain** e **Infrastructure**, mantendo a lógica de negócios independente de frameworks externos.  
- **Componentes**:
  - Serviços de aplicação.
  - Interfaces de uso (ex.: DTOs, ViewModels).
 
![image](https://github.com/user-attachments/assets/24a30b4e-c396-45f0-8a24-9e06a2c027e8)

---

### 2. **CrossCutting**
- **Responsabilidade**: Define componentes e utilitários reutilizáveis que são transversais às camadas, como:
  - Validações.
  - Tratamento de exceções.
  - Gerenciamento de logs.  
- **Função**: Promover reutilização e centralizar funcionalidades genéricas.
- ![image](https://github.com/user-attachments/assets/cce371bf-3ce7-4ce1-92d4-bd19da34c4b4)


---

### 3. **Domain**
- **Responsabilidade**: Representa o **núcleo** do sistema e contém a lógica de negócios pura.  
- **Função**:
  - Modelagem do domínio através de **entidades** e **objetos de valor**.
  - Regras de negócio e validações específicas do domínio.
  - Interfaces de repositórios (sem implementações).  
- **Importante**: Não depende de nenhuma outra camada, garantindo total independência.
![image](https://github.com/user-attachments/assets/42f2e7d9-6dc6-411d-ae85-1b05a8b7baec)

---

### 4. **Infrastructure**
- **Responsabilidade**: Implementa os detalhes técnicos necessários para o funcionamento da aplicação.  
- **Função**:
  - Implementação de repositórios (acesso a bancos de dados).
  - Comunicação com APIs externas.
  - Integração com bibliotecas/frameworks de terceiros.  
- **Componentes**:
  - Conexões com o banco de dados.
  - Configurações e provedores externos.
![image](https://github.com/user-attachments/assets/eb54c330-84a1-4d6e-bef7-1dd668e89dd9)

---

### 5. **CatalogoApi**
- **Responsabilidade**: Expor os serviços através de uma **API RESTful**.  
- **Função**:
  - Receber e processar requisições HTTP.
  - Delegar o processamento para a camada **Application**.
  - Gerar respostas baseadas nos dados processados.
![image](https://github.com/user-attachments/assets/f0308404-9d9f-4b65-8b6d-1de25116a4b2)

---

## Benefícios da Arquitetura Limpa

- **Independência**: Cada camada é isolada, permitindo mudanças sem impactar diretamente outras partes do sistema.
- **Testabilidade**: O isolamento facilita a criação de testes unitários e de integração.
- **Escalabilidade**: O sistema é facilmente escalável para atender novas funcionalidades.
- **Reutilização**: As regras de negócio e componentes genéricos podem ser reutilizados em diferentes contextos.

---

## Como Usar Este Modelo

1. **Clone o repositório**:  
   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git
