using DAW.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAW.IRepositories
{
    public interface IProfessorRepository: IGenericRepository<Professor>
    {
        Professor GetByIdJoined(int id);
    }
}
