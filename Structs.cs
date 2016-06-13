using System;

namespace StylingKit_Xamarin
{

	public enum PXStylesheetOrigin
	{
		PXStylesheetOriginApplication,
		PXStylesheetOriginUser,
		PXStylesheetOriginView
	}

	public enum PXParseErrorDestination
	{
		PXParseErrorDestinationNone,
		PXParseErrorDestinationConsole,
	}

	public enum PXCacheStylesType
	{
		PXCacheStylesTypeAuto,
		PXCacheStylesTypeNone,
	}

	public enum PXStylingMode
	{
		PXStylingUndefined = 0,
		PXStylingNormal,
		PXStylingNone,
	}

}

