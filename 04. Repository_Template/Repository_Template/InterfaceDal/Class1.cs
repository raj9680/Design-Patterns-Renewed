using System;
using System.Collections.Generic;

namespace InterfaceDal
{
    // Generic Repository Pattern
    public interface IDal<AnyType>
    {
        void Add(AnyType obj); // InMemory Addition
        void Update(AnyType obj); // InMemory Updation
        List<AnyType> Search();
        void Save(); // Physical committ
    }
}
