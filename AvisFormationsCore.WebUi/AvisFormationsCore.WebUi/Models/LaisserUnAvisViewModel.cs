﻿using System;
using System.ComponentModel.DataAnnotations;

namespace AvisFormationsCore.WebUi.Models
{
    public class LaisserUnAvisViewModel
    {
       [StringLength(5)]
       public string Commentaire { get; set; }

       [Required]
       public string Nom { get; set; }
        [Required]
       public string Note { get; set; }
        [Required]
       public string IdFormation { get; set; }
       public string NomFormation { get; set; }
    }   
    
    
}
