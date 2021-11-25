// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.HtmlTemplate
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI
{
  public class HtmlTemplate : HtmlTemplate<object>
  {
    private Action content;

    public Action Content
    {
      get => this.content;
      set
      {
        this.content = value;
        if (value != null)
          this.CodeBlockTemplate = (Action<object>) (_param1 => this.content());
        else
          this.CodeBlockTemplate = (Action<object>) null;
      }
    }

    public void Apply(IHtmlNode node) => this.Apply((object) null, node);
  }
}
