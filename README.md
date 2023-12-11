# MiniERP ![C#](https://img.shields.io/badge/c%23-%23239120.svg?logo=c-sharp&logoColor=white) ![Dot Net 6.0](https://img.shields.io/badge/6.0-blueviolet?logo=.net&logoColor=white) ![MySQL](https://img.shields.io/badge/mysql-%2300f.svg?logo=mysql&logoColor=white)

Aplicação `C# Windows Form` MiniERP avaliativo com cadastro de produtos, clientes e fornecedores, e emissão de notas em PDF.

<img src="https://github.com/OQueLucas/AcademiaDotNet_WFMiniERP/assets/36959868/d14c8fe3-420b-44ca-98a9-8a1492ddd27b" title="Tela inicial" alt="Tela incial de emissão de nota" width="300px" />
<img src="https://github.com/OQueLucas/AcademiaDotNet_WFMiniERP/assets/36959868/252da96b-c1e6-4e2f-94b2-03ef42268da0" title="Tela de clientes" alt="Tela gerenciamento de clientes" width="300px" />
<img src="https://github.com/OQueLucas/AcademiaDotNet_WFMiniERP/assets/36959868/e94f8468-870a-4dda-a57a-59880ec088cf" title="Tela de produtos" alt="Tela gerenciamento de produtos" width="300px" />
<img src="https://github.com/OQueLucas/AcademiaDotNet_WFMiniERP/assets/36959868/7e833ebc-165c-4d0e-b3cd-ae676be52113" title="Tela de fornecedores" alt="Tela gerenciamento de fornecedores" width="300px" />
<img src="https://github.com/OQueLucas/AcademiaDotNet_WFMiniERP/assets/36959868/19bda731-d979-47f2-b565-94dee9646392" title="Tela de visualizar nota" alt="Tela visualização e cancelamento de nota" width="300px" />
<img src="https://github.com/OQueLucas/AcademiaDotNet_WFMiniERP/assets/36959868/b54461fd-e726-4e37-90b4-e48f14c30875" title="Tela de visualizar nota e nota selecionada" alt="Tela visualização e cancelamento de nota com nota selecionada" width="300px" />
<img src="https://github.com/OQueLucas/AcademiaDotNet_WFMiniERP/assets/36959868/55a579a8-915a-495e-9e3d-97623212be27" title="PDF gerado" alt="PDF emitido referente a nota" width="300px" />

## 📏 Regras de negócio

- As classes DataModels possuem suas relações, conforme os vínculos:
  - Cliente possui ICollection de Notas;
  - Fornecedor possui ICollection de Produtos;
  - Notas possui ICollection de itens(ItemNota);
  - Produto tem relacionamento com o Fornecedor;
  - ItemNota tem relacionamento com o Produto e Nota (No mesmo, é salvo o Nome e Preço isolado do produto para a persistência de dado, enquanto tem ligação do produto que foi feito a venda);
- CBItem tem objetivo facilitar para pegar e mostrar os dados no combobox;
- Os form `FormCliente`, `FormFornecedor`, `FormProduto` possuem os campos e tratativas para cadastrar, consultar, excluir e editar seus respectivos itens;
- O `Form1` é o principal, onde vai selecionar o cliente, junto com os itens na lista e gerar a nota fiscal ao fim do cadastro, que quando emitido, irá gerar um PDF;
- E por fim, temos o `NotaFiscal` onde é possível visualizar todas as notas, filtrar, cancelar, e gerar o PDF da mesma.

## 📲 Recursos implementados

- Produtos:
  - Cadastro;
  - Edição;
  - Visualização;
  - Exclusão;
- Fornecedores:
  - Cadastro;
  - Edição;
  - Visualização;
  - Exclusão;
- Clientes:
  - Cadastro;
  - Edição;
  - Visualização;
  - Exclusão;
- Notas
  - Emissão de nota;
  - PDF da nota ao emitir;
  - Consulta por notas;
  - Cancelamento de nota (A mesma continua na consulta, com status de Cancelada);
  - Filtro para buscar notas por: Cliente, Datas e Status de nota;
- Foi adicionado os tabIndex para facilitar o uso do sistema pro usuário com a tecla tab.
- Adicionado combobox para selecionar os fornecedores, produtos e clientes.

## 🔧 Recursos Utilizados

- `.NET 6`
- `C#`
- `Entity Framework`
- `SQL Server`
- `Migration`
- `iText7`
  - Para a criação de PDF;

## 👨🏽‍💻 Comandos úteis

```bash
Add-Migration "name"
```

```bash
Update-Database
```

## 🔻 Clonar Repositório

```bash
git clone git@github.com:OQueLucas/AcademiaDotNet_WFMiniERP.git
```

## 👨‍💻 Como utilizar

- Após o download, abra e execute o seguinte comando em Package Manager Console(Console de Gerenciamento de Pacote).

```bash
Update-Database
```

- Cadastre ao menos um fornecedor, para depois poder cadastrar o produto e vincular o mesmo.
- Cadastre o cliente;
- Após cadastrar todos os dados importantes, na tela inicial clique em Atualizar, para buscar todos os clientes e produtos cadastrados.
- Adicione os produtos e quantidades.
- E escolha o cliente.
- Após tudo estar preenchido, clique em Emitir Nota.
- Será gerada uma nova nota, e assim que for gerada, irá gerar um documento PDF na pasta "C:\dados\" com o ID e tick do horário que está sendo impresso.
- Agora poderá visualizar a(s) nota(s) gerada(s) e filtrar para achar as notas especificadas nos campos ao clicar em `Visualizar Notas`.

## 🦾 Iniciar Projeto

Acesse o Data/Contexto.cs e altere os valores para adequar a database;

Abra o Package Manager Console e digite o comando abaixo para criar a database;

```bash
Update-Database
```

## 👨🏻‍🦱 Author

[Lucas Queiroz](https://github.com/OQueLucas/)
