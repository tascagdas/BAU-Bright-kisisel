﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Shared.ComplexTypes
{
    public enum OrderState
    {
        [Display(Name = "Sipariş Alındı")]
        Received=0,
        
        [Display(Name = "Hazırlanıyor")]
        Preparing=1,
        
        [Display(Name = "Gönderildi")]
        Sent=2,
        
        [Display(Name = "Teslim Edildi")]
        Delivered=3
    }
}
