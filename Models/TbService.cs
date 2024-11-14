﻿using System;
using System.Collections.Generic;

namespace Pantus.Models;

public partial class TbService
{
    public int ServiceId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsActive { get; set; }

    public string? Icon { get; set; }
}
