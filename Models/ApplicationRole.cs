using AspNetCore.Identity.MongoDbCore.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcidentity.Models
{
    public class ApplicationRole : MongoIdentityRole<ObjectId>
    {
        public ApplicationRole() : base()
        {

        }

        public ApplicationRole(string roleName) : base(roleName)
        {

        }
    }
}
