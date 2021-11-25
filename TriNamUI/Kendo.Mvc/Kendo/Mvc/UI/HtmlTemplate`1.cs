// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.HtmlTemplate`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.IO;
using System.Text.Encodings.Web;

namespace Kendo.Mvc.UI
{
  public class HtmlTemplate<T> where T : class
  {
    private string html;
    private Action<T> codeBlockTemplate;
    private Func<T, object> inlineTemplate;
    private Action<T, IHtmlNode> binder;

    public string Html
    {
      get => this.html;
      set
      {
        this.html = value;
        this.binder = (Action<T, IHtmlNode>) ((dataItem, node) => node.Html(this.html));
        this.codeBlockTemplate = (Action<T>) null;
        this.inlineTemplate = (Func<T, object>) null;
      }
    }

    public Action<T> CodeBlockTemplate
    {
      get => this.codeBlockTemplate;
      set
      {
        this.codeBlockTemplate = value;
        this.binder = (Action<T, IHtmlNode>) ((dataItem, node) => node.Template((Action<TextWriter>) (writer => this.CodeBlockTemplate(dataItem))));
        this.html = (string) null;
        this.inlineTemplate = (Func<T, object>) null;
      }
    }

    public Func<T, object> InlineTemplate
    {
      get => this.inlineTemplate;
      set
      {
        this.inlineTemplate = value;
        this.binder = (Action<T, IHtmlNode>) ((dataItem, node) => node.Template((Action<TextWriter>) (writer =>
        {
          object obj = this.InlineTemplate(dataItem);
          if (obj is HelperResult helperResult2)
          {
            helperResult2.WriteTo(writer, HtmlEncoder.Default);
          }
          else
          {
            if (obj == null)
              return;
            writer.Write(obj.ToString());
          }
        })));
        this.codeBlockTemplate = (Action<T>) null;
        this.html = (string) null;
      }
    }

    public void Apply(T dataItem, IHtmlNode node)
    {
      if (!this.HasValue())
        return;
      this.binder(dataItem, node);
    }

    public bool HasValue() => this.Html.HasValue() || this.InlineTemplate != null || this.CodeBlockTemplate != null;
  }
}
