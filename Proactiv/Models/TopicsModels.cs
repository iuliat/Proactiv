using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proactiv.Models
{
    public class TopicsModels
    {

        public int TopicID { get; set; }
        public string TopicTitle { get; set; }

        public string TopicDescription { get; set; }

        public string TopicTag { get; set; }
        
    }

    public class TopicsDBContext : DbContext
    {
        public DbSet<TopicsModels> Topics { get; set; }
    }

}