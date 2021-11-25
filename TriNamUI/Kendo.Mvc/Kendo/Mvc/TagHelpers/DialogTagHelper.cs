// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DialogTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-dialog")]
  [RestrictChildren("actions", new string[] {"content", "popup-animation", "dialog-title", "modal"})]
  [OutputElementHint("div")]
  public class DialogTagHelper : TagHelperBase
  {
    [HtmlAttributeNotBound]
    public 
    #nullable disable
    DialogPopupAnimationSettingsTagHelper Animation { get; set; }

    [HtmlAttributeNotBound]
    public DialogTitleSettingsTagHelper TitleSettings { get; set; }

    public string Title { get; set; }

    public bool? Modal { get; set; }

    [HtmlAttributeNotBound]
    public DialogModalSettingsTagHelper ModalSettings { get; set; }

    public string Height { get; set; }

    public string MaxHeight { get; set; }

    public string MaxWidth { get; set; }

    public string MinHeight { get; set; }

    public string MinWidth { get; set; }

    public string Width { get; set; }

    public DialogTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      DialogTagHelper dialogTagHelper = this;
      context.Items[(object) dialogTagHelper.GetType()] = (object) dialogTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await dialogTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript()
    {
      Dictionary<string, object> dictionary1 = this.SerializeSettings();
      if (this.Animation != null)
      {
        Dictionary<string, object> source = this.Animation.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Animation.Enabled.HasValue || this.Animation.Enabled.Value))
          dictionary1["animation"] = (object) source;
        else if (this.Animation.Enabled.HasValue && !this.Animation.Enabled.Value)
          dictionary1["animation"] = (object) this.Animation.Enabled;
      }
      if (this.Title != null)
        dictionary1["title"] = (object) this.Title;
      else if (this.TitleSettings != null)
      {
        Dictionary<string, object> source = this.TitleSettings.SerializeSettings();
        if (this.TitleSettings.Enabled.HasValue && !this.TitleSettings.Enabled.Value)
          dictionary1["title"] = (object) this.TitleSettings.Enabled.Value;
        else if (source.Any<KeyValuePair<string, object>>())
          dictionary1["title"] = (object) this.TitleSettings.Text;
      }
      bool? nullable = this.Modal;
      bool flag = false;
      if (nullable.GetValueOrDefault() == flag & nullable.HasValue)
        dictionary1["modal"] = (object) this.Modal;
      else if (this.ModalSettings != null)
      {
        Dictionary<string, object> source = this.ModalSettings.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
        {
          nullable = this.ModalSettings.Enabled;
          if (nullable.HasValue)
          {
            nullable = this.ModalSettings.Enabled;
            if (!nullable.Value)
              goto label_19;
          }
          dictionary1["modal"] = (object) source;
          goto label_22;
        }
label_19:
        nullable = this.ModalSettings.Enabled;
        if (nullable.HasValue)
        {
          nullable = this.ModalSettings.Enabled;
          if (!nullable.Value)
          {
            Dictionary<string, object> dictionary2 = dictionary1;
            nullable = this.ModalSettings.Enabled;
            // ISSUE: variable of a boxed type
            __Boxed<bool> local = (ValueType) nullable.Value;
            dictionary2["modal"] = (object) local;
          }
        }
      }
label_22:
      if (!string.IsNullOrEmpty(this.Height))
        dictionary1["height"] = (object) this.Height;
      if (!string.IsNullOrEmpty(this.MaxHeight))
        dictionary1["maxHeight"] = (object) this.MaxHeight;
      if (!string.IsNullOrEmpty(this.MaxWidth))
        dictionary1["maxWidth"] = (object) this.MaxWidth;
      if (!string.IsNullOrEmpty(this.MinHeight))
        dictionary1["minHeight"] = (object) this.MinHeight;
      if (!string.IsNullOrEmpty(this.MinWidth))
        dictionary1["minWidth"] = (object) this.MinWidth;
      if (!string.IsNullOrEmpty(this.Width))
        dictionary1["width"] = (object) this.Width;
      return this.Initializer.Initialize(this.Selector, "Dialog", (IDictionary<string, object>) dictionary1);
    }

    public string OnClose { get; set; }

    public string OnHide { get; set; }

    public string OnInitOpen { get; set; }

    public string OnOpen { get; set; }

    public string OnShow { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onClose = this.OnClose;
      if ((onClose != null ? (onClose.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["close"] = (object) this.CreateHandler(this.OnClose);
      string onHide = this.OnHide;
      if ((onHide != null ? (onHide.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["hide"] = (object) this.CreateHandler(this.OnHide);
      string onInitOpen = this.OnInitOpen;
      if ((onInitOpen != null ? (onInitOpen.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["initOpen"] = (object) this.CreateHandler(this.OnInitOpen);
      string onOpen = this.OnOpen;
      if ((onOpen != null ? (onOpen.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["open"] = (object) this.CreateHandler(this.OnOpen);
      string onShow = this.OnShow;
      if ((onShow != null ? (onShow.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["show"] = (object) this.CreateHandler(this.OnShow);
      return dictionary;
    }

    [HtmlAttributeNotBound]
    public DialogActionsTagHelper Actions { get; set; }

    public string ButtonLayout { get; set; }

    public bool? Closable { get; set; }

    [HtmlAttributeNotBound]
    public DialogMessagesSettingsTagHelper Messages { get; set; }

    public bool? Visible { get; set; }

    public string Size { get; set; }

    public string Content { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Actions != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Actions.Select<DialogActionTagHelper, Dictionary<string, object>>((Func<DialogActionTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["actions"] = (object) source;
      }
      string buttonLayout = this.ButtonLayout;
      if ((buttonLayout != null ? (buttonLayout.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["buttonLayout"] = (object) this.ButtonLayout;
      if (this.Closable.HasValue)
        dictionary["closable"] = (object) this.Closable;
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
      if (this.Visible.HasValue)
        dictionary["visible"] = (object) this.Visible;
      string size = this.Size;
      if ((size != null ? (size.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["size"] = (object) this.Size;
      string content = this.Content;
      if ((content != null ? (content.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["content"] = (object) this.Content;
      return dictionary;
    }
  }
}
