using CompanyBlazor.Models;

namespace CompanyBlazor.Services
{
    public interface IServies<T>
    {
        List<T> getAll();
        T getById(int id);
    }
}
