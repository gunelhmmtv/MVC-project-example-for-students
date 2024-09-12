using System;
using System.Collections.Generic;

namespace MentorProject.Tables;

public partial class Writer
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public bool IsAlive { get; set; }
}
