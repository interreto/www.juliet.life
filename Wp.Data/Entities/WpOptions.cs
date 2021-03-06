﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wp.Data.Attributes;

namespace Wp.Data.Entities
{
    /// <summary>
    /// A option entity of Wordpress 
    /// </summary>
    [WpTable("options")]
    public partial class WpOptions : WpEntity<ulong>
    {
        [Key]
        [Column("option_id")]
        public override ulong Id { get; set; }

        [Required]
        [Column("option_name")]
        [StringLength(191)]
        public string Name { get; set; }

        [Required]
        [Column("option_value")]
        public string Value { get; set; }

        [Required]
        [Column("autoload")]
        [StringLength(20)]
        public string Autoload { get; set; }
    }
}
