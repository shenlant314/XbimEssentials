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
namespace Xbim.Ifc2x3.SharedBldgElements
{
	public partial class @IfcRailing : IIfcRailing
	{
		Xbim.Ifc4.SharedBldgElements.IfcRailingTypeEnum? IIfcRailing.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case Xbim.Ifc2x3.SharedBldgElements.IfcRailingTypeEnum.HANDRAIL:
						return Xbim.Ifc4.SharedBldgElements.IfcRailingTypeEnum.HANDRAIL;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcRailingTypeEnum.GUARDRAIL:
						return Xbim.Ifc4.SharedBldgElements.IfcRailingTypeEnum.GUARDRAIL;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcRailingTypeEnum.BALUSTRADE:
						return Xbim.Ifc4.SharedBldgElements.IfcRailingTypeEnum.BALUSTRADE;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcRailingTypeEnum.USERDEFINED:
						return Xbim.Ifc4.SharedBldgElements.IfcRailingTypeEnum.USERDEFINED;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcRailingTypeEnum.NOTDEFINED:
						return Xbim.Ifc4.SharedBldgElements.IfcRailingTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}