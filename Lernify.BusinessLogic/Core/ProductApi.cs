using Lernify.BusinessLogic.DBModel;
using Lernify.Domain.Entities.Teacher;
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


          internal List<Teacher> GetTeacherList()
          {
               List<TDbTable> context;

               var mapper = new MapperConfiguration(cfg => cfg.CreateMap<TDbTable, Teacher>()).CreateMapper();
               using (var db = new TeacherContext())
               {
                    context = db.Teacher.ToList();
               }
               return mapper.Map<List<Teacher>>(context);
          }

          internal ULoginResp AddNewTeacher(Teacher data)
          {
               IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<Teacher, TDbTable>()).CreateMapper();
               var context = mapper.Map<TDbTable>(data);

               using (var db = new TeacherContext())
               {
                    db.Teacher.Add(context);
                    db.SaveChanges();
               }
               return new ULoginResp { Status = true };
          }
          internal Teacher GetTeacher(int id)
          {
               TDbTable context;
               using (var db = new TeacherContext())
                    context = db.Teacher.FirstOrDefault(u => u.Id == id);
               IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<TDbTable, Teacher>()).CreateMapper();

               return context != null ? mapper.Map<Teacher>(context) : null;
          }
          internal ULoginResp UpdateTea(Teacher data)
          {
               if (GetTeacher(data.Id) == null)
                    return new ULoginResp { Status = false, StatusMsg = "An Error occur at updating" };

               IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<Teacher, TDbTable>()).CreateMapper();
               var result = mapper.Map<TDbTable>(data);

               using (var db = new TeacherContext())
               {
                    db.Teacher.AddOrUpdate(result);
                    db.SaveChanges();
               }
               return new ULoginResp { Status = true };

          }

          internal void DeleteProfessor(int id)
          {
               using (var db = new TeacherContext())
               {
                    var teacher = db.Teacher.FirstOrDefault(u => u.Id == id);
                    if (teacher != null)
                    {
                         db.Teacher.Remove(teacher);
                         db.SaveChanges();
                    }
               }
          }
     }
}
