﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TigerPad1.ViewModel
{
    public class AdminQOTDViewModel
    {
        public int adminQotdID { get; set; }

        [Display(Name = "AdminUserName")]
        public string? adminUserName { get; set; }

        [Display(Name = "AdminQOTD")]
        public string? adminQOTD { get; set; }

    }
}
