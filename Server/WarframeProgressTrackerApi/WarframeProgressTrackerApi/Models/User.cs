﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WarframeProgressTrackerApi.Models {
    public class User : IdentityUser {
        bool IsAdmin { get; set; } = false;
    }
}
