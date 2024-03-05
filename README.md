# file-integrity-checker-sha-512
Usando o algoritmo SHA-512 (Secure Hash Algorithm) para verificar a integridade de arquivos em C#

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)

## Sobre o projeto
Este projeto mostra como usar o algoritmo SHA-512 (Secure Hash Algorithm) para verificar a integridade de arquivos em C#.

O algoritmo SHA-512 é uma função hash criptográfica que produz um resumo (ou hash) de 512 bits (ou 64 bytes) de dados. Ele é uma versão mais segura e robusta do SHA-256, projetada para fornecer uma maior resistência a ataques criptográficos.

O objetivo principal de utilizar o SHA-512 para validar a integridade de arquivos é gerar um hash único para um arquivo específico. Este hash pode ser comparado com um hash previamente gerado e armazenado para verificar se o arquivo foi modificado ou corrompido. Se o hash gerado a partir do arquivo atual corresponder ao hash armazenado, então é razoavelmente seguro assumir que o arquivo não foi alterado.

No entanto, é importante destacar que o SHA-512 é apenas um método para verificar a integridade de um arquivo. Ele não oferece proteção contra adulterações intencionais por indivíduos maliciosos. Para mitigar esse risco, é necessário implementar medidas adicionais, como assinaturas digitais ou outros mecanismos de segurança.

<div align="center">
    <img src="https://github.com/jfs-dev/file-integrity-checker-sha-512/assets/54154628/ee8c10a0-de5a-496e-b639-1d25359e6d41"</img>
</div>

## Referências
https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.sha512?view=net-8.0

## Licença
GPL-3.0 license
