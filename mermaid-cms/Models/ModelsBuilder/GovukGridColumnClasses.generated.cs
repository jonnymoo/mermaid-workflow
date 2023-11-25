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
	// Mixin Content Type with alias "govukGridColumnClasses"
	/// <summary>Grid (column classes)</summary>
	public partial interface IGovukGridColumnClasses : IPublishedElement
	{
		/// <summary>Column size</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string ColumnSize { get; }

		/// <summary>Column size (from desktop)</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string ColumnSizeFromDesktop { get; }

		/// <summary>CSS classes for column</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string CssClassesForColumn { get; }
	}

	/// <summary>Grid (column classes)</summary>
	[PublishedModel("govukGridColumnClasses")]
	public partial class GovukGridColumnClasses : PublishedElementModel, IGovukGridColumnClasses
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		public new const string ModelTypeAlias = "govukGridColumnClasses";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<GovukGridColumnClasses, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public GovukGridColumnClasses(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Column size
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("columnSize")]
		public virtual string ColumnSize => GetColumnSize(this, _publishedValueFallback);

		/// <summary>Static getter for Column size</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetColumnSize(IGovukGridColumnClasses that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "columnSize");

		///<summary>
		/// Column size (from desktop): Defaults to 'two-thirds' if both column size properties are left blank.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("columnSizeFromDesktop")]
		public virtual string ColumnSizeFromDesktop => GetColumnSizeFromDesktop(this, _publishedValueFallback);

		/// <summary>Static getter for Column size (from desktop)</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetColumnSizeFromDesktop(IGovukGridColumnClasses that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "columnSizeFromDesktop");

		///<summary>
		/// CSS classes for column: Applied to the grid column which contains this component and other adjacent components that have the same setting.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("cssClassesForColumn")]
		public virtual string CssClassesForColumn => GetCssClassesForColumn(this, _publishedValueFallback);

		/// <summary>Static getter for CSS classes for column</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.1+80fac86")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetCssClassesForColumn(IGovukGridColumnClasses that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "cssClassesForColumn");
	}
}
