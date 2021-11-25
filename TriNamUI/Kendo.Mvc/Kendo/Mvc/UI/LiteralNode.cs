// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.LiteralNode
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;

namespace Kendo.Mvc.UI
{
  public class LiteralNode : IHtmlNode
  {
    public LiteralNode(string content) => this.Content = (IHtmlContent) new HtmlString(content);

    public IHtmlContent Content { get; set; }

    public IList<IHtmlNode> Children => throw new NotImplementedException();

    public IHtmlContentBuilder InnerHtml => throw new NotImplementedException();

    public TagRenderMode RenderMode => throw new NotImplementedException();

    public string TagName => throw new NotImplementedException();

    public IHtmlNode AddClass(params string[] classes) => throw new NotImplementedException();

    public IHtmlNode AppendTo(IHtmlNode parent)
    {
      parent.Children.Add((IHtmlNode) this);
      return (IHtmlNode) this;
    }

    public void WriteTo(TextWriter output, HtmlEncoder encoder) => this.Content.WriteTo(output, encoder);

    public string Attribute(string key) => throw new NotImplementedException();

    public IHtmlNode Attribute(string key, string value) => throw new NotImplementedException();

    public IHtmlNode Attribute(string key, string value, bool replaceExisting) => throw new NotImplementedException();

    public AttributeDictionary Attributes() => throw new NotImplementedException();

    public IHtmlNode Attributes(object attributes) => throw new NotImplementedException();

    public IHtmlNode Attributes<TKey, TValue>(IDictionary<TKey, TValue> attributes) => throw new NotImplementedException();

    public IHtmlNode Attributes<TKey, TValue>(
      IDictionary<TKey, TValue> attributes,
      bool replaceExisting)
    {
      throw new NotImplementedException();
    }

    public IHtmlNode Css(string key, string value) => throw new NotImplementedException();

    public IHtmlNode Html(string value) => throw new NotImplementedException();

    public IHtmlNode PrependClass(params string[] classes) => throw new NotImplementedException();

    public IHtmlNode RemoveAttribute(string key) => throw new NotImplementedException();

    public Action<TextWriter> Template() => throw new NotImplementedException();

    public IHtmlNode Template(Action<TextWriter> value) => throw new NotImplementedException();

    public IHtmlNode Text(string value) => throw new NotImplementedException();

    public IHtmlNode ToggleAttribute(string key, string value, bool condition) => throw new NotImplementedException();

    public IHtmlNode ToggleClass(string @class, bool condition) => throw new NotImplementedException();

    public IHtmlNode ToggleCss(string key, string value, bool condition) => throw new NotImplementedException();
  }
}
