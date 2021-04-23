﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace final_MVC_Test.Models
{
	public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Sales Person")]
        public string Name { get; set; }

        [NotMapped]
        public bool isSuperAdmin { get; set; }



    }
}
