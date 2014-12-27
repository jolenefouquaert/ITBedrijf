﻿using ITBedrijf.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITBedrijf.PresentationModels
{
    public class PMOrganisation : Organisation
    {
        [Required]
        [DisplayName("Controle Wachtwoord")]
        public string ControlePassword { get; set; }

        [Required]
        [DisplayName("Database Controle Wachtwoord")]
        public string DbControlePassword { get; set; }
    }
}