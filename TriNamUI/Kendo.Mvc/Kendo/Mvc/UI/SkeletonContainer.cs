// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SkeletonContainer
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class SkeletonContainer : WidgetBase
  {
    public SkeletonContainer(ViewContext viewContext)
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
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (SkeletonContainer), (IDictionary<string, object>) dictionary));
    }

    public SkeletonContainerGridSettings Grid { get; } = new SkeletonContainerGridSettings();

    public string Height { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public string Width { get; set; }

    public SkeletonContainerAnimation? Animation { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      Dictionary<string, object> source = this.Grid.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary1["grid"] = (object) source;
      string height = this.Height;
      if ((height != null ? (height.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["height"] = (object) this.Height;
      if (this.TemplateId.HasValue())
        dictionary1["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary1["template"] = (object) this.Template;
      string width = this.Width;
      if ((width != null ? (width.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["width"] = (object) this.Width;
      SkeletonContainerAnimation? animation = this.Animation;
      if (animation.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        animation = this.Animation;
        ref SkeletonContainerAnimation? local = ref animation;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["animation"] = (object) str;
      }
      return dictionary1;
    }
  }
}
