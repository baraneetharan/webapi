using System.Collections.Generic;
using ProductsApp.Models;

namespace ProductsApp.Repository{
public interface IContactsRepository
    {
        void Add(Contacts item);
        IEnumerable<Contacts> GetAll();
        Contacts Find(string key);
        void Remove(string Id);
        void Update(Contacts item);
    }}