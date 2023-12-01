//global using EntityState = Microsoft.EntityFrameworkCore.EntityState;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class EntityEntryFake
    {
        public EntityState State { get; set; }
        public static EntityEntryFake Instance { get; } = new EntityEntryFake();
    }

}
