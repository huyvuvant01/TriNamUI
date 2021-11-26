// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SwitchHtmlBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.IO;
using System.Text.Encodings.Web;

namespace Kendo.Mvc.UI
{
  public class SwitchHtmlBuilder
  {
    public SwitchHtmlBuilder(
      Switch switchInstance,
      IKendoHtmlGenerator generator,
      ModelExplorer explorer)
    {
      this.Component = switchInstance;
      this.Generator = generator;
      this.Explorer = explorer;
    }

    public Switch Component { get; private set; }

    public IKendoHtmlGenerator Generator { get; private set; }

    public ModelExplorer Explorer { get; set; }

    public virtual void WriteHtml(TextWriter writer, HtmlEncoder htmlEncoder)
    {
      this.BuildCheckBox().WriteTo(writer, htmlEncoder);
      this.BuildHiddenInput().WriteTo(writer, htmlEncoder);
    }

    protected virtual TagBuilder BuildCheckBox()
    {
      TagBuilder input = this.Generator.GenerateInput(this.Component.ViewContext, this.Explorer ?? this.GetModelExplorer(), this.Component.Id, this.Component.Name, (object) "true", string.Empty, "checkbox", this.Component.HtmlAttributes);
      bool? enabled = this.Component.Enabled;
      bool flag1 = false;
      if (enabled.GetValueOrDefault() == flag1 & enabled.HasValue)
        input.MergeAttribute("disabled", "disabled");
      enabled = this.Component.Checked;
      bool flag2 = true;
      if (enabled.GetValueOrDefault() == flag2 & enabled.HasValue)
        input.MergeAttribute("checked", "checked");
      return input;
    }

    protected virtual TagBuilder BuildHiddenInput() => this.Generator.GenerateHiddenForCheckbox(this.Component.ViewContext, this.Component.Name, this.Component.HtmlAttributes);

    protected virtual ModelExplorer GetModelExplorer() => ExpressionMetadataProvider.FromStringExpression(this.Component.Name, this.Component.ViewContext.ViewData, this.Component.ModelMetadataProvider);

    protected virtual ModelMetadata GetModelMetaData() => this.GetModelExplorer().Metadata;
  }
}
