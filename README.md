Nome do projeto
Gnirehtet Easy Manager

---

Descrição do projeto (README.md)
Gnirehtet Easy Manager
Aplicativo desktop em C# (Windows Forms, .NET Framework 4.8) para gerenciar facilmente o uso do tethering reverse com o gnirehtet, uma ferramenta que permite compartilhar a internet do PC com o celular via USB usando VPN.

----

Este app facilita o processo que normalmente é feito via linha de comando (cmd), automatizando etapas comuns como:

Verificar se o dispositivo Android está conectado via ADB

Verificar se o cliente gnirehtet está instalado no celular

Instalar o cliente gnirehtet caso necessário

Iniciar o serviço gnirehtet (gnirehtet run) sem travar a interface

Parar o serviço gnirehtet e matar processos remanescentes

Exibir logs em tempo real para monitoramento

Interface gráfica simples e intuitiva para usuários iniciantes


-----
Motivação
O processo padrão de usar o gnirehtet envolve comandos no terminal e gerenciamento manual de processos, o que pode ser complicado para iniciantes. Com este projeto, qualquer usuário pode controlar a conexão com o celular e o compartilhamento de internet diretamente com botões e feedback visual.


---
Funcionalidades
Detecta automaticamente se o celular está conectado via ADB

Detecta se o cliente gnirehtet está instalado no dispositivo Android

Instala o cliente gnirehtet com um clique, se necessário

Executa o serviço gnirehtet sem travar a interface usando execução assíncrona

Mata processos gnirehtet e cmd para liberar a porta caso esteja ocupada

Mostra logs e status em tempo real em uma TextBox

Interface gráfica simples para facilitar o uso

----

Tecnologias usadas
C# com Windows Forms (.NET Framework 4.8)

ADB (Android Debug Bridge) para comunicação com o dispositivo Android

Processos do Windows para executar comandos e gerenciar processos externos

----

Como usar
Conecte seu dispositivo Android via USB com depuração ativada.

Abra o app.

O app automaticamente verifica conexão e status da instalação do gnirehtet.

Caso o gnirehtet não esteja instalado no celular, clique em "Instalar".

Clique em "Iniciar" para iniciar o serviço.

Para interromper a conexão, clique em "Parar".

Veja os logs no painel para confirmar ações e status.


----

Estrutura do projeto
Services/AdbService.cs — Gerencia comandos ADB (conexão e instalação)

Services/GnirehtetService.cs — Gerencia execução do gnirehtet e controle de processos

Helpers/CmdHelper.cs — Executa comandos no terminal e retorna saída

Form1.cs — Interface gráfica e interação com o usuário


-----

Observações
Este projeto foi desenvolvido para Windows e Androind, requer que o ADB e gnirehtet estejam configurados corretamente na pasta do projeto.

Feito para aprendizado e uso pessoal, sinta-se livre para contribuir e melhorar!

---


O Debug está em formato rar, depois disso é so correr o Tethering-Reverse-Easy-Start-Progam.exe

[📦 Baixar debug.rar](https://github.com/DannyJr97/Tethering-Reverse-Easy-Start-Progam/raw/master/debug.rar)



