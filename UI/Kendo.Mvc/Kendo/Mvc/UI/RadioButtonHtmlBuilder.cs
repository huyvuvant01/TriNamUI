// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.RadioButtonHtmlBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;

namespace Kendo.Mvc.UI
{
  public class RadioButtonHtmlBuilder
  {
    public RadioButtonHtmlBuilder(RadioButton component, IKendoHtmlGenerator generator)
    {
      this.Component = component;
      this.Generator = generator;
    }

    public RadioButton Component { get; private set; }

    public IKendoHtmlGenerator Generator { get; private set; }

    public virtual void WriteHtml(TextWriter writer, HtmlEncoder htmlEncoder)
    {
      this.BuildRadioButton().WriteTo(writer, htmlEncoder);
      this.BuildLabel().WriteTo(writer, htmlEncoder);
    }

    protected virtual TagBuilder BuildRadioButton()
    {
      string str = this.Component.Value != null ? this.Component.Value.ToString() : string.Empty;
      TagBuilder radioInput = this.Generator.GenerateRadioInput(this.Component.ViewContext, this.GetModelExplorer(), this.RenderId(), this.Component.Name, (object) str, string.Empty, this.Component.HtmlAttributes);
      radioInput.AddCssClass("k-radio");
      bool? enabled = this.Component.Checked;
      bool flag1 = true;
      if (enabled.GetValueOrDefault() == flag1 & enabled.HasValue || this.IsCheckedFromModel())
        radioInput.MergeAttribute("checked", "checked");
      enabled = this.Component.Enabled;
      bool flag2 = false;
      if (enabled.GetValueOrDefault() == flag2 & enabled.HasValue)
        radioInput.MergeAttribute("disabled", "disabled");
      return radioInput;
    }

    protected virtual TagBuilder BuildLabel()
    {
      ModelMetadata modelMetaData = this.GetModelMetaData();
      string str = modelMetaData != null ? modelMetaData.DisplayName : string.Empty;
      TagBuilder tag = this.Generator.GenerateTag("label", (IDictionary<string, object>) new Dictionary<string, object>()
      {
        {
          "for",
          (object) this.RenderId()
        }
      });
      tag.AddCssClass("k-radio-label");
      if (!string.IsNullOrEmpty(this.Component.Label) || !string.IsNullOrEmpty(str))
        tag.InnerHtml.Append(this.Component.Label ?? str);
      return tag;
    }

    protected virtual bool IsCheckedFromModel()
    {
      string str1 = "";
      ModelStateEntry modelStateEntry;
      if (this.Component.ViewContext.ViewData.ModelState.TryGetValue(this.Component.Name, out modelStateEntry) && modelStateEntry.RawValue != null)
      {
        str1 = modelStateEntry.RawValue as string;
      }
      else
      {
        object obj = this.Component.Name.HasValue() ? this.Component.ViewContext.ViewData.Eval(this.Component.Name) : (object) null;
        if (obj != null && (obj.GetType().IsPredefinedType() || obj.GetType().IsEnumType()))
          str1 = obj.ToString();
      }
      string str2 = this.Component.Value != null ? this.Component.Value.ToString() : string.Empty;
      return str1.HasValue() && str1 == str2;
    }

    protected virtual ModelExplorer GetModelExplorer() => ExpressionMetadataProvider.FromStringExpression(this.Component.Name, this.Component.ViewContext.ViewData, this.Component.ModelMetadataProvider);

    protected virtual ModelMetadata GetModelMetaData() => this.GetModelExplorer().Metadata;

    private string RenderId() => this.Component.Value == null ? this.Component.Id : this.Component.Id + "_" + this.Component.Value.ToString();
  }
}
