﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("tblUserFriend")]
    public class UserFriends
    {
        
        
        [Key]
        public int Id { get; set; }

        [ForeignKey("UserOf")]
        public int UserId { get; set; }

        [ForeignKey("FriendOf")]
        public int FriendId { get; set; }

        public virtual Users UserOf { get; set; }

        public virtual Friend FriendOf { get; set; }
    }
}
