using System.Collections;

namespace Labb2_API_Angular.Models
{
    public interface IRepository<T>
    {
        ICollection GetAll();
        Employee GetOne(Guid id);
        Task<T> Create(T newEntity);
        Task<T> Delete(Guid id);
        Task<T> Update(T Entity);
    }
}
