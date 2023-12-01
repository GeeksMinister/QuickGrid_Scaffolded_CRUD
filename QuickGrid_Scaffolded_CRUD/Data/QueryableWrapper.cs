//global using EntityState = Microsoft.EntityFrameworkCore.EntityState;
using System.Linq.Expressions;

namespace Data;

public class QueryableWrapper<T> : IQueryable<T>
{
    private List<T> BackingList = new List<T>();
    private IQueryable<T> _BackingListQueryable;
    private IQueryable<T> BackingListQueryable => _BackingListQueryable ??= BackingList.AsQueryable();
    public Type ElementType => typeof(T);

    public Expression Expression => BackingListQueryable.Expression;

    public IQueryProvider Provider => BackingListQueryable.Provider;


    public IEnumerator<T> GetEnumerator() => BackingListQueryable.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => BackingListQueryable.GetEnumerator();


    public void Add(T item) => BackingList.Add(item);
    public void Remove(T item) => BackingList.Remove(item);

    public Task<T?> FirstOrDefaultAsync(Func<T, bool> keyFunc) => Task.FromResult(BackingListQueryable.FirstOrDefault(keyFunc));
}
