using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{   
    // representação do relacionamente de Dependência, por meio de um parâmetro que é um objeto de outra Classe.
    public class Teste
    {
        public void AvaliarIdade(Cliente cliente)
        {
            cliente.VerificaIdade();
        }
    }
}