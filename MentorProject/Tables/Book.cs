using System;
using System.Collections.Generic;

namespace MentorProject.Tables;

public partial class Book
{
    public int Id { get; set; }

    public string BookName { get; set; } = null!;

    public int Price { get; set; }

    public bool InStock { get; set; }
}
