// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	public partial class @IfcLibraryReference : IIfcLibraryReference
	{
		Xbim.Ifc4.MeasureResource.IfcText? IIfcLibraryReference.Description 
		{ 
			get
			{
				//## Handle return of Description for which no match was found
				//TODO: Handle return of Description for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		Xbim.Ifc4.ExternalReferenceResource.IfcLanguageId? IIfcLibraryReference.Language 
		{ 
			get
			{
				//## Handle return of Language for which no match was found
				//TODO: Handle return of Language for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		IIfcLibraryInformation IIfcLibraryReference.ReferencedLibrary 
		{ 
			get
			{
				//## Handle return of ReferencedLibrary for which no match was found
				//TODO: Handle return of ReferencedLibrary for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		IEnumerable<IIfcRelAssociatesLibrary> IIfcLibraryReference.LibraryRefForObjects 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssociatesLibrary>(e => (e.RelatingLibrary as IfcLibraryReference) == this);
			} 
		}
	}
}