using SampleWebApiNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebApiNetCore.Repositories
{
    public interface IWellRepository
    {
        IEnumerable<Well> GetAll();
        Well Find(int id);
        void Add(Well well);
        Well Remove(int id);
        void Update(Well well);
    }
}
