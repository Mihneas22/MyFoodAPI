﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Repository.AddRating
{
    public record AddRatingResponse(bool Flag, string message = null!);
}
