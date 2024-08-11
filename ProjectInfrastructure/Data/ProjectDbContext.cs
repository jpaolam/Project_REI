using Microsoft.EntityFrameworkCore;
using ProjectDomain.Setup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInfrastructure.Data
{
    public partial class ProjectDbContext : DbContext
    {
        //CONSTRUCTOR
        //To make sure that we pass our connection string into our DB
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
            //Aqui ponemos los modelos de los cuales queremos hacer una db
        }

        public virtual DbSet<Entidad> entidades { get; set; }
    }
}
