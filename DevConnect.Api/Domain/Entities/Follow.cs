using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevConnect.Api.Domain.Entities
{
    public class Follow
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public int FollowerId { get; set; }
        public User? Follower { get; set; }

        public int FollowedId { get; set; }
        public User? Followed { get; set; }
    }

}