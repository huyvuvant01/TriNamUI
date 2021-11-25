// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TaskBoardMessagesSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("messages", ParentTag = "kendo-taskboard", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class TaskBoardMessagesSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (TaskBoardTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as TaskBoardTagHelper).Messages = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Edit { get; set; }

    public string CreateNewCard { get; set; }

    public string Create { get; set; }

    public string Search { get; set; }

    public string PreviewCard { get; set; }

    public string AddCard { get; set; }

    public string EditCard { get; set; }

    public string DeleteCard { get; set; }

    public string AddColumn { get; set; }

    public string EditColumn { get; set; }

    public string DeleteColumn { get; set; }

    public string Close { get; set; }

    public string Cancel { get; set; }

    public string Delete { get; set; }

    public string SaveChanges { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public string NewColumn { get; set; }

    public string DeleteColumnConfirm { get; set; }

    public string DeleteCardConfirm { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string edit = this.Edit;
      if ((edit != null ? (edit.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["edit"] = (object) this.Edit;
      string createNewCard = this.CreateNewCard;
      if ((createNewCard != null ? (createNewCard.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["createNewCard"] = (object) this.CreateNewCard;
      string create = this.Create;
      if ((create != null ? (create.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["create"] = (object) this.Create;
      string search = this.Search;
      if ((search != null ? (search.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["search"] = (object) this.Search;
      string previewCard = this.PreviewCard;
      if ((previewCard != null ? (previewCard.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["previewCard"] = (object) this.PreviewCard;
      string addCard = this.AddCard;
      if ((addCard != null ? (addCard.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["addCard"] = (object) this.AddCard;
      string editCard = this.EditCard;
      if ((editCard != null ? (editCard.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["editCard"] = (object) this.EditCard;
      string deleteCard = this.DeleteCard;
      if ((deleteCard != null ? (deleteCard.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deleteCard"] = (object) this.DeleteCard;
      string addColumn = this.AddColumn;
      if ((addColumn != null ? (addColumn.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["addColumn"] = (object) this.AddColumn;
      string editColumn = this.EditColumn;
      if ((editColumn != null ? (editColumn.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["editColumn"] = (object) this.EditColumn;
      string deleteColumn = this.DeleteColumn;
      if ((deleteColumn != null ? (deleteColumn.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deleteColumn"] = (object) this.DeleteColumn;
      string close = this.Close;
      if ((close != null ? (close.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["close"] = (object) this.Close;
      string cancel = this.Cancel;
      if ((cancel != null ? (cancel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cancel"] = (object) this.Cancel;
      string delete = this.Delete;
      if ((delete != null ? (delete.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["delete"] = (object) this.Delete;
      string saveChanges = this.SaveChanges;
      if ((saveChanges != null ? (saveChanges.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["saveChanges"] = (object) this.SaveChanges;
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      string description = this.Description;
      if ((description != null ? (description.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["description"] = (object) this.Description;
      string newColumn = this.NewColumn;
      if ((newColumn != null ? (newColumn.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["newColumn"] = (object) this.NewColumn;
      string deleteColumnConfirm = this.DeleteColumnConfirm;
      if ((deleteColumnConfirm != null ? (deleteColumnConfirm.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deleteColumnConfirm"] = (object) this.DeleteColumnConfirm;
      string deleteCardConfirm = this.DeleteCardConfirm;
      if ((deleteCardConfirm != null ? (deleteCardConfirm.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deleteCardConfirm"] = (object) this.DeleteCardConfirm;
      return dictionary;
    }
  }
}
