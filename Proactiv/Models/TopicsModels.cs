using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proactiv.Models
{
    public class TopicsModels
    {
        [Key]
        public int TopicID { get; set; }
        public string TopicTitle { get; set; }

        public string TopicDescription { get; set; }

        public string TopicTag { get; set; }
        
    }


}