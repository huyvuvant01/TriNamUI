// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.CheckBoxHtmlBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;

namespace Kendo.Mvc.UI
{
  public class CheckBoxHtmlBuilder
  {
    public CheckBoxHtmlBuilder(CheckBox checkBox, IKendoHtmlGenerator generator)
    {
      this.Component = checkBox;
      this.Generator = generator;
    }

    public CheckBox Component { get; private set; }

    public IKendoHtmlGenerator Generator { get; private set; }

    public virtual void WriteHtml(TextWriter writer, HtmlEncoder htmlEncoder)
    {
      this.BuildCheckBox().WriteTo(writer, htmlEncoder);
      this.BuildLabel().WriteTo(writer, htmlEncoder);
      this.BuildHiddenInput().WriteTo(writer, htmlEncoder);
    }

    protected virtual TagBuilder BuildCheckBox()
    {
      TagBuilder input = this.Generator.GenerateInput(this.Component.ViewContext, this.GetModelExplorer(), this.Component.Id, this.Component.Name, (object) "true", string.Empty, "checkbox", this.Component.HtmlAttributes);
      input.AddCssClass("k-checkbox");
      bool? enabled = this.Component.Enabled;
      bool flag1 = false;
      if (enabled.GetValueOrDefault() == flag1 & enabled.HasValue)
      {
        input.MergeAttribute("disabled", "disabled");
        input.AddCssClass("k-state-disabled");
      }
      bool? nullable = this.Component.Checked;
      bool flag2 = true;
      if (nullable.GetValueOrDefault() == flag2 & nullable.HasValue)
        input.MergeAttribute("checked", "checked");
      return input;
    }

    protected virtual TagBuilder BuildLabel()
    {
      ModelMetadata modelMetaData = this.GetModelMetaData();
      string str = modelMetaData != null ? modelMetaData.DisplayName : string.Empty;
      TagBuilder tag = this.Generator.GenerateTag("label", (IDictionary<string, object>) new Dictionary<string, object>()
      {
        {
          "for",
          (object) this.Component.Id
        }
      });
      tag.AddCssClass("k-checkbox-label");
      if (!string.IsNullOrEmpty(this.Component.Label) || !string.IsNullOrEmpty(str))
        tag.InnerHtml.Append(this.Component.Label ?? str);
      return tag;
    }

    protected virtual TagBuilder BuildHiddenInput() => this.Generator.GenerateHiddenForCheckbox(this.Component.ViewContext, this.Component.Name, this.Component.HtmlAttributes);

    protected virtual ModelExplorer GetModelExplorer() => ExpressionMetadataProvider.FromStringExpression(this.Component.Name, this.Component.ViewContext.ViewData, this.Component.ModelMetadataProvider);

    protected virtual ModelMetadata GetModelMetaData() => this.GetModelExplorer().Metadata;
  }
}
