// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Form.Fluent.FormItemEditorBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.UI.Fluent;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kendo.Mvc.UI.Form.Fluent
{
  public class FormItemEditorBuilder<T>
  {
    private readonly ViewContext ViewContext;

    public FormItemEditorBuilder(FormItem container, ViewContext viewContext)
    {
      this.Container = container;
      this.ViewContext = viewContext;
    }

    protected FormItem Container { get; private set; }

    public DropDownListBuilder DropDownList()
    {
      this.Container.Editor = nameof (DropDownList);
      this.Container.EditorComponent = (IFormEditor) new Kendo.Mvc.UI.DropDownList(this.ViewContext);
      return new DropDownListBuilder(this.Container.EditorComponent as Kendo.Mvc.UI.DropDownList);
    }

    public AutoCompleteBuilder AutoComplete()
    {
      this.Container.Editor = nameof (AutoComplete);
      this.Container.EditorComponent = (IFormEditor) new Kendo.Mvc.UI.AutoComplete(this.ViewContext);
      return new AutoCompleteBuilder(this.Container.EditorComponent as Kendo.Mvc.UI.AutoComplete);
    }

    public CaptchaBuilder Captcha()
    {
      this.Container.Editor = nameof (Captcha);
      this.Container.EditorComponent = (IFormEditor) new Kendo.Mvc.UI.Captcha(this.ViewContext);
      return new CaptchaBuilder(this.Container.EditorComponent as Kendo.Mvc.UI.Captcha);
    }

    public ComboBoxBuilder ComboBox()
    {
      this.Container.Editor = nameof (ComboBox);
      this.Container.EditorComponent = (IFormEditor) new Kendo.Mvc.UI.ComboBox(this.ViewContext);
      return new ComboBoxBuilder(this.Container.EditorComponent as Kendo.Mvc.UI.ComboBox);
    }

    public MultiSelectBuilder MultiSelect()
    {
      this.Container.Editor = nameof (MultiSelect);
      this.Container.EditorComponent = (IFormEditor) new Kendo.Mvc.UI.MultiSelect(this.ViewContext);
      return new MultiSelectBuilder(this.Container.EditorComponent as Kendo.Mvc.UI.MultiSelect);
    }

    public MultiColumnComboBoxBuilder MultiColumnComboBox()
    {
      this.Container.Editor = nameof (MultiColumnComboBox);
      this.Container.EditorComponent = (IFormEditor) new Kendo.Mvc.UI.MultiColumnComboBox(this.ViewContext);
      return new MultiColumnComboBoxBuilder(this.Container.EditorComponent as Kendo.Mvc.UI.MultiColumnComboBox);
    }

    public DropDownTreeBuilder DropDownTree()
    {
      this.Container.Editor = nameof (DropDownTree);
      this.Container.EditorComponent = (IFormEditor) new Kendo.Mvc.UI.DropDownTree(this.ViewContext);
      return new DropDownTreeBuilder(this.Container.EditorComponent as Kendo.Mvc.UI.DropDownTree);
    }

    public DateInputBuilder DateInput()
    {
      this.Container.Editor = nameof (DateInput);
      this.Container.EditorComponent = (IFormEditor) new Kendo.Mvc.UI.DateInput(this.ViewContext);
      return new DateInputBuilder(this.Container.EditorComponent as Kendo.Mvc.UI.DateInput);
    }

    public DatePickerBuilder DatePicker()
    {
      this.Container.Editor = nameof (DatePicker);
      this.Container.EditorComponent = (IFormEditor) new Kendo.Mvc.UI.DatePicker(this.ViewContext);
      return new DatePickerBuilder(this.Container.EditorComponent as Kendo.Mvc.UI.DatePicker);
    }

    public DateTimePickerBuilder DateTimePicker()
    {
      this.Container.Editor = nameof (DateTimePicker);
      this.Container.EditorComponent = (IFormEditor) new Kendo.Mvc.UI.DateTimePicker(this.ViewContext);
      return new DateTimePickerBuilder(this.Container.EditorComponent as Kendo.Mvc.UI.DateTimePicker);
    }

    public TimePickerBuilder TimePicker()
    {
      this.Container.Editor = nameof (TimePicker);
      this.Container.EditorComponent = (IFormEditor) new Kendo.Mvc.UI.TimePicker(this.ViewContext);
      return new TimePickerBuilder(this.Container.EditorComponent as Kendo.Mvc.UI.TimePicker);
    }

    public NumericTextBoxBuilder<double> NumericTextBox()
    {
      this.Container.Editor = nameof (NumericTextBox);
      this.Container.EditorComponent = (IFormEditor) new Kendo.Mvc.UI.NumericTextBox<double>(this.ViewContext);
      return new NumericTextBoxBuilder<double>(this.Container.EditorComponent as Kendo.Mvc.UI.NumericTextBox<double>);
    }

    public NumericTextBoxBuilder<NT> NumericTextBox<NT>() where NT : struct
    {
      this.Container.Editor = nameof (NumericTextBox);
      this.Container.EditorComponent = (IFormEditor) new Kendo.Mvc.UI.NumericTextBox<NT>(this.ViewContext);
      return new NumericTextBoxBuilder<NT>(this.Container.EditorComponent as Kendo.Mvc.UI.NumericTextBox<NT>);
    }

    public MaskedTextBoxBuilder MaskedTextBox()
    {
      this.Container.Editor = nameof (MaskedTextBox);
      this.Container.EditorComponent = (IFormEditor) new Kendo.Mvc.UI.MaskedTextBox(this.ViewContext);
      return new MaskedTextBoxBuilder(this.Container.EditorComponent as Kendo.Mvc.UI.MaskedTextBox);
    }

    public TextBoxBuilder<string> TextBox()
    {
      this.Container.Editor = nameof (TextBox);
      this.Container.EditorComponent = (IFormEditor) new Kendo.Mvc.UI.TextBox<string>(this.ViewContext);
      return new TextBoxBuilder<string>(this.Container.EditorComponent as Kendo.Mvc.UI.TextBox<string>);
    }

    public TextAreaBuilder TextArea()
    {
      this.Container.Editor = nameof (TextArea);
      this.Container.EditorComponent = (IFormEditor) new Kendo.Mvc.UI.TextArea(this.ViewContext);
      return new TextAreaBuilder(this.Container.EditorComponent as Kendo.Mvc.UI.TextArea);
    }

    public SwitchBuilder Switch()
    {
      this.Container.Editor = nameof (Switch);
      this.Container.EditorComponent = (IFormEditor) new Kendo.Mvc.UI.Switch(this.ViewContext);
      return new SwitchBuilder(this.Container.EditorComponent as Kendo.Mvc.UI.Switch);
    }

    public RatingBuilder Rating()
    {
      this.Container.Editor = nameof (Rating);
      this.Container.EditorComponent = (IFormEditor) new Kendo.Mvc.UI.Rating(this.ViewContext);
      return new RatingBuilder(this.Container.EditorComponent as Kendo.Mvc.UI.Rating);
    }

    public SliderBuilder<int> Slider()
    {
      this.Container.Editor = nameof (Slider);
      this.Container.EditorComponent = (IFormEditor) new Kendo.Mvc.UI.Slider<int>(this.ViewContext);
      return new SliderBuilder<int>(this.Container.EditorComponent as Kendo.Mvc.UI.Slider<int>);
    }

    public ColorPickerBuilder ColorPicker()
    {
      this.Container.Editor = nameof (ColorPicker);
      this.Container.EditorComponent = (IFormEditor) new Kendo.Mvc.UI.ColorPicker(this.ViewContext);
      return new ColorPickerBuilder(this.Container.EditorComponent as Kendo.Mvc.UI.ColorPicker);
    }

    public EditorBuilder Editor()
    {
      this.Container.Editor = nameof (Editor);
      this.Container.EditorComponent = (IFormEditor) new Kendo.Mvc.UI.Editor(this.ViewContext);
      return new EditorBuilder(this.Container.EditorComponent as Kendo.Mvc.UI.Editor);
    }

    public RadioGroupBuilder RadioGroup()
    {
      this.Container.Editor = nameof (RadioGroup);
      this.Container.EditorComponent = (IFormEditor) new Kendo.Mvc.UI.RadioGroup(this.ViewContext);
      return new RadioGroupBuilder(this.Container.EditorComponent as Kendo.Mvc.UI.RadioGroup);
    }

    public CheckBoxGroupBuilder CheckBoxGroup()
    {
      this.Container.Editor = nameof (CheckBoxGroup);
      this.Container.EditorComponent = (IFormEditor) new Kendo.Mvc.UI.CheckBoxGroup(this.ViewContext);
      return new CheckBoxGroupBuilder(this.Container.EditorComponent as Kendo.Mvc.UI.CheckBoxGroup);
    }

    public void Hidden() => this.Container.Editor = "hidden";
  }
}
