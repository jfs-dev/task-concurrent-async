# task-concurrent-async
Executando tarefas simultâneas de forma assíncrona em C#

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)

## Sobre o projeto
Este projeto mostra como executar tarefas simultâneas de forma assíncrona em C#.

Em C#, a execução simultânea de tarefas é uma prática comum para melhorar o desempenho de aplicativos, especialmente em cenários assíncronos. Vamos explorar alguns conceitos e recursos relacionados a tarefas simultâneas em C#.

**Task:** A classe Task é usada para representar uma operação assíncrona que pode ser executada em segundo plano.

**async e await:** O operador async é usado para declarar um método assíncrono, enquanto o operador await é usado para esperar a conclusão de uma tarefa sem bloquear a execução.

**Task.WhenAll:** O método Task.WhenAll espera que todas as tarefas fornecidas sejam concluídas.

<div align="center">
    <img src="https://github.com/jfs-dev/task-concurrent-async/assets/54154628/ee71d84f-40ca-4ef3-bf6b-d54b83f74550"</img>
</div>

## Referências
https://learn.microsoft.com/pt-br/dotnet/standard/parallel-programming/task-based-asynchronous-programming/

https://devblogs.microsoft.com/dotnet/how-async-await-really-works/

## Licença
GPL-3.0 license
