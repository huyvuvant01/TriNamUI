// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PDFViewerToolbarSettingsItemTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("pdfviewer-toolbar-item", ParentTag = "pdfviewer-toolbar-items", TagStructure = TagStructure.NormalOrSelfClosing)]
  [SuppressTagRendering]
  public class PDFViewerToolbarSettingsItemTagHelper : TagHelperCollectionItemBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      System.Type type = typeof (PDFViewerToolbarSettingsItemsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as PDFViewerToolbarSettingsItemsTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Type { get; set; }

    public string Overflow { get; set; }

    public string Command { get; set; }

    public string Name { get; set; }

    public string Click { get; set; }

    public string Toggle { get; set; }

    public bool? Togglable { get; set; }

    public string Text { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public string ShowText { get; set; }

    public bool? Primary { get; set; }

    public IDictionary<string, object> HtmlAttributes { get; set; }

    public bool? Enable { get; set; }

    public bool? Hidden { get; set; }

    public string SpriteCssClass { get; set; }

    public string ImageUrl { get; set; }

    public string ShowIcon { get; set; }

    public string Icon { get; set; }

    public string Id { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["type"] = (object) this.Type;
      string overflow = this.Overflow;
      if ((overflow != null ? (overflow.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["overflow"] = (object) this.Overflow;
      string command = this.Command;
      if ((command != null ? (command.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["command"] = (object) this.Command;
      string name = this.Name;
      if ((name != null ? (name.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["name"] = (object) this.Name;
      string click = this.Click;
      if ((click != null ? (click.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["click"] = (object) this.CreateHandler(this.Click);
      string toggle = this.Toggle;
      if ((toggle != null ? (toggle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["toggle"] = (object) this.CreateHandler(this.Toggle);
      bool? nullable = this.Togglable;
      if (nullable.HasValue)
        dictionary["togglable"] = (object) this.Togglable;
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["text"] = (object) this.Text;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      string showText = this.ShowText;
      if ((showText != null ? (showText.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["showText"] = (object) this.ShowText;
      nullable = this.Primary;
      if (nullable.HasValue)
        dictionary["primary"] = (object) this.Primary;
      IDictionary<string, object> htmlAttributes = this.HtmlAttributes;
      if ((htmlAttributes != null ? (htmlAttributes.Any<KeyValuePair<string, object>>() ? 1 : 0) : 0) != 0)
        dictionary["attributes"] = (object) this.HtmlAttributes;
      nullable = this.Enable;
      if (nullable.HasValue)
        dictionary["enable"] = (object) this.Enable;
      nullable = this.Hidden;
      if (nullable.HasValue)
        dictionary["hidden"] = (object) this.Hidden;
      string spriteCssClass = this.SpriteCssClass;
      if ((spriteCssClass != null ? (spriteCssClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["spriteCssClass"] = (object) this.SpriteCssClass;
      string imageUrl = this.ImageUrl;
      if ((imageUrl != null ? (imageUrl.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["imageUrl"] = (object) this.ImageUrl;
      string showIcon = this.ShowIcon;
      if ((showIcon != null ? (showIcon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["showIcon"] = (object) this.ShowIcon;
      string icon = this.Icon;
      if ((icon != null ? (icon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["icon"] = (object) this.Icon;
      string id = this.Id;
      if ((id != null ? (id.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["id"] = (object) this.Id;
      return dictionary;
    }
  }
}
