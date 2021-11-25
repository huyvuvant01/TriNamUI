// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Pager
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class Pager : WidgetBase
  {
    public Pager(ViewContext viewContext)
      : base(viewContext)
    {
    }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.DataSourceId.HasValue())
        dictionary["dataSourceId"] = (object) this.DataSourceId;
      if (this.PageSizes != null && this.PageSizes.GetEnumerator().MoveNext())
        dictionary["pageSizes"] = (object) this.PageSizes;
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Pager), (IDictionary<string, object>) dictionary));
    }

    public string DataSourceId { get; set; }

    public IEnumerable PageSizes { get; set; }

    public string ARIATemplate { get; set; }

    public string ARIATemplateId { get; set; }

    public bool? AutoBind { get; set; }

    public double? ButtonCount { get; set; }

    public string SelectTemplate { get; set; }

    public string SelectTemplateId { get; set; }

    public string LinkTemplate { get; set; }

    public string LinkTemplateId { get; set; }

    public bool? Info { get; set; }

    public bool? Input { get; set; }

    public bool? Numeric { get; set; }

    public bool? PreviousNext { get; set; }

    public bool? Refresh { get; set; }

    public bool? Responsive { get; set; }

    public PagerMessagesSettings Messages { get; } = new PagerMessagesSettings();

    public bool? Navigatable { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.ARIATemplateId.HasValue())
        dictionary["ARIATemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.ARIATemplateId)
        };
      else if (this.ARIATemplate.HasValue())
        dictionary["ARIATemplate"] = (object) this.ARIATemplate;
      bool? nullable = this.AutoBind;
      if (nullable.HasValue)
        dictionary["autoBind"] = (object) this.AutoBind;
      if (this.ButtonCount.HasValue)
        dictionary["buttonCount"] = (object) this.ButtonCount;
      if (this.SelectTemplateId.HasValue())
        dictionary["selectTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.SelectTemplateId)
        };
      else if (this.SelectTemplate.HasValue())
        dictionary["selectTemplate"] = (object) this.SelectTemplate;
      if (this.LinkTemplateId.HasValue())
        dictionary["linkTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.LinkTemplateId)
        };
      else if (this.LinkTemplate.HasValue())
        dictionary["linkTemplate"] = (object) this.LinkTemplate;
      nullable = this.Info;
      if (nullable.HasValue)
        dictionary["info"] = (object) this.Info;
      nullable = this.Input;
      if (nullable.HasValue)
        dictionary["input"] = (object) this.Input;
      nullable = this.Numeric;
      if (nullable.HasValue)
        dictionary["numeric"] = (object) this.Numeric;
      nullable = this.PreviousNext;
      if (nullable.HasValue)
        dictionary["previousNext"] = (object) this.PreviousNext;
      nullable = this.Refresh;
      if (nullable.HasValue)
        dictionary["refresh"] = (object) this.Refresh;
      nullable = this.Responsive;
      if (nullable.HasValue)
        dictionary["responsive"] = (object) this.Responsive;
      Dictionary<string, object> source = this.Messages.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source;
      nullable = this.Navigatable;
      if (nullable.HasValue)
        dictionary["navigatable"] = (object) this.Navigatable;
      return dictionary;
    }
  }
}
