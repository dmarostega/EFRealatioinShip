using EFWithRelationship2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFWithRelationship2.Data
{
    public class EFWithReationship2Context : DbContext
    {
        public EFWithReationship2Context()
        { }
        public EFWithReationship2Context(DbContextOptions<EFWithReationship2Context> options) : base(options)
        {
        }
        public DbSet<State> State { get; set; }
        public DbSet<City> City { get; set; }


    }
}
