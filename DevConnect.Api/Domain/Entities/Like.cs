using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevConnect.Api.DevConnect.Domain.Entities;

namespace DevConnect.Api.Domain.Entities
{
    public class Like
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public int PostId { get; set; }
        public Post? Post { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }
    }
}