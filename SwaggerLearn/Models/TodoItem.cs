﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SwaggerLearn.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DefaultValue(false)]
        public bool IsComplete { get; set; }
    }
}