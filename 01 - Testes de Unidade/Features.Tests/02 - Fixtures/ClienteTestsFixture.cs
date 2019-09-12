using Features.Clientes;
using System;
using Xunit;

namespace Features.Tests
{
    // [CollectionDefinition("ClienteCollection")]
    [CollectionDefinition(nameof(ClienteCollection))]
    public class ClienteCollection : ICollectionFixture<ClienteTestsFixture>
    {}

    // Por essa classe ser reaproveitável, entre as outras classes de testes que irão utilizar, ela implementa o IDisposable;
    // O Objeto é criado e ele fica disponível para todos os testes que estiverem rodando dentro da coleção;
    public class ClienteTestsFixture : IDisposable
    {
        public Cliente GerarClienteValido()
        {
            var cliente = new Cliente(
                Guid.NewGuid(),
                "Henrique",
                "Domareski",
                DateTime.Now.AddYears(-30),
                "henrique@henrique.com",
                true,
                DateTime.Now);

            return cliente;
        }

        public Cliente GerarClienteInValido()
        {
            var cliente = new Cliente(
                Guid.NewGuid(),
                "",
                "",
                DateTime.Now,
                "henrique2henrique.com",
                true,
                DateTime.Now);

            return cliente;
        }

        public void Dispose()
        {
        }
    }
}
