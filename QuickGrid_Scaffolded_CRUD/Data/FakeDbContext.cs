//global using EntityState = Microsoft.EntityFrameworkCore.EntityState;
using QuickGrid_Scaffolded_CRUD.Models;

namespace Data
{
    public class FakeDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public EntityEntryFake Attach(DbObj _) => EntityEntryFake.Instance;

        public Task SaveChangesAsync()
        {
            return Task.CompletedTask;
        }
    }

}
