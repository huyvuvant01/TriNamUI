// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.FileManagerMessagesToolbarSettingsTagHelper
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
  [HtmlTargetElement("toolbar", ParentTag = "messages", TagStructure = TagStructure.NormalOrSelfClosing)]
  [SuppressTagRendering]
  public class FileManagerMessagesToolbarSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (FileManagerMessagesSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as FileManagerMessagesSettingsTagHelper).Toolbar = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string CreateFolder { get; set; }

    public string Upload { get; set; }

    public string SortDirection { get; set; }

    public string SortDirectionAsc { get; set; }

    public string SortDirectionDesc { get; set; }

    public string SortField { get; set; }

    public string NameField { get; set; }

    public string SizeField { get; set; }

    public string TypeField { get; set; }

    public string DateModifiedField { get; set; }

    public string DateCreatedField { get; set; }

    public string Search { get; set; }

    public string Details { get; set; }

    public string DetailsChecked { get; set; }

    public string DetailsUnchecked { get; set; }

    public string Delete { get; set; }

    public string Rename { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string createFolder = this.CreateFolder;
      if ((createFolder != null ? (createFolder.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["createFolder"] = (object) this.CreateFolder;
      string upload = this.Upload;
      if ((upload != null ? (upload.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["upload"] = (object) this.Upload;
      string sortDirection = this.SortDirection;
      if ((sortDirection != null ? (sortDirection.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["sortDirection"] = (object) this.SortDirection;
      string sortDirectionAsc = this.SortDirectionAsc;
      if ((sortDirectionAsc != null ? (sortDirectionAsc.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["sortDirectionAsc"] = (object) this.SortDirectionAsc;
      string sortDirectionDesc = this.SortDirectionDesc;
      if ((sortDirectionDesc != null ? (sortDirectionDesc.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["sortDirectionDesc"] = (object) this.SortDirectionDesc;
      string sortField = this.SortField;
      if ((sortField != null ? (sortField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["sortField"] = (object) this.SortField;
      string nameField = this.NameField;
      if ((nameField != null ? (nameField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["nameField"] = (object) this.NameField;
      string sizeField = this.SizeField;
      if ((sizeField != null ? (sizeField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["sizeField"] = (object) this.SizeField;
      string typeField = this.TypeField;
      if ((typeField != null ? (typeField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["typeField"] = (object) this.TypeField;
      string dateModifiedField = this.DateModifiedField;
      if ((dateModifiedField != null ? (dateModifiedField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dateModifiedField"] = (object) this.DateModifiedField;
      string dateCreatedField = this.DateCreatedField;
      if ((dateCreatedField != null ? (dateCreatedField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dateCreatedField"] = (object) this.DateCreatedField;
      string search = this.Search;
      if ((search != null ? (search.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["search"] = (object) this.Search;
      string details = this.Details;
      if ((details != null ? (details.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["details"] = (object) this.Details;
      string detailsChecked = this.DetailsChecked;
      if ((detailsChecked != null ? (detailsChecked.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["detailsChecked"] = (object) this.DetailsChecked;
      string detailsUnchecked = this.DetailsUnchecked;
      if ((detailsUnchecked != null ? (detailsUnchecked.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["detailsUnchecked"] = (object) this.DetailsUnchecked;
      string delete = this.Delete;
      if ((delete != null ? (delete.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["delete"] = (object) this.Delete;
      string rename = this.Rename;
      if ((rename != null ? (rename.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["rename"] = (object) this.Rename;
      return dictionary;
    }
  }
}
