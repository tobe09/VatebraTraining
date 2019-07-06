﻿using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManager.DbContext.Models
{
    public abstract class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}
