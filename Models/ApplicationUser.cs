using AspNetCore.Identity.MongoDbCore.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcidentity.Models
{
    public class ApplicationUser : MongoIdentityUser<ObjectId>
    {
        public ApplicationUser() :base()
        {

        }

        public ApplicationUser(string userName, string email) : base(userName, email)
        {

        }
    }
}
