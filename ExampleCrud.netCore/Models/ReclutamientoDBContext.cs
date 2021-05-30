using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleCrud.netCore.Models
{
    public class ReclutamientoDBContext:DbContext
    {




        public ReclutamientoDBContext(DbContextOptions<ReclutamientoDBContext> options) : base(options)
        {


        }




        public DbSet<OfertaLaboral> OfertaLaboral { get; set; }






    }
}
