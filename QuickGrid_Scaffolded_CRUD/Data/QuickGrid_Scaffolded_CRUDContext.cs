using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuickGrid_Scaffolded_CRUD.Models;

    public class QuickGrid_Scaffolded_CRUDContext : DbContext
    {
        public QuickGrid_Scaffolded_CRUDContext (DbContextOptions<QuickGrid_Scaffolded_CRUDContext> options)
            : base(options)
        {
        }

        public DbSet<QuickGrid_Scaffolded_CRUD.Models.Customer> Customer { get; set; } = default!;
    }
