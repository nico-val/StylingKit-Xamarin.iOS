using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace StylingKit
{
	public enum PXDimensionType : uint
	{
		Ems,
		Exs,
		Pixels,
		DevicePixels,
		Centimeters,
		Millimeters,
		Inches,
		Points,
		Picas,
		Degrees,
		Radians,
		Gradians,
		Milliseconds,
		Seconds,
		Hertz,
		Kilohertz,
		Percentage,
		UserDefined
	}

	public enum PXStylingMode : uint
	{
		Undefined = 0,
		Normal,
		None
	}

	public enum PXParseErrorDestination : uint
	{
		None,
		Console
	}

	public enum PXCacheStylesType : uint
	{
		None = 0,
		StyleOnce = 1,
		Save = 2,
		Images = 4
	}

	public enum PXBorderStyle : uint
	{
		None,
		Hidden,
		Dotted,
		Dashed,
		Solid,
		Double,
		Groove,
		Ridge,
		Inset,
		Outset
	}

	public enum PXSpecificityType : uint
	{
		Origin,
		Id,
		ClassOrAttribute,
		Element
	}

	public enum PXAnimationTimingFunction
	{
		Undefined = -1,
		Ease,
		Linear,
		EaseIn,
		EaseOut,
		EaseInOut,
		StepStart,
		StepEnd
	}

	public enum PXAnimationDirection
	{
		Undefined = -1,
		Normal,
		Reverse,
		Alternate,
		AlternateReverse
	}

	public enum PXAnimationPlayState
	{
		Undefined = -1,
		Running,
		Paused
	}

	public enum PXAnimationFillMode
	{
		Undefined = -1,
		None,
		Forwards,
		Backwards,
		Both
	}

	public enum PXBoxSizing : uint
	{
		ContentBox,
		PaddingBox,
		BorderBox
	}

	public enum PXArrowRectangleDirection : uint
	{
		Left,
		Right
	}

	public enum PXAttributeSelectorOperatorType : uint
	{
		StartsWith,
		EndsWith,
		Contains,
		Equal,
		ListContains,
		EqualWithHyphen
	}

	public enum PXLexemeFlagType : uint
	{
		PXLexemeFlagFollowsWhitespace = 1
	}

	static class CFunctions
	{
		// extern void CGPathAddEllipticalArc (CGMutablePathRef path, const CGAffineTransform *m, CGFloat x, CGFloat y, CGFloat radiusX, CGFloat radiusY, CGFloat startAngle, CGFloat endAngle);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern unsafe void CGPathAddEllipticalArc (CGMutablePathRef* path, CGAffineTransform* m, nfloat x, nfloat y, nfloat radiusX, nfloat radiusY, nfloat startAngle, nfloat endAngle);

		// extern PXVersionType PXVersionFromObject (id value);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern PXVersionType PXVersionFromObject (NSObject value);

		// extern PXVersionType PXVersionFromString (NSString *vString);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern PXVersionType PXVersionFromString (NSString vString);

		// extern NSString * NSStringFromPXVersion (PXVersionType v);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern NSString NSStringFromPXVersion (PXVersionType v);

		// extern int16_t PXVersionPrimary (PXVersionType v);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern short PXVersionPrimary (PXVersionType v);

		// extern int16_t PXVersionSecondary (PXVersionType v);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern short PXVersionSecondary (PXVersionType v);

		// extern int16_t PXVersionTertiary (PXVersionType v);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern short PXVersionTertiary (PXVersionType v);

		// extern NSComparisonResult PXVersionCompare (PXVersionType v1, PXVersionType v2);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern NSComparisonResult PXVersionCompare (PXVersionType v1, PXVersionType v2);

		// extern BOOL PXVersionMatch (PXVersionType base, PXVersionType testVersion);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern bool PXVersionMatch (PXVersionType @base, PXVersionType testVersion);

		// extern PXVersionType PXVersionCurrentSystem ();
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern PXVersionType PXVersionCurrentSystem ();

		// extern PXScreenRatioType PXScreenRatioFromString (NSString *ratioString);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern double PXScreenRatioFromString (NSString ratioString);

		// extern PXScreenRatioType PXScreenRatioFromObject (id object);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern double PXScreenRatioFromObject (NSObject @object);

		// extern NSComparisonResult PXScreenRatioCompare (PXScreenRatioType ratio1, PXScreenRatioType ratio2);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern NSComparisonResult PXScreenRatioCompare (double ratio1, double ratio2);

		// extern PXScreenRatioType PXScreenRatioCurrentSystem ();
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern double PXScreenRatioCurrentSystem ();

		// extern void * callSuper0 (id self, Class superClass, SEL _cmd);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern unsafe void* callSuper0 (NSObject self, Class superClass, Selector _cmd);

		// extern void * callSuper1 (id self, Class superClass, SEL _cmd, id arg1);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern unsafe void* callSuper1 (NSObject self, Class superClass, Selector _cmd, NSObject arg1);

		// extern void * callSuper1b (id self, Class superClass, SEL _cmd, BOOL arg1);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern unsafe void* callSuper1b (NSObject self, Class superClass, Selector _cmd, bool arg1);

		// extern void * callSuper1v (id self, Class superClass, SEL _cmd, void *arg1);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern unsafe void* callSuper1v (NSObject self, Class superClass, Selector _cmd, void* arg1);

		// extern void * callSuper2 (id self, Class superClass, SEL _cmd, id arg1, id arg2);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern unsafe void* callSuper2 (NSObject self, Class superClass, Selector _cmd, NSObject arg1, NSObject arg2);

		// extern void * callSuper2v (id self, Class superClass, SEL _cmd, id arg1, void *arg2);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern unsafe void* callSuper2v (NSObject self, Class superClass, Selector _cmd, NSObject arg1, void* arg2);

		// extern void * callSuper2vv (id self, Class superClass, SEL _cmd, void *arg1, void *arg2);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern unsafe void* callSuper2vv (NSObject self, Class superClass, Selector _cmd, void* arg1, void* arg2);

		// extern void * callSuper3v (id self, Class superClass, SEL _cmd, id arg1, void *arg2, void *arg3);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern unsafe void* callSuper3v (NSObject self, Class superClass, Selector _cmd, NSObject arg1, void* arg2, void* arg3);

		// extern void * callSuper4v (id self, Class superClass, SEL _cmd, id arg1, void *arg2, void *arg3, void *arg4);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern unsafe void* callSuper4v (NSObject self, Class superClass, Selector _cmd, NSObject arg1, void* arg2, void* arg3, void* arg4);

		// extern void copyIndexedIvars (id src, id dest, size_t size);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern void copyIndexedIvars (NSObject src, NSObject dest, nuint size);
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct PXVersionType
	{
		public short primary;

		public short secondary;

		public short tertiary;
	}

	public enum PXGradientUnits : uint
	{
		BoundingBox,
		UserSpace
	}

	public enum PXLinearGradientDirection : uint
	{
		Top,
		TopRight,
		Right,
		BottomRight,
		Bottom,
		BottomLeft,
		Left,
		TopLeft
	}

	public enum AlignViewPortType : uint
	{
		None,
		XMinYMin,
		XMinYMid,
		XMinYMax,
		XMidYMin,
		XMidYMid,
		XMidYMax,
		XMaxYMin,
		XMaxYMid,
		XMaxYMax
	}

	public enum CropType : uint
	{
		Meet,
		Slice
	}

	public enum PXStrokeType : uint
	{
		Center,
		Inner,
		Outer
	}

	public enum PXImageRepeatType : uint
	{
		Repeat,
		Space,
		Round,
		NoRepeat
	}

	public enum DDLogLevel : uint
	{
		DDLogLevelNone
	}

	public enum PXStylesheetOrigin : uint
	{
		Application,
		User,
		View,
		Inline
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct PXStyleableChildrenInfo
	{
		public nint childrenCount;

		public nint childrenIndex;

		public nint childrenOfTypeCount;

		public nint childrenOfTypeIndex;
	}

	public enum PXPseudoClassFunctionType : uint
	{
		Child,
		LastChild,
		OfType,
		LastOfType
	}

	public enum PXPseudoClassPredicateType : uint
	{
		Root,
		FirstChild,
		LastChild,
		FirstOfType,
		LastOfType,
		OnlyChild,
		OnlyOfType,
		Empty
	}

	[Native]
	public enum PXStylesheetTokens : nint
	{
		Error = -1,
		Eof,
		Whitespace,
		Number,
		Class,
		Id,
		Identifier,
		Lcurly,
		Rcurly,
		Lparen,
		Rparen,
		Lbracket,
		Rbracket,
		Semicolon,
		GreaterThan,
		Plus,
		Tilde,
		Star,
		Equal,
		Colon,
		Comma,
		Pipe,
		Slash,
		DoubleColon,
		StartsWith,
		EndsWith,
		Contains,
		ListContains,
		EqualsWithHyphen,
		String,
		LinearGradient,
		RadialGradient,
		Hsl,
		Hsla,
		Hsb,
		Hsba,
		Rgb,
		Rgba,
		HexColor,
		Url,
		Namespace,
		NotPseudoClass,
		LinkPseudoClass,
		VisitedPseudoClass,
		HoverPseudoClass,
		ActivePseudoClass,
		FocusPseudoClass,
		TargetPseudoClass,
		LangPseudoClass,
		EnabledPseudoClass,
		CheckedPseudoClass,
		IndeterminatePseudoClass,
		RootPseudoClass,
		NthChildPseudoClass,
		NthLastChildPseudoClass,
		NthOfTypePseudoClass,
		NthLastOfTypePseudoClass,
		FirstChildPseudoClass,
		LastChildPseudoClass,
		FirstOfTypePseudoClass,
		LastOfTypePseudoClass,
		OnlyChildPseudoClass,
		OnlyOfTypePseudoClass,
		EmptyPseudoClass,
		Nth,
		FirstLinePseudoElement,
		FirstLetterPseudoElement,
		BeforePseudoElement,
		AfterPseudoElement,
		Keyframes,
		Important,
		Import,
		Media,
		FontFace,
		And,
		Ems,
		Exs,
		Length,
		Angle,
		Time,
		Frequency,
		Dimension,
		Percentage
	}

	public enum PXTransformTokens
	{
		Error = -1,
		Eof,
		Whitespace,
		Ems,
		Exs,
		Length,
		Angle,
		Time,
		Frequency,
		Percentage,
		Dimension,
		Number,
		Lparen,
		Rparen,
		Comma,
		Translate,
		Translatex,
		Translatey,
		Scale,
		Scalex,
		Scaley,
		Skew,
		Skewx,
		Skewy,
		Rotate,
		Matrix
	}

	public enum PXValueType : uint
	{
		CGRect,
		CGSize,
		CGFloat,
		CGAffineTransform,
		UIEdgeInsets,
		NSTextAlignment,
		NSLineBreakMode,
		Boolean,
		PXParseErrorDestination,
		PXCacheStylesType,
		UITextBorderStyle,
		CGColorRef,
		PXBorderStyle
	}
}
