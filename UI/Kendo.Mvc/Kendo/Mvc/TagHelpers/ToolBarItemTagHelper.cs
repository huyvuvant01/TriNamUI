// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ToolBarItemTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("item", ParentTag = "toolbar-items", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("buttons", new string[] {"menu-buttons"})]
  [OutputElementHint("div")]
  [SuppressTagRendering]
  public class ToolBarItemTagHelper : TagHelperCollectionItemBase
  {
    public 
    #nullable disable
    string Click { get; set; }

    public string Toggle { get; set; }

    private Dictionary<string, object> _attributesDictionary { get; set; }

    private object _attributesObject { get; set; }

    public object HtmlAttributes
    {
      set
      {
        if (ToolBarItemTagHelper.\u003C\u003Eo__17.\u003C\u003Ep__2 == null)
          ToolBarItemTagHelper.\u003C\u003Eo__17.\u003C\u003Ep__2 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof (ToolBarItemTagHelper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
          }));
        Func<CallSite, object, bool> target1 = ToolBarItemTagHelper.\u003C\u003Eo__17.\u003C\u003Ep__2.Target;
        CallSite<Func<CallSite, object, bool>> p2 = ToolBarItemTagHelper.\u003C\u003Eo__17.\u003C\u003Ep__2;
        if (ToolBarItemTagHelper.\u003C\u003Eo__17.\u003C\u003Ep__1 == null)
          ToolBarItemTagHelper.\u003C\u003Eo__17.\u003C\u003Ep__1 = CallSite<Func<CallSite, object, System.Type, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof (ToolBarItemTagHelper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
          }));
        Func<CallSite, object, System.Type, object> target2 = ToolBarItemTagHelper.\u003C\u003Eo__17.\u003C\u003Ep__1.Target;
        CallSite<Func<CallSite, object, System.Type, object>> p1 = ToolBarItemTagHelper.\u003C\u003Eo__17.\u003C\u003Ep__1;
        if (ToolBarItemTagHelper.\u003C\u003Eo__17.\u003C\u003Ep__0 == null)
          ToolBarItemTagHelper.\u003C\u003Eo__17.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "GetType", (IEnumerable<System.Type>) null, typeof (ToolBarItemTagHelper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
          }));
        object obj1 = ToolBarItemTagHelper.\u003C\u003Eo__17.\u003C\u003Ep__0.Target((CallSite) ToolBarItemTagHelper.\u003C\u003Eo__17.\u003C\u003Ep__0, value);
        System.Type type = typeof (Dictionary<string, object>);
        object obj2 = target2((CallSite) p1, obj1, type);
        if (target1((CallSite) p2, obj2))
        {
          if (ToolBarItemTagHelper.\u003C\u003Eo__17.\u003C\u003Ep__3 == null)
            ToolBarItemTagHelper.\u003C\u003Eo__17.\u003C\u003Ep__3 = CallSite<Func<CallSite, object, Dictionary<string, object>>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (Dictionary<string, object>), typeof (ToolBarItemTagHelper)));
          this._attributesDictionary = ToolBarItemTagHelper.\u003C\u003Eo__17.\u003C\u003Ep__3.Target((CallSite) ToolBarItemTagHelper.\u003C\u003Eo__17.\u003C\u003Ep__3, value);
        }
        else
          this._attributesObject = value;
      }
      get => this._attributesDictionary != null ? (object) this._attributesDictionary : this._attributesObject;
    }

    [HtmlAttributeNotBound]
    private Dictionary<string, string> Attributes { get; set; }

    public ToolBarItemTagHelper() => this.Attributes = new Dictionary<string, string>();

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      ToolBarItemTagHelper barItemTagHelper = this;
      // ISSUE: reference to a compiler-generated method
      await barItemTagHelper.\u003C\u003En__0(context, output);
      if (output.Attributes.Count <= 0)
        return;
      // ISSUE: reference to a compiler-generated method
      output.Attributes.ToList<TagHelperAttribute>().ForEach(new Action<TagHelperAttribute>(barItemTagHelper.\u003CProcessAsync\u003Eb__24_0));
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      System.Type type = typeof (ToolBarItemsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ToolBarItemsTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this._attributesObject != null)
        this._attributesObject.ToDictionary().ToList<KeyValuePair<string, object>>().ForEach((Action<KeyValuePair<string, object>>) (item =>
        {
          if (this.Attributes.ContainsKey(item.Key))
            return;
          this.Attributes.Add(item.Key, item.Value.ToString());
        }));
      if (this._attributesDictionary != null)
        this._attributesDictionary.ToList<KeyValuePair<string, object>>().ForEach((Action<KeyValuePair<string, object>>) (item =>
        {
          if (this.Attributes.ContainsKey(item.Key))
            return;
          this.Attributes.Add(item.Key, item.Value.ToString());
        }));
      dictionary["attributes"] = (object) this.Attributes;
      string click = this.Click;
      if ((click != null ? (click.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["click"] = (object) this.CreateHandler(this.Click);
      string toggle = this.Toggle;
      if ((toggle != null ? (toggle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["toggle"] = (object) this.CreateHandler(this.Toggle);
      return dictionary;
    }

    [HtmlAttributeNotBound]
    public ToolBarItemButtonsTagHelper Buttons { get; set; }

    public bool? Enable { get; set; }

    public string Group { get; set; }

    public bool? Hidden { get; set; }

    public string Icon { get; set; }

    public string Id { get; set; }

    public string ImageUrl { get; set; }

    [HtmlAttributeNotBound]
    public ToolBarItemMenuButtonsTagHelper MenuButtons { get; set; }

    public string OverflowTemplate { get; set; }

    public string OverflowTemplateId { get; set; }

    public bool? Primary { get; set; }

    public bool? Selected { get; set; }

    public string SpriteCssClass { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public string Text { get; set; }

    public bool? Togglable { get; set; }

    public string Url { get; set; }

    public CommandType? Type { get; set; }

    public ShowIn? ShowText { get; set; }

    public ShowIn? ShowIcon { get; set; }

    public ShowInOverflowPopup? Overflow { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      if (this.Buttons != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Buttons.Select<ToolBarItemButtonTagHelper, Dictionary<string, object>>((Func<ToolBarItemButtonTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary1["buttons"] = (object) source;
      }
      if (this.Enable.HasValue)
        dictionary1["enable"] = (object) this.Enable;
      string group = this.Group;
      if ((group != null ? (group.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["group"] = (object) this.Group;
      if (this.Hidden.HasValue)
        dictionary1["hidden"] = (object) this.Hidden;
      string icon = this.Icon;
      if ((icon != null ? (icon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["icon"] = (object) this.Icon;
      string id = this.Id;
      if ((id != null ? (id.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["id"] = (object) this.Id;
      string imageUrl = this.ImageUrl;
      if ((imageUrl != null ? (imageUrl.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["imageUrl"] = (object) this.ImageUrl;
      if (this.MenuButtons != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.MenuButtons.Select<ToolBarItemMenuButtonTagHelper, Dictionary<string, object>>((Func<ToolBarItemMenuButtonTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary1["menuButtons"] = (object) source;
      }
      if (this.OverflowTemplateId.HasValue())
        dictionary1["overflowTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.OverflowTemplateId)
        };
      else if (this.OverflowTemplate.HasValue())
        dictionary1["overflowTemplate"] = (object) this.OverflowTemplate;
      if (this.Primary.HasValue)
        dictionary1["primary"] = (object) this.Primary;
      if (this.Selected.HasValue)
        dictionary1["selected"] = (object) this.Selected;
      string spriteCssClass = this.SpriteCssClass;
      if ((spriteCssClass != null ? (spriteCssClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["spriteCssClass"] = (object) this.SpriteCssClass;
      if (this.TemplateId.HasValue())
        dictionary1["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary1["template"] = (object) this.Template;
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["text"] = (object) this.Text;
      if (this.Togglable.HasValue)
        dictionary1["togglable"] = (object) this.Togglable;
      string url = this.Url;
      if ((url != null ? (url.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["url"] = (object) this.Url;
      if (this.Type.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        CommandType? type = this.Type;
        ref CommandType? local = ref type;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["type"] = (object) str;
      }
      ShowIn? nullable;
      if (this.ShowText.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        nullable = this.ShowText;
        ref ShowIn? local = ref nullable;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["showText"] = (object) str;
      }
      nullable = this.ShowIcon;
      if (nullable.HasValue)
      {
        Dictionary<string, object> dictionary4 = dictionary1;
        nullable = this.ShowIcon;
        ref ShowIn? local = ref nullable;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary4["showIcon"] = (object) str;
      }
      if (this.Overflow.HasValue)
      {
        Dictionary<string, object> dictionary5 = dictionary1;
        ShowInOverflowPopup? overflow = this.Overflow;
        ref ShowInOverflowPopup? local = ref overflow;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary5["overflow"] = (object) str;
      }
      return dictionary1;
    }
  }
}
