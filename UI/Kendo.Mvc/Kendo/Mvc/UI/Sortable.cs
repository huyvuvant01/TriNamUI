// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Sortable
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Kendo.Mvc.UI
{
  public class Sortable : WidgetBase
  {
    public Sortable(ViewContext viewContext)
      : base(viewContext)
    {
    }

    public string SortableContainer { get; set; }

    public string ContainerSelector { get; set; }

    public ClientHandlerDescriptor HintHandler { get; set; }

    public string Hint { get; set; }

    public ClientHandlerDescriptor PlaceholderHandler { get; set; }

    public string Placeholder { get; set; }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary1 = this.SerializeSettings();
      ClientHandlerDescriptor hintHandler = this.HintHandler;
      if ((hintHandler != null ? (hintHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["hint"] = (object) this.HintHandler;
      }
      else
      {
        string hint = this.Hint;
        if ((hint != null ? (hint.HasValue() ? 1 : 0) : 0) != 0)
          dictionary1["hint"] = (object) this.Hint;
      }
      ClientHandlerDescriptor placeholderHandler = this.PlaceholderHandler;
      if ((placeholderHandler != null ? (placeholderHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["placeholder"] = (object) this.PlaceholderHandler;
      }
      else
      {
        string placeholder = this.Placeholder;
        if ((placeholder != null ? (placeholder.HasValue() ? 1 : 0) : 0) != 0)
          dictionary1["placeholder"] = (object) this.Placeholder;
      }
      string containerSelector = this.ContainerSelector;
      if ((containerSelector != null ? (containerSelector.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["container"] = (object) this.SanitizeSelector(this.ContainerSelector);
      string filter = this.Filter;
      if ((filter != null ? (filter.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["filter"] = (object) this.SanitizeSelector(this.Filter);
      string disabled = this.Disabled;
      if ((disabled != null ? (disabled.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["disabled"] = (object) this.SanitizeSelector(this.Disabled);
      string handler = this.Handler;
      if ((handler != null ? (handler.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["handler"] = (object) this.SanitizeSelector(this.Handler);
      string connectWith = this.ConnectWith;
      if ((connectWith != null ? (connectWith.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["connectWith"] = (object) this.SanitizeSelector(this.ConnectWith);
      string ignore = this.Ignore;
      if ((ignore != null ? (ignore.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["ignore"] = (object) this.SanitizeSelector(this.Ignore);
      bool? holdToDrag = this.HoldToDrag;
      if (holdToDrag.HasValue)
      {
        holdToDrag = this.HoldToDrag;
        if (holdToDrag.Value)
          dictionary1["holdToDrag"] = (object) this.HoldToDrag;
      }
      SortableAxis? axis = this.Axis;
      if (axis.HasValue)
      {
        axis = this.Axis;
        if (axis.Value != SortableAxis.None)
        {
          Dictionary<string, object> dictionary2 = dictionary1;
          axis = this.Axis;
          ref SortableAxis? local = ref axis;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary2["axis"] = (object) str;
        }
      }
      string cursor = this.Cursor;
      if ((cursor != null ? (cursor.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["cursor"] = (object) this.SanitizeSelector(this.Cursor);
      writer.Write(this.Initializer.InitializeFor(this.SanitizeSelector(this.SortableContainer), nameof (Sortable), (IDictionary<string, object>) dictionary1));
    }

    public override void VerifySettings()
    {
      if (string.IsNullOrEmpty(this.SortableContainer))
        throw new InvalidOperationException(Exceptions.TooltipContainerShouldBeSet);
      this.ThrowIfClassIsPresent("k-" + this.GetType().GetTypeName().ToLowerInvariant() + "-rtl", Exceptions.Rtl);
    }

    private string SanitizeSelector(string selector)
    {
      if (string.IsNullOrWhiteSpace(selector))
        return string.Empty;
      if (!this.IsInClientTemplate)
        return selector;
      StringBuilder stringBuilder = new StringBuilder(selector.Length);
      int num1 = selector.IndexOf("#=");
      int num2 = selector.LastIndexOf("#");
      if (num2 > num1 && num1 > -1)
      {
        stringBuilder.Append(selector.Substring(0, num1).Replace("#", "\\#"));
        stringBuilder.Append(selector.Substring(num1, num2 - num1 + 1));
        stringBuilder.Append(selector.Substring(num2 + 1).Replace("#", "\\#"));
      }
      else
        stringBuilder.Append(selector.Replace("#", "\\#"));
      return stringBuilder.ToString();
    }

    private string Encode(string value)
    {
      value = Regex.Replace(value, "(%20)*%23%3D(%20)*", "#=", RegexOptions.IgnoreCase);
      value = Regex.Replace(value, "(%20)*%23(%20)*", "#", RegexOptions.IgnoreCase);
      value = Regex.Replace(value, "(%20)*%24%7B(%20)*", "${", RegexOptions.IgnoreCase);
      value = Regex.Replace(value, "(%20)*%7D(%20)*", "}", RegexOptions.IgnoreCase);
      return value;
    }

    public bool? AutoScroll { get; set; }

    public string ConnectWith { get; set; }

    public string Cursor { get; set; }

    public SortableCursorOffsetSettings CursorOffset { get; } = new SortableCursorOffsetSettings();

    public string Disabled { get; set; }

    public string Filter { get; set; }

    public string Handler { get; set; }

    public bool? HoldToDrag { get; set; }

    public string Ignore { get; set; }

    public SortableAxis? Axis { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.AutoScroll.HasValue)
        dictionary1["autoScroll"] = (object) this.AutoScroll;
      string connectWith = this.ConnectWith;
      if ((connectWith != null ? (connectWith.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["connectWith"] = (object) this.ConnectWith;
      string cursor = this.Cursor;
      if ((cursor != null ? (cursor.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["cursor"] = (object) this.Cursor;
      Dictionary<string, object> source = this.CursorOffset.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary1["cursorOffset"] = (object) source;
      string disabled = this.Disabled;
      if ((disabled != null ? (disabled.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["disabled"] = (object) this.Disabled;
      string filter = this.Filter;
      if ((filter != null ? (filter.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["filter"] = (object) this.Filter;
      string handler = this.Handler;
      if ((handler != null ? (handler.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["handler"] = (object) this.Handler;
      if (this.HoldToDrag.HasValue)
        dictionary1["holdToDrag"] = (object) this.HoldToDrag;
      string ignore = this.Ignore;
      if ((ignore != null ? (ignore.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["ignore"] = (object) this.Ignore;
      if (this.Axis.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        SortableAxis? axis = this.Axis;
        ref SortableAxis? local = ref axis;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["axis"] = (object) str;
      }
      return dictionary1;
    }
  }
}
