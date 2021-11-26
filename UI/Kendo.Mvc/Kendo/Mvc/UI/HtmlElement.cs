// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.HtmlElement
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;

namespace Kendo.Mvc.UI
{
  public class HtmlElement : IHtmlNode
  {
    private readonly TagBuilder tagBuilder;

    public HtmlElement(string tagName)
      : this(tagName, TagRenderMode.Normal)
    {
    }

    public HtmlElement(string tagName, TagRenderMode renderMode)
    {
      this.tagBuilder = new TagBuilder(tagName);
      this.Children = (IList<IHtmlNode>) new List<IHtmlNode>();
      this.RenderMode = renderMode;
    }

    private Action<TextWriter> TemplateCallback { get; set; }

    public TagRenderMode RenderMode { get; private set; }

    public IList<IHtmlNode> Children { get; private set; }

    public IHtmlContentBuilder InnerHtml => this.tagBuilder.InnerHtml;

    public string TagName => this.tagBuilder.TagName;

    public IHtmlNode AddClass(params string[] classes)
    {
      foreach (string str1 in classes)
      {
        string str2;
        this.Attributes()["class"] = !this.Attributes().TryGetValue("class", out str2) ? str1 : str2 + " " + str1;
      }
      return (IHtmlNode) this;
    }

    public IHtmlNode AppendTo(IHtmlNode parent)
    {
      parent.Children.Add((IHtmlNode) this);
      return (IHtmlNode) this;
    }

    public string Attribute(string key) => this.Attributes()[key];

    public IHtmlNode Attribute(string key, string value) => this.Attribute(key, value, true);

    public IHtmlNode Attribute(string key, string value, bool replaceExisting)
    {
      this.tagBuilder.MergeAttribute(key, value, replaceExisting);
      return (IHtmlNode) this;
    }

    public AttributeDictionary Attributes() => this.tagBuilder.Attributes;

    public IHtmlNode Attributes(object attributes)
    {
      this.Attributes<string, object>(attributes.ToDictionary());
      return (IHtmlNode) this;
    }

    public IHtmlNode Attributes<TKey, TValue>(IDictionary<TKey, TValue> attributes) => this.Attributes<TKey, TValue>(attributes, true);

    public IHtmlNode Attributes<TKey, TValue>(
      IDictionary<TKey, TValue> attributes,
      bool replaceExisting)
    {
      this.tagBuilder.MergeAttributes<TKey, TValue>(attributes, replaceExisting);
      return (IHtmlNode) this;
    }

    public IHtmlNode Html(string value)
    {
      this.Children.Clear();
      this.Children.Add((IHtmlNode) new LiteralNode(value));
      return (IHtmlNode) this;
    }

    public IHtmlNode PrependClass(params string[] classes)
    {
      foreach (string str in ((IEnumerable<string>) classes).Reverse<string>())
        this.tagBuilder.AddCssClass(str);
      return (IHtmlNode) this;
    }

    public IHtmlNode RemoveAttribute(string key)
    {
      this.tagBuilder.Attributes.Remove(key);
      return (IHtmlNode) this;
    }

    public Action<TextWriter> Template() => this.TemplateCallback;

    public IHtmlNode Template(Action<TextWriter> value)
    {
      this.TemplateCallback = value;
      return (IHtmlNode) this;
    }

    public IHtmlNode Text(string value)
    {
      this.Children.Clear();
      this.tagBuilder.InnerHtml.SetContent(value);
      return (IHtmlNode) this;
    }

    public IHtmlNode ToggleAttribute(string key, string value, bool condition)
    {
      if (condition)
        this.Attribute(key, value);
      return (IHtmlNode) this;
    }

    public IHtmlNode ToggleClass(string @class, bool condition)
    {
      if (condition)
        this.AddClass(new string[1]{ @class });
      return (IHtmlNode) this;
    }

    public IHtmlNode Css(string key, string value)
    {
      string str;
      if (this.Attributes().TryGetValue("style", out str))
        this.Attributes()["style"] = str + ";" + key + ":" + value;
      else
        this.Attributes()["style"] = key + ":" + value;
      return (IHtmlNode) this;
    }

    public IHtmlNode ToggleCss(string key, string value, bool condition)
    {
      if (condition)
        this.Css(key, value);
      return (IHtmlNode) this;
    }

    public void WriteTo(TextWriter output, HtmlEncoder encoder)
    {
      this.tagBuilder.TagRenderMode = this.RenderMode != TagRenderMode.SelfClosing ? TagRenderMode.StartTag : TagRenderMode.SelfClosing;
      this.tagBuilder.WriteTo(output, encoder);
      if (this.RenderMode == TagRenderMode.SelfClosing)
        return;
      if (this.TemplateCallback != null)
        this.TemplateCallback(output);
      else if (this.Children.Any<IHtmlNode>())
        this.Children.Each<IHtmlNode>((Action<IHtmlNode>) (child => child.WriteTo(output, encoder)));
      else
        this.tagBuilder.InnerHtml.WriteTo(output, encoder);
      this.tagBuilder.TagRenderMode = TagRenderMode.EndTag;
      this.tagBuilder.WriteTo(output, encoder);
    }
  }
}
