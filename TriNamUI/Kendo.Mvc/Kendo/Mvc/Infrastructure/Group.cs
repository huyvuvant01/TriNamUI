// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Group
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;

namespace Kendo.Mvc.Infrastructure
{
  public class Group : IGroup
  {
    private ReadOnlyCollection<IGroup> subgroups;

    public bool HasSubgroups { get; set; }

    public int SubgroupCount { get; set; }

    public string Member { get; set; }

    public int ItemCount { get; set; }

    [IgnoreDataMember]
    public ReadOnlyCollection<IGroup> Subgroups
    {
      get
      {
        if (this.subgroups == null)
          this.InitializeSubgroups();
        return this.subgroups;
      }
    }

    private void InitializeSubgroups()
    {
      List<IGroup> groupList = new List<IGroup>();
      if (this.HasSubgroups)
        groupList.AddRange(this.Items.OfType<IGroup>());
      this.subgroups = new ReadOnlyCollection<IGroup>((IList<IGroup>) groupList);
    }

    public IEnumerable Items { get; set; }

    public object Key { get; set; }
  }
}
