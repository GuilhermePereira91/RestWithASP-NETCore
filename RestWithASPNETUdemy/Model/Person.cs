﻿using RestWithASPNETUdemy.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Model
{
    [Table("person")]
    public class Person : BaseEntity
    {
        [Column("first_name")]
        public string FirstName { get; set; } = string.Empty;
        [Column("last_name")]
        public string LastName { get; set; } = string.Empty;
        [Column("address")]
        public string Address { get; set; } = string.Empty;
        [Column("gender")]
        public string Gender { get; set; } = string.Empty;
        [Column("enabled")]
        public bool Enabled { get; set; }

    }
}
