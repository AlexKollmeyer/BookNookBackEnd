﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
namespace FullStackAuth_WebAPI.Models
{
    public class Favorite
    {
        [Key]
        public int Id { get; set; }
        public string BookId { get; set; }
        public string Title { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}