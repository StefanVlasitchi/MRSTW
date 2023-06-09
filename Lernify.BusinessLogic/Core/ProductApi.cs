using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernify.BusinessLogic.Core
{
     public class ProductApi
     {
          internal void AddNewReview(Review review)
          {
               var config = new MapperConfiguration(cfg =>
               {
                    cfg.CreateMap<Review, RDbTable>();
               });
               IMapper mapper = config.CreateMapper();
               var result = mapper.Map<RDbTable>(review);

               using (var db = new ReviewContext())
               {
                    db.Reviews.Add(result);
                    db.SaveChanges();
               }
          }

          internal List<Review> GetReviewList()
          {
               var config = new MapperConfiguration(cfg =>
               {
                    cfg.CreateMap<RDbTable, Review>();
               });
               IMapper mapper = config.CreateMapper();

               using (var db = new ReviewContext())
               {
                    var result = db.Reviews.ToList();
                    var reviewData = mapper.Map<List<Review>>(result);
                    return reviewData;
               }
          }
}
