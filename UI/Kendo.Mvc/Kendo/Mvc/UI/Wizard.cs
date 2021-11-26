// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Wizard
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class Wizard : WidgetBase
  {
    public Wizard(ViewContext viewContext)
      : base(viewContext)
    {
    }

    public List<WizardStep> Steps { get; set; } = new List<WizardStep>();

    public string Tag { get; set; } = "div";

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag(this.Tag, this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      List<IDictionary<string, object>> source = new List<IDictionary<string, object>>();
      for (int index = 0; index < this.Steps.Count; ++index)
      {
        WizardStep step = this.Steps[index];
        source.Add((IDictionary<string, object>) step.Serialize());
      }
      if (source.Any<IDictionary<string, object>>())
        dictionary["steps"] = (object) source;
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Wizard), (IDictionary<string, object>) dictionary));
    }

    public bool? ActionBar { get; set; }

    public bool? LoadOnDemand { get; set; }

    public WizardMessagesSettings Messages { get; } = new WizardMessagesSettings();

    public bool? Pager { get; set; }

    public bool? ReloadOnSelect { get; set; }

    public WizardStepperSettings Stepper { get; } = new WizardStepperSettings();

    public WizardValidateFormsSettings ValidateForms { get; } = new WizardValidateFormsSettings();

    public WizardContentPosition? ContentPosition { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.ActionBar.HasValue)
        dictionary1["actionBar"] = (object) this.ActionBar;
      if (this.LoadOnDemand.HasValue)
        dictionary1["loadOnDemand"] = (object) this.LoadOnDemand;
      Dictionary<string, object> source1 = this.Messages.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary1["messages"] = (object) source1;
      if (this.Pager.HasValue)
        dictionary1["pager"] = (object) this.Pager;
      if (this.ReloadOnSelect.HasValue)
        dictionary1["reloadOnSelect"] = (object) this.ReloadOnSelect;
      Dictionary<string, object> source2 = this.Stepper.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["stepper"] = (object) source2;
      Dictionary<string, object> source3 = this.ValidateForms.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary1["validateForms"] = (object) source3;
      else if (this.ValidateForms.Enabled.HasValue)
        dictionary1["validateForms"] = (object) this.ValidateForms.Enabled;
      if (this.ContentPosition.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        WizardContentPosition? contentPosition = this.ContentPosition;
        ref WizardContentPosition? local = ref contentPosition;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["contentPosition"] = (object) str;
      }
      return dictionary1;
    }
  }
}
