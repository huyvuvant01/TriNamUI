// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DiagramEditableSettings`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class DiagramEditableSettings<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public string ShapeTemplateName { get; set; }

    public string ShapeEditorHtml { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      this.SerializeShapeEditTemplate((IDictionary<string, object>) dictionary);
      return dictionary;
    }

    private void SerializeShapeEditTemplate(IDictionary<string, object> options)
    {
      if (string.IsNullOrEmpty(this.ShapeEditorHtml))
        return;
      string str = this.ShapeEditorHtml.Trim().EscapeHtmlEntities().Replace("\r\n", string.Empty).Replace("jQuery(\"#", "jQuery(\"\\#");
      options["shapeTemplate"] = (object) str;
    }

    public string ConnectionTemplate { get; set; }

    public string ConnectionTemplateId { get; set; }

    public DiagramEditableDragSettings<TShapeModel, TConnectionModel> Drag { get; } = new DiagramEditableDragSettings<TShapeModel, TConnectionModel>();

    public bool? Remove { get; set; }

    public DiagramEditableResizeSettings<TShapeModel, TConnectionModel> Resize { get; } = new DiagramEditableResizeSettings<TShapeModel, TConnectionModel>();

    public DiagramEditableRotateSettings<TShapeModel, TConnectionModel> Rotate { get; } = new DiagramEditableRotateSettings<TShapeModel, TConnectionModel>();

    public string ShapeTemplate { get; set; }

    public string ShapeTemplateId { get; set; }

    public List<DiagramEditableSettingsTool<TShapeModel, TConnectionModel>> Tools { get; set; } = new List<DiagramEditableSettingsTool<TShapeModel, TConnectionModel>>();

    public bool? Enabled { get; set; }

    public Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel> Diagram { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.ConnectionTemplateId.HasValue())
        dictionary["connectionTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.Diagram.IdPrefix, (object) this.ConnectionTemplateId)
        };
      else if (this.ConnectionTemplate.HasValue())
        dictionary["connectionTemplate"] = (object) this.ConnectionTemplate;
      Dictionary<string, object> source1 = this.Drag.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["drag"] = (object) source1;
      else if (this.Drag.Enabled.HasValue)
        dictionary["drag"] = (object) this.Drag.Enabled;
      if (this.Remove.HasValue)
        dictionary["remove"] = (object) this.Remove;
      Dictionary<string, object> source2 = this.Resize.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["resize"] = (object) source2;
      else if (this.Resize.Enabled.HasValue)
        dictionary["resize"] = (object) this.Resize.Enabled;
      Dictionary<string, object> source3 = this.Rotate.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["rotate"] = (object) source3;
      else if (this.Rotate.Enabled.HasValue)
        dictionary["rotate"] = (object) this.Rotate.Enabled;
      if (this.ShapeTemplateId.HasValue())
        dictionary["shapeTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.Diagram.IdPrefix, (object) this.ShapeTemplateId)
        };
      else if (this.ShapeTemplate.HasValue())
        dictionary["shapeTemplate"] = (object) this.ShapeTemplate;
      IEnumerable<Dictionary<string, object>> source4 = this.Tools.Select<DiagramEditableSettingsTool<TShapeModel, TConnectionModel>, Dictionary<string, object>>((Func<DiagramEditableSettingsTool<TShapeModel, TConnectionModel>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source4.Any<Dictionary<string, object>>())
        dictionary["tools"] = (object) source4;
      return dictionary;
    }
  }
}
