// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.MaskedTextBox
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class MaskedTextBox : WidgetBase, IFormEditor
  {
    public MaskedTextBox(ViewContext viewContext)
      : base(viewContext)
    {
    }

    public Dictionary<string, object> Rules { get; } = new Dictionary<string, object>();

    protected override void WriteHtml(TextWriter writer)
    {
      TagBuilder textInput = this.Generator.GenerateTextInput(this.ViewContext, this.Explorer ?? ExpressionMetadataProvider.FromStringExpression(this.Name, this.HtmlHelper.ViewData, this.HtmlHelper.MetadataProvider), this.Id, this.Name, (object) this.Value, string.Empty, this.HtmlAttributes);
      if (!this.Enable.GetValueOrDefault(true))
        textInput.MergeAttribute("disabled", "disabled");
      textInput.TagRenderMode = TagRenderMode.SelfClosing;
      textInput.WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public IDictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      dictionary["rules"] = (object) this.Rules;
      return (IDictionary<string, object>) dictionary;
    }

    public override void WriteInitializationScript(TextWriter writer) => writer.Write(this.Initializer.Initialize(this.Selector, nameof (MaskedTextBox), this.Serialize()));

    public bool? ClearPromptChar { get; set; }

    public string Culture { get; set; }

    public MaskedTextBoxLabelSettings Label { get; } = new MaskedTextBoxLabelSettings();

    public string Mask { get; set; }

    public string PromptChar { get; set; }

    public bool? UnmaskOnPost { get; set; }

    public string Value { get; set; }

    public bool? Enable { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.ClearPromptChar.HasValue)
        dictionary["clearPromptChar"] = (object) this.ClearPromptChar;
      string culture = this.Culture;
      if ((culture != null ? (culture.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["culture"] = (object) this.Culture;
      Dictionary<string, object> source = this.Label.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["label"] = (object) source;
      string mask = this.Mask;
      if ((mask != null ? (mask.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["mask"] = (object) this.Mask;
      string promptChar = this.PromptChar;
      if ((promptChar != null ? (promptChar.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["promptChar"] = (object) this.PromptChar;
      if (this.UnmaskOnPost.HasValue)
        dictionary["unmaskOnPost"] = (object) this.UnmaskOnPost;
      string str = this.Value;
      if ((str != null ? (str.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["value"] = (object) this.Value;
      if (this.Enable.HasValue)
        dictionary["enable"] = (object) this.Enable;
      return dictionary;
    }
  }
}
