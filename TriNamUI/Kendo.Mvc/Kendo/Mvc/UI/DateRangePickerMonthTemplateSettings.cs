// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DateRangePickerMonthTemplateSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class DateRangePickerMonthTemplateSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Empty { get; set; }

    public string EmptyId { get; set; }

    public string Content { get; set; }

    public string ContentId { get; set; }

    public string WeekNumber { get; set; }

    public string WeekNumberId { get; set; }

    public DateRangePicker DateRangePicker { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string empty = this.Empty;
      if ((empty != null ? (empty.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["empty"] = (object) this.Empty;
      string emptyId = this.EmptyId;
      if ((emptyId != null ? (emptyId.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["emptyId"] = (object) this.EmptyId;
      string content = this.Content;
      if ((content != null ? (content.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["content"] = (object) this.Content;
      string contentId = this.ContentId;
      if ((contentId != null ? (contentId.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["contentId"] = (object) this.ContentId;
      string weekNumber = this.WeekNumber;
      if ((weekNumber != null ? (weekNumber.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["weekNumber"] = (object) this.WeekNumber;
      string weekNumberId = this.WeekNumberId;
      if ((weekNumberId != null ? (weekNumberId.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["weekNumberId"] = (object) this.WeekNumberId;
      return dictionary;
    }
  }
}
