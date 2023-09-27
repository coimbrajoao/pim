using System;
using System.Collections.Generic;

namespace Course;

public partial class Game
{
    public int Id { get; set; }

    public int? GenreId { get; set; }

    public string? GameName { get; set; }

   

    public virtual Genre? Genre { get; set; }
}
