// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SchedulerCustomView
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class SchedulerCustomView : SchedulerViewBase
  {
    public SchedulerCustomView(string typeName, IScheduler scheduler)
      : base(SchedulerViewType.Custom, scheduler)
    {
      this.TypeName = typeName;
    }

    public string TypeName { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      base.Serialize(json);
      json["type"] = (object) this.TypeName;
    }
  }
}
