using escolaNc.Modelos;
using System.Collections.Generic;

namespace escolaNc.Interfaces
{
    public interface ILoginService
    {
        public List<Login> RetornaLogin();
        public bool ValidaUsuario(string cpf, string senha);        
        public bool CadastraUsuario(string nome, string cpf, string senha);       
    }
}
