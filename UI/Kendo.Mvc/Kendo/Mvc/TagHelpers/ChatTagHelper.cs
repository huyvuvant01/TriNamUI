// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChatTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-chat")]
  [RestrictChildren("messages", new string[] {"user", "toolbar"})]
  [OutputElementHint("div")]
  public class ChatTagHelper : TagHelperBase
  {
    public ChatTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      ChatTagHelper chatTagHelper = this;
      context.Items[(object) chatTagHelper.GetType()] = (object) chatTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await chatTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "Chat", (IDictionary<string, object>) this.SerializeSettings());

    public string OnActionClick { get; set; }

    public string OnPost { get; set; }

    public string OnSendMessage { get; set; }

    public string OnTypingEnd { get; set; }

    public string OnTypingStart { get; set; }

    public string OnToolClick { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onActionClick = this.OnActionClick;
      if ((onActionClick != null ? (onActionClick.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["actionClick"] = (object) this.CreateHandler(this.OnActionClick);
      string onPost = this.OnPost;
      if ((onPost != null ? (onPost.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["post"] = (object) this.CreateHandler(this.OnPost);
      string onSendMessage = this.OnSendMessage;
      if ((onSendMessage != null ? (onSendMessage.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["sendMessage"] = (object) this.CreateHandler(this.OnSendMessage);
      string onTypingEnd = this.OnTypingEnd;
      if ((onTypingEnd != null ? (onTypingEnd.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["typingEnd"] = (object) this.CreateHandler(this.OnTypingEnd);
      string onTypingStart = this.OnTypingStart;
      if ((onTypingStart != null ? (onTypingStart.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["typingStart"] = (object) this.CreateHandler(this.OnTypingStart);
      string onToolClick = this.OnToolClick;
      if ((onToolClick != null ? (onToolClick.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["toolClick"] = (object) this.CreateHandler(this.OnToolClick);
      return dictionary;
    }

    [HtmlAttributeNotBound]
    public ChatMessagesSettingsTagHelper Messages { get; set; }

    [HtmlAttributeNotBound]
    public ChatUserSettingsTagHelper User { get; set; }

    [HtmlAttributeNotBound]
    public ChatToolbarSettingsTagHelper Toolbar { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
      if (this.User != null)
      {
        Dictionary<string, object> source = this.User.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["user"] = (object) source;
      }
      if (this.Toolbar != null)
      {
        Dictionary<string, object> source = this.Toolbar.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["toolbar"] = (object) source;
      }
      return dictionary;
    }
  }
}
