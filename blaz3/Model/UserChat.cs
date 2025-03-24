﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace blaz3.Model
{
    public class UserChat
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("User")]
        public string SenderId { get; set; }
        [Required]
        public string SenderName { get; set; }
        [Required]
        [ForeignKey("User")]
        public string RecipientId { get; set; }
        [Required]
        public string Message { get; set; }
        public string ImageUrl { get; set; } // URL изображения
        [Required]
        public DateTime Timestamp { get; set; }
    }
}
