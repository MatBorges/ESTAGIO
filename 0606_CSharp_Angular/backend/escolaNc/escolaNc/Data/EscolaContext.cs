using escolaNc.Interfaces;
using escolaNc.modelos;
using escolaNc.Servicos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace escolaNc.Data{
    public class EscolaContext : DbContext{
        public EscolaContext(DbContextOptions<EscolaContext> options) : base(options) { }
        public DbSet<Usuario> USUARIOS { get; set; }        

    }
}
