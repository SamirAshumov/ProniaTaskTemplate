using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProniaTask.Core.Models;
using ProniaTask.Core.RepositoryAbstract;
using ProniaTask.Data.DAL;

namespace ProniaTask.Data.RepositoryConcretes
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }
    }
}
