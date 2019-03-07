using System;
using Microsoft.Extensions.Logging;
using Xbim.Common;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;

// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.IfcRail.ExternalReferenceResource
{
	public partial class IfcDocumentReference : IExpressValidatable
	{
		public enum IfcDocumentReferenceClause
		{
			WR1,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcDocumentReferenceClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcDocumentReferenceClause.WR1:
						retVal = Functions.EXISTS(Name) ^ Functions.EXISTS(ReferencedDocument);
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Xbim.IfcRail.ExternalReferenceResource.IfcDocumentReference>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcDocumentReference.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcDocumentReferenceClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcDocumentReference.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}