using System.Collections.Generic;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using Lernify.Domain.Entities.User;

namespace Lernify.BusinessLogic.DBModel
{
     public class SessionContext : DbContext
     {
          public SessionContext() :
               base("name=Lernify") // connectionstring name define in your web.config
          {
          }

          public virtual DbSet<Session> Sessions { get; set; }
     }
}