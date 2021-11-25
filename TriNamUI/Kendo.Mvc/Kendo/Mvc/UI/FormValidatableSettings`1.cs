// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FormValidatableSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class FormValidatableSettings<T>
  {
    public FormValidatableSettings() => this.ValidationSummary = new FormValidationSummarySettings();

    public FormValidationSummarySettings ValidationSummary { get; set; }

    public bool? ValidateOnBlur { get; set; }

    public string ErrorTemplate { get; set; }

    public string ErrorTemplateId { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.ValidateOnBlur.HasValue)
        dictionary["validateOnBlur"] = (object) this.ValidateOnBlur;
      if (!string.IsNullOrEmpty(this.ErrorTemplateId))
        dictionary["errorTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('#{0}').html()", (object) this.ErrorTemplateId)
        };
      else if (!string.IsNullOrEmpty(this.ErrorTemplate))
        dictionary["errorTemplate"] = (object) this.ErrorTemplate;
      dictionary["validationSummary"] = !this.ValidationSummary.Enabled ? (object) false : (object) this.ValidationSummary.Serialize();
      return dictionary;
    }
  }
}
