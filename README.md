# TestesDeSoftware
Projeto de Testes de Software, utilizando .NET Core 2.2 e xUnit



## Instalações

### Framework
```
Install-Package xunit
```

### Para reconhecimento do Visual Studio
```
Install-Package xunit.runner.visualstudio
```

### MOQ (utilizado para simular objetos; Mock são objetos que simulam o comportamento de objetos reais de forma controlada)
```
Install-Package Moq
```

### Bogus (utilizado para gerar dados fictícios para testes)
```
Install-Package Bogus
```

### AutoMock (utilizado para facilitar a criação dos mocks de forma automática)
```
Install-Package MOQ.automock
```

### Fluent Assertions (utilizado para substituir os Asserts tradicionais)
```
Install-Package FluentAssertions
```

### Para rodar os testes via linha de comando
```
Install-Package xunit.runner.console
```

#### Para executar os testes, acesse o diretório onde está a dll e execute:
```
dotnet vstest Features.Tests.dll
```

### Framework Fluent Validation no projeto Core (02 - TDD\NerdStore.Core)
```
install-package fluentvalidation
```