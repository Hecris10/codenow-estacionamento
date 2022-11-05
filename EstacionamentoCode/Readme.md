# Readme.md
## Sistema de Controle de Estacionamento

### Curso Code Now! de desenvolvimento C# e .net

#### Defini��o
Permitir controlar as vagas e gerenciar os ve�culos estacionados


#### Etapas
##### 1. Cria��o da Solu��o 'EstacionamentoCode'
	1.1. Cria��o de um Projeto Console 'EstacionamentoCode.Console' que conter� o projeto principal nessa etapa
	1.2. Cria��o de um Projeto Class Library 'EstacionamentoCode.Dominio' que conter� as Classes do Modelo
	1.3. Cria��o de um Projeto Class Library 'EstacionamentoCode.Infra' que conter� o Contexto e Reposit�rios
	1.4. Adicionar Refer�ncias entre os projetos
		1.4.1. Console dever� acessar Dominio e Infra
		1.4.2. Infra dever� acessar Dom�nio

##### 2. Cria��o dos Modelos
	2.1. Criar uma pasta Models no projeto Dominio
	2.2. Criar as Classes na pasta Models
	2.2.1. Classe Veiculo
		2.2.1.1 Propriedades
			2.2.1.1.01 Id - inteiro
			2.2.1.1.02 Placa - texto
			2.2.1.1.03 Tipo de Ve�culo - inteiro
		2.2.1.1 M�todos
			2.2.1.1.1 ValidarPlaca(placa) : Validar� se a placa informada tem 3 caracteres

	2.2.2. Classe Estacionamento
		2.2.2.1 Propriedades
			2.2.2.1.01  Id - inteiro
			2.2.2.1.02  Nome - texto
			2.2.2.1.03  PrecoInicial - decimal
			2.2.2.1.04  PrecoHora - decimal
			2.2.2.1.05  Tolerancia - inteiro
			2.2.2.1.06  QtdeVagasTotais - inteiro
			2.2.2.1.07  Veiculos - Lista de Ve�culos
		2.2.2.2 M�todos
			2.2.2.2.01  Estacionar(veiculo) - Deve adicionar um ve�culo na lista de Ve�culos. N�o pode ter mais de um ve�culo com a mesma placa
			2.2.2.2.02  ObterVagasOcupadas() - Deve retornar a quantidade de vagas ocupadas
			2.2.2.2.03  ObterVagasDisponiveis() - Deve retornar a quantidade de vagas dispon�veis
			2.2.2.2.04  Obter(placa) - Deve retornar um ve�culo estacionado a partir da Placa. Retornar null se n�o encontrar o ve�culo
			2.2.2.2.05  Obter() - Deve retornar a lista com todos os ve�culos estacionados
			2.2.2.2.06  CalcularValor(placa, tempo) - Deve calcular o valor do estacionamento, com base no tempo do ve�culo estacionado
			2.2.2.2.07  Pagar(placa) - Deve identificar que o pagamento do estacionamento foi realizado
			2.2.2.2.08  Retirar(placa) - Deve remover o ve�culo do Estacionamento, desde que ele esteja pago
