using Data;
using Microsoft.EntityFrameworkCore;
using QuickGrid_Scaffolded_CRUD.Models;


namespace QuickGrid_Scaffolded_CRUD.Data;


public class BlazorScaffoldingAppsDbContext : FakeDbContext
{

    #region this is necessary for scaffolding
    public BlazorScaffoldingAppsDbContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.;Database=master;Integrated Security=True");

        base.OnConfiguring(optionsBuilder);
    }

    #endregion




    public QueryableWrapper<Customer> Customer { get; set; } = new ()
    {
        new Customer() { FirstName = "Carl", LastName="LamasWithHeads", Email="bla@blub.de", ID = Guid.NewGuid().ToString()}

    };

    // TODO to scaffold House, rightclick on the project, add, scaffolded item, razor component, ... with entity framework
    // TODO THEN uncomment this afterwards.
            //public QueryableWrapper<House> House { get; set; } = new ()
            //{
            //    new House() { Address = "SomeStreet", Area = 123, RoofTypes = RoofTypes.Flat, ID = Guid.NewGuid().ToString()}

            //};
    // TODO ALSO, uncomment the block in NavMenu.

    // TODO after scaffolding a new entity, change the collection type from DbSet to QueryableWrapper.
    // TODO i can get DbSet working here, with collection initializers by creating an Add extension method.
}
