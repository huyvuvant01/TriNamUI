// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SchedulerEditableSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.RegularExpressions;


#nullable enable
namespace Kendo.Mvc.UI
{
  public class SchedulerEditableSettings<T> : SchedulerEditableSettingsBase
    where T : 
    #nullable disable
    class
  {
    private const string DefaultConfirmation = "Are you sure you want to delete this event?";

    public SchedulerEditableSettings()
    {
      this.DisplayDeleteConfirmation = true;
      this.Confirmation = Messages.Scheduler_Confirmation;
      this.DefaultDataItem = new Func<T>(this.CreateDefaultItem);
      this.Resize = true;
      this.Move = true;
    }

    public HtmlEncoder HtmlEncoder { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public string Confirmation { get; set; }

    public bool Resize { get; set; }

    public bool DisplayDeleteConfirmation { get; set; }

    public bool Move { get; set; }

    public SchedulerEditRecurringMode EditRecurringMode { get; set; }

    public string TemplateName { get; set; }

    protected string EditorHtml { get; set; }

    public Window PopUp { get; set; }

    public object AdditionalViewData { get; set; }

    private IDictionary<string, object> SerializePopUp()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.PopUp.Title == null)
      {
        string editorEditorTitle = Messages.Scheduler_Editor_EditorTitle;
      }
      if ((string) this.PopUp.Title != Messages.Scheduler_Editor_EditorTitle)
        dictionary["title"] = this.PopUp.Title;
      if (this.PopUp.ResizingSettings.Enabled)
        dictionary["resizable"] = (object) this.PopUp.ResizingSettings.Enabled;
      if (this.PopUp.ResizingSettings.MaxHeight != null)
        dictionary["maxHeight"] = (object) this.PopUp.ResizingSettings.MaxHeight;
      if (this.PopUp.ResizingSettings.MinHeight != null)
        dictionary["minHeight"] = (object) this.PopUp.ResizingSettings.MinHeight;
      if (this.PopUp.ResizingSettings.MaxWidth != null)
        dictionary["maxWidth"] = (object) this.PopUp.ResizingSettings.MaxWidth;
      if (this.PopUp.ResizingSettings.MinWidth != null)
        dictionary["minWidth"] = (object) this.PopUp.ResizingSettings.MinWidth;
      if (!string.IsNullOrEmpty(this.PopUp.Width))
        dictionary["width"] = (object) this.PopUp.Width;
      if (!string.IsNullOrEmpty(this.PopUp.Height))
        dictionary["height"] = (object) this.PopUp.Height;
      return (IDictionary<string, object>) dictionary;
    }

    protected override void Serialize(IDictionary<string, object> json)
    {
      base.Serialize(json);
      if (!string.IsNullOrEmpty(this.Template))
        json["template"] = (object) this.Template;
      if (!string.IsNullOrEmpty(this.TemplateId))
      {
        string str = "#";
        json["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("kendo.template(jQuery('{0}{1}').html())", (object) str, (object) this.TemplateId)
        };
      }
      this.SerializeEditTemplate(json);
      if (!this.DisplayDeleteConfirmation)
        json["confirmation"] = (object) false;
      else if (!string.IsNullOrEmpty(this.Confirmation) && this.Confirmation != "Are you sure you want to delete this event?")
        json["confirmation"] = (object) this.Confirmation;
      if (!this.Resize)
        json["resize"] = (object) false;
      if (!this.Move)
        json["move"] = (object) false;
      IDictionary<string, object> dictionary = this.SerializePopUp();
      if (dictionary.Count > 0)
        json["window"] = (object) dictionary;
      string str1 = this.EditRecurringMode.ToString();
      json["editRecurringMode"] = (object) (char.ToLowerInvariant(str1[0]).ToString() + str1.Substring(1));
    }

    private void SerializeEditTemplate(IDictionary<string, object> options)
    {
      if (!this.Enabled || string.IsNullOrEmpty(this.EditorHtml))
        return;
      string str = this.EditorHtml.Trim().EscapeHtmlEntities().Replace("\r\n", string.Empty).Replace("</script>", "<\\/script>").Replace("jQuery(\"#", "jQuery(\"\\#");
      options["template"] = (object) str;
    }

    public void InitializeEditor(
      ViewContext viewContext,
      IModelMetadataProvider ModelMetadataProvider)
    {
      if (!this.Enabled || !this.TemplateName.HasValue())
        return;
      Regex regex = new Regex("(?<=data-val-regex-pattern=\")([^\"]*)", RegexOptions.Multiline);
      ViewContext viewContext1 = viewContext.ViewContextForType<T>(ModelMetadataProvider);
      HtmlHelper<T> htmlHelper = viewContext.CreateHtmlHelper<T>();
      htmlHelper.Contextualize(viewContext1);
      IHtmlContent htmlContent = htmlHelper.EditorForModel(this.TemplateName, this.AdditionalViewData);
      StringBuilder sb = new StringBuilder();
      using (StringWriter stringWriter = new StringWriter(sb))
        htmlContent.WriteTo((TextWriter) stringWriter, this.HtmlEncoder);
      this.EditorHtml = regex.Replace(sb.ToString(), (MatchEvaluator) (match => match.Groups[0].Value.Replace("\\", "\\\\")));
    }

    public Func<T> DefaultDataItem { get; set; }

    private T CreateDefaultItem() => Activator.CreateInstance<T>();
  }
}
