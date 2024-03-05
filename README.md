# Controle de velocidade: Robo ⚠️

## Desafio Bootcamp DIO Decola Tech 2024 🚀 
</br>  

- Você foi contratado para criar um software que simule o controle de velocidade de um robô. Esse robô possui uma velocidade máxima e uma velocidade mínima. Sua tarefa é desenvolver um programa  utilizando o conceito de Orientação a Objetos para calcular a velocidade final do robô após uma sequência de comandos. Crie uma classe chamada "Robo" que possua as seguintes propriedades e métodos:

  - velocidadeAtual: inteiro que representa a velocidade atual do robô (inicialmente 0);

  - velocidadeMaxima: inteiro que representa a velocidade máxima do robô;

  - velocidadeMinima: inteiro que representa a velocidade mínima do robô;

  - acelerar(): um método que aumenta a velocidade atual em 1 unidade, desde que não ultrapasse a velocidade máxima;

  - desacelerar(): um método que diminui a velocidade atual em 1 unidade, desde que não fique abaixo da velocidade mínima.
#
### 📌 Entrada
</br>  

- A entrada consiste em duas linhas: A primeira linha contém dois inteiros Vmin e Vmax (1 ≤ Vmin < Vmax ≤ 100), representando a velocidade mínima e máxima do robô, respectivamente.

- A segunda linha contém uma sequência de comandos (com no máximo 100 caracteres), onde: 'A' representa uma aceleração e 'D' representa uma desaceleração. Desta maneira, a entrada seria da seguinte maneira:

  - Vmin Vmax: ambos valores int.
  - comandos: string.
#
### 📌 Saída
</br>

- A saída deve apresentar apenas a velocidade final (int)  do robô, considerando as regras descritas nos métodos de acelerar e desacelerar.
#
### 📌 Tecnologias e ferramentas:

</br>

<div>

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![VS Code](https://img.shields.io/badge/VS%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)
<a href="https://www.dio.me/" target="_blank"><img src="https://img.shields.io/badge/dio-%23323330.svg?style=for-the-badge&logo=Color=%23F7DF1E" target="_blank"></a>
</div>