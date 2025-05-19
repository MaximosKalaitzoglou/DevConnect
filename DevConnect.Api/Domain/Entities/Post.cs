using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevConnect.Api.Domain.Entities;

namespace DevConnect.Api.DevConnect.Domain.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Body { get; set; }
        public string? Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }

        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Like>? Likes { get; set; }
    }

}