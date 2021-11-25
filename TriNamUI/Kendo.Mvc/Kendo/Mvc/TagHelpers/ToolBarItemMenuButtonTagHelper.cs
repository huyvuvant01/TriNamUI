// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ToolBarItemMenuButtonTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
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
  [HtmlTargetElement("toolbar-button", ParentTag = "menu-buttons", TagStructure = TagStructure.NormalOrSelfClosing)]
  [OutputElementHint("div")]
  [SuppressTagRendering]
  public class ToolBarItemMenuButtonTagHelper : TagHelperCollectionItemBase
  {
    private 
    #nullable disable
    Dictionary<string, object> _attributesDictionary { get; set; }

    private object _attributesObject { get; set; }

    public object HtmlAttributes
    {
      set
      {
        if (ToolBarItemMenuButtonTagHelper.\u003C\u003Eo__9.\u003C\u003Ep__2 == null)
          ToolBarItemMenuButtonTagHelper.\u003C\u003Eo__9.\u003C\u003Ep__2 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof (ToolBarItemMenuButtonTagHelper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
          }));
        Func<CallSite, object, bool> target1 = ToolBarItemMenuButtonTagHelper.\u003C\u003Eo__9.\u003C\u003Ep__2.Target;
        CallSite<Func<CallSite, object, bool>> p2 = ToolBarItemMenuButtonTagHelper.\u003C\u003Eo__9.\u003C\u003Ep__2;
        if (ToolBarItemMenuButtonTagHelper.\u003C\u003Eo__9.\u003C\u003Ep__1 == null)
          ToolBarItemMenuButtonTagHelper.\u003C\u003Eo__9.\u003C\u003Ep__1 = CallSite<Func<CallSite, object, Type, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof (ToolBarItemMenuButtonTagHelper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
          }));
        Func<CallSite, object, Type, object> target2 = ToolBarItemMenuButtonTagHelper.\u003C\u003Eo__9.\u003C\u003Ep__1.Target;
        CallSite<Func<CallSite, object, Type, object>> p1 = ToolBarItemMenuButtonTagHelper.\u003C\u003Eo__9.\u003C\u003Ep__1;
        if (ToolBarItemMenuButtonTagHelper.\u003C\u003Eo__9.\u003C\u003Ep__0 == null)
          ToolBarItemMenuButtonTagHelper.\u003C\u003Eo__9.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "GetType", (IEnumerable<Type>) null, typeof (ToolBarItemMenuButtonTagHelper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
          }));
        object obj1 = ToolBarItemMenuButtonTagHelper.\u003C\u003Eo__9.\u003C\u003Ep__0.Target((CallSite) ToolBarItemMenuButtonTagHelper.\u003C\u003Eo__9.\u003C\u003Ep__0, value);
        Type type = typeof (Dictionary<string, object>);
        object obj2 = target2((CallSite) p1, obj1, type);
        if (target1((CallSite) p2, obj2))
        {
          if (ToolBarItemMenuButtonTagHelper.\u003C\u003Eo__9.\u003C\u003Ep__3 == null)
            ToolBarItemMenuButtonTagHelper.\u003C\u003Eo__9.\u003C\u003Ep__3 = CallSite<Func<CallSite, object, Dictionary<string, object>>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (Dictionary<string, object>), typeof (ToolBarItemMenuButtonTagHelper)));
          this._attributesDictionary = ToolBarItemMenuButtonTagHelper.\u003C\u003Eo__9.\u003C\u003Ep__3.Target((CallSite) ToolBarItemMenuButtonTagHelper.\u003C\u003Eo__9.\u003C\u003Ep__3, value);
        }
        else
          this._attributesObject = value;
      }
      get => this._attributesDictionary != null ? (object) this._attributesDictionary : this._attributesObject;
    }

    [HtmlAttributeNotBound]
    private Dictionary<string, string> Attributes { get; set; }

    public ToolBarItemMenuButtonTagHelper() => this.Attributes = new Dictionary<string, string>();

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      ToolBarItemMenuButtonTagHelper menuButtonTagHelper = this;
      // ISSUE: reference to a compiler-generated method
      await menuButtonTagHelper.\u003C\u003En__0(context, output);
      if (output.Attributes.Count <= 0)
        return;
      // ISSUE: reference to a compiler-generated method
      output.Attributes.ToList<TagHelperAttribute>().ForEach(new Action<TagHelperAttribute>(menuButtonTagHelper.\u003CProcessAsync\u003Eb__16_0));
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ToolBarItemMenuButtonsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ToolBarItemMenuButtonsTagHelper).Add(this);
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
      return dictionary;
    }

    public bool? Enable { get; set; }

    public bool? Hidden { get; set; }

    public string Icon { get; set; }

    public string Id { get; set; }

    public string ImageUrl { get; set; }

    public string SpriteCssClass { get; set; }

    public string Text { get; set; }

    public string Url { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Enable.HasValue)
        dictionary["enable"] = (object) this.Enable;
      if (this.Hidden.HasValue)
        dictionary["hidden"] = (object) this.Hidden;
      string icon = this.Icon;
      if ((icon != null ? (icon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["icon"] = (object) this.Icon;
      string id = this.Id;
      if ((id != null ? (id.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["id"] = (object) this.Id;
      string imageUrl = this.ImageUrl;
      if ((imageUrl != null ? (imageUrl.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["imageUrl"] = (object) this.ImageUrl;
      string spriteCssClass = this.SpriteCssClass;
      if ((spriteCssClass != null ? (spriteCssClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["spriteCssClass"] = (object) this.SpriteCssClass;
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["text"] = (object) this.Text;
      string url = this.Url;
      if ((url != null ? (url.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["url"] = (object) this.Url;
      return dictionary;
    }
  }
}
