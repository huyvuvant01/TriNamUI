// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ISchedulerView
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  public interface ISchedulerView
  {
    string Title { get; set; }

    SchedulerViewType Type { get; set; }

    SchedulerViewEditableSettings Editable { get; set; }

    string EventTemplate { get; set; }

    string EventTemplateId { get; set; }

    string SelectedDateFormat { get; set; }

    string SelectedShortDateFormat { get; set; }

    bool Selected { get; set; }

    SchedulerGroupSettings Group { get; set; }
  }
}
