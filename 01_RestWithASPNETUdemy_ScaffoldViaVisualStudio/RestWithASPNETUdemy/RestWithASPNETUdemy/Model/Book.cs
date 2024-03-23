﻿using RestWithASPNETUdemy.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Model
{
    [Table("books")]
    public class Book : BaseEntity
    {
        [Column("author")]
        public string Author { get; set; } = string.Empty;
        [Column("launch_date")]
        public DateTime LaunchDate { get; set; } = DateTime.MinValue;
        [Column("price")]
        public decimal Decimal { get; set; } = 0;
        [Column("title")]
        public string title { get; set; } = string.Empty;
    }
}
