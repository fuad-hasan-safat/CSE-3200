using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AustOldBook
{
    
    public class BookModelView
    {
        public List<BookInfo> ListOfMybook()
        {
            try
            {
                using(AustOldBookDBEntities4 dbContext = new AustOldBookDBEntities4())
                {
                    var Query = (from n in dbContext.BookInfoes
                                 select new BookInfo
                                 {
                                     bookId = n.bookId,
                                     userId = n.userId,
                                     bookImage = n.bookImage,
                                     bookName = n.bookName,
                                     authorName = n.authorName,
                                     price = n.price

                                 }).ToList();


                    return Query;

                }
            }
            catch(Exception)
            {
                throw;
            }
        }

    }
}
