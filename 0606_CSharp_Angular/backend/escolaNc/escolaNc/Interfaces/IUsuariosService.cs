using escolaNc.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace escolaNc.Interfaces{
    public interface IUsuariosService{
        public List<Usuario> RetornaUsuario();
        public Usuario InsereUsuario(Usuario usuarios);
        public Usuario AtualizaUsuario(Usuario usuarios);
        public bool RemoveUsuario(string cpf);  
    }
}
