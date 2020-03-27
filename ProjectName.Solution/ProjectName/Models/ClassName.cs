using System;
using System.Collections.Generic;

namespace ProjectName.Models
{
  public class ClassName
  {
    public int ClassNameId { get; set; }
    public ICollection<ParentChildClassName> ParentClassesName { get; set; }

    public ClassName()
    {
      this.ParentClassesName = new HashSet<ParentChildClassName>();
    }

  }
}
