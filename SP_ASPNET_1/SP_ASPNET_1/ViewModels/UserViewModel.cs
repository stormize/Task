using SP_ASPNET_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SP_ASPNET_1.ViewModels
{
    public class UserViewModel
    {
        [Key]
        public string Id { get; set; }
        [required]
        [MinLength(3)]
        public string Name { get; set; }
        [required]
        [MinLength(3)]
        public string Surname { get; set; }
        [required]
        [MinLength(6)]
        public string Password { get; set; }
        [required]
        [EmailAddress]
        public string Email { get; set; }
    }
}