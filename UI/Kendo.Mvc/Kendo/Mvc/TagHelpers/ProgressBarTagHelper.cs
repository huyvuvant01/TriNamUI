// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ProgressBarTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-progressbar")]
  [OutputElementHint("div")]
  public class ProgressBarTagHelper : TagHelperBase
  {
    public double? AnimationDuration { get; set; }

    public bool? Animation { get; set; }

    public bool? ProgressbarAriaRole { get; set; }

    public ProgressBarTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      ProgressBarTagHelper progressBarTagHelper = this;
      context.Items[(object) progressBarTagHelper.GetType()] = (object) progressBarTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await progressBarTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.TagMode = TagMode.StartTagAndEndTag;
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Animation.HasValue)
        dictionary["animation"] = (object) this.Animation;
      bool? nullable;
      int num;
      if (!this.Animation.HasValue)
      {
        num = 1;
      }
      else
      {
        nullable = this.Animation;
        num = nullable.Value ? 1 : 0;
      }
      if (num != 0 && this.AnimationDuration.HasValue)
        dictionary["animation"] = (object) new Dictionary<string, object>()
        {
          {
            "duration",
            (object) this.AnimationDuration
          }
        };
      nullable = this.ProgressbarAriaRole;
      if (nullable.HasValue)
        dictionary["ariaRole"] = (object) this.ProgressbarAriaRole;
      return this.Initializer.Initialize(this.Selector, "ProgressBar", (IDictionary<string, object>) dictionary);
    }

    public string OnChange { get; set; }

    public string OnComplete { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      string onComplete = this.OnComplete;
      if ((onComplete != null ? (onComplete.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["complete"] = (object) this.CreateHandler(this.OnComplete);
      return dictionary;
    }

    public double? ChunkCount { get; set; }

    public bool? Enable { get; set; }

    public string Label { get; set; }

    public string LabelId { get; set; }

    public double? Max { get; set; }

    public double? Min { get; set; }

    public bool? Reverse { get; set; }

    public bool? ShowStatus { get; set; }

    public double? Value { get; set; }

    public ProgressBarOrientation? Orientation { get; set; }

    public ProgressBarType? Type { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.ChunkCount.HasValue)
        dictionary1["chunkCount"] = (object) this.ChunkCount;
      if (this.Enable.HasValue)
        dictionary1["enable"] = (object) this.Enable;
      string label = this.Label;
      if ((label != null ? (label.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["label"] = (object) this.Label;
      string labelId = this.LabelId;
      if ((labelId != null ? (labelId.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["labelId"] = (object) this.LabelId;
      if (this.Max.HasValue)
        dictionary1["max"] = (object) this.Max;
      if (this.Min.HasValue)
        dictionary1["min"] = (object) this.Min;
      if (this.Reverse.HasValue)
        dictionary1["reverse"] = (object) this.Reverse;
      if (this.ShowStatus.HasValue)
        dictionary1["showStatus"] = (object) this.ShowStatus;
      if (this.Value.HasValue)
        dictionary1["value"] = (object) this.Value;
      if (this.Orientation.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        ProgressBarOrientation? orientation = this.Orientation;
        ref ProgressBarOrientation? local = ref orientation;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["orientation"] = (object) str;
      }
      if (this.Type.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        ProgressBarType? type = this.Type;
        ref ProgressBarType? local = ref type;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["type"] = (object) str;
      }
      return dictionary1;
    }
  }
}
