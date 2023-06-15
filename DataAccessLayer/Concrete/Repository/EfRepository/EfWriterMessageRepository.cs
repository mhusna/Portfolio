using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repository.EfRepository
{
    public class EfWriterMessageRepository : GenericRepository<WriterMessage>, IWriterMessageDal
    {
        public List<WriterMessage> GetByFilter(Expression<Func<WriterMessage, bool>> filter)
        {
            using (var context = new Context())
            {
                return context.Set<WriterMessage>().Where(filter).ToList();
            }
        }
    }
}
