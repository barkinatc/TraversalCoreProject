﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTO.DTOs.AppUserDTOs
{
   public class AppUserRegisterDTO
    {
        
        public string Name { get; set; }
       
        public string SurName { get; set; }
        
        public string UserName { get; set; }
       
        public string Mail { get; set; }
      
        public string Password { get; set; }
   
        public string ConfirmPassword { get; set; }
    }
}
