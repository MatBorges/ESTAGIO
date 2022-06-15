using escolaNc.Data;
using escolaNc.Interfaces;
using escolaNc.Modelos;
using escolaNc.Excecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace escolaNc.Servicos {
    public class LoginService : ILoginService {
        private
        public bool CadastraUsuario(string nome, string cpf, string senha) {

            throw new NotImplementedException();
        }

        public List<Login> RetornaLogin() {
            throw new NotImplementedException();
        }

        public bool ValidaUsuario(string cpf, string senha) {
            throw new NotImplementedException();
        }
    }
}
