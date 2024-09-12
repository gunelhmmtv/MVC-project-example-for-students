using System;
using System.Collections.Generic;

namespace MentorProject.Tables;

public partial class Order
{
    public int Id { get; set; }

    public int OrderNumber { get; set; }

    public DateTime OrderDate { get; set; }

    public int OrderTotalPrice { get; set; }
}
