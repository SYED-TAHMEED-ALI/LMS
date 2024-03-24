using System;
using System.Collections.Generic;

namespace LMS.Models;

public partial class Library
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Title { get; set; }

    public string? Author { get; set; }

    public decimal? Price { get; set; }
}
