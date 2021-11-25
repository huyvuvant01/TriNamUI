// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DatePickerMonthTemplateSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class DatePickerMonthTemplateSettings
  {
    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.ContentId.HasValue())
        dictionary["content"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.DatePicker.IdPrefix, (object) this.ContentId)
        };
      else if (this.Content.HasValue())
        dictionary["content"] = (object) this.Content;
      if (this.EmptyId.HasValue())
        dictionary["empty"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.DatePicker.IdPrefix, (object) this.EmptyId)
        };
      else if (this.Empty.HasValue())
        dictionary["empty"] = (object) this.Empty;
      if (this.WeekNumberId.HasValue())
        dictionary["weekNumber"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.DatePicker.IdPrefix, (object) this.WeekNumberId)
        };
      else if (this.WeekNumber.HasValue())
        dictionary["weekNumber"] = (object) this.WeekNumber;
      return dictionary;
    }

    public string Empty { get; set; }

    public string EmptyId { get; set; }

    public string Content { get; set; }

    public string ContentId { get; set; }

    public string WeekNumber { get; set; }

    public string WeekNumberId { get; set; }

    public DatePicker DatePicker { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings() => new Dictionary<string, object>();
  }
}
