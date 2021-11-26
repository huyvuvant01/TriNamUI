// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.StepperStep
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class StepperStep
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Enabled { get; set; }

    public bool? Error { get; set; }

    public string Icon { get; set; }

    public string IconTemplate { get; set; }

    public string IconTemplateId { get; set; }

    public string Label { get; set; }

    public bool? Selected { get; set; }

    public string SuccessIcon { get; set; }

    public Stepper Stepper { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Enabled.HasValue)
        dictionary["enabled"] = (object) this.Enabled;
      if (this.Error.HasValue)
        dictionary["error"] = (object) this.Error;
      string icon = this.Icon;
      if ((icon != null ? (icon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["icon"] = (object) this.Icon;
      if (this.IconTemplateId.HasValue())
        dictionary["iconTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.Stepper.IdPrefix, (object) this.IconTemplateId)
        };
      else if (this.IconTemplate.HasValue())
        dictionary["iconTemplate"] = (object) this.IconTemplate;
      string label = this.Label;
      if ((label != null ? (label.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["label"] = (object) this.Label;
      if (this.Selected.HasValue)
        dictionary["selected"] = (object) this.Selected;
      string successIcon = this.SuccessIcon;
      if ((successIcon != null ? (successIcon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["successIcon"] = (object) this.SuccessIcon;
      return dictionary;
    }
  }
}
