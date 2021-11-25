// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.IGroup
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections;
using System.Collections.ObjectModel;

namespace Kendo.Mvc.Infrastructure
{
  public interface IGroup
  {
    object Key { get; }

    IEnumerable Items { get; set; }

    bool HasSubgroups { get; }

    string Member { get; set; }

    int ItemCount { get; }

    ReadOnlyCollection<IGroup> Subgroups { get; }
  }
}
