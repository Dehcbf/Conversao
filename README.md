# aula-stack-queue

# Projeto Desafio "Paralelo"

- Adicionar a opção de programação paralela no menu principal
- Criar uma calculadora que poderá fazer até 100 números para uma única vez
    - O usuário define a quantidade de operações que irá realizar
    - Insere primeiro o numero
    - Depois a operação
    - Em seguida, o próximo numero
    - Operação
    - Numero
- Ao finalizar a digitação dos números e operações, mostrar como ficou a linha completa
- A calculadora poderá receber operações de Adição, Subtração, Divisão, Multiplicação, potenciação (Math.Pow)
- Deverá realizar tudo o que está na mesma prioridade em paralelo
- Gerar para o usuário o resultado de cada passo realizado
- Salvar todos os passos e o resultado, na ordem que foi feito pelo programa, em um arquivo.txt

Observações:
    1º Parêntesis;
    2º Potenciação;
    3º Multiplicações e Divisões; (da esquerda para a direita)
    4º Somas e Subtrações. (da esquerda para a direita)

# Projeto Conversão Monetária"

## Informações
Conversões disponíveis: https://economia.awesomeapi.com.br/xml/available
Site Base: https://docs.awesomeapi.com.br/api-de-moedas

## Modelo 1 (Avançado)
1º O usuário digita o valor em reais que deseja (1 a 100 reais)
2º Escolhe converter para Dolar ou Rublo Russo 
3º 
    Se ele escolher Dolar
        - Primeiro pegar o valor de Real e Rublo Russo
        - Depois Rublo Russo e Dolar
        - Após isso, calcular a conversão do Real para o Dolar com os valores que retornou
        - (Test) Verificar se o valor INTEIRO está batendo através da conversão direta (não usar esse valor para o usuário)
    Se ele escolher Rublo Russo
        - Primeiro pegar o valor de Real e Dolar
        - Depois Dolar para Rublo Russo
        - Após isso, calcular a conversão do Real para o Rublo Russo com os valores que retornou
        - (Test) Verificar se o valor está batendo através da conversão direta (não usar esse valor para o usuário)
4º Exibir o resultado para o usuário

## Modelo 2 (Intermediário) - MODELO UTILIZADO
1º O usuário digita o valor em reais que deseja (1 a 100 reais)
2º Escolhe converter para Dolar 
3º 
        - Primeiro pegar o valor de Real e Rublo Russo
        - Depois Rublo Russo e Dolar
        - Após isso, calcular a conversão do Real para o Dolar com os valores que retornou
4º Exibir o resultado para o usuário

Nomes: 
Eduardo Gabriel Wehrmeister
Débora Cristina Brandão Franco
Natanael Junkes
Michele de Lima