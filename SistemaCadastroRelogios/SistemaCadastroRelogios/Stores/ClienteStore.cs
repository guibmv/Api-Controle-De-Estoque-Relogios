using SistemaCadastroRelogios.Interfaces;

namespace SistemaCadastroRelogios.Stores
{
    public class ClienteStore : ICliente
    {
        public void GetAllClientes()
        {
            Console.WriteLine("Você escolheu a Opção GetAll da lista de Clientes");
        }
    }
}
