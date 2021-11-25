// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Form.Fluent.FormItemFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;

namespace Kendo.Mvc.UI.Form.Fluent
{
  public class FormItemFactory<T>
  {
    private readonly ViewContext ViewContext;

    public FormItemFactory(List<FormItem> container, ViewContext viewContext)
    {
      this.Container = container;
      this.ViewContext = viewContext;
    }

    protected List<FormItem> Container { get; private set; }

    public virtual FormItemBuilder<T> Add()
    {
      FormItem container = new FormItem();
      this.Container.Add(container);
      return new FormItemBuilder<T>(container, this.ViewContext);
    }

    public virtual FormItemsContainerBuilder<T> AddGroup()
    {
      FormItem container = new FormItem();
      container.Type = "group";
      this.Container.Add(container);
      return new FormItemsContainerBuilder<T>(container, this.ViewContext);
    }

    public virtual FormItemsContainerBuilder<T> AddAntiForgeryToken(
      IHtmlContent antiForgeryToken)
    {
      string str;
      using (StringWriter stringWriter = new StringWriter())
      {
        antiForgeryToken.WriteTo((TextWriter) stringWriter, HtmlEncoder.Default);
        str = stringWriter.ToString();
      }
      FormItem container = new FormItem()
      {
        Field = "__RequestVerificationToken",
        EditorTemplate = str
      };
      this.Container.Add(container);
      return new FormItemsContainerBuilder<T>(container, this.ViewContext);
    }
  }
}
