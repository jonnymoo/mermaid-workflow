//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v12.3.1+80fac86
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace MermaidWorkflow.CMS.Models
{
	/// <summary>Text input settings</summary>
	[PublishedModel("govukTextInputSettings")]
	public partial class GovukTextInputSettings : PublishedElementModel, IGovukCssClasses, IGovukGrid, IGovukGridColumnClasses, IGovukLabelIsPageHeading, IGovukModelProperty, IGovukValidationCustom, IGovukValidationRange, IGovukValidationRequired, IGovukValidationText
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		public new const string ModelTypeAlias = "govukTextInputSettings";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<GovukTextInputSettings, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public GovukTextInputSettings(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Prefix: For example, a £ sign before a currency field.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("prefix")]
		public virtual string Prefix => this.Value<string>(_publishedValueFallback, "prefix");

		///<summary>
		/// Suffix: For example, a % sign after a percentage field.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("suffix")]
		public virtual string Suffix => this.Value<string>(_publishedValueFallback, "suffix");

		///<summary>
		/// Text input width
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("textInputWidth")]
		public virtual string TextInputWidth => this.Value<string>(_publishedValueFallback, "textInputWidth");

		///<summary>
		/// CSS classes: Applied to the outermost HTML element of the component.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("cssClasses")]
		public virtual string CssClasses => global::MermaidWorkflow.CMS.Models.GovukCssClasses.GetCssClasses(this, _publishedValueFallback);

		///<summary>
		/// CSS classes for row: Applied to the grid row which contains this component and other adjacent components that have the same setting.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("cssClassesForRow")]
		public virtual string CssClassesForRow => global::MermaidWorkflow.CMS.Models.GovukGrid.GetCssClassesForRow(this, _publishedValueFallback);

		///<summary>
		/// Column size
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("columnSize")]
		public virtual string ColumnSize => global::MermaidWorkflow.CMS.Models.GovukGridColumnClasses.GetColumnSize(this, _publishedValueFallback);

		///<summary>
		/// Column size (from desktop): Defaults to 'two-thirds' if both column size properties are left blank.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("columnSizeFromDesktop")]
		public virtual string ColumnSizeFromDesktop => global::MermaidWorkflow.CMS.Models.GovukGridColumnClasses.GetColumnSizeFromDesktop(this, _publishedValueFallback);

		///<summary>
		/// CSS classes for column: Applied to the grid column which contains this component and other adjacent components that have the same setting.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("cssClassesForColumn")]
		public virtual string CssClassesForColumn => global::MermaidWorkflow.CMS.Models.GovukGridColumnClasses.GetCssClassesForColumn(this, _publishedValueFallback);

		///<summary>
		/// The label is the page heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[ImplementPropertyType("labelIsPageHeading")]
		public virtual bool LabelIsPageHeading => global::MermaidWorkflow.CMS.Models.GovukLabelIsPageHeading.GetLabelIsPageHeading(this, _publishedValueFallback);

		///<summary>
		/// Model property: The name of the property on the view model being bound to in the code.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("modelProperty")]
		public virtual object ModelProperty => global::MermaidWorkflow.CMS.Models.GovukModelProperty.GetModelProperty(this, _publishedValueFallback);

		///<summary>
		/// Custom error 1: Sets the message displayed by a custom validator.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("customError1")]
		public virtual string CustomError1 => global::MermaidWorkflow.CMS.Models.GovukValidationCustom.GetCustomError1(this, _publishedValueFallback);

		///<summary>
		/// Custom error 2: Sets the message displayed by a custom validator.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("customError2")]
		public virtual string CustomError2 => global::MermaidWorkflow.CMS.Models.GovukValidationCustom.GetCustomError2(this, _publishedValueFallback);

		///<summary>
		/// Custom error 3: Sets the message displayed by a custom validator.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("customError3")]
		public virtual string CustomError3 => global::MermaidWorkflow.CMS.Models.GovukValidationCustom.GetCustomError3(this, _publishedValueFallback);

		///<summary>
		/// Numeric or date range: Sets the message displayed if the field is set by the code to require a number or date in a given range.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("errorMessageRange")]
		public virtual string ErrorMessageRange => global::MermaidWorkflow.CMS.Models.GovukValidationRange.GetErrorMessageRange(this, _publishedValueFallback);

		///<summary>
		/// Required: Sets the message displayed if the field is set by the code to be required.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("errorMessageRequired")]
		public virtual string ErrorMessageRequired => global::MermaidWorkflow.CMS.Models.GovukValidationRequired.GetErrorMessageRequired(this, _publishedValueFallback);

		///<summary>
		/// Compare to another field: Sets the error message displayed if the field is set to be the same as another (like when you're asked to re-enter an email address).
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("errorMessageCompare")]
		public virtual string ErrorMessageCompare => global::MermaidWorkflow.CMS.Models.GovukValidationText.GetErrorMessageCompare(this, _publishedValueFallback);

		///<summary>
		/// Email address: Sets the message displayed if the field is set by the code to require an email address.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("errorMessageEmail")]
		public virtual string ErrorMessageEmail => global::MermaidWorkflow.CMS.Models.GovukValidationText.GetErrorMessageEmail(this, _publishedValueFallback);

		///<summary>
		/// Minimum and maximum length: Sets the message displayed if the field is set by the code to require text between a minimum and maximum length.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("errorMessageLength")]
		public virtual string ErrorMessageLength => global::MermaidWorkflow.CMS.Models.GovukValidationText.GetErrorMessageLength(this, _publishedValueFallback);

		///<summary>
		/// Maximum length: Sets the message displayed if the field is set by the code to require text of a maximum length.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("errorMessageMaxLength")]
		public virtual string ErrorMessageMaxLength => global::MermaidWorkflow.CMS.Models.GovukValidationText.GetErrorMessageMaxLength(this, _publishedValueFallback);

		///<summary>
		/// Minimum length: Sets the message displayed if the field is set by the code to require text of a minimum length.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("errorMessageMinLength")]
		public virtual string ErrorMessageMinLength => global::MermaidWorkflow.CMS.Models.GovukValidationText.GetErrorMessageMinLength(this, _publishedValueFallback);

		///<summary>
		/// Phone number: Sets the message displayed if the field is set by the code to require a phone number.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("errorMessagePhone")]
		public virtual string ErrorMessagePhone => global::MermaidWorkflow.CMS.Models.GovukValidationText.GetErrorMessagePhone(this, _publishedValueFallback);

		///<summary>
		/// Pattern: Sets the message displayed if the field is set by the code to require a regular expression pattern to be matched.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("errorMessageRegex")]
		public virtual string ErrorMessageRegex => global::MermaidWorkflow.CMS.Models.GovukValidationText.GetErrorMessageRegex(this, _publishedValueFallback);
	}
}
