using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusinessEntities.Account
{
    [Table("SYS_User")]

    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModifyDate { get; set; }
        public bool IsActive { get; set; }
        public int UserTypeId { get; set; }
        public DateTime LastLoginDate { get; set; }
    }
}
