using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProniaTask.Core.RepositoryAbstract.IGenrericrepository;
using ProniaTask.Core.Models;

namespace ProniaTask.Core.RepositoryAbstract
{
    public interface ITagRepository : IGenericRepository<Tag>
    {
    }
}
