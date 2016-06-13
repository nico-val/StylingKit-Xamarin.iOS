using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace StylingKit
{
	// @interface Reverse (NSArray)
	[Category]
	[BaseType (typeof(NSArray))]
	interface NSArray_Reverse
	{
		// -(NSArray *)reversedArray;
		[Export ("reversedArray")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] ReversedArray { get; }
	}

	// @interface PXCSSEncoding (NSDictionary)
	[Category]
	[BaseType (typeof(NSDictionary))]
	interface NSDictionary_PXCSSEncoding
	{
		// -(NSString *)toCSS;
		[Export ("toCSS")]
		[Verify (MethodToProperty)]
		string ToCSS { get; }

		// -(NSString *)toCSSWithKeys:(NSArray *)keys;
		[Export ("toCSSWithKeys:")]
		[Verify (StronglyTypedNSArray)]
		string ToCSSWithKeys (NSObject[] keys);
	}

	// @interface PXObject (NSDictionary)
	[Category]
	[BaseType (typeof(NSDictionary))]
	interface NSDictionary_PXObject
	{
		// -(id)nilableObjectForKey:(id)key;
		[Export ("nilableObjectForKey:")]
		NSObject NilableObjectForKey (NSObject key);

		// -(id)rectForKey:(id)key;
		[Export ("rectForKey:")]
		NSObject RectForKey (NSObject key);

		// -(id)floatForKey:(id)key;
		[Export ("floatForKey:")]
		NSObject FloatForKey (NSObject key);

		// -(id)colorRefForKey:(id)key;
		[Export ("colorRefForKey:")]
		NSObject ColorRefForKey (NSObject key);

		// -(id)sizeForKey:(id)key;
		[Export ("sizeForKey:")]
		NSObject SizeForKey (NSObject key);

		// -(BOOL)booleanForKey:(id)key;
		[Export ("booleanForKey:")]
		bool BooleanForKey (NSObject key);

		// -(id)transformForKey:(id)key;
		[Export ("transformForKey:")]
		NSObject TransformForKey (NSObject key);

		// -(id)insetsForKey:(id)key;
		[Export ("insetsForKey:")]
		NSObject InsetsForKey (NSObject key);

		// -(id)lineBreakModeForKey:(id)key;
		[Export ("lineBreakModeForKey:")]
		NSObject LineBreakModeForKey (NSObject key);

		// -(id)textAlignmentForKey:(id)key;
		[Export ("textAlignmentForKey:")]
		NSObject TextAlignmentForKey (NSObject key);
	}

	// @interface QueueAdditions (NSMutableArray)
	[Category]
	[BaseType (typeof(NSMutableArray))]
	interface NSMutableArray_QueueAdditions
	{
		// -(id)dequeue;
		[Export ("dequeue")]
		[Verify (MethodToProperty)]
		NSObject Dequeue { get; }

		// -(void)enqueue:(id)object;
		[Export ("enqueue:")]
		void Enqueue (NSObject @object);

		// -(BOOL)addObjectIfNotNil:(id)object;
		[Export ("addObjectIfNotNil:")]
		bool AddObjectIfNotNil (NSObject @object);
	}

	// @interface StackAdditions (NSMutableArray)
	[Category]
	[BaseType (typeof(NSMutableArray))]
	interface NSMutableArray_StackAdditions
	{
		// -(void)push:(id)item;
		[Export ("push:")]
		void Push (NSObject item);

		// -(id)pop;
		[Export ("pop")]
		[Verify (MethodToProperty)]
		NSObject Pop { get; }
	}

	// @interface PXObject (NSMutableDictionary)
	[Category]
	[BaseType (typeof(NSMutableDictionary))]
	interface NSMutableDictionary_PXObject
	{
		// -(void)setNilableObject:(id)object forKey:(id<NSCopying>)key;
		[Export ("setNilableObject:forKey:")]
		void SetNilableObject (NSObject @object, NSCopying key);

		// -(void)setRect:(id)rect forKey:(id<NSCopying>)key;
		[Export ("setRect:forKey:")]
		void SetRect (NSObject rect, NSCopying key);

		// -(void)setFloat:(id)floatValue forKey:(id<NSCopying>)key;
		[Export ("setFloat:forKey:")]
		void SetFloat (NSObject floatValue, NSCopying key);

		// -(void)setColorRef:(id)colorRef forKey:(id<NSCopying>)key;
		[Export ("setColorRef:forKey:")]
		void SetColorRef (NSObject colorRef, NSCopying key);

		// -(void)setSize:(id)size forKey:(id<NSCopying>)key;
		[Export ("setSize:forKey:")]
		void SetSize (NSObject size, NSCopying key);

		// -(void)setBoolean:(BOOL)booleanValue forKey:(id<NSCopying>)key;
		[Export ("setBoolean:forKey:")]
		void SetBoolean (bool booleanValue, NSCopying key);

		// -(void)setTransform:(id)transform forKey:(id<NSCopying>)key;
		[Export ("setTransform:forKey:")]
		void SetTransform (NSObject transform, NSCopying key);

		// -(void)setInsets:(id)insets forKey:(id<NSCopying>)key;
		[Export ("setInsets:forKey:")]
		void SetInsets (NSObject insets, NSCopying key);

		// -(void)setLineBreakMode:(id)mode forKey:(id<NSCopying>)key;
		[Export ("setLineBreakMode:forKey:")]
		void SetLineBreakMode (NSObject mode, NSCopying key);

		// -(void)setTextAlignment:(id)alignment forKey:(id<NSCopying>)key;
		[Export ("setTextAlignment:forKey:")]
		void SetTextAlignment (NSObject alignment, NSCopying key);
	}

	// @interface PXClass (NSObject)
	[Category]
	[BaseType (typeof(NSObject))]
	interface NSObject_PXClass
	{
		// @property (readonly, nonatomic) Class pxClass;
		[Export ("pxClass")]
		Class PxClass { get; }
	}

	// @protocol PXPaint <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface PXPaint
	{
		// @required @property (nonatomic) int blendMode;
		[Export ("blendMode")]
		int BlendMode { get; set; }

		// @required @property (readonly, getter = isOpaque, nonatomic) BOOL opaque;
		[Export ("opaque")]
		bool Opaque { [Bind ("isOpaque")] get; }

		// @required -(void)applyFillToPath:(id)path withContext:(id)context;
		[Abstract]
		[Export ("applyFillToPath:withContext:")]
		void ApplyFillToPath (NSObject path, NSObject context);

		// @required -(id<PXPaint>)lightenByPercent:(id)percent;
		[Abstract]
		[Export ("lightenByPercent:")]
		PXPaint LightenByPercent (NSObject percent);

		// @required -(id<PXPaint>)darkenByPercent:(id)percent;
		[Abstract]
		[Export ("darkenByPercent:")]
		PXPaint DarkenByPercent (NSObject percent);
	}

	// @protocol PXShadowPaint <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface PXShadowPaint
	{
		// @required -(void)applyOutsetToPath:(id)path withContext:(id)context;
		[Abstract]
		[Export ("applyOutsetToPath:withContext:")]
		void ApplyOutsetToPath (NSObject path, NSObject context);

		// @required -(void)applyInsetToPath:(id)path withContext:(id)context;
		[Abstract]
		[Export ("applyInsetToPath:withContext:")]
		void ApplyInsetToPath (NSObject path, NSObject context);
	}

	// @interface PXShadow : NSObject <PXShadowPaint>
	[BaseType (typeof(NSObject))]
	interface PXShadow : IPXShadowPaint
	{
		// @property (nonatomic) BOOL inset;
		[Export ("inset")]
		bool Inset { get; set; }

		// @property (nonatomic) int horizontalOffset;
		[Export ("horizontalOffset")]
		int HorizontalOffset { get; set; }

		// @property (nonatomic) int verticalOffset;
		[Export ("verticalOffset")]
		int VerticalOffset { get; set; }

		// @property (nonatomic) int blurDistance;
		[Export ("blurDistance")]
		int BlurDistance { get; set; }

		// @property (nonatomic) int spreadDistance;
		[Export ("spreadDistance")]
		int SpreadDistance { get; set; }

		// @property (nonatomic, strong) int * color;
		[Export ("color", ArgumentSemantic.Strong)]
		unsafe int* Color { get; set; }

		// @property (nonatomic) int blendMode;
		[Export ("blendMode")]
		int BlendMode { get; set; }
	}

	// @interface PXDimension : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PXDimension
	{
		// @property (readonly, nonatomic) int number;
		[Export ("number")]
		int Number { get; }

		// @property (readonly, nonatomic, strong) NSString * dimension;
		[Export ("dimension", ArgumentSemantic.Strong)]
		string Dimension { get; }

		// @property (readonly, nonatomic) PXDimensionType type;
		[Export ("type")]
		PXDimensionType Type { get; }

		// +(instancetype)dimensionWithNumber:(id)number withDimension:(NSString *)dimension;
		[Static]
		[Export ("dimensionWithNumber:withDimension:")]
		PXDimension DimensionWithNumber (NSObject number, string dimension);

		// -(instancetype)initWithNumber:(id)number withDimension:(NSString *)dimension __attribute__((objc_designated_initializer));
		[Export ("initWithNumber:withDimension:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject number, string dimension);

		// @property (readonly, getter = isLength, nonatomic) BOOL length;
		[Export ("length")]
		bool Length { [Bind ("isLength")] get; }

		// @property (readonly, getter = isAngle, nonatomic) BOOL angle;
		[Export ("angle")]
		bool Angle { [Bind ("isAngle")] get; }

		// @property (readonly, getter = isTime, nonatomic) BOOL time;
		[Export ("time")]
		bool Time { [Bind ("isTime")] get; }

		// @property (readonly, getter = isFrequency, nonatomic) BOOL frequency;
		[Export ("frequency")]
		bool Frequency { [Bind ("isFrequency")] get; }

		// @property (readonly, getter = isPercentage, nonatomic) BOOL percentage;
		[Export ("percentage")]
		bool Percentage { [Bind ("isPercentage")] get; }

		// @property (readonly, getter = isUserDefined, nonatomic) BOOL userDefined;
		[Export ("userDefined")]
		bool UserDefined { [Bind ("isUserDefined")] get; }

		// @property (readonly, nonatomic, strong) PXDimension * points;
		[Export ("points", ArgumentSemantic.Strong)]
		PXDimension Points { get; }

		// @property (readonly, nonatomic, strong) PXDimension * degrees;
		[Export ("degrees", ArgumentSemantic.Strong)]
		PXDimension Degrees { get; }

		// @property (readonly, nonatomic, strong) PXDimension * radians;
		[Export ("radians", ArgumentSemantic.Strong)]
		PXDimension Radians { get; }
	}

	// @interface PXOffsets : NSObject
	[BaseType (typeof(NSObject))]
	interface PXOffsets
	{
		// @property (readonly, nonatomic) int top;
		[Export ("top")]
		int Top { get; }

		// @property (readonly, nonatomic) int right;
		[Export ("right")]
		int Right { get; }

		// @property (readonly, nonatomic) int bottom;
		[Export ("bottom")]
		int Bottom { get; }

		// @property (readonly, nonatomic) int left;
		[Export ("left")]
		int Left { get; }

		// @property (readonly, nonatomic) BOOL hasOffset;
		[Export ("hasOffset")]
		bool HasOffset { get; }

		// -(instancetype)initWithTop:(id)top right:(id)right bottom:(id)bottom left:(id)left __attribute__((objc_designated_initializer));
		[Export ("initWithTop:right:bottom:left:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject top, NSObject right, NSObject bottom, NSObject left);
	}

	// @protocol PXStyleable <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface PXStyleable
	{
		// @required @property (copy, nonatomic) NSString * styleId;
		[Abstract]
		[Export ("styleId")]
		string StyleId { get; set; }

		// @required @property (copy, nonatomic) NSString * styleClass;
		[Abstract]
		[Export ("styleClass")]
		string StyleClass { get; set; }

		// @required @property (readonly, nonatomic) NSSet * styleClasses;
		[Abstract]
		[Export ("styleClasses")]
		NSSet StyleClasses { get; }

		// @required @property (nonatomic) BOOL styleChangeable;
		[Abstract]
		[Export ("styleChangeable")]
		bool StyleChangeable { get; set; }

		// @required @property (nonatomic) PXStylingMode styleMode;
		[Abstract]
		[Export ("styleMode", ArgumentSemantic.Assign)]
		PXStylingMode StyleMode { get; set; }

		// @required @property (readonly, copy, nonatomic) NSString * pxStyleElementName;
		[Abstract]
		[Export ("pxStyleElementName")]
		string PxStyleElementName { get; }

		// @required @property (readonly, nonatomic, weak) id _Nullable pxStyleParent;
		[Abstract]
		[NullAllowed, Export ("pxStyleParent", ArgumentSemantic.Weak)]
		NSObject PxStyleParent { get; }

		// @required @property (readonly, copy, nonatomic) NSArray * pxStyleChildren;
		[Abstract]
		[Export ("pxStyleChildren", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] PxStyleChildren { get; }

		// @required @property (nonatomic) int bounds;
		[Abstract]
		[Export ("bounds")]
		int Bounds { get; set; }

		// @required @property (nonatomic) int frame;
		[Abstract]
		[Export ("frame")]
		int Frame { get; set; }

		// @required @property (readonly, copy, nonatomic) NSString * styleKey;
		[Abstract]
		[Export ("styleKey")]
		string StyleKey { get; }

		// @optional -(void)updateStyles;
		[Export ("updateStyles")]
		void UpdateStyles ();

		// @optional -(void)updateStylesNonRecursively;
		[Export ("updateStylesNonRecursively")]
		void UpdateStylesNonRecursively ();

		// @optional -(void)updateStylesAsync;
		[Export ("updateStylesAsync")]
		void UpdateStylesAsync ();

		// @optional -(void)updateStylesNonRecursivelyAsync;
		[Export ("updateStylesNonRecursivelyAsync")]
		void UpdateStylesNonRecursivelyAsync ();

		// @optional @property (copy, nonatomic) NSString * styleCSS;
		[Export ("styleCSS")]
		string StyleCSS { get; set; }

		// @optional @property (readonly, copy, nonatomic) NSString * pxStyleNamespace;
		[Export ("pxStyleNamespace")]
		string PxStyleNamespace { get; }

		// @optional @property (readonly, copy, nonatomic) NSArray * supportedPseudoClasses;
		[Export ("supportedPseudoClasses", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] SupportedPseudoClasses { get; }

		// @optional @property (readonly, copy, nonatomic) NSString * defaultPseudoClass;
		[Export ("defaultPseudoClass")]
		string DefaultPseudoClass { get; }

		// @optional -(BOOL)canStylePseudoClass:(NSString *)pseudoClass;
		[Export ("canStylePseudoClass:")]
		bool CanStylePseudoClass (string pseudoClass);

		// @optional @property (readonly, nonatomic) BOOL preventStyling;
		[Export ("preventStyling")]
		bool PreventStyling { get; }

		// @optional @property (readonly, copy, nonatomic) NSArray * supportedPseudoElements;
		[Export ("supportedPseudoElements", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] SupportedPseudoElements { get; }

		// @optional -(void)registerNotifications;
		[Export ("registerNotifications")]
		void RegisterNotifications ();

		// @optional -(NSString *)attributeValueForName:(NSString *)name withNamespace:(NSString *)aNamespace;
		[Export ("attributeValueForName:withNamespace:")]
		string AttributeValueForName (string name, string aNamespace);

		// @optional -(id<PXStyleable>)styleableForPseudoElement:(NSString *)pseudoElement;
		[Export ("styleableForPseudoElement:")]
		PXStyleable StyleableForPseudoElement (string pseudoElement);

		// @optional @property (readonly, copy, nonatomic) NSDictionary * animationPropertyHandlers;
		[Export ("animationPropertyHandlers", ArgumentSemantic.Copy)]
		NSDictionary AnimationPropertyHandlers { get; }
	}

	// @interface PixateFreestyleConfiguration : NSObject <PXStyleable>
	[BaseType (typeof(NSObject))]
	interface PixateFreestyleConfiguration : IPXStyleable
	{
		// @property (copy, nonatomic) NSString * styleId;
		[Export ("styleId")]
		string StyleId { get; set; }

		// @property (copy, nonatomic) NSString * styleClass;
		[Export ("styleClass")]
		string StyleClass { get; set; }

		// @property (nonatomic) PXStylingMode styleMode;
		[Export ("styleMode", ArgumentSemantic.Assign)]
		PXStylingMode StyleMode { get; set; }

		// @property (nonatomic) PXParseErrorDestination parseErrorDestination;
		[Export ("parseErrorDestination", ArgumentSemantic.Assign)]
		PXParseErrorDestination ParseErrorDestination { get; set; }

		// @property (nonatomic) PXCacheStylesType cacheStylesType;
		[Export ("cacheStylesType", ArgumentSemantic.Assign)]
		PXCacheStylesType CacheStylesType { get; set; }

		// -(BOOL)cacheImages;
		[Export ("cacheImages")]
		[Verify (MethodToProperty)]
		bool CacheImages { get; }

		// -(BOOL)cacheStyles;
		[Export ("cacheStyles")]
		[Verify (MethodToProperty)]
		bool CacheStyles { get; }

		// -(BOOL)preventRedundantStyling;
		[Export ("preventRedundantStyling")]
		[Verify (MethodToProperty)]
		bool PreventRedundantStyling { get; }

		// @property (nonatomic) NSUInteger imageCacheCount;
		[Export ("imageCacheCount")]
		nuint ImageCacheCount { get; set; }

		// @property (nonatomic) NSUInteger imageCacheSize;
		[Export ("imageCacheSize")]
		nuint ImageCacheSize { get; set; }

		// @property (nonatomic) NSUInteger styleCacheCount;
		[Export ("styleCacheCount")]
		nuint StyleCacheCount { get; set; }

		// -(id)propertyValueForName:(NSString *)name;
		[Export ("propertyValueForName:")]
		NSObject PropertyValueForName (string name);

		// -(void)setPropertyValue:(id)value forName:(NSString *)name;
		[Export ("setPropertyValue:forName:")]
		void SetPropertyValue (NSObject value, string name);

		// -(void)sendParseMessage:(NSString *)message;
		[Export ("sendParseMessage:")]
		void SendParseMessage (string message);
	}

	// @interface PXBorderInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface PXBorderInfo
	{
		// @property (nonatomic) id<PXPaint> paint;
		[Export ("paint", ArgumentSemantic.Assign)]
		PXPaint Paint { get; set; }

		// @property (nonatomic) PXBorderStyle style;
		[Export ("style", ArgumentSemantic.Assign)]
		PXBorderStyle Style { get; set; }

		// @property (nonatomic) int width;
		[Export ("width")]
		int Width { get; set; }

		// -(instancetype)initWithPaint:(id<PXPaint>)paint width:(id)width;
		[Export ("initWithPaint:width:")]
		IntPtr Constructor (PXPaint paint, NSObject width);

		// -(instancetype)initWithPaint:(id<PXPaint>)paint width:(id)width style:(PXBorderStyle)style __attribute__((objc_designated_initializer));
		[Export ("initWithPaint:width:style:")]
		[DesignatedInitializer]
		IntPtr Constructor (PXPaint paint, NSObject width, PXBorderStyle style);

		// @property (readonly, getter = isOpaque, nonatomic) BOOL opaque;
		[Export ("opaque")]
		bool Opaque { [Bind ("isOpaque")] get; }

		// @property (readonly, nonatomic) BOOL hasContent;
		[Export ("hasContent")]
		bool HasContent { get; }
	}

	// @interface PXDeclaration : NSObject
	[BaseType (typeof(NSObject))]
	interface PXDeclaration
	{
		// @property (nonatomic, strong) NSString * name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (readonly, nonatomic, strong) NSArray * lexemes;
		[Export ("lexemes", ArgumentSemantic.Strong)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Lexemes { get; }

		// @property (nonatomic) BOOL important;
		[Export ("important")]
		bool Important { get; set; }

		// -(instancetype)initWithName:(NSString *)name;
		[Export ("initWithName:")]
		IntPtr Constructor (string name);

		// -(instancetype)initWithName:(NSString *)name value:(NSString *)value __attribute__((objc_designated_initializer));
		[Export ("initWithName:value:")]
		[DesignatedInitializer]
		IntPtr Constructor (string name, string value);

		// -(void)setSource:(NSString *)source filename:(NSString *)filename lexemes:(NSArray *)lexemes;
		[Export ("setSource:filename:lexemes:")]
		[Verify (StronglyTypedNSArray)]
		void SetSource (string source, string filename, NSObject[] lexemes);

		// @property (readonly, nonatomic) int affineTransformValue;
		[Export ("affineTransformValue")]
		int AffineTransformValue { get; }

		// @property (readonly, copy, nonatomic) NSArray * animationInfoList;
		[Export ("animationInfoList", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] AnimationInfoList { get; }

		// @property (readonly, copy, nonatomic) NSArray * transitionInfoList;
		[Export ("transitionInfoList", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] TransitionInfoList { get; }

		// @property (readonly, copy, nonatomic) NSArray * animationDirectionList;
		[Export ("animationDirectionList", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] AnimationDirectionList { get; }

		// @property (readonly, copy, nonatomic) NSArray * animationFillModeList;
		[Export ("animationFillModeList", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] AnimationFillModeList { get; }

		// @property (readonly, copy, nonatomic) NSArray * animationPlayStateList;
		[Export ("animationPlayStateList", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] AnimationPlayStateList { get; }

		// @property (readonly, copy, nonatomic) NSArray * animationTimingFunctionList;
		[Export ("animationTimingFunctionList", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] AnimationTimingFunctionList { get; }

		// @property (readonly, nonatomic) BOOL booleanValue;
		[Export ("booleanValue")]
		bool BooleanValue { get; }

		// @property (readonly, nonatomic, strong) PXBorderInfo * borderValue;
		[Export ("borderValue", ArgumentSemantic.Strong)]
		PXBorderInfo BorderValue { get; }

		// @property (readonly, copy, nonatomic) NSArray * borderRadiiList;
		[Export ("borderRadiiList", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] BorderRadiiList { get; }

		// @property (readonly, nonatomic) PXBorderStyle borderStyleValue;
		[Export ("borderStyleValue")]
		PXBorderStyle BorderStyleValue { get; }

		// @property (readonly, copy, nonatomic) NSArray * borderStyleList;
		[Export ("borderStyleList", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] BorderStyleList { get; }

		// @property (readonly, nonatomic) PXCacheStylesType cacheStylesTypeValue;
		[Export ("cacheStylesTypeValue")]
		PXCacheStylesType CacheStylesTypeValue { get; }

		// @property (readonly, copy, nonatomic) int * colorValue;
		[Export ("colorValue", ArgumentSemantic.Copy)]
		unsafe int* ColorValue { get; }

		// @property (readonly, nonatomic) int floatValue;
		[Export ("floatValue")]
		int FloatValue { get; }

		// @property (readonly, copy, nonatomic) NSArray * floatListValue;
		[Export ("floatListValue", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] FloatListValue { get; }

		// @property (readonly, nonatomic) int insetsValue;
		[Export ("insetsValue")]
		int InsetsValue { get; }

		// @property (readonly, nonatomic, strong) PXDimension * lengthValue;
		[Export ("lengthValue", ArgumentSemantic.Strong)]
		PXDimension LengthValue { get; }

		// @property (readonly, nonatomic) int lineBreakModeValue;
		[Export ("lineBreakModeValue")]
		int LineBreakModeValue { get; }

		// @property (readonly, copy, nonatomic) NSArray * nameListValue;
		[Export ("nameListValue", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] NameListValue { get; }

		// @property (readonly, nonatomic, strong) PXOffsets * offsetsValue;
		[Export ("offsetsValue", ArgumentSemantic.Strong)]
		PXOffsets OffsetsValue { get; }

		// @property (readonly, copy, nonatomic) NSArray * paintList;
		[Export ("paintList", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] PaintList { get; }

		// @property (readonly, nonatomic, strong) id<PXPaint> paintValue;
		[Export ("paintValue", ArgumentSemantic.Strong)]
		PXPaint PaintValue { get; }

		// @property (readonly, nonatomic) PXParseErrorDestination parseErrorDestinationValue;
		[Export ("parseErrorDestinationValue")]
		PXParseErrorDestination ParseErrorDestinationValue { get; }

		// @property (readonly, nonatomic) int secondsValue;
		[Export ("secondsValue")]
		int SecondsValue { get; }

		// @property (readonly, copy, nonatomic) NSArray * secondsListValue;
		[Export ("secondsListValue", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] SecondsListValue { get; }

		// @property (readonly, nonatomic) int sizeValue;
		[Export ("sizeValue")]
		int SizeValue { get; }

		// @property (readonly, nonatomic, strong) PXShadow * shadowValue;
		[Export ("shadowValue", ArgumentSemantic.Strong)]
		PXShadow ShadowValue { get; }

		// @property (readonly, copy, nonatomic) NSString * stringValue;
		[Export ("stringValue")]
		string StringValue { get; }

		// @property (readonly, nonatomic) int textAlignmentValue;
		[Export ("textAlignmentValue")]
		int TextAlignmentValue { get; }

		// @property (readonly, nonatomic) int textBorderStyleValue;
		[Export ("textBorderStyleValue")]
		int TextBorderStyleValue { get; }

		// -(NSString *)transformString:(NSString *)value;
		[Export ("transformString:")]
		string TransformString (string value);

		// @property (readonly, nonatomic, strong) PXDimension * letterSpacingValue;
		[Export ("letterSpacingValue", ArgumentSemantic.Strong)]
		PXDimension LetterSpacingValue { get; }

		// @property (readonly, copy, nonatomic) NSURL * URLValue;
		[Export ("URLValue", ArgumentSemantic.Copy)]
		NSUrl URLValue { get; }
	}

	// @interface PXSpecificity : NSObject
	[BaseType (typeof(NSObject))]
	interface PXSpecificity
	{
		// -(NSComparisonResult)compareSpecificity:(PXSpecificity *)specificity;
		[Export ("compareSpecificity:")]
		NSComparisonResult CompareSpecificity (PXSpecificity specificity);

		// -(void)incrementSpecifity:(PXSpecificityType)specificity;
		[Export ("incrementSpecifity:")]
		void IncrementSpecifity (PXSpecificityType specificity);

		// -(void)setSpecificity:(PXSpecificityType)specificity toValue:(int)value;
		[Export ("setSpecificity:toValue:")]
		void SetSpecificity (PXSpecificityType specificity, int value);
	}

	// @interface PXSourceWriter : NSObject
	[BaseType (typeof(NSObject))]
	interface PXSourceWriter
	{
		// -(void)increaseIndent;
		[Export ("increaseIndent")]
		void IncreaseIndent ();

		// -(void)decreaseIndent;
		[Export ("decreaseIndent")]
		void DecreaseIndent ();

		// -(void)printIndent;
		[Export ("printIndent")]
		void PrintIndent ();

		// -(void)printWithIndent:(NSString *)text;
		[Export ("printWithIndent:")]
		void PrintWithIndent (string text);

		// -(void)print:(NSString *)text;
		[Export ("print:")]
		void Print (string text);

		// -(void)printNewLine;
		[Export ("printNewLine")]
		void PrintNewLine ();

		// -(void)printWithNewLine:(NSString *)text;
		[Export ("printWithNewLine:")]
		void PrintWithNewLine (string text);
	}

	// @protocol PXSourceEmitter <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface PXSourceEmitter
	{
		// @optional -(NSString *)source;
		[Export ("source")]
		[Verify (MethodToProperty)]
		string Source { get; }

		// @optional -(void)sourceWithSourceWriter:(PXSourceWriter *)writer;
		[Export ("sourceWithSourceWriter:")]
		void SourceWithSourceWriter (PXSourceWriter writer);
	}

	// @protocol PXSelector <PXSourceEmitter>
	[Protocol, Model]
	interface PXSelector : IPXSourceEmitter
	{
		// @required -(BOOL)matches:(id<PXStyleable>)element;
		[Abstract]
		[Export ("matches:")]
		bool Matches (PXStyleable element);

		// @required -(void)incrementSpecificity:(PXSpecificity *)specificity;
		[Abstract]
		[Export ("incrementSpecificity:")]
		void IncrementSpecificity (PXSpecificity specificity);
	}

	// @interface PXTypeSelector : NSObject <PXSelector>
	[BaseType (typeof(NSObject))]
	interface PXTypeSelector : IPXSelector
	{
		// @property (readonly, nonatomic, strong) NSString * namespaceURI;
		[Export ("namespaceURI", ArgumentSemantic.Strong)]
		string NamespaceURI { get; }

		// @property (readonly, nonatomic, strong) NSString * typeName;
		[Export ("typeName", ArgumentSemantic.Strong)]
		string TypeName { get; }

		// @property (readonly, nonatomic) BOOL hasUniversalNamespace;
		[Export ("hasUniversalNamespace")]
		bool HasUniversalNamespace { get; }

		// @property (readonly, nonatomic) BOOL hasUniversalType;
		[Export ("hasUniversalType")]
		bool HasUniversalType { get; }

		// @property (readonly, nonatomic, strong) NSArray * attributeExpressions;
		[Export ("attributeExpressions", ArgumentSemantic.Strong)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] AttributeExpressions { get; }

		// @property (readonly, nonatomic) BOOL hasPseudoClasses;
		[Export ("hasPseudoClasses")]
		bool HasPseudoClasses { get; }

		// @property (nonatomic, strong) NSString * pseudoElement;
		[Export ("pseudoElement", ArgumentSemantic.Strong)]
		string PseudoElement { get; set; }

		// @property (readonly, nonatomic) NSString * styleId;
		[Export ("styleId")]
		string StyleId { get; }

		// @property (readonly, nonatomic) NSSet * styleClasses;
		[Export ("styleClasses")]
		NSSet StyleClasses { get; }

		// -(instancetype)initWithTypeName:(NSString *)type;
		[Export ("initWithTypeName:")]
		IntPtr Constructor (string type);

		// -(instancetype)initWithNamespaceURI:(NSString *)uri typeName:(NSString *)type __attribute__((objc_designated_initializer));
		[Export ("initWithNamespaceURI:typeName:")]
		[DesignatedInitializer]
		IntPtr Constructor (string uri, string type);

		// -(void)addAttributeExpression:(id<PXSelector>)expression;
		[Export ("addAttributeExpression:")]
		void AddAttributeExpression (PXSelector expression);

		// -(BOOL)hasPseudoClass:(NSString *)className;
		[Export ("hasPseudoClass:")]
		bool HasPseudoClass (string className);
	}

	// @interface PXDeclarationContainer : NSObject
	[BaseType (typeof(NSObject))]
	interface PXDeclarationContainer
	{
		// @property (readonly, nonatomic) NSArray * declarations;
		[Export ("declarations")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Declarations { get; }

		// -(void)addDeclaration:(PXDeclaration *)declaration;
		[Export ("addDeclaration:")]
		void AddDeclaration (PXDeclaration declaration);

		// -(void)removeDeclaration:(PXDeclaration *)declaration;
		[Export ("removeDeclaration:")]
		void RemoveDeclaration (PXDeclaration declaration);

		// -(BOOL)hasDeclarationForName:(NSString *)name;
		[Export ("hasDeclarationForName:")]
		bool HasDeclarationForName (string name);

		// -(PXDeclaration *)declarationForName:(NSString *)name;
		[Export ("declarationForName:")]
		PXDeclaration DeclarationForName (string name);
	}

	// @interface PXRuleSet : PXDeclarationContainer
	[BaseType (typeof(PXDeclarationContainer))]
	interface PXRuleSet
	{
		// @property (readonly, nonatomic) NSArray * selectors;
		[Export ("selectors")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Selectors { get; }

		// @property (readonly, nonatomic) PXSpecificity * specificity;
		[Export ("specificity")]
		PXSpecificity Specificity { get; }

		// @property (readonly, nonatomic) PXTypeSelector * targetTypeSelector;
		[Export ("targetTypeSelector")]
		PXTypeSelector TargetTypeSelector { get; }

		// +(instancetype)ruleSetWithMergedRuleSets:(NSArray *)ruleSets;
		[Static]
		[Export ("ruleSetWithMergedRuleSets:")]
		[Verify (StronglyTypedNSArray)]
		PXRuleSet RuleSetWithMergedRuleSets (NSObject[] ruleSets);

		// -(void)addSelector:(id<PXSelector>)selector;
		[Export ("addSelector:")]
		void AddSelector (PXSelector selector);

		// -(BOOL)matches:(id<PXStyleable>)element;
		[Export ("matches:")]
		bool Matches (PXStyleable element);
	}

	// @protocol PXRenderable <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface PXRenderable
	{
		// @required @property (nonatomic, strong) id<PXRenderable> parent;
		[Export ("parent", ArgumentSemantic.Strong)]
		PXRenderable Parent { get; set; }

		// @required @property (nonatomic) int transform;
		[Export ("transform")]
		int Transform { get; set; }

		// @required @property (nonatomic) PXOffsets * padding;
		[Export ("padding", ArgumentSemantic.Assign)]
		PXOffsets Padding { get; set; }

		// @required -(void)render:(id)context;
		[Abstract]
		[Export ("render:")]
		void Render (NSObject context);

		// @required -(id)renderToImageWithBounds:(id)bounds withOpacity:(BOOL)opaque;
		[Abstract]
		[Export ("renderToImageWithBounds:withOpacity:")]
		NSObject RenderToImageWithBounds (NSObject bounds, bool opaque);
	}

	// @protocol PXStrokeRenderer <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface PXStrokeRenderer
	{
		// @required @property (readonly, getter = isOpaque, nonatomic) BOOL opaque;
		[Export ("opaque")]
		bool Opaque { [Bind ("isOpaque")] get; }

		// @required -(void)applyStrokeToPath:(id)path withContext:(id)context;
		[Abstract]
		[Export ("applyStrokeToPath:withContext:")]
		void WithContext (NSObject path, NSObject context);
	}

	// @protocol PXPaintable <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface PXPaintable
	{
		// @required @property (nonatomic, strong) id<PXStrokeRenderer> stroke;
		[Export ("stroke", ArgumentSemantic.Strong)]
		PXStrokeRenderer Stroke { get; set; }

		// @required @property (nonatomic, strong) id<PXPaint> fill;
		[Export ("fill", ArgumentSemantic.Strong)]
		PXPaint Fill { get; set; }

		// @required @property (nonatomic) int opacity;
		[Export ("opacity")]
		int Opacity { get; set; }

		// @required @property (nonatomic) BOOL visible;
		[Export ("visible")]
		bool Visible { get; set; }

		// @required @property (nonatomic, strong) PXShape * clippingPath;
		[Export ("clippingPath", ArgumentSemantic.Strong)]
		PXShape ClippingPath { get; set; }

		// @required @property (nonatomic, strong) id<PXShadowPaint> shadow;
		[Export ("shadow", ArgumentSemantic.Strong)]
		PXShadowPaint Shadow { get; set; }
	}

	// @interface PXShapeDocument : NSObject <PXRenderable>
	[BaseType (typeof(NSObject))]
	interface PXShapeDocument : IPXRenderable
	{
		// @property (nonatomic) int bounds;
		[Export ("bounds")]
		int Bounds { get; set; }

		// @property (nonatomic, strong) id<PXRenderable> shape;
		[Export ("shape", ArgumentSemantic.Strong)]
		PXRenderable Shape { get; set; }

		// @property (nonatomic, strong) PXShapeView * parentView;
		[Export ("parentView", ArgumentSemantic.Strong)]
		PXShapeView ParentView { get; set; }

		// -(id<PXRenderable>)shapeForName:(NSString *)name;
		[Export ("shapeForName:")]
		PXRenderable ShapeForName (string name);

		// -(void)addShape:(id<PXRenderable>)shape forName:(NSString *)name;
		[Export ("addShape:forName:")]
		void AddShape (PXRenderable shape, string name);
	}

	// @interface PXShape : NSObject <PXRenderable, PXPaintable>
	[BaseType (typeof(NSObject))]
	interface PXShape : IPXRenderable, IPXPaintable
	{
		// @property (readonly, nonatomic) int path;
		[Export ("path")]
		int Path { get; }

		// @property (readonly, nonatomic) PXShapeDocument * owningDocument;
		[Export ("owningDocument")]
		PXShapeDocument OwningDocument { get; }

		// @property (readonly, nonatomic) int newPath;
		[Export ("newPath")]
		int NewPath { get; }

		// -(void)clearPath;
		[Export ("clearPath")]
		void ClearPath ();

		// -(void)renderChildren:(id)context;
		[Export ("renderChildren:")]
		void RenderChildren (NSObject context);

		// -(void)setNeedsDisplay;
		[Export ("setNeedsDisplay")]
		void SetNeedsDisplay ();
	}

	// @interface PXShadowGroup : NSObject <PXShadowPaint>
	[BaseType (typeof(NSObject))]
	interface PXShadowGroup : IPXShadowPaint
	{
		// @property (readonly, nonatomic) NSUInteger count;
		[Export ("count")]
		nuint Count { get; }

		// @property (readonly, nonatomic) NSArray * shadows;
		[Export ("shadows")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Shadows { get; }

		// -(void)addShadowPaint:(id<PXShadowPaint>)shadow;
		[Export ("addShadowPaint:")]
		void AddShadowPaint (PXShadowPaint shadow);
	}

	// @interface PXKeyframeBlock : PXDeclarationContainer
	[BaseType (typeof(PXDeclarationContainer))]
	[DisableDefaultCtor]
	interface PXKeyframeBlock
	{
		// @property (readonly, nonatomic) int offset;
		[Export ("offset")]
		int Offset { get; }

		// -(instancetype)initWithOffset:(id)offset __attribute__((objc_designated_initializer));
		[Export ("initWithOffset:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject offset);
	}

	// @interface PXKeyframe : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PXKeyframe
	{
		// @property (readonly, nonatomic, strong) NSString * name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; }

		// @property (readonly, nonatomic, strong) NSArray * blocks;
		[Export ("blocks", ArgumentSemantic.Strong)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Blocks { get; }

		// -(instancetype)initWithName:(NSString *)name __attribute__((objc_designated_initializer));
		[Export ("initWithName:")]
		[DesignatedInitializer]
		IntPtr Constructor (string name);

		// -(void)addKeyframeBlock:(PXKeyframeBlock *)block;
		[Export ("addKeyframeBlock:")]
		void AddKeyframeBlock (PXKeyframeBlock block);
	}

	// @interface PXAnimationInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface PXAnimationInfo
	{
		// @property (nonatomic, strong) NSString * animationName;
		[Export ("animationName", ArgumentSemantic.Strong)]
		string AnimationName { get; set; }

		// @property (nonatomic) int animationDuration;
		[Export ("animationDuration")]
		int AnimationDuration { get; set; }

		// @property (nonatomic) PXAnimationTimingFunction animationTimingFunction;
		[Export ("animationTimingFunction", ArgumentSemantic.Assign)]
		PXAnimationTimingFunction AnimationTimingFunction { get; set; }

		// @property (nonatomic) NSUInteger animationIterationCount;
		[Export ("animationIterationCount")]
		nuint AnimationIterationCount { get; set; }

		// @property (nonatomic) PXAnimationDirection animationDirection;
		[Export ("animationDirection", ArgumentSemantic.Assign)]
		PXAnimationDirection AnimationDirection { get; set; }

		// @property (nonatomic) PXAnimationPlayState animationPlayState;
		[Export ("animationPlayState", ArgumentSemantic.Assign)]
		PXAnimationPlayState AnimationPlayState { get; set; }

		// @property (nonatomic) int animationDelay;
		[Export ("animationDelay")]
		int AnimationDelay { get; set; }

		// @property (nonatomic) PXAnimationFillMode animationFillMode;
		[Export ("animationFillMode", ArgumentSemantic.Assign)]
		PXAnimationFillMode AnimationFillMode { get; set; }

		// @property (readonly, nonatomic, strong) PXKeyframe * keyframe;
		[Export ("keyframe", ArgumentSemantic.Strong)]
		PXKeyframe Keyframe { get; }

		// @property (readonly, getter = isValid, nonatomic) BOOL valid;
		[Export ("valid")]
		bool Valid { [Bind ("isValid")] get; }

		// -(void)setUndefinedPropertiesWithAnimationInfo:(PXAnimationInfo *)info;
		[Export ("setUndefinedPropertiesWithAnimationInfo:")]
		void SetUndefinedPropertiesWithAnimationInfo (PXAnimationInfo info);
	}

	// @protocol PXBoundable <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface PXBoundable
	{
		// @required @property (nonatomic) int bounds;
		[Export ("bounds")]
		int Bounds { get; set; }
	}

	// @interface PXBoxModel : PXShape <PXBoundable>
	[BaseType (typeof(PXShape))]
	interface PXBoxModel : IPXBoundable
	{
		// @property (nonatomic) id<PXPaint> borderTopPaint;
		[Export ("borderTopPaint", ArgumentSemantic.Assign)]
		PXPaint BorderTopPaint { get; set; }

		// @property (nonatomic) int borderTopWidth;
		[Export ("borderTopWidth")]
		int BorderTopWidth { get; set; }

		// @property (nonatomic) PXBorderStyle borderTopStyle;
		[Export ("borderTopStyle", ArgumentSemantic.Assign)]
		PXBorderStyle BorderTopStyle { get; set; }

		// @property (nonatomic) id<PXPaint> borderRightPaint;
		[Export ("borderRightPaint", ArgumentSemantic.Assign)]
		PXPaint BorderRightPaint { get; set; }

		// @property (nonatomic) int borderRightWidth;
		[Export ("borderRightWidth")]
		int BorderRightWidth { get; set; }

		// @property (nonatomic) PXBorderStyle borderRightStyle;
		[Export ("borderRightStyle", ArgumentSemantic.Assign)]
		PXBorderStyle BorderRightStyle { get; set; }

		// @property (nonatomic) id<PXPaint> borderBottomPaint;
		[Export ("borderBottomPaint", ArgumentSemantic.Assign)]
		PXPaint BorderBottomPaint { get; set; }

		// @property (nonatomic) int borderBottomWidth;
		[Export ("borderBottomWidth")]
		int BorderBottomWidth { get; set; }

		// @property (nonatomic) PXBorderStyle borderBottomStyle;
		[Export ("borderBottomStyle", ArgumentSemantic.Assign)]
		PXBorderStyle BorderBottomStyle { get; set; }

		// @property (nonatomic) id<PXPaint> borderLeftPaint;
		[Export ("borderLeftPaint", ArgumentSemantic.Assign)]
		PXPaint BorderLeftPaint { get; set; }

		// @property (nonatomic) int borderLeftWidth;
		[Export ("borderLeftWidth")]
		int BorderLeftWidth { get; set; }

		// @property (nonatomic) PXBorderStyle borderLeftStyle;
		[Export ("borderLeftStyle", ArgumentSemantic.Assign)]
		PXBorderStyle BorderLeftStyle { get; set; }

		// @property (nonatomic) int radiusTopLeft;
		[Export ("radiusTopLeft")]
		int RadiusTopLeft { get; set; }

		// @property (nonatomic) int radiusTopRight;
		[Export ("radiusTopRight")]
		int RadiusTopRight { get; set; }

		// @property (nonatomic) int radiusBottomRight;
		[Export ("radiusBottomRight")]
		int RadiusBottomRight { get; set; }

		// @property (nonatomic) int radiusBottomLeft;
		[Export ("radiusBottomLeft")]
		int RadiusBottomLeft { get; set; }

		// @property (readonly, nonatomic) int borderBounds;
		[Export ("borderBounds")]
		int BorderBounds { get; }

		// @property (readonly, nonatomic) int contentBounds;
		[Export ("contentBounds")]
		int ContentBounds { get; }

		// @property (nonatomic) PXOffsets * padding;
		[Export ("padding", ArgumentSemantic.Assign)]
		PXOffsets Padding { get; set; }

		// @property (nonatomic) PXBoxSizing boxSizing;
		[Export ("boxSizing", ArgumentSemantic.Assign)]
		PXBoxSizing BoxSizing { get; set; }

		// -(instancetype)initWithBounds:(id)bounds __attribute__((objc_designated_initializer));
		[Export ("initWithBounds:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject bounds);

		// @property (readonly, nonatomic) BOOL hasBorder;
		[Export ("hasBorder")]
		bool HasBorder { get; }

		// @property (readonly, nonatomic) BOOL hasCornerRadius;
		[Export ("hasCornerRadius")]
		bool HasCornerRadius { get; }

		// @property (readonly, getter = isOpaque, nonatomic) BOOL opaque;
		[Export ("opaque")]
		bool Opaque { [Bind ("isOpaque")] get; }

		// -(void)setCornerRadius:(id)radius;
		[Export ("setCornerRadius:")]
		void SetCornerRadius (NSObject radius);

		// -(void)setCornerRadii:(id)radii;
		[Export ("setCornerRadii:")]
		void SetCornerRadii (NSObject radii);

		// -(void)setBorderPaint:(id<PXPaint>)paint;
		[Export ("setBorderPaint:")]
		void SetBorderPaint (PXPaint paint);

		// -(void)setBorderWidth:(id)width;
		[Export ("setBorderWidth:")]
		void SetBorderWidth (NSObject width);

		// -(void)setBorderStyle:(PXBorderStyle)style;
		[Export ("setBorderStyle:")]
		void SetBorderStyle (PXBorderStyle style);

		// -(void)setBorderPaint:(id<PXPaint>)paint width:(id)width style:(PXBorderStyle)style;
		[Export ("setBorderPaint:width:style:")]
		void SetBorderPaint (PXPaint paint, NSObject width, PXBorderStyle style);

		// -(void)setBorderTopPaint:(id<PXPaint>)paint width:(id)width style:(PXBorderStyle)style;
		[Export ("setBorderTopPaint:width:style:")]
		void SetBorderTopPaint (PXPaint paint, NSObject width, PXBorderStyle style);

		// -(void)setBorderRightPaint:(id<PXPaint>)paint width:(id)width style:(PXBorderStyle)style;
		[Export ("setBorderRightPaint:width:style:")]
		void SetBorderRightPaint (PXPaint paint, NSObject width, PXBorderStyle style);

		// -(void)setBorderBottomPaint:(id<PXPaint>)paint width:(id)width style:(PXBorderStyle)style;
		[Export ("setBorderBottomPaint:width:style:")]
		void SetBorderBottomPaint (PXPaint paint, NSObject width, PXBorderStyle style);

		// -(void)setBorderLeftPaint:(id<PXPaint>)paint width:(id)width style:(PXBorderStyle)style;
		[Export ("setBorderLeftPaint:width:style:")]
		void SetBorderLeftPaint (PXPaint paint, NSObject width, PXBorderStyle style);
	}

	// @interface PXStylerContext : NSObject
	[BaseType (typeof(NSObject))]
	interface PXStylerContext
	{
		// @property (nonatomic, strong) id<PXStyleable> styleable;
		[Export ("styleable", ArgumentSemantic.Strong)]
		PXStyleable Styleable { get; set; }

		// @property (nonatomic, strong) NSString * activeStateName;
		[Export ("activeStateName", ArgumentSemantic.Strong)]
		string ActiveStateName { get; set; }

		// @property (nonatomic) NSUInteger styleHash;
		[Export ("styleHash")]
		nuint StyleHash { get; set; }

		// @property (nonatomic, strong) PXShape * shape;
		[Export ("shape", ArgumentSemantic.Strong)]
		PXShape Shape { get; set; }

		// @property (nonatomic) int top;
		[Export ("top")]
		int Top { get; set; }

		// @property (nonatomic) int left;
		[Export ("left")]
		int Left { get; set; }

		// @property (nonatomic) int width;
		[Export ("width")]
		int Width { get; set; }

		// @property (nonatomic) int height;
		[Export ("height")]
		int Height { get; set; }

		// @property (nonatomic) int bounds;
		[Export ("bounds")]
		int Bounds { get; set; }

		// @property (nonatomic, strong) PXOffsets * padding;
		[Export ("padding", ArgumentSemantic.Strong)]
		PXOffsets Padding { get; set; }

		// @property (nonatomic) int transform;
		[Export ("transform")]
		int Transform { get; set; }

		// @property (nonatomic, strong) PXBoxModel * boxModel;
		[Export ("boxModel", ArgumentSemantic.Strong)]
		PXBoxModel BoxModel { get; set; }

		// @property (nonatomic, strong) id<PXPaint> fill;
		[Export ("fill", ArgumentSemantic.Strong)]
		PXPaint Fill { get; set; }

		// @property (nonatomic, strong) id<PXPaint> imageFill;
		[Export ("imageFill", ArgumentSemantic.Strong)]
		PXPaint ImageFill { get; set; }

		// @property (nonatomic, strong) id<PXShadowPaint> shadow;
		[Export ("shadow", ArgumentSemantic.Strong)]
		PXShadowPaint Shadow { get; set; }

		// @property (nonatomic, strong) id<PXShadowPaint> textShadow;
		[Export ("textShadow", ArgumentSemantic.Strong)]
		PXShadowPaint TextShadow { get; set; }

		// @property (readonly, nonatomic, strong) PXShadowGroup * innerShadow;
		[Export ("innerShadow", ArgumentSemantic.Strong)]
		PXShadowGroup InnerShadow { get; }

		// @property (readonly, nonatomic, strong) PXShadowGroup * outerShadow;
		[Export ("outerShadow", ArgumentSemantic.Strong)]
		PXShadowGroup OuterShadow { get; }

		// @property (nonatomic) int opacity;
		[Export ("opacity")]
		int Opacity { get; set; }

		// @property (readonly, nonatomic, strong) int * backgroundImage;
		[Export ("backgroundImage", ArgumentSemantic.Strong)]
		unsafe int* BackgroundImage { get; }

		// @property (nonatomic) int imageSize;
		[Export ("imageSize")]
		int ImageSize { get; set; }

		// @property (nonatomic) int insets;
		[Export ("insets")]
		int Insets { get; set; }

		// @property (nonatomic, strong) PXDimension * barMetricsVerticalOffset;
		[Export ("barMetricsVerticalOffset", ArgumentSemantic.Strong)]
		PXDimension BarMetricsVerticalOffset { get; set; }

		// @property (nonatomic, strong) NSString * fontName;
		[Export ("fontName", ArgumentSemantic.Strong)]
		string FontName { get; set; }

		// @property (nonatomic, strong) NSString * fontStyle;
		[Export ("fontStyle", ArgumentSemantic.Strong)]
		string FontStyle { get; set; }

		// @property (nonatomic, strong) NSString * fontWeight;
		[Export ("fontWeight", ArgumentSemantic.Strong)]
		string FontWeight { get; set; }

		// @property (nonatomic, strong) NSString * fontStretch;
		[Export ("fontStretch", ArgumentSemantic.Strong)]
		string FontStretch { get; set; }

		// @property (nonatomic) int fontSize;
		[Export ("fontSize")]
		int FontSize { get; set; }

		// @property (readonly, nonatomic, strong) int * font;
		[Export ("font", ArgumentSemantic.Strong)]
		unsafe int* Font { get; }

		// @property (nonatomic, strong) NSString * text;
		[Export ("text", ArgumentSemantic.Strong)]
		string Text { get; set; }

		// @property (nonatomic, strong) NSString * transformedText;
		[Export ("transformedText", ArgumentSemantic.Strong)]
		string TransformedText { get; set; }

		// @property (nonatomic) PXDimension * letterSpacing;
		[Export ("letterSpacing", ArgumentSemantic.Assign)]
		PXDimension LetterSpacing { get; set; }

		// @property (nonatomic, strong) NSString * textTransform;
		[Export ("textTransform", ArgumentSemantic.Strong)]
		string TextTransform { get; set; }

		// @property (nonatomic, strong) NSString * textDecoration;
		[Export ("textDecoration", ArgumentSemantic.Strong)]
		string TextDecoration { get; set; }

		// @property (nonatomic) int shadowBounds;
		[Export ("shadowBounds")]
		int ShadowBounds { get; set; }

		// @property (nonatomic) NSURL * shadowUrl;
		[Export ("shadowUrl", ArgumentSemantic.Assign)]
		NSUrl ShadowUrl { get; set; }

		// @property (nonatomic) int * shadowImage;
		[Export ("shadowImage", ArgumentSemantic.Assign)]
		unsafe int* ShadowImage { get; set; }

		// @property (nonatomic) int shadowInsets;
		[Export ("shadowInsets")]
		int ShadowInsets { get; set; }

		// @property (nonatomic) int shadowPadding;
		[Export ("shadowPadding")]
		int ShadowPadding { get; set; }

		// @property (nonatomic, strong) NSMutableArray * animationInfos;
		[Export ("animationInfos", ArgumentSemantic.Strong)]
		NSMutableArray AnimationInfos { get; set; }

		// @property (nonatomic, strong) NSMutableArray * transitionInfos;
		[Export ("transitionInfos", ArgumentSemantic.Strong)]
		NSMutableArray TransitionInfos { get; set; }

		// @property (readonly, nonatomic, strong) int * color;
		[Export ("color", ArgumentSemantic.Strong)]
		unsafe int* Color { get; }

		// @property (readonly, nonatomic) BOOL usesColorOnly;
		[Export ("usesColorOnly")]
		bool UsesColorOnly { get; }

		// @property (readonly, nonatomic) BOOL usesImage;
		[Export ("usesImage")]
		bool UsesImage { get; }

		// -(id)propertyValueForName:(NSString *)name;
		[Export ("propertyValueForName:")]
		NSObject PropertyValueForName (string name);

		// -(void)setPropertyValue:(id)value forName:(NSString *)name;
		[Export ("setPropertyValue:forName:")]
		void SetPropertyValue (NSObject value, string name);

		// -(int)stateFromStateNameMap:(NSDictionary *)map;
		[Export ("stateFromStateNameMap:")]
		int StateFromStateNameMap (NSDictionary map);

		// -(void)applyOuterShadowToLayer:(id)layer;
		[Export ("applyOuterShadowToLayer:")]
		void ApplyOuterShadowToLayer (NSObject layer);

		// -(id)backgroundImageWithBounds:(id)bounds;
		[Export ("backgroundImageWithBounds:")]
		NSObject BackgroundImageWithBounds (NSObject bounds);

		// +(NSString *)transformString:(NSString *)value usingAttribute:(NSString *)attribute;
		[Static]
		[Export ("transformString:usingAttribute:")]
		string TransformString (string value, string attribute);

		// +(NSNumber *)kernPointsFrom:(PXDimension *)dimension usingFont:(id)font;
		[Static]
		[Export ("kernPointsFrom:usingFont:")]
		NSNumber KernPointsFrom (PXDimension dimension, NSObject font);

		// +(void)addDecoration:(NSString *)decoration toAttributes:(NSMutableDictionary *)attributes;
		[Static]
		[Export ("addDecoration:toAttributes:")]
		void AddDecoration (string decoration, NSMutableDictionary attributes);

		// -(NSDictionary *)mergeTextAttributes:(NSDictionary *)originalAttributes;
		[Export ("mergeTextAttributes:")]
		NSDictionary MergeTextAttributes (NSDictionary originalAttributes);

		// -(NSMutableDictionary *)attributedTextAttributes:(id)view withDefaultText:(NSString *)text andColor:(id)defaultColor;
		[Export ("attributedTextAttributes:withDefaultText:andColor:")]
		NSMutableDictionary AttributedTextAttributes (NSObject view, string text, NSObject defaultColor);
	}

	// @interface PXStyling (NSObject)
	[Category]
	[BaseType (typeof(NSObject))]
	interface NSObject_PXStyling
	{
		// -(NSArray *)viewStylers;
		[Export ("viewStylers")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] ViewStylers { get; }

		// -(NSDictionary *)viewStylersByProperty;
		[Export ("viewStylersByProperty")]
		[Verify (MethodToProperty)]
		NSDictionary ViewStylersByProperty { get; }

		// -(void)updateStyleWithRuleSet:(PXRuleSet *)ruleSet context:(PXStylerContext *)context;
		[Export ("updateStyleWithRuleSet:context:")]
		void UpdateStyleWithRuleSet (PXRuleSet ruleSet, PXStylerContext context);
	}

	// @interface PXSubclass (NSObject)
	[Category]
	[BaseType (typeof(NSObject))]
	interface NSObject_PXSubclass
	{
		// +(void)subclassInstance:(id)object;
		[Static]
		[Export ("subclassInstance:")]
		void SubclassInstance (NSObject @object);
	}

	// @interface PXSwizzle (NSObject)
	[Category]
	[BaseType (typeof(NSObject))]
	interface NSObject_PXSwizzle
	{
		// -(void)swizzleMethod:(SEL)orig_sel withMethod:(SEL)alt_sel;
		[Export ("swizzleMethod:withMethod:")]
		void SwizzleMethod (Selector orig_sel, Selector alt_sel);

		// +(void)swizzleMethod:(SEL)orig_sel withMethod:(SEL)alt_sel;
		[Static]
		[Export ("swizzleMethod:withMethod:")]
		void SwizzleMethod (Selector orig_sel, Selector alt_sel);
	}

	// @interface PXFloat (NSScanner)
	[Category]
	[BaseType (typeof(NSScanner))]
	interface NSScanner_PXFloat
	{
		// -(BOOL)scanCGFloat:(id)cgFloatValue;
		[Export ("scanCGFloat:")]
		bool ScanCGFloat (NSObject cgFloatValue);
	}

	// @protocol PXCombinator <PXSelector>
	[Protocol, Model]
	interface PXCombinator : IPXSelector
	{
		// @required @property (readonly, nonatomic, strong) id<PXSelector> lhs;
		[Export ("lhs", ArgumentSemantic.Strong)]
		PXSelector Lhs { get; }

		// @required @property (readonly, nonatomic, strong) id<PXSelector> rhs;
		[Export ("rhs", ArgumentSemantic.Strong)]
		PXSelector Rhs { get; }
	}

	// @interface PXCombinatorBase : NSObject <PXCombinator>
	[BaseType (typeof(NSObject))]
	interface PXCombinatorBase : IPXCombinator
	{
		// @property (readonly, nonatomic, strong) NSString * displayName;
		[Export ("displayName", ArgumentSemantic.Strong)]
		string DisplayName { get; }

		// -(id)initWithLHS:(id<PXSelector>)lhs RHS:(id<PXSelector>)rhs;
		[Export ("initWithLHS:RHS:")]
		IntPtr Constructor (PXSelector lhs, PXSelector rhs);
	}

	// @interface PXAdjacentSiblingCombinator : PXCombinatorBase
	[BaseType (typeof(PXCombinatorBase))]
	interface PXAdjacentSiblingCombinator
	{
	}

	// typedef id (^PXAnimationPropertyHandlerBlock)(PXDeclaration *);
	delegate NSObject PXAnimationPropertyHandlerBlock (PXDeclaration arg0);

	// @interface PXAnimationPropertyHandler : NSObject
	[BaseType (typeof(NSObject))]
	interface PXAnimationPropertyHandler
	{
		// @property (nonatomic, strong) NSString * keyPath;
		[Export ("keyPath", ArgumentSemantic.Strong)]
		string KeyPath { get; set; }

		// @property (nonatomic, strong) PXAnimationPropertyHandlerBlock block;
		[Export ("block", ArgumentSemantic.Strong)]
		PXAnimationPropertyHandlerBlock Block { get; set; }

		// +(PXAnimationPropertyHandlerBlock)FloatValueBlock;
		[Static]
		[Export ("FloatValueBlock")]
		[Verify (MethodToProperty)]
		PXAnimationPropertyHandlerBlock FloatValueBlock { get; }

		// -(id)initWithKeyPath:(NSString *)keyPath block:(PXAnimationPropertyHandlerBlock)block;
		[Export ("initWithKeyPath:block:")]
		IntPtr Constructor (string keyPath, PXAnimationPropertyHandlerBlock block);

		// -(id)getValueFromDeclaration:(PXDeclaration *)declaration;
		[Export ("getValueFromDeclaration:")]
		NSObject GetValueFromDeclaration (PXDeclaration declaration);
	}

	// @protocol PXStyler <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface PXStyler
	{
		// @required @property (readonly, nonatomic) NSArray * supportedProperties;
		[Abstract]
		[Export ("supportedProperties")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] SupportedProperties { get; }

		// @required -(void)processDeclaration:(PXDeclaration *)declaration withContext:(PXStylerContext *)context;
		[Abstract]
		[Export ("processDeclaration:withContext:")]
		void ProcessDeclaration (PXDeclaration declaration, PXStylerContext context);

		// @required -(void)applyStylesWithContext:(PXStylerContext *)context;
		[Abstract]
		[Export ("applyStylesWithContext:")]
		void ApplyStylesWithContext (PXStylerContext context);
	}

	// typedef void (^PXStylerCompletionBlock)(id<PXStyleable>, id<PXStyler>, PXStylerContext *);
	delegate void PXStylerCompletionBlock (PXStyleable arg0, PXStyler arg1, PXStylerContext arg2);

	// typedef void (^PXDeclarationHandlerBlock)(PXDeclaration *, PXStylerContext *);
	delegate void PXDeclarationHandlerBlock (PXDeclaration arg0, PXStylerContext arg1);

	// @interface PXStylerBase : NSObject <PXStyler>
	[BaseType (typeof(NSObject))]
	interface PXStylerBase : IPXStyler
	{
		// @property (readonly, nonatomic) PXStylerCompletionBlock completionBlock;
		[Export ("completionBlock")]
		PXStylerCompletionBlock CompletionBlock { get; }

		// -(instancetype)initWithCompletionBlock:(PXStylerCompletionBlock)block __attribute__((objc_designated_initializer));
		[Export ("initWithCompletionBlock:")]
		[DesignatedInitializer]
		IntPtr Constructor (PXStylerCompletionBlock block);
	}

	// @interface PXAnimationStyler : PXStylerBase
	[BaseType (typeof(PXStylerBase))]
	interface PXAnimationStyler
	{
		// +(PXAnimationStyler *)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		[Verify (MethodToProperty)]
		PXAnimationStyler SharedInstance { get; }
	}

	// @interface PXArc : PXShape
	[BaseType (typeof(PXShape))]
	interface PXArc
	{
		// @property (nonatomic) int center;
		[Export ("center")]
		int Center { get; set; }

		// @property (nonatomic) int radius;
		[Export ("radius")]
		int Radius { get; set; }

		// @property (nonatomic) int startingAngle;
		[Export ("startingAngle")]
		int StartingAngle { get; set; }

		// @property (nonatomic) int endingAngle;
		[Export ("endingAngle")]
		int EndingAngle { get; set; }
	}

	// @interface PXRectangle : PXShape <PXBoundable>
	[BaseType (typeof(PXShape))]
	interface PXRectangle : IPXBoundable
	{
		// @property (nonatomic) int size;
		[Export ("size")]
		int Size { get; set; }

		// @property (nonatomic) int x;
		[Export ("x")]
		int X { get; set; }

		// @property (nonatomic) int y;
		[Export ("y")]
		int Y { get; set; }

		// @property (nonatomic) int width;
		[Export ("width")]
		int Width { get; set; }

		// @property (nonatomic) int height;
		[Export ("height")]
		int Height { get; set; }

		// @property (nonatomic) int radiusTopLeft;
		[Export ("radiusTopLeft")]
		int RadiusTopLeft { get; set; }

		// @property (nonatomic) int radiusTopRight;
		[Export ("radiusTopRight")]
		int RadiusTopRight { get; set; }

		// @property (nonatomic) int radiusBottomRight;
		[Export ("radiusBottomRight")]
		int RadiusBottomRight { get; set; }

		// @property (nonatomic) int radiusBottomLeft;
		[Export ("radiusBottomLeft")]
		int RadiusBottomLeft { get; set; }

		// -(id)initWithRect:(id)bounds;
		[Export ("initWithRect:")]
		IntPtr Constructor (NSObject bounds);

		// -(BOOL)hasRoundedCorners;
		[Export ("hasRoundedCorners")]
		[Verify (MethodToProperty)]
		bool HasRoundedCorners { get; }

		// -(void)setCornerRadius:(id)radius;
		[Export ("setCornerRadius:")]
		void SetCornerRadius (NSObject radius);

		// -(void)setCornerRadii:(id)radii;
		[Export ("setCornerRadii:")]
		void SetCornerRadii (NSObject radii);
	}

	// @interface PXArrowRectangle : PXRectangle
	[BaseType (typeof(PXRectangle))]
	interface PXArrowRectangle
	{
		// @property (nonatomic) PXArrowRectangleDirection direction;
		[Export ("direction", ArgumentSemantic.Assign)]
		PXArrowRectangleDirection Direction { get; set; }

		// -(id)initWithDirection:(PXArrowRectangleDirection)direction;
		[Export ("initWithDirection:")]
		IntPtr Constructor (PXArrowRectangleDirection direction);

		// -(id)initWithRect:(id)bounds direction:(PXArrowRectangleDirection)direction;
		[Export ("initWithRect:direction:")]
		IntPtr Constructor (NSObject bounds, PXArrowRectangleDirection direction);
	}

	// @interface PXAttributeSelector : NSObject <PXSelector>
	[BaseType (typeof(NSObject))]
	interface PXAttributeSelector : IPXSelector
	{
		// @property (readonly, nonatomic, strong) NSString * namespaceURI;
		[Export ("namespaceURI", ArgumentSemantic.Strong)]
		string NamespaceURI { get; }

		// @property (readonly, nonatomic, strong) NSString * attributeName;
		[Export ("attributeName", ArgumentSemantic.Strong)]
		string AttributeName { get; }

		// -(id)initWithAttributeName:(NSString *)name;
		[Export ("initWithAttributeName:")]
		IntPtr Constructor (string name);

		// -(id)initWithNamespaceURI:(NSString *)uri attributeName:(NSString *)name;
		[Export ("initWithNamespaceURI:attributeName:")]
		IntPtr Constructor (string uri, string name);
	}

	// @interface PXAttributeSelectorOperator : NSObject <PXSelector>
	[BaseType (typeof(NSObject))]
	interface PXAttributeSelectorOperator : IPXSelector
	{
		// @property (readonly, nonatomic) PXAttributeSelectorOperatorType operatorType;
		[Export ("operatorType")]
		PXAttributeSelectorOperatorType OperatorType { get; }

		// @property (readonly, nonatomic, strong) PXAttributeSelector * attributeSelector;
		[Export ("attributeSelector", ArgumentSemantic.Strong)]
		PXAttributeSelector AttributeSelector { get; }

		// @property (readonly, nonatomic, strong) NSString * value;
		[Export ("value", ArgumentSemantic.Strong)]
		string Value { get; }

		// -(id)initWithOperatorType:(PXAttributeSelectorOperatorType)type attributeSelector:(PXAttributeSelector *)attributeSelector stringValue:(NSString *)value;
		[Export ("initWithOperatorType:attributeSelector:stringValue:")]
		IntPtr Constructor (PXAttributeSelectorOperatorType type, PXAttributeSelector attributeSelector, string value);
	}

	// @interface PXAttributedTextStyler : PXStylerBase
	[BaseType (typeof(PXStylerBase))]
	interface PXAttributedTextStyler
	{
	}

	// @interface PXBarMetricsAdjustmentStyler : PXStylerBase
	[BaseType (typeof(PXStylerBase))]
	interface PXBarMetricsAdjustmentStyler
	{
	}

	// @interface PXBarShadowStyler : PXStylerBase
	[BaseType (typeof(PXStylerBase))]
	interface PXBarShadowStyler
	{
	}

	// @interface PXBorderStyler : PXStylerBase
	[BaseType (typeof(PXStylerBase))]
	interface PXBorderStyler
	{
		// +(PXBorderStyler *)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		[Verify (MethodToProperty)]
		PXBorderStyler SharedInstance { get; }
	}

	// @interface PXBoxShadowStyler : PXStylerBase
	[BaseType (typeof(PXStylerBase))]
	interface PXBoxShadowStyler
	{
		// +(PXBoxShadowStyler *)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		[Verify (MethodToProperty)]
		PXBoxShadowStyler SharedInstance { get; }
	}

	// @interface PXStyleTreeInfo : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PXStyleTreeInfo
	{
		// @property (readonly, nonatomic) NSString * styleKey;
		[Export ("styleKey")]
		string StyleKey { get; }

		// @property (readonly, nonatomic) BOOL cached;
		[Export ("cached")]
		bool Cached { get; }

		// -(instancetype)initWithStyleable:(id<PXStyleable>)styleable __attribute__((objc_designated_initializer));
		[Export ("initWithStyleable:")]
		[DesignatedInitializer]
		IntPtr Constructor (PXStyleable styleable);

		// -(void)applyStylesToStyleable:(id<PXStyleable>)styleable;
		[Export ("applyStylesToStyleable:")]
		void ApplyStylesToStyleable (PXStyleable styleable);
	}

	// @interface PXCacheManager : NSObject
	[BaseType (typeof(NSObject))]
	interface PXCacheManager
	{
		// +(UIImage *)imageForKey:(NSNumber *)key;
		[Static]
		[Export ("imageForKey:")]
		UIImage ImageForKey (NSNumber key);

		// +(void)setImage:(UIImage *)image forKey:(NSNumber *)key cost:(NSUInteger)cost;
		[Static]
		[Export ("setImage:forKey:cost:")]
		void SetImage (UIImage image, NSNumber key, nuint cost);

		// +(void)clearImageCache;
		[Static]
		[Export ("clearImageCache")]
		void ClearImageCache ();

		// +(NSUInteger)imageCacheCount;
		// +(void)setImageCacheCount:(NSUInteger)count;
		[Static]
		[Export ("imageCacheCount")]
		[Verify (MethodToProperty)]
		nuint ImageCacheCount { get; set; }

		// +(NSUInteger)imageCacheSize;
		// +(void)setImageCacheSize:(NSUInteger)size;
		[Static]
		[Export ("imageCacheSize")]
		[Verify (MethodToProperty)]
		nuint ImageCacheSize { get; set; }

		// +(PXStyleTreeInfo *)styleTreeInfoForKey:(NSString *)key;
		[Static]
		[Export ("styleTreeInfoForKey:")]
		PXStyleTreeInfo StyleTreeInfoForKey (string key);

		// +(void)setStyleTreeInfo:(PXStyleTreeInfo *)styleTreeInfo forKey:(NSString *)key;
		[Static]
		[Export ("setStyleTreeInfo:forKey:")]
		void SetStyleTreeInfo (PXStyleTreeInfo styleTreeInfo, string key);

		// +(void)clearStyleCache;
		[Static]
		[Export ("clearStyleCache")]
		void ClearStyleCache ();

		// +(NSUInteger)styleCacheCount;
		[Static]
		[Export ("styleCacheCount")]
		nuint StyleCacheCount ();

		// +(void)setStyleCacheCount:(NSUInteger)count;
		[Static]
		[Export ("setStyleCacheCount:")]
		void SetStyleCacheCount (nuint count);

		// +(void)clearAllCaches;
		[Static]
		[Export ("clearAllCaches")]
		void ClearAllCaches ();
	}

	// @protocol PXLexeme <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface PXLexeme
	{
		// @required @property (readonly, nonatomic) int type;
		[Export ("type")]
		int Type { get; }

		// @required @property (readonly, nonatomic, strong) NSString * text;
		[Export ("text", ArgumentSemantic.Strong)]
		string Text { get; }

		// @required @property (readonly, nonatomic, strong) NSString * name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; }

		// @required @property (readonly, nonatomic, strong) id value;
		[Export ("value", ArgumentSemantic.Strong)]
		NSObject Value { get; }

		// @required @property (readonly, nonatomic) NSRange range;
		[Export ("range")]
		NSRange Range { get; }

		// @required -(instancetype)initWithType:(int)type text:(NSString *)text;
		[Abstract]
		[Export ("initWithType:text:")]
		IntPtr Constructor (int type, string text);

		// @required -(void)clearFlag:(int)type;
		[Abstract]
		[Export ("clearFlag:")]
		void ClearFlag (int type);

		// @required -(void)setFlag:(int)type;
		[Abstract]
		[Export ("setFlag:")]
		void SetFlag (int type);

		// @required -(BOOL)flagIsSet:(int)type;
		[Abstract]
		[Export ("flagIsSet:")]
		bool FlagIsSet (int type);
	}

	// @interface PXStylesheetLexeme : NSObject <PXLexeme>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PXStylesheetLexeme : IPXLexeme
	{
		// +(instancetype)lexemeWithType:(int)type;
		[Static]
		[Export ("lexemeWithType:")]
		PXStylesheetLexeme LexemeWithType (int type);

		// +(instancetype)lexemeWithType:(int)type withRange:(NSRange)range;
		[Static]
		[Export ("lexemeWithType:withRange:")]
		PXStylesheetLexeme LexemeWithType (int type, NSRange range);

		// +(instancetype)lexemeWithType:(int)type withValue:(id)value;
		[Static]
		[Export ("lexemeWithType:withValue:")]
		PXStylesheetLexeme LexemeWithType (int type, NSObject value);

		// +(instancetype)lexemeWithType:(int)type withRange:(NSRange)range withValue:(id)value;
		[Static]
		[Export ("lexemeWithType:withRange:withValue:")]
		PXStylesheetLexeme LexemeWithType (int type, NSRange range, NSObject value);

		// -(instancetype)initWithType:(int)type withRange:(NSRange)range withValue:(id)value __attribute__((objc_designated_initializer));
		[Export ("initWithType:withRange:withValue:")]
		[DesignatedInitializer]
		IntPtr Constructor (int type, NSRange range, NSObject value);
	}

	// @protocol PXLexemeCreator <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface PXLexemeCreator
	{
		// @required -(PXStylesheetLexeme *)createLexemeWithString:(NSString *)aString withRange:(NSRange)aRange;
		[Abstract]
		[Export ("createLexemeWithString:withRange:")]
		PXStylesheetLexeme WithRange (string aString, NSRange aRange);
	}

	// @interface PXCharacterMatcher : NSObject <PXLexemeCreator>
	[BaseType (typeof(NSObject))]
	interface PXCharacterMatcher : IPXLexemeCreator
	{
		// -(id)initWithCharactersInString:(NSString *)characters withTypes:(NSArray *)types;
		[Export ("initWithCharactersInString:withTypes:")]
		[Verify (StronglyTypedNSArray)]
		IntPtr Constructor (string characters, NSObject[] types);
	}

	// @interface PXChildCombinator : PXCombinatorBase
	[BaseType (typeof(PXCombinatorBase))]
	interface PXChildCombinator
	{
	}

	// @interface PXCircle : PXShape
	[BaseType (typeof(PXShape))]
	interface PXCircle
	{
		// @property (nonatomic) CGPoint center;
		[Export ("center", ArgumentSemantic.Assign)]
		CGPoint Center { get; set; }

		// @property (nonatomic) CGFloat radius;
		[Export ("radius")]
		nfloat Radius { get; set; }

		// +(id)circleWithCenter:(CGPoint)center withRadius:(CGFloat)radius;
		[Static]
		[Export ("circleWithCenter:withRadius:")]
		NSObject CircleWithCenter (CGPoint center, nfloat radius);

		// -(id)initCenter:(CGPoint)center radius:(CGFloat)radius;
		[Export ("initCenter:radius:")]
		IntPtr Constructor (CGPoint center, nfloat radius);
	}

	// @interface PXClassSelector : NSObject <PXSelector>
	[BaseType (typeof(NSObject))]
	interface PXClassSelector : IPXSelector
	{
		// @property (readonly, nonatomic, strong) NSString * className;
		[Export ("className", ArgumentSemantic.Strong)]
		string ClassName { get; }

		// -(id)initWithClassName:(NSString *)name;
		[Export ("initWithClassName:")]
		IntPtr Constructor (string name);
	}

	// @interface PXClassUtils : NSObject
	[BaseType (typeof(NSObject))]
	interface PXClassUtils
	{
		// +(NSString *)classDescriptionForObject:(id)object;
		[Static]
		[Export ("classDescriptionForObject:")]
		string ClassDescriptionForObject (NSObject @object);

		// +(NSString *)classDescription:(Class)c;
		[Static]
		[Export ("classDescription:")]
		string ClassDescription (Class c);
	}

	// @interface PXColorStyler : PXStylerBase
	[BaseType (typeof(PXStylerBase))]
	interface PXColorStyler
	{
	}

	// @interface PXDescendantCombinator : PXCombinatorBase
	[BaseType (typeof(PXCombinatorBase))]
	interface PXDescendantCombinator
	{
	}

	// @interface PXEllipse : PXShape <PXBoundable>
	[BaseType (typeof(PXShape))]
	interface PXEllipse : IPXBoundable
	{
		// @property (nonatomic) CGPoint center;
		[Export ("center", ArgumentSemantic.Assign)]
		CGPoint Center { get; set; }

		// @property (nonatomic) CGFloat radiusX;
		[Export ("radiusX")]
		nfloat RadiusX { get; set; }

		// @property (nonatomic) CGFloat radiusY;
		[Export ("radiusY")]
		nfloat RadiusY { get; set; }

		// +(id)ellipseWithCenter:(CGPoint)center withRadiusX:(CGFloat)radiusX withRadiusY:(CGFloat)radiusY;
		[Static]
		[Export ("ellipseWithCenter:withRadiusX:withRadiusY:")]
		NSObject EllipseWithCenter (CGPoint center, nfloat radiusX, nfloat radiusY);

		// -(id)initCenter:(CGPoint)center radiusX:(CGFloat)radiusX radiusY:(CGFloat)radiusY;
		[Export ("initCenter:radiusX:radiusY:")]
		IntPtr Constructor (CGPoint center, nfloat radiusX, nfloat radiusY);
	}

	// @interface PXEllipticalArc : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PXEllipticalArc
	{
		// -(instancetype)initWithCx:(CGFloat)cx cy:(CGFloat)cy radiusX:(CGFloat)a radiusY:(CGFloat)b startingAngle:(CGFloat)lambda1 endingAngle:(CGFloat)lambda2 __attribute__((objc_designated_initializer));
		[Export ("initWithCx:cy:radiusX:radiusY:startingAngle:endingAngle:")]
		[DesignatedInitializer]
		IntPtr Constructor (nfloat cx, nfloat cy, nfloat a, nfloat b, nfloat lambda1, nfloat lambda2);

		// -(void)addToPath:(CGMutablePathRef)path transform:(CGAffineTransform)transform;
		[Export ("addToPath:transform:")]
		unsafe void AddToPath (CGMutablePathRef* path, CGAffineTransform transform);
	}

	// @interface PXFileUtils : NSObject
	[BaseType (typeof(NSObject))]
	interface PXFileUtils
	{
		// +(NSString *)sourceFromResource:(NSString *)resource ofType:(NSString *)type;
		[Static]
		[Export ("sourceFromResource:ofType:")]
		string SourceFromResource (string resource, string type);

		// +(NSString *)sourceFromPath:(NSString *)path;
		[Static]
		[Export ("sourceFromPath:")]
		string SourceFromPath (string path);
	}

	// @interface PXFileWatcher : NSObject
	[BaseType (typeof(NSObject))]
	interface PXFileWatcher
	{
		// +(PXFileWatcher *)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		[Verify (MethodToProperty)]
		PXFileWatcher SharedInstance { get; }

		// -(void)watchFile:(NSString *)filePath handler:(dispatch_block_t)handler;
		[Export ("watchFile:handler:")]
		void WatchFile (string filePath, dispatch_block_t handler);
	}

	// @interface PXFillStyler : PXStylerBase
	[BaseType (typeof(PXStylerBase))]
	interface PXFillStyler
	{
		// +(PXFillStyler *)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		[Verify (MethodToProperty)]
		PXFillStyler SharedInstance { get; }
	}

	// @interface PXFontEntry : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PXFontEntry
	{
		// @property (readonly, nonatomic) NSString * family;
		[Export ("family")]
		string Family { get; }

		// @property (readonly, nonatomic) NSString * name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, nonatomic) NSInteger weight;
		[Export ("weight")]
		nint Weight { get; }

		// @property (readonly, nonatomic) NSInteger stretch;
		[Export ("stretch")]
		nint Stretch { get; }

		// @property (readonly, nonatomic) NSString * style;
		[Export ("style")]
		string Style { get; }

		// +(NSInteger)indexFromStretchName:(NSString *)name;
		[Static]
		[Export ("indexFromStretchName:")]
		nint IndexFromStretchName (string name);

		// +(NSInteger)indexFromWeightName:(NSString *)name;
		[Static]
		[Export ("indexFromWeightName:")]
		nint IndexFromWeightName (string name);

		// +(NSArray *)fontEntriesForFamily:(NSString *)family;
		[Static]
		[Export ("fontEntriesForFamily:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] FontEntriesForFamily (string family);

		// +(NSArray *)filterEntries:(NSArray *)entries byStretch:(NSInteger)fontStretch;
		[Static]
		[Export ("filterEntries:byStretch:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] FilterEntries (NSObject[] entries, nint fontStretch);

		// +(NSArray *)filterEntries:(NSArray *)entries byStyle:(NSString *)style;
		[Static]
		[Export ("filterEntries:byStyle:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] FilterEntries (NSObject[] entries, string style);

		// +(NSArray *)filterEntries:(NSArray *)entries byWeight:(NSInteger)weight;
		[Static]
		[Export ("filterEntries:byWeight:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] FilterEntries (NSObject[] entries, nint weight);

		// -(instancetype)initWithFontFamily:(NSString *)family fontName:(NSString *)name __attribute__((objc_designated_initializer));
		[Export ("initWithFontFamily:fontName:")]
		[DesignatedInitializer]
		IntPtr Constructor (string family, string name);
	}

	// @interface PXFontInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface PXFontInfo
	{
		// @property (nonatomic, strong) NSString * family;
		[Export ("family", ArgumentSemantic.Strong)]
		string Family { get; set; }

		// @property (nonatomic, strong) NSString * name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic) NSInteger weight;
		[Export ("weight")]
		nint Weight { get; set; }

		// @property (nonatomic) NSInteger stretch;
		[Export ("stretch")]
		nint Stretch { get; set; }

		// @property (nonatomic, strong) NSString * style;
		[Export ("style", ArgumentSemantic.Strong)]
		string Style { get; set; }
	}

	// @interface PXFontRegistry : NSObject
	[BaseType (typeof(NSObject))]
	interface PXFontRegistry
	{
		// +(void)clearRegistry;
		[Static]
		[Export ("clearRegistry")]
		void ClearRegistry ();

		// +(UIFont *)fontWithFamily:(NSString *)family fontStretch:(NSString *)stretch fontWeight:(NSString *)weight fontStyle:(NSString *)style size:(CGFloat)size isDefaultFont:(BOOL)isDefaultFont;
		[Static]
		[Export ("fontWithFamily:fontStretch:fontWeight:fontStyle:size:isDefaultFont:")]
		UIFont FontWithFamily (string family, string stretch, string weight, string style, nfloat size, bool isDefaultFont);

		// +(void)loadFontFromURL:(NSURL *)URL;
		[Static]
		[Export ("loadFontFromURL:")]
		void LoadFontFromURL (NSUrl URL);
	}

	// @interface PXFontStyler : PXStylerBase
	[BaseType (typeof(PXStylerBase))]
	interface PXFontStyler
	{
	}

	// @interface PXForceLoadCGCategories : NSObject
	[BaseType (typeof(NSObject))]
	interface PXForceLoadCGCategories
	{
		// +(void)forceLoad;
		[Static]
		[Export ("forceLoad")]
		void ForceLoad ();
	}

	// @interface PXForceLoadControls : NSObject
	[BaseType (typeof(NSObject))]
	interface PXForceLoadControls
	{
		// +(void)forceLoad;
		[Static]
		[Export ("forceLoad")]
		void ForceLoad ();
	}

	// @interface PXForceLoadPixateCategories : NSObject
	[BaseType (typeof(NSObject))]
	interface PXForceLoadPixateCategories
	{
		// +(void)forceLoad;
		[Static]
		[Export ("forceLoad")]
		void ForceLoad ();
	}

	// @interface PXForceLoadStylingCategories : NSObject
	[BaseType (typeof(NSObject))]
	interface PXForceLoadStylingCategories
	{
		// +(void)forceLoad;
		[Static]
		[Export ("forceLoad")]
		void ForceLoad ();
	}

	// @interface PXForceLoadVirtualCategories : NSObject
	[BaseType (typeof(NSObject))]
	interface PXForceLoadVirtualCategories
	{
		// +(void)forceLoad;
		[Static]
		[Export ("forceLoad")]
		void ForceLoad ();
	}

	// @interface PXGenericStyler : PXStylerBase
	[BaseType (typeof(PXStylerBase))]
	[DisableDefaultCtor]
	interface PXGenericStyler
	{
		// -(instancetype)initWithHandlers:(NSDictionary *)handlers;
		[Export ("initWithHandlers:")]
		IntPtr Constructor (NSDictionary handlers);

		// -(instancetype)initWithHandlers:(NSDictionary *)handlers completionBlock:(PXStylerCompletionBlock)block __attribute__((objc_designated_initializer));
		[Export ("initWithHandlers:completionBlock:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSDictionary handlers, PXStylerCompletionBlock block);
	}

	// @interface PXGradient : NSObject <PXPaint>
	[BaseType (typeof(NSObject))]
	interface PXGradient : IPXPaint
	{
		// @property (nonatomic) NSMutableArray * offsets;
		[Export ("offsets", ArgumentSemantic.Assign)]
		NSMutableArray Offsets { get; set; }

		// @property (nonatomic) NSMutableArray * colors;
		[Export ("colors", ArgumentSemantic.Assign)]
		NSMutableArray Colors { get; set; }

		// @property (nonatomic) PXGradientUnits gradientUnits;
		[Export ("gradientUnits", ArgumentSemantic.Assign)]
		PXGradientUnits GradientUnits { get; set; }

		// @property (nonatomic) CGAffineTransform transform;
		[Export ("transform", ArgumentSemantic.Assign)]
		CGAffineTransform Transform { get; set; }

		// @property (readonly) CGGradientRef gradient;
		[Export ("gradient")]
		unsafe CGGradientRef* Gradient { get; }

		// -(void)addColor:(UIColor *)color;
		[Export ("addColor:")]
		void AddColor (UIColor color);

		// -(void)addColor:(UIColor *)color withOffset:(CGFloat)offset;
		[Export ("addColor:withOffset:")]
		void AddColor (UIColor color, nfloat offset);
	}

	// @interface PXColors (UIColor)
	[Category]
	[BaseType (typeof(UIColor))]
	interface UIColor_PXColors
	{
		// +(UIColor *)colorFromName:(NSString *)name;
		[Static]
		[Export ("colorFromName:")]
		UIColor ColorFromName (string name);

		// +(UIColor *)colorWithHue:(CGFloat)hue saturation:(CGFloat)saturation lightness:(CGFloat)lightness;
		[Static]
		[Export ("colorWithHue:saturation:lightness:")]
		UIColor ColorWithHue (nfloat hue, nfloat saturation, nfloat lightness);

		// +(UIColor *)colorWithHue:(CGFloat)hue saturation:(CGFloat)saturation lightness:(CGFloat)lightness alpha:(CGFloat)alpha;
		[Static]
		[Export ("colorWithHue:saturation:lightness:alpha:")]
		UIColor ColorWithHue (nfloat hue, nfloat saturation, nfloat lightness, nfloat alpha);

		// +(UIColor *)colorWithHexString:(NSString *)hexString;
		[Static]
		[Export ("colorWithHexString:")]
		UIColor ColorWithHexString (string hexString);

		// +(UIColor *)colorWithHexString:(NSString *)hexString withAlpha:(CGFloat)alpha;
		[Static]
		[Export ("colorWithHexString:withAlpha:")]
		UIColor ColorWithHexString (string hexString, nfloat alpha);

		// +(UIColor *)colorWithRGBAValue:(uint)value;
		[Static]
		[Export ("colorWithRGBAValue:")]
		UIColor ColorWithRGBAValue (uint value);

		// +(UIColor *)colorWithARGBValue:(uint)value;
		[Static]
		[Export ("colorWithARGBValue:")]
		UIColor ColorWithARGBValue (uint value);

		// +(UIColor *)colorWithRGBValue:(uint)value;
		[Static]
		[Export ("colorWithRGBValue:")]
		UIColor ColorWithRGBValue (uint value);

		// -(BOOL)getHue:(CGFloat *)hue saturation:(CGFloat *)saturation lightness:(CGFloat *)lightness alpha:(CGFloat *)alpha;
		[Export ("getHue:saturation:lightness:alpha:")]
		unsafe bool GetHue (nfloat* hue, nfloat* saturation, nfloat* lightness, nfloat* alpha);

		// @property (readonly, getter = isOpaque, nonatomic) BOOL opaque;
		[Export ("opaque")]
		bool Opaque { [Bind ("isOpaque")] get; }

		// -(UIColor *)darkenByPercent:(CGFloat)percent;
		[Export ("darkenByPercent:")]
		UIColor DarkenByPercent (nfloat percent);

		// -(UIColor *)lightenByPercent:(CGFloat)percent;
		[Export ("lightenByPercent:")]
		UIColor LightenByPercent (nfloat percent);
	}

	// @interface PXVector : NSObject
	[BaseType (typeof(NSObject))]
	interface PXVector
	{
		// @property (readonly, nonatomic) CGFloat x;
		[Export ("x")]
		nfloat X { get; }

		// @property (readonly, nonatomic) CGFloat y;
		[Export ("y")]
		nfloat Y { get; }

		// @property (readonly, nonatomic) CGFloat angle;
		[Export ("angle")]
		nfloat Angle { get; }

		// @property (readonly, nonatomic) CGFloat length;
		[Export ("length")]
		nfloat Length { get; }

		// @property (readonly, nonatomic) CGFloat magnitude;
		[Export ("magnitude")]
		nfloat Magnitude { get; }

		// @property (readonly, nonatomic) PXVector * perp;
		[Export ("perp")]
		PXVector Perp { get; }

		// @property (readonly, nonatomic) PXVector * unit;
		[Export ("unit")]
		PXVector Unit { get; }

		// +(instancetype)vectorWithX:(CGFloat)x Y:(CGFloat)y;
		[Static]
		[Export ("vectorWithX:Y:")]
		PXVector VectorWithX (nfloat x, nfloat y);

		// +(instancetype)vectorWithStartPoint:(CGPoint)p1 EndPoint:(CGPoint)p2;
		[Static]
		[Export ("vectorWithStartPoint:EndPoint:")]
		PXVector VectorWithStartPoint (CGPoint p1, CGPoint p2);

		// -(instancetype)initWithX:(CGFloat)x Y:(CGFloat)y __attribute__((objc_designated_initializer));
		[Export ("initWithX:Y:")]
		[DesignatedInitializer]
		IntPtr Constructor (nfloat x, nfloat y);

		// -(CGFloat)angleBetweenVector:(PXVector *)vector;
		[Export ("angleBetweenVector:")]
		nfloat AngleBetweenVector (PXVector vector);

		// -(CGFloat)dot:(PXVector *)vector;
		[Export ("dot:")]
		nfloat Dot (PXVector vector);

		// -(CGFloat)cross:(PXVector *)vector;
		[Export ("cross:")]
		nfloat Cross (PXVector vector);

		// -(PXVector *)add:(PXVector *)vector;
		[Export ("add:")]
		PXVector Add (PXVector vector);

		// -(PXVector *)subtract:(PXVector *)vector;
		[Export ("subtract:")]
		PXVector Subtract (PXVector vector);

		// -(PXVector *)divide:(CGFloat)scalar;
		[Export ("divide:")]
		PXVector Divide (nfloat scalar);

		// -(PXVector *)multiply:(CGFloat)scalar;
		[Export ("multiply:")]
		PXVector Multiply (nfloat scalar);

		// -(PXVector *)perpendicular:(PXVector *)vector;
		[Export ("perpendicular:")]
		PXVector Perpendicular (PXVector vector);

		// -(PXVector *)projectOnto:(PXVector *)vector;
		[Export ("projectOnto:")]
		PXVector ProjectOnto (PXVector vector);
	}

	// @interface PXLinearGradient : PXGradient
	[BaseType (typeof(PXGradient))]
	interface PXLinearGradient
	{
		// @property (nonatomic) CGFloat angle;
		[Export ("angle")]
		nfloat Angle { get; set; }

		// @property (nonatomic) CGFloat cssAngle;
		[Export ("cssAngle")]
		nfloat CssAngle { get; set; }

		// @property (nonatomic) CGFloat psAngle;
		[Export ("psAngle")]
		nfloat PsAngle { get; set; }

		// @property (nonatomic) CGPoint p1;
		[Export ("p1", ArgumentSemantic.Assign)]
		CGPoint P1 { get; set; }

		// @property (nonatomic) CGPoint p2;
		[Export ("p2", ArgumentSemantic.Assign)]
		CGPoint P2 { get; set; }

		// @property (nonatomic) PXLinearGradientDirection gradientDirection;
		[Export ("gradientDirection", ArgumentSemantic.Assign)]
		PXLinearGradientDirection GradientDirection { get; set; }

		// +(PXLinearGradient *)gradientFromStartColor:(UIColor *)startColor endColor:(UIColor *)endColor;
		[Static]
		[Export ("gradientFromStartColor:endColor:")]
		PXLinearGradient GradientFromStartColor (UIColor startColor, UIColor endColor);
	}

	// @interface PXPaintGroup : NSObject <PXPaint>
	[BaseType (typeof(NSObject))]
	interface PXPaintGroup : IPXPaint
	{
		// @property (readonly, nonatomic) NSArray * paints;
		[Export ("paints")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Paints { get; }

		// -(instancetype)initWithPaints:(NSArray *)paints;
		[Export ("initWithPaints:")]
		[Verify (StronglyTypedNSArray)]
		IntPtr Constructor (NSObject[] paints);

		// -(void)addPaint:(id<PXPaint>)paint;
		[Export ("addPaint:")]
		void AddPaint (PXPaint paint);
	}

	// @interface PXRadialGradient : PXGradient
	[BaseType (typeof(PXGradient))]
	interface PXRadialGradient
	{
		// @property (nonatomic) CGPoint startCenter;
		[Export ("startCenter", ArgumentSemantic.Assign)]
		CGPoint StartCenter { get; set; }

		// @property (nonatomic) CGPoint endCenter;
		[Export ("endCenter", ArgumentSemantic.Assign)]
		CGPoint EndCenter { get; set; }

		// @property (nonatomic) CGFloat radius;
		[Export ("radius")]
		nfloat Radius { get; set; }
	}

	// @interface PXSolidPaint : NSObject <PXPaint>
	[BaseType (typeof(NSObject))]
	interface PXSolidPaint : IPXPaint
	{
		// @property (nonatomic, strong) UIColor * color;
		[Export ("color", ArgumentSemantic.Strong)]
		UIColor Color { get; set; }

		// +(instancetype)paintWithColor:(UIColor *)color;
		[Static]
		[Export ("paintWithColor:")]
		PXSolidPaint PaintWithColor (UIColor color);

		// -(instancetype)initWithColor:(UIColor *)color __attribute__((objc_designated_initializer));
		[Export ("initWithColor:")]
		[DesignatedInitializer]
		IntPtr Constructor (UIColor color);
	}

	// @interface PXSVGLoader : NSObject <NSXMLParserDelegate>
	[BaseType (typeof(NSObject))]
	interface PXSVGLoader : INSXMLParserDelegate
	{
		// @property (nonatomic) NSURL * URL;
		[Export ("URL", ArgumentSemantic.Assign)]
		NSUrl URL { get; set; }

		// +(PXShapeDocument *)loadFromURL:(NSURL *)URL;
		[Static]
		[Export ("loadFromURL:")]
		PXShapeDocument LoadFromURL (NSUrl URL);

		// +(PXShapeDocument *)loadFromData:(NSData *)data;
		[Static]
		[Export ("loadFromData:")]
		PXShapeDocument LoadFromData (NSData data);

		// +(Class)loaderClass;
		// +(void)setLoaderClass:(Class)class;
		[Static]
		[Export ("loaderClass")]
		[Verify (MethodToProperty)]
		Class LoaderClass { get; set; }

		// -(CGFloat)numberFromString:(NSString *)attributeValue;
		[Export ("numberFromString:")]
		nfloat NumberFromString (string attributeValue);

		// -(void)applyStyles:(NSDictionary *)attributeDict forShape:(PXShape *)shape;
		[Export ("applyStyles:forShape:")]
		void ApplyStyles (NSDictionary attributeDict, PXShape shape);

		// -(void)addShape:(PXShape *)shape;
		[Export ("addShape:")]
		void AddShape (PXShape shape);
	}

	// @interface PXLine : PXShape
	[BaseType (typeof(PXShape))]
	interface PXLine
	{
		// @property (nonatomic) CGPoint p1;
		[Export ("p1", ArgumentSemantic.Assign)]
		CGPoint P1 { get; set; }

		// @property (nonatomic) CGPoint p2;
		[Export ("p2", ArgumentSemantic.Assign)]
		CGPoint P2 { get; set; }

		// -(id)initX1:(CGFloat)x1 y1:(CGFloat)y1 x2:(CGFloat)x2 y2:(CGFloat)y2;
		[Export ("initX1:y1:x2:y2:")]
		IntPtr Constructor (nfloat x1, nfloat y1, nfloat x2, nfloat y2);
	}

	// @interface PXPath : PXShape
	[BaseType (typeof(PXShape))]
	interface PXPath
	{
		// +(PXPath *)createPathFromPathData:(NSString *)data;
		[Static]
		[Export ("createPathFromPathData:")]
		PXPath CreatePathFromPathData (string data);

		// -(void)close;
		[Export ("close")]
		void Close ();

		// -(void)lineToX:(CGFloat)x y:(CGFloat)y;
		[Export ("lineToX:y:")]
		void LineToX (nfloat x, nfloat y);

		// -(void)moveToX:(CGFloat)x y:(CGFloat)y;
		[Export ("moveToX:y:")]
		void MoveToX (nfloat x, nfloat y);

		// -(void)cubicBezierToX1:(CGFloat)x1 y1:(CGFloat)y1 x2:(CGFloat)x2 y2:(CGFloat)y2 x3:(CGFloat)x3 y3:(CGFloat)y3;
		[Export ("cubicBezierToX1:y1:x2:y2:x3:y3:")]
		void CubicBezierToX1 (nfloat x1, nfloat y1, nfloat x2, nfloat y2, nfloat x3, nfloat y3);

		// -(void)quadraticBezierToX1:(CGFloat)x1 y1:(CGFloat)y1 x2:(CGFloat)x2 y2:(CGFloat)y2;
		[Export ("quadraticBezierToX1:y1:x2:y2:")]
		void QuadraticBezierToX1 (nfloat x1, nfloat y1, nfloat x2, nfloat y2);

		// -(void)ellipticalArcX:(CGFloat)x y:(CGFloat)y radiusX:(CGFloat)radiusX radiusY:(CGFloat)radiusY startAngle:(CGFloat)startAngle endAngle:(CGFloat)endAngle;
		[Export ("ellipticalArcX:y:radiusX:radiusY:startAngle:endAngle:")]
		void EllipticalArcX (nfloat x, nfloat y, nfloat radiusX, nfloat radiusY, nfloat startAngle, nfloat endAngle);
	}

	// @interface PXPie : PXArc
	[BaseType (typeof(PXArc))]
	interface PXPie
	{
	}

	// @interface PXPolygon : PXShape
	[BaseType (typeof(PXShape))]
	interface PXPolygon
	{
		// @property (nonatomic) BOOL closed;
		[Export ("closed")]
		bool Closed { get; set; }

		// @property (nonatomic, strong) NSArray * points;
		[Export ("points", ArgumentSemantic.Strong)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Points { get; set; }

		// -(id)initWithPoints:(NSArray *)points;
		[Export ("initWithPoints:")]
		[Verify (StronglyTypedNSArray)]
		IntPtr Constructor (NSObject[] points);
	}

	// @interface PXShapeGroup : PXShape
	[BaseType (typeof(PXShape))]
	interface PXShapeGroup
	{
		// @property (nonatomic) CGFloat width;
		[Export ("width")]
		nfloat Width { get; set; }

		// @property (nonatomic) CGFloat height;
		[Export ("height")]
		nfloat Height { get; set; }

		// @property (nonatomic) CGRect viewport;
		[Export ("viewport", ArgumentSemantic.Assign)]
		CGRect Viewport { get; set; }

		// @property (nonatomic) AlignViewPortType viewportAlignment;
		[Export ("viewportAlignment", ArgumentSemantic.Assign)]
		AlignViewPortType ViewportAlignment { get; set; }

		// @property (nonatomic) CropType viewportCrop;
		[Export ("viewportCrop", ArgumentSemantic.Assign)]
		CropType ViewportCrop { get; set; }

		// @property (readonly, nonatomic) NSUInteger shapeCount;
		[Export ("shapeCount")]
		nuint ShapeCount { get; }

		// @property (readonly, nonatomic) CGAffineTransform viewPortTransform;
		[Export ("viewPortTransform")]
		CGAffineTransform ViewPortTransform { get; }

		// -(void)addShape:(id<PXRenderable>)shape;
		[Export ("addShape:")]
		void AddShape (PXRenderable shape);

		// -(void)removeShape:(id<PXRenderable>)shape;
		[Export ("removeShape:")]
		void RemoveShape (PXRenderable shape);

		// -(id<PXRenderable>)shapeAtIndex:(NSUInteger)index;
		[Export ("shapeAtIndex:")]
		PXRenderable ShapeAtIndex (nuint index);
	}

	// @interface PXStroke : NSObject <PXStrokeRenderer>
	[BaseType (typeof(NSObject))]
	interface PXStroke : IPXStrokeRenderer
	{
		// @property (nonatomic) PXStrokeType type;
		[Export ("type", ArgumentSemantic.Assign)]
		PXStrokeType Type { get; set; }

		// @property (nonatomic) CGFloat width;
		[Export ("width")]
		nfloat Width { get; set; }

		// @property (nonatomic, strong) id<PXPaint> color;
		[Export ("color", ArgumentSemantic.Strong)]
		PXPaint Color { get; set; }

		// @property (nonatomic, strong) NSArray * dashArray;
		[Export ("dashArray", ArgumentSemantic.Strong)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] DashArray { get; set; }

		// @property (nonatomic) CGFloat dashOffset;
		[Export ("dashOffset")]
		nfloat DashOffset { get; set; }

		// @property (nonatomic) CGLineCap lineCap;
		[Export ("lineCap", ArgumentSemantic.Assign)]
		CGLineCap LineCap { get; set; }

		// @property (nonatomic) CGLineJoin lineJoin;
		[Export ("lineJoin", ArgumentSemantic.Assign)]
		CGLineJoin LineJoin { get; set; }

		// @property (nonatomic) CGFloat miterLimit;
		[Export ("miterLimit")]
		nfloat MiterLimit { get; set; }

		// -(instancetype)initWithStrokeWidth:(CGFloat)width __attribute__((objc_designated_initializer));
		[Export ("initWithStrokeWidth:")]
		[DesignatedInitializer]
		IntPtr Constructor (nfloat width);

		// -(CGPathRef)newStrokedPath:(CGPathRef)path __attribute__((cf_returns_retained));
		[Export ("newStrokedPath:")]
		unsafe CGPathRef* NewStrokedPath (CGPathRef* path);
	}

	// @interface PXNonScalingStroke : PXStroke
	[BaseType (typeof(PXStroke))]
	interface PXNonScalingStroke
	{
	}

	// @interface PXStrokeGroup : NSObject <PXStrokeRenderer>
	[BaseType (typeof(NSObject))]
	interface PXStrokeGroup : IPXStrokeRenderer
	{
		// -(void)addStroke:(id<PXStrokeRenderer>)stroke;
		[Export ("addStroke:")]
		void AddStroke (PXStrokeRenderer stroke);
	}

	// @interface PXStrokeStroke : NSObject <PXStrokeRenderer>
	[BaseType (typeof(NSObject))]
	interface PXStrokeStroke : IPXStrokeRenderer
	{
		// @property (nonatomic, strong) PXStroke * strokeEffect;
		[Export ("strokeEffect", ArgumentSemantic.Strong)]
		PXStroke StrokeEffect { get; set; }

		// @property (nonatomic, strong) id<PXStrokeRenderer> strokeToApply;
		[Export ("strokeToApply", ArgumentSemantic.Strong)]
		PXStrokeRenderer StrokeToApply { get; set; }
	}

	// @interface PXShapeView : UIView
	[BaseType (typeof(UIView))]
	interface PXShapeView
	{
		// @property (nonatomic, weak) PXShapeDocument * _Nullable document;
		[NullAllowed, Export ("document", ArgumentSemantic.Weak)]
		PXShapeDocument Document { get; set; }

		// @property (nonatomic, strong) NSString * resourcePath;
		[Export ("resourcePath", ArgumentSemantic.Strong)]
		string ResourcePath { get; set; }

		// -(void)loadSceneFromURL:(NSURL *)URL;
		[Export ("loadSceneFromURL:")]
		void LoadSceneFromURL (NSUrl URL);

		// @property (readonly, nonatomic, strong) UIImage * renderToImage;
		[Export ("renderToImage", ArgumentSemantic.Strong)]
		UIImage RenderToImage { get; }

		// -(void)applyBoundsToScene;
		[Export ("applyBoundsToScene")]
		void ApplyBoundsToScene ();
	}

	// @interface PXIdSelector : NSObject <PXSelector>
	[BaseType (typeof(NSObject))]
	interface PXIdSelector : IPXSelector
	{
		// @property (readonly, nonatomic, strong) NSString * idValue;
		[Export ("idValue", ArgumentSemantic.Strong)]
		string IdValue { get; }

		// -(id)initWithIdValue:(NSString *)value;
		[Export ("initWithIdValue:")]
		IntPtr Constructor (string value);
	}

	// @interface PXImagePaint : NSObject <PXPaint>
	[BaseType (typeof(NSObject))]
	interface PXImagePaint : IPXPaint
	{
		// @property (nonatomic) NSURL * imageURL;
		[Export ("imageURL", ArgumentSemantic.Assign)]
		NSUrl ImageURL { get; set; }

		// -(id)initWithURL:(NSURL *)url;
		[Export ("initWithURL:")]
		IntPtr Constructor (NSUrl url);
	}

	// @interface PXImageUtils : NSObject
	[BaseType (typeof(NSObject))]
	interface PXImageUtils
	{
		// +(UIImage *)clearPixel;
		[Static]
		[Export ("clearPixel")]
		[Verify (MethodToProperty)]
		UIImage ClearPixel { get; }

		// +(void)writeImage:(UIImage *)image withPath:(NSString *)path overwrite:(BOOL)overwrite;
		[Static]
		[Export ("writeImage:withPath:overwrite:")]
		void WriteImage (UIImage image, string path, bool overwrite);
	}

	// @interface PXInsetStyler : PXStylerBase
	[BaseType (typeof(PXStylerBase))]
	interface PXInsetStyler
	{
		// @property (nonatomic) UIEdgeInsets insets;
		[Export ("insets", ArgumentSemantic.Assign)]
		UIEdgeInsets Insets { get; set; }

		// -(id)initWithBaseName:(NSString *)baseName completionBlock:(PXStylerCompletionBlock)block;
		[Export ("initWithBaseName:completionBlock:")]
		IntPtr Constructor (string baseName, PXStylerCompletionBlock block);
	}

	// @interface PXKeyframeAnimation : NSObject
	[BaseType (typeof(NSObject))]
	interface PXKeyframeAnimation
	{
		// @property (nonatomic) NSString * keyPath;
		[Export ("keyPath")]
		string KeyPath { get; set; }

		// @property (nonatomic) CGFloat beginTime;
		[Export ("beginTime")]
		nfloat BeginTime { get; set; }

		// @property (nonatomic) CGFloat duration;
		[Export ("duration")]
		nfloat Duration { get; set; }

		// @property (nonatomic) NSArray * values;
		[Export ("values", ArgumentSemantic.Assign)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Values { get; set; }

		// @property (nonatomic) NSArray * keyTimes;
		[Export ("keyTimes", ArgumentSemantic.Assign)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] KeyTimes { get; set; }

		// @property (nonatomic) NSArray * timingFunctions;
		[Export ("timingFunctions", ArgumentSemantic.Assign)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] TimingFunctions { get; set; }

		// @property (nonatomic) PXAnimationFillMode fillMode;
		[Export ("fillMode", ArgumentSemantic.Assign)]
		PXAnimationFillMode FillMode { get; set; }

		// @property (nonatomic) NSUInteger repeatCount;
		[Export ("repeatCount")]
		nuint RepeatCount { get; set; }

		// @property (nonatomic) CAKeyframeAnimation * caKeyframeAnimation;
		[Export ("caKeyframeAnimation", ArgumentSemantic.Assign)]
		CAKeyFrameAnimation CaKeyframeAnimation { get; set; }

		// -(void)addValue:(id)value;
		[Export ("addValue:")]
		void AddValue (NSObject value);

		// -(void)addKeyTime:(CGFloat)keyTime;
		[Export ("addKeyTime:")]
		void AddKeyTime (nfloat keyTime);

		// -(void)addTimingFunction:(PXAnimationTimingFunction)timingFunction;
		[Export ("addTimingFunction:")]
		void AddTimingFunction (PXAnimationTimingFunction timingFunction);
	}

	// @interface PXLayoutStyler : PXStylerBase
	[BaseType (typeof(PXStylerBase))]
	interface PXLayoutStyler
	{
		// +(PXLayoutStyler *)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		[Verify (MethodToProperty)]
		PXLayoutStyler SharedInstance { get; }
	}

	// @protocol PXLoggingDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface PXLoggingDelegate
	{
		// @required -(void)logEntry:(NSString *)logItem atLogLevel:(DDLogLevel)logLevel;
		[Abstract]
		[Export ("logEntry:atLogLevel:")]
		void AtLogLevel (string logItem, DDLogLevel logLevel);
	}

	// @interface PXLoggingUtils : NSObject
	[BaseType (typeof(NSObject))]
	interface PXLoggingUtils
	{
		// +(void)enableLogging;
		[Static]
		[Export ("enableLogging")]
		void EnableLogging ();

		// +(void)enablePrettyLogFormatting;
		[Static]
		[Export ("enablePrettyLogFormatting")]
		void EnablePrettyLogFormatting ();

		// +(void)enableLoggingToDirectoryPath:(NSString *)path;
		[Static]
		[Export ("enableLoggingToDirectoryPath:")]
		void EnableLoggingToDirectoryPath (string path);

		// +(void)setGlobalLoggingLevel:(DDLogLevel)logLevel;
		[Static]
		[Export ("setGlobalLoggingLevel:")]
		void SetGlobalLoggingLevel (DDLogLevel logLevel);

		// +(void)addLoggingDelegate:(id<PXLoggingDelegate>)delegate;
		[Static]
		[Export ("addLoggingDelegate:")]
		void AddLoggingDelegate (PXLoggingDelegate @delegate);
	}

	// @interface PXMKAnnotationContainerView : UIView
	[BaseType (typeof(UIView))]
	interface PXMKAnnotationContainerView
	{
	}

	// @interface PXMKAnnotationView : UIView
	[BaseType (typeof(UIView))]
	interface PXMKAnnotationView
	{
	}

	// @interface PXMKMapView : UIView
	[BaseType (typeof(UIView))]
	interface PXMKMapView
	{
	}

	// @interface PXMPVolumeView : UIView
	[BaseType (typeof(UIView))]
	interface PXMPVolumeView
	{
	}

	// @interface PXStylesheet : NSObject
	[BaseType (typeof(NSObject))]
	interface PXStylesheet
	{
		// @property (readonly, nonatomic) PXStylesheetOrigin origin;
		[Export ("origin")]
		PXStylesheetOrigin Origin { get; }

		// @property (nonatomic, strong) NSArray * errors;
		[Export ("errors", ArgumentSemantic.Strong)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Errors { get; set; }

		// @property (nonatomic, strong) NSString * filePath;
		[Export ("filePath", ArgumentSemantic.Strong)]
		string FilePath { get; set; }

		// @property (assign, nonatomic) BOOL monitorChanges;
		[Export ("monitorChanges")]
		bool MonitorChanges { get; set; }

		// +(void)clearCache;
		[Static]
		[Export ("clearCache")]
		void ClearCache ();

		// @property (readonly, nonatomic, strong) NSArray * ruleSets;
		[Export ("ruleSets", ArgumentSemantic.Strong)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] RuleSets { get; }

		// @property (readonly, nonatomic, strong) NSArray * mediaGroups;
		[Export ("mediaGroups", ArgumentSemantic.Strong)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] MediaGroups { get; }

		// @property (nonatomic, strong) id<PXMediaExpression> activeMediaQuery;
		[Export ("activeMediaQuery", ArgumentSemantic.Strong)]
		PXMediaExpression ActiveMediaQuery { get; set; }
	}

	// @interface PXStyling (UIView) <PXStyleable>
	[Category]
	[BaseType (typeof(UIView))]
	interface UIView_PXStyling : IPXStyleable
	{
		// @property (copy, nonatomic) NSString * styleId;
		[Export ("styleId")]
		string StyleId { get; set; }

		// @property (copy, nonatomic) NSString * styleClass;
		[Export ("styleClass")]
		string StyleClass { get; set; }

		// @property (copy, nonatomic) NSString * styleCSS;
		[Export ("styleCSS")]
		string StyleCSS { get; set; }

		// @property (nonatomic) PXStylingMode styleMode __attribute__((annotate("ui_appearance_selector")));
		[Export ("styleMode", ArgumentSemantic.Assign)]
		PXStylingMode StyleMode { get; set; }

		// -(void)addStyleClass:(NSString *)styleClass;
		[Export ("addStyleClass:")]
		void AddStyleClass (string styleClass);

		// -(void)removeStyleClass:(NSString *)styleClass;
		[Export ("removeStyleClass:")]
		void RemoveStyleClass (string styleClass);

		// -(void)styleClassed:(NSString *)styleClass enabled:(_Bool)enabled;
		[Export ("styleClassed:enabled:")]
		void StyleClassed (string styleClass, bool enabled);

		// -(void)stkUpdateStylesFromLayoutSubviewsRecursively:(BOOL)recursively;
		[Export ("stkUpdateStylesFromLayoutSubviewsRecursively:")]
		void StkUpdateStylesFromLayoutSubviewsRecursively (bool recursively);

		// +(void)updateStyles:(id<PXStyleable>)styleable recursively:(_Bool)recurse;
		[Static]
		[Export ("updateStyles:recursively:")]
		void UpdateStyles (PXStyleable styleable, bool recurse);
	}

	// @protocol PXVirtualControl <PXStyleable>
	[Protocol, Model]
	interface PXVirtualControl : IPXStyleable
	{
		// @required @property (readonly, nonatomic) BOOL isVirtualControl;
		[Export ("isVirtualControl")]
		bool IsVirtualControl { get; }
	}

	// @interface PXStyling (UIBarButtonItem) <PXVirtualControl>
	[Category]
	[BaseType (typeof(UIBarButtonItem))]
	interface UIBarButtonItem_PXStyling : IPXVirtualControl
	{
		// @property (readwrite, nonatomic, weak) id _Nullable pxStyleParent;
		[NullAllowed, Export ("pxStyleParent", ArgumentSemantic.Weak)]
		NSObject PxStyleParent { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * pxStyleElementName;
		[Export ("pxStyleElementName")]
		string PxStyleElementName { get; set; }
	}

	// @interface PXStyling (UITabBarItem) <PXVirtualControl>
	[Category]
	[BaseType (typeof(UITabBarItem))]
	interface UITabBarItem_PXStyling : IPXVirtualControl
	{
		// @property (readwrite, nonatomic, weak) id _Nullable pxStyleParent;
		[NullAllowed, Export ("pxStyleParent", ArgumentSemantic.Weak)]
		NSObject PxStyleParent { get; set; }
	}

	// @interface PXStyling (UINavigationItem) <PXVirtualControl>
	[Category]
	[BaseType (typeof(UINavigationItem))]
	interface UINavigationItem_PXStyling : IPXVirtualControl
	{
		// @property (readwrite, nonatomic, weak) id _Nullable pxStyleParent;
		[NullAllowed, Export ("pxStyleParent", ArgumentSemantic.Weak)]
		NSObject PxStyleParent { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * pxStyleElementName;
		[Export ("pxStyleElementName")]
		string PxStyleElementName { get; set; }
	}

	// @interface PixateFreestyle : NSObject
	[BaseType (typeof(NSObject))]
	interface PixateFreestyle
	{
		// +(NSString *)version;
		[Static]
		[Export ("version")]
		[Verify (MethodToProperty)]
		string Version { get; }

		// +(NSDate *)buildDate;
		[Static]
		[Export ("buildDate")]
		[Verify (MethodToProperty)]
		NSDate BuildDate { get; }

		// +(int)apiVersion;
		[Static]
		[Export ("apiVersion")]
		[Verify (MethodToProperty)]
		int ApiVersion { get; }

		// +(BOOL)titaniumMode;
		[Static]
		[Export ("titaniumMode")]
		[Verify (MethodToProperty)]
		bool TitaniumMode { get; }

		// +(PixateFreestyleConfiguration *)configuration;
		[Static]
		[Export ("configuration")]
		[Verify (MethodToProperty)]
		PixateFreestyleConfiguration Configuration { get; }

		// +(BOOL)refreshStylesWithOrientationChange;
		// +(void)setRefreshStylesWithOrientationChange:(BOOL)value;
		[Static]
		[Export ("refreshStylesWithOrientationChange")]
		[Verify (MethodToProperty)]
		bool RefreshStylesWithOrientationChange { get; set; }

		// +(NSArray *)selectFromStyleable:(id<PXStyleable>)styleable usingSelector:(NSString *)source;
		[Static]
		[Export ("selectFromStyleable:usingSelector:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] SelectFromStyleable (PXStyleable styleable, string source);

		// +(NSString *)matchingRuleSetsForStyleable:(id<PXStyleable>)styleable;
		[Static]
		[Export ("matchingRuleSetsForStyleable:")]
		string MatchingRuleSetsForStyleable (PXStyleable styleable);

		// +(NSString *)matchingDeclarationsForStyleable:(id<PXStyleable>)styleable;
		[Static]
		[Export ("matchingDeclarationsForStyleable:")]
		string MatchingDeclarationsForStyleable (PXStyleable styleable);

		// +(id)styleSheetFromSource:(NSString *)source withOrigin:(PXStylesheetOrigin)origin;
		[Static]
		[Export ("styleSheetFromSource:withOrigin:")]
		NSObject StyleSheetFromSource (string source, PXStylesheetOrigin origin);

		// +(id)styleSheetFromFilePath:(NSString *)filePath withOrigin:(PXStylesheetOrigin)origin;
		[Static]
		[Export ("styleSheetFromFilePath:withOrigin:")]
		NSObject StyleSheetFromFilePath (string filePath, PXStylesheetOrigin origin);

		// +(PXStylesheet *)currentApplicationStylesheet;
		[Static]
		[Export ("currentApplicationStylesheet")]
		PXStylesheet CurrentApplicationStylesheet ();

		// +(PXStylesheet *)currentUserStylesheet;
		[Static]
		[Export ("currentUserStylesheet")]
		PXStylesheet CurrentUserStylesheet ();

		// +(PXStylesheet *)currentViewStylesheet;
		[Static]
		[Export ("currentViewStylesheet")]
		PXStylesheet CurrentViewStylesheet ();

		// +(void)applyStylesheets __attribute__((deprecated("Use updateStylesForAllViews")));
		[Static]
		[Export ("applyStylesheets")]
		void ApplyStylesheets ();

		// +(void)updateStylesForAllViews;
		[Static]
		[Export ("updateStylesForAllViews")]
		void UpdateStylesForAllViews ();

		// +(void)updateStyles:(id<PXStyleable>)styleable;
		[Static]
		[Export ("updateStyles:")]
		void UpdateStyles (PXStyleable styleable);

		// +(void)updateStylesNonRecursively:(id<PXStyleable>)styleable;
		[Static]
		[Export ("updateStylesNonRecursively:")]
		void UpdateStylesNonRecursively (PXStyleable styleable);

		// +(void)updateStylesAsync:(id<PXStyleable>)styleable;
		[Static]
		[Export ("updateStylesAsync:")]
		void UpdateStylesAsync (PXStyleable styleable);

		// +(void)updateStylesNonRecursivelyAsync:(id<PXStyleable>)styleable;
		[Static]
		[Export ("updateStylesNonRecursivelyAsync:")]
		void UpdateStylesNonRecursivelyAsync (PXStyleable styleable);

		// +(void)clearImageCache;
		[Static]
		[Export ("clearImageCache")]
		void ClearImageCache ();

		// +(void)clearStyleCache;
		[Static]
		[Export ("clearStyleCache")]
		void ClearStyleCache ();

		// @property (readwrite, nonatomic, strong) NSString * version;
		[Export ("version", ArgumentSemantic.Strong)]
		string Version { get; set; }

		// @property (readwrite, nonatomic, strong) NSDate * buildDate;
		[Export ("buildDate", ArgumentSemantic.Strong)]
		NSDate BuildDate { get; set; }

		// @property (readwrite, nonatomic) int apiVersion;
		[Export ("apiVersion")]
		int ApiVersion { get; set; }

		// @property (readwrite, nonatomic) BOOL titaniumMode;
		[Export ("titaniumMode")]
		bool TitaniumMode { get; set; }

		// @property (readonly, nonatomic, strong) PixateFreestyleConfiguration * configuration;
		[Export ("configuration", ArgumentSemantic.Strong)]
		PixateFreestyleConfiguration Configuration { get; }
	}

	// @interface  (PixateFreestyle)
	[Category]
	[BaseType (typeof(PixateFreestyle))]
	interface PixateFreestyle_
	{
		// @property (readwrite, nonatomic, strong) NSString * version;
		[Export ("version")]
		string Version { get; set; }

		// @property (readwrite, nonatomic, strong) NSDate * buildDate;
		[Export ("buildDate")]
		NSDate BuildDate { get; set; }

		// @property (readwrite, nonatomic) int apiVersion;
		[Export ("apiVersion")]
		int ApiVersion { get; set; }

		// @property (readwrite, nonatomic) BOOL titaniumMode;
		[Export ("titaniumMode")]
		bool TitaniumMode { get; set; }

		// @property (readonly, nonatomic, strong) PixateFreestyleConfiguration * configuration;
		[Export ("configuration")]
		PixateFreestyleConfiguration Configuration { get; }

		// +(PixateFreestyle *)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		[Verify (MethodToProperty)]
		PixateFreestyle SharedInstance { get; }
	}

	// @interface PXStyleUtils : NSObject
	[BaseType (typeof(NSObject))]
	interface PXStyleUtils
	{
		// +(NSArray *)elementChildrenOfStyleable:(id<PXStyleable>)styleable;
		[Static]
		[Export ("elementChildrenOfStyleable:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] ElementChildrenOfStyleable (PXStyleable styleable);

		// +(NSInteger)childCountForStyleable:(id<PXStyleable>)styleable;
		[Static]
		[Export ("childCountForStyleable:")]
		nint ChildCountForStyleable (PXStyleable styleable);

		// +(PXStyleableChildrenInfo *)childrenInfoForStyleable:(id<PXStyleable>)styleable;
		[Static]
		[Export ("childrenInfoForStyleable:")]
		unsafe PXStyleableChildrenInfo* ChildrenInfoForStyleable (PXStyleable styleable);

		// +(NSString *)descriptionForStyleable:(id<PXStyleable>)styleable;
		[Static]
		[Export ("descriptionForStyleable:")]
		string DescriptionForStyleable (PXStyleable styleable);

		// +(NSString *)selectorFromStyleable:(id<PXStyleable>)styleable;
		[Static]
		[Export ("selectorFromStyleable:")]
		string SelectorFromStyleable (PXStyleable styleable);

		// +(NSString *)styleKeyFromStyleable:(id<PXStyleable>)styleable;
		[Static]
		[Export ("styleKeyFromStyleable:")]
		string StyleKeyFromStyleable (PXStyleable styleable);

		// +(void)enumerateStyleableAndDescendants:(id<PXStyleable>)styleable usingBlock:(void (^)(id, BOOL *, BOOL *))block;
		[Static]
		[Export ("enumerateStyleableAndDescendants:usingBlock:")]
		unsafe void EnumerateStyleableAndDescendants (PXStyleable styleable, Action<NSObject, bool*, bool*> block);

		// +(void)enumerateStyleableDescendants:(id<PXStyleable>)styleable usingBlock:(void (^)(id, BOOL *, BOOL *))block;
		[Static]
		[Export ("enumerateStyleableDescendants:usingBlock:")]
		unsafe void EnumerateStyleableDescendants (PXStyleable styleable, Action<NSObject, bool*, bool*> block);

		// +(NSDictionary *)viewStylerPropertyMapForStyleable:(id<PXStyleable>)styleable;
		[Static]
		[Export ("viewStylerPropertyMapForStyleable:")]
		NSDictionary ViewStylerPropertyMapForStyleable (PXStyleable styleable);

		// +(NSMutableArray *)matchingRuleSetsForStyleable:(id<PXStyleable>)styleable;
		[Static]
		[Export ("matchingRuleSetsForStyleable:")]
		NSMutableArray MatchingRuleSetsForStyleable (PXStyleable styleable);

		// +(NSArray *)filterRuleSets:(NSArray *)ruleSets forStyleable:(id<PXStyleable>)styleable byState:(NSString *)stateName;
		[Static]
		[Export ("filterRuleSets:forStyleable:byState:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] FilterRuleSets (NSObject[] ruleSets, PXStyleable styleable, string stateName);

		// +(NSArray *)filterRuleSets:(NSArray *)ruleSets byPseudoElement:(NSString *)pseudoElement;
		[Static]
		[Export ("filterRuleSets:byPseudoElement:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] FilterRuleSets (NSObject[] ruleSets, string pseudoElement);

		// +(BOOL)stylesOfStyleable:(id<PXStyleable>)styleable matchDeclarations:(NSArray *)declarations state:(NSString *)state;
		[Static]
		[Export ("stylesOfStyleable:matchDeclarations:state:")]
		[Verify (StronglyTypedNSArray)]
		bool StylesOfStyleable (PXStyleable styleable, NSObject[] declarations, string state);

		// +(void)invalidateStyleable:(id<PXStyleable>)styleable;
		[Static]
		[Export ("invalidateStyleable:")]
		void InvalidateStyleable (PXStyleable styleable);

		// +(void)invalidateStyleableAndDescendants:(id<PXStyleable>)styleable;
		[Static]
		[Export ("invalidateStyleableAndDescendants:")]
		void InvalidateStyleableAndDescendants (PXStyleable styleable);

		// +(NSUInteger)hashValueForStyleable:(id<PXStyleable>)styleable state:(NSString *)state;
		[Static]
		[Export ("hashValueForStyleable:state:")]
		nuint HashValueForStyleable (PXStyleable styleable, string state);

		// +(void)setItemIndex:(NSIndexPath *)index forObject:(NSObject *)object;
		[Static]
		[Export ("setItemIndex:forObject:")]
		void SetItemIndex (NSIndexPath index, NSObject @object);

		// +(NSIndexPath *)itemIndexForObject:(NSObject *)object;
		[Static]
		[Export ("itemIndexForObject:")]
		NSIndexPath ItemIndexForObject (NSObject @object);

		// +(void)setViewDelegate:(id)delegate forObject:(id)object;
		[Static]
		[Export ("setViewDelegate:forObject:")]
		void SetViewDelegate (NSObject @delegate, NSObject @object);

		// +(id)viewDelegateForObject:(id)object;
		[Static]
		[Export ("viewDelegateForObject:")]
		NSObject ViewDelegateForObject (NSObject @object);

		// +(void)updateStyleForStyleable:(id<PXStyleable>)styleable;
		[Static]
		[Export ("updateStyleForStyleable:")]
		void UpdateStyleForStyleable (PXStyleable styleable);

		// +(void)updateStylesForStyleable:(id<PXStyleable>)styleable andDescendants:(BOOL)recurse;
		[Static]
		[Export ("updateStylesForStyleable:andDescendants:")]
		void UpdateStylesForStyleable (PXStyleable styleable, bool recurse);

		// +(void)updateCellStyleWhenReady:(UIView *)view;
		[Static]
		[Export ("updateCellStyleWhenReady:")]
		void UpdateCellStyleWhenReady (UIView view);

		// +(void)updateCellStyleNonRecursiveWhenReady:(UIView *)view;
		[Static]
		[Export ("updateCellStyleNonRecursiveWhenReady:")]
		void UpdateCellStyleNonRecursiveWhenReady (UIView view);
	}

	// @protocol PXMediaExpression <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface PXMediaExpression
	{
		// @required -(BOOL)matches;
		[Abstract]
		[Export ("matches")]
		[Verify (MethodToProperty)]
		bool Matches { get; }

		// @required -(void)clearCache;
		[Abstract]
		[Export ("clearCache")]
		void ClearCache ();
	}

	// @interface PXMediaExpressionGroup : NSObject <PXMediaExpression>
	[BaseType (typeof(NSObject))]
	interface PXMediaExpressionGroup : IPXMediaExpression
	{
		// @property (readonly, nonatomic, strong) NSArray * expressions;
		[Export ("expressions", ArgumentSemantic.Strong)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Expressions { get; }

		// -(void)addExpression:(id<PXMediaExpression>)expression;
		[Export ("addExpression:")]
		void AddExpression (PXMediaExpression expression);
	}

	// @interface PXMediaGroup : NSObject <PXMediaExpression>
	[BaseType (typeof(NSObject))]
	interface PXMediaGroup : IPXMediaExpression
	{
		// @property (readonly, nonatomic) PXStylesheetOrigin origin;
		[Export ("origin")]
		PXStylesheetOrigin Origin { get; }

		// @property (readonly, nonatomic) id<PXMediaExpression> query;
		[Export ("query")]
		PXMediaExpression Query { get; }

		// @property (readonly, nonatomic, strong) NSArray * ruleSets;
		[Export ("ruleSets", ArgumentSemantic.Strong)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] RuleSets { get; }

		// -(id)initWithQuery:(id<PXMediaExpression>)query origin:(PXStylesheetOrigin)origin;
		[Export ("initWithQuery:origin:")]
		IntPtr Constructor (PXMediaExpression query, PXStylesheetOrigin origin);

		// -(void)addRuleSet:(PXRuleSet *)ruleSet;
		[Export ("addRuleSet:")]
		void AddRuleSet (PXRuleSet ruleSet);

		// -(NSArray *)ruleSetsForStyleable:(id<PXStyleable>)styleable;
		[Export ("ruleSetsForStyleable:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] RuleSetsForStyleable (PXStyleable styleable);
	}

	// typedef BOOL (^PXNamedMediaExpressionHandler)(id<PXMediaExpression>);
	delegate bool PXNamedMediaExpressionHandler (PXMediaExpression arg0);

	// @interface PXNamedMediaExpression : NSObject <PXMediaExpression>
	[BaseType (typeof(NSObject))]
	interface PXNamedMediaExpression : IPXMediaExpression
	{
		// @property (readonly, nonatomic, strong) NSString * name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; }

		// @property (readonly, nonatomic, strong) id value;
		[Export ("value", ArgumentSemantic.Strong)]
		NSObject Value { get; }

		// -(id)initWithName:(NSString *)name value:(id)value;
		[Export ("initWithName:value:")]
		IntPtr Constructor (string name, NSObject value);
	}

	// @interface PXNotPseudoClass : NSObject <PXSelector>
	[BaseType (typeof(NSObject))]
	interface PXNotPseudoClass : IPXSelector
	{
		// @property (nonatomic, strong) id<PXSelector> expression;
		[Export ("expression", ArgumentSemantic.Strong)]
		PXSelector Expression { get; set; }

		// -(id)initWithExpression:(id<PXSelector>)expression;
		[Export ("initWithExpression:")]
		IntPtr Constructor (PXSelector expression);
	}

	// @interface PXWeakWrapper : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PXWeakWrapper
	{
		// @property (readonly, nonatomic, weak) id _Nullable object;
		[NullAllowed, Export ("object", ArgumentSemantic.Weak)]
		NSObject Object { get; }

		// -(instancetype)initWithObject:(id)object __attribute__((objc_designated_initializer));
		[Export ("initWithObject:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject @object);
	}

	// @interface PXNotificationInfo : PXWeakWrapper
	[BaseType (typeof(PXWeakWrapper))]
	[DisableDefaultCtor]
	interface PXNotificationInfo
	{
		// -(instancetype)initWithObject:(id)object withBlock:(void (^)())block __attribute__((objc_designated_initializer));
		[Export ("initWithObject:withBlock:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject @object, Action block);

		// -(void)invokeBlock;
		[Export ("invokeBlock")]
		void InvokeBlock ();
	}

	// @interface PXNotificationManager : NSObject
	[BaseType (typeof(NSObject))]
	interface PXNotificationManager
	{
		// +(PXNotificationManager *)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		[Verify (MethodToProperty)]
		PXNotificationManager SharedInstance { get; }

		// -(void)registerObserver:(id)observer forNotification:(NSString *)notification withBlock:(void (^)())block;
		[Export ("registerObserver:forNotification:withBlock:")]
		void RegisterObserver (NSObject observer, string notification, Action block);

		// -(void)unregisterObserver:(id)observer forNotification:(NSString *)notification;
		[Export ("unregisterObserver:forNotification:")]
		void UnregisterObserver (NSObject observer, string notification);
	}

	// @interface PXPatternMatcher : NSObject <PXLexemeCreator>
	[BaseType (typeof(NSObject))]
	interface PXPatternMatcher : IPXLexemeCreator
	{
		// @property (readonly, nonatomic) int type;
		[Export ("type")]
		int Type { get; }

		// @property (readonly, nonatomic, strong) NSString * name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; }

		// -(id)initWithType:(int)type withPatternString:(NSString *)patternString;
		[Export ("initWithType:withPatternString:")]
		IntPtr Constructor (int type, string patternString);

		// -(id)initWithType:(int)type withRegularExpression:(NSRegularExpression *)aPattern;
		[Export ("initWithType:withRegularExpression:")]
		IntPtr Constructor (int type, NSRegularExpression aPattern);
	}

	// @interface PXNumberMatcher : PXPatternMatcher
	[BaseType (typeof(PXPatternMatcher))]
	interface PXNumberMatcher
	{
		// -(id)initWithType:(int)type;
		[Export ("initWithType:")]
		IntPtr Constructor (int type);

		// -(id)initWithType:(int)type withDictionary:(NSDictionary *)dictionary withUnknownType:(int)unknownType;
		[Export ("initWithType:withDictionary:withUnknownType:")]
		IntPtr Constructor (int type, NSDictionary dictionary, int unknownType);
	}

	// @interface PXOpacityStyler : PXStylerBase
	[BaseType (typeof(PXStylerBase))]
	interface PXOpacityStyler
	{
		// +(PXOpacityStyler *)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		[Verify (MethodToProperty)]
		PXOpacityStyler SharedInstance { get; }
	}

	// @interface PXPaintStyler : PXStylerBase
	[BaseType (typeof(PXStylerBase))]
	interface PXPaintStyler
	{
		// +(PXPaintStyler *)sharedInstanceForTintColor;
		[Static]
		[Export ("sharedInstanceForTintColor")]
		[Verify (MethodToProperty)]
		PXPaintStyler SharedInstanceForTintColor { get; }
	}

	// @protocol PXParser <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface PXParser
	{
		// @required @property (readonly, nonatomic, strong) NSMutableArray * errors;
		[Export ("errors", ArgumentSemantic.Strong)]
		NSMutableArray Errors { get; }

		// @required -(id<PXLexeme>)advance;
		[Abstract]
		[Export ("advance")]
		[Verify (MethodToProperty)]
		PXLexeme Advance { get; }

		// @required -(NSString *)lexemeNameFromType:(int)type;
		[Abstract]
		[Export ("lexemeNameFromType:")]
		string LexemeNameFromType (int type);

		// @required -(void)addError:(NSString *)error;
		[Abstract]
		[Export ("addError:")]
		void AddError (string error);

		// @required -(void)addError:(NSString *)error filename:(NSString *)filename offset:(NSString *)offset;
		[Abstract]
		[Export ("addError:filename:offset:")]
		void AddError (string error, string filename, string offset);

		// @required -(void)clearErrors;
		[Abstract]
		[Export ("clearErrors")]
		void ClearErrors ();

		// @required -(void)errorWithMessage:(NSString *)message;
		[Abstract]
		[Export ("errorWithMessage:")]
		void ErrorWithMessage (string message);

		// @required -(void)assertType:(int)type;
		[Abstract]
		[Export ("assertType:")]
		void AssertType (int type);

		// @required -(void)assertTypeInSet:(NSIndexSet *)types;
		[Abstract]
		[Export ("assertTypeInSet:")]
		void AssertTypeInSet (NSIndexSet types);

		// @required -(id<PXLexeme>)assertTypeAndAdvance:(int)type;
		[Abstract]
		[Export ("assertTypeAndAdvance:")]
		PXLexeme AssertTypeAndAdvance (int type);

		// @required -(void)advanceIfIsType:(int)type;
		[Abstract]
		[Export ("advanceIfIsType:")]
		void AdvanceIfIsType (int type);

		// @required -(void)advanceIfIsType:(int)type withWarning:(NSString *)warning;
		[Abstract]
		[Export ("advanceIfIsType:withWarning:")]
		void AdvanceIfIsType (int type, string warning);

		// @required -(BOOL)isType:(int)type;
		[Abstract]
		[Export ("isType:")]
		bool IsType (int type);

		// @required -(BOOL)isInTypeSet:(NSIndexSet *)types;
		[Abstract]
		[Export ("isInTypeSet:")]
		bool IsInTypeSet (NSIndexSet types);
	}

	// @interface PXParserBase : NSObject <PXParser>
	[BaseType (typeof(NSObject))]
	interface PXParserBase : IPXParser
	{
	}

	// @interface PXProxy : NSProxy
	[BaseType (typeof(NSProxy))]
	interface PXProxy
	{
		// @property (nonatomic, weak) id _Nullable baseObject;
		[NullAllowed, Export ("baseObject", ArgumentSemantic.Weak)]
		NSObject BaseObject { get; set; }

		// @property (nonatomic, weak) id _Nullable overridingObject;
		[NullAllowed, Export ("overridingObject", ArgumentSemantic.Weak)]
		NSObject OverridingObject { get; set; }

		// -(id)initWithBaseOject:(id)base overridingObject:(id)overrider;
		[Export ("initWithBaseOject:overridingObject:")]
		IntPtr Constructor (NSObject @base, NSObject overrider);
	}

	// @interface PXPseudoClassFunction : NSObject <PXSelector>
	[BaseType (typeof(NSObject))]
	interface PXPseudoClassFunction : IPXSelector
	{
		// @property (readonly, nonatomic) PXPseudoClassFunctionType functionType;
		[Export ("functionType")]
		PXPseudoClassFunctionType FunctionType { get; }

		// @property (readonly, nonatomic) NSInteger modulus;
		[Export ("modulus")]
		nint Modulus { get; }

		// @property (readonly, nonatomic) NSInteger remainder;
		[Export ("remainder")]
		nint Remainder { get; }

		// -(id)initWithFunctionType:(PXPseudoClassFunctionType)type modulus:(NSInteger)modulus remainder:(NSInteger)remainder;
		[Export ("initWithFunctionType:modulus:remainder:")]
		IntPtr Constructor (PXPseudoClassFunctionType type, nint modulus, nint remainder);
	}

	// @interface PXPseudoClassPredicate : NSObject <PXSelector>
	[BaseType (typeof(NSObject))]
	interface PXPseudoClassPredicate : IPXSelector
	{
		// @property (readonly, nonatomic) PXPseudoClassPredicateType predicateType;
		[Export ("predicateType")]
		PXPseudoClassPredicateType PredicateType { get; }

		// -(id)initWithPredicateType:(PXPseudoClassPredicateType)type;
		[Export ("initWithPredicateType:")]
		IntPtr Constructor (PXPseudoClassPredicateType type);
	}

	// @interface PXPseudoClassSelector : NSObject <PXSelector>
	[BaseType (typeof(NSObject))]
	interface PXPseudoClassSelector : IPXSelector
	{
		// @property (readonly, nonatomic, strong) NSString * className;
		[Export ("className", ArgumentSemantic.Strong)]
		string ClassName { get; }

		// -(id)initWithClassName:(NSString *)name;
		[Export ("initWithClassName:")]
		IntPtr Constructor (string name);
	}

	// @interface PXRuntimeUtils : NSObject
	[BaseType (typeof(NSObject))]
	interface PXRuntimeUtils
	{
		// +(NSArray *)getLastCallers:(int)count;
		[Static]
		[Export ("getLastCallers:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] GetLastCallers (int count);
	}

	// @interface PXShapeStyler : PXStylerBase
	[BaseType (typeof(PXStylerBase))]
	interface PXShapeStyler
	{
		// +(PXShapeStyler *)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		[Verify (MethodToProperty)]
		PXShapeStyler SharedInstance { get; }
	}

	// @interface PXSiblingCombinator : PXCombinatorBase
	[BaseType (typeof(PXCombinatorBase))]
	interface PXSiblingCombinator
	{
	}

	// @interface PXStyleInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface PXStyleInfo
	{
		// @property (readonly, nonatomic) NSString * styleKey;
		[Export ("styleKey")]
		string StyleKey { get; }

		// @property (readonly, nonatomic) NSArray * states;
		[Export ("states")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] States { get; }

		// @property (nonatomic) BOOL forceInvalidation;
		[Export ("forceInvalidation")]
		bool ForceInvalidation { get; set; }

		// @property (nonatomic) BOOL changeable;
		[Export ("changeable")]
		bool Changeable { get; set; }

		// +(PXStyleInfo *)styleInfoForStyleable:(id<PXStyleable>)styleable;
		[Static]
		[Export ("styleInfoForStyleable:")]
		PXStyleInfo StyleInfoForStyleable (PXStyleable styleable);

		// +(PXStyleInfo *)styleInfoForStyleable:(id<PXStyleable>)styleable checkPseudoClassFunction:(NSNumber **)checkPseudoClassFunction;
		[Static]
		[Export ("styleInfoForStyleable:checkPseudoClassFunction:")]
		PXStyleInfo StyleInfoForStyleable (PXStyleable styleable, out NSNumber checkPseudoClassFunction);

		// +(void)setStyleInfo:(PXStyleInfo *)styleInfo withRuleSets:(NSArray *)ruleSets styleable:(id<PXStyleable>)styleable stateName:(NSString *)stateName;
		[Static]
		[Export ("setStyleInfo:withRuleSets:styleable:stateName:")]
		[Verify (StronglyTypedNSArray)]
		void SetStyleInfo (PXStyleInfo styleInfo, NSObject[] ruleSets, PXStyleable styleable, string stateName);

		// -(id)initWithStyleKey:(NSString *)styleKey;
		[Export ("initWithStyleKey:")]
		IntPtr Constructor (string styleKey);

		// -(void)addDeclarations:(NSArray *)declarations forState:(NSString *)stateName;
		[Export ("addDeclarations:forState:")]
		[Verify (StronglyTypedNSArray)]
		void AddDeclarations (NSObject[] declarations, string stateName);

		// -(void)addStylers:(NSSet *)stylers forState:(NSString *)stateName;
		[Export ("addStylers:forState:")]
		void AddStylers (NSSet stylers, string stateName);

		// -(NSArray *)declarationsForState:(NSString *)stateName;
		[Export ("declarationsForState:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] DeclarationsForState (string stateName);

		// -(NSSet *)stylersForState:(NSString *)stateName;
		[Export ("stylersForState:")]
		NSSet StylersForState (string stateName);

		// -(void)applyToStyleable:(id<PXStyleable>)styleable;
		[Export ("applyToStyleable:")]
		void ApplyToStyleable (PXStyleable styleable);
	}

	// @interface  (PXStylesheet)
	[Category]
	[BaseType (typeof(PXStylesheet))]
	interface PXStylesheet_
	{
		// @property (readonly, nonatomic, strong) NSArray * ruleSets;
		[Export ("ruleSets")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] RuleSets { get; }

		// @property (readonly, nonatomic, strong) NSArray * mediaGroups;
		[Export ("mediaGroups")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] MediaGroups { get; }

		// @property (nonatomic, strong) id<PXMediaExpression> activeMediaQuery;
		[Export ("activeMediaQuery")]
		PXMediaExpression ActiveMediaQuery { get; set; }

		// +(id)styleSheetFromSource:(NSString *)source withOrigin:(PXStylesheetOrigin)origin;
		[Static]
		[Export ("styleSheetFromSource:withOrigin:")]
		NSObject StyleSheetFromSource (string source, PXStylesheetOrigin origin);

		// +(id)styleSheetFromFilePath:(NSString *)filePath withOrigin:(PXStylesheetOrigin)origin;
		[Static]
		[Export ("styleSheetFromFilePath:withOrigin:")]
		NSObject StyleSheetFromFilePath (string filePath, PXStylesheetOrigin origin);

		// +(PXStylesheet *)currentApplicationStylesheet;
		[Static]
		[Export ("currentApplicationStylesheet")]
		[Verify (MethodToProperty)]
		PXStylesheet CurrentApplicationStylesheet { get; }

		// +(PXStylesheet *)currentUserStylesheet;
		[Static]
		[Export ("currentUserStylesheet")]
		[Verify (MethodToProperty)]
		PXStylesheet CurrentUserStylesheet { get; }

		// +(PXStylesheet *)currentViewStylesheet;
		[Static]
		[Export ("currentViewStylesheet")]
		[Verify (MethodToProperty)]
		PXStylesheet CurrentViewStylesheet { get; }

		// -(id)initWithOrigin:(PXStylesheetOrigin)origin;
		[Export ("initWithOrigin:")]
		IntPtr Constructor (PXStylesheetOrigin origin);

		// -(void)addRuleSet:(PXRuleSet *)ruleSet;
		[Export ("addRuleSet:")]
		void AddRuleSet (PXRuleSet ruleSet);

		// -(void)setURI:(NSString *)uri forNamespacePrefix:(NSString *)prefix;
		[Export ("setURI:forNamespacePrefix:")]
		void SetURI (string uri, string prefix);

		// -(NSString *)namespaceForPrefix:(NSString *)prefix;
		[Export ("namespaceForPrefix:")]
		string NamespaceForPrefix (string prefix);

		// -(NSArray *)ruleSetsMatchingStyleable:(id<PXStyleable>)element;
		[Export ("ruleSetsMatchingStyleable:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] RuleSetsMatchingStyleable (PXStyleable element);

		// -(void)addKeyframe:(PXKeyframe *)keyframe;
		[Export ("addKeyframe:")]
		void AddKeyframe (PXKeyframe keyframe);

		// -(PXKeyframe *)keyframeForName:(NSString *)name;
		[Export ("keyframeForName:")]
		PXKeyframe KeyframeForName (string name);
	}

	// @protocol PXStylesheetLexerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface PXStylesheetLexerDelegate
	{
		// @optional -(void)lexerDidPopSource;
		[Export ("lexerDidPopSource")]
		void LexerDidPopSource ();
	}

	// @interface PXStylesheetLexer : NSObject
	[BaseType (typeof(NSObject))]
	interface PXStylesheetLexer
	{
		// @property (nonatomic, strong) NSString * source;
		[Export ("source", ArgumentSemantic.Strong)]
		string Source { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		PXStylesheetLexerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<PXStylesheetLexerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype)initWithString:(NSString *)source;
		[Export ("initWithString:")]
		IntPtr Constructor (string source);

		// @property (readonly, nonatomic, strong) PXStylesheetLexeme * nextLexeme;
		[Export ("nextLexeme", ArgumentSemantic.Strong)]
		PXStylesheetLexeme NextLexeme { get; }

		// -(void)pushLexeme:(PXStylesheetLexeme *)lexeme;
		[Export ("pushLexeme:")]
		void PushLexeme (PXStylesheetLexeme lexeme);

		// -(void)increaseNesting;
		[Export ("increaseNesting")]
		void IncreaseNesting ();

		// -(void)decreaseNesting;
		[Export ("decreaseNesting")]
		void DecreaseNesting ();

		// -(void)pushSource:(NSString *)source;
		[Export ("pushSource:")]
		void PushSource (string source);
	}

	// @interface PXStylesheetParser : PXParserBase <PXStylesheetLexerDelegate>
	[BaseType (typeof(PXParserBase))]
	interface PXStylesheetParser : IPXStylesheetLexerDelegate
	{
		// -(PXStylesheet *)parse:(NSString *)source withOrigin:(PXStylesheetOrigin)origin;
		[Export ("parse:withOrigin:")]
		PXStylesheet Parse (string source, PXStylesheetOrigin origin);

		// -(PXStylesheet *)parse:(NSString *)source withOrigin:(PXStylesheetOrigin)origin filename:(NSString *)name;
		[Export ("parse:withOrigin:filename:")]
		PXStylesheet Parse (string source, PXStylesheetOrigin origin, string name);

		// -(PXStylesheet *)parseInlineCSS:(NSString *)css;
		[Export ("parseInlineCSS:")]
		PXStylesheet ParseInlineCSS (string css);

		// -(id<PXSelector>)parseSelectorString:(NSString *)source;
		[Export ("parseSelectorString:")]
		PXSelector ParseSelectorString (string source);
	}

	// @interface PXStylesheetTokenType : NSObject
	[BaseType (typeof(NSObject))]
	interface PXStylesheetTokenType
	{
		// +(NSString *)typeNameForInt:(PXStylesheetTokens)type;
		[Static]
		[Export ("typeNameForInt:")]
		string TypeNameForInt (PXStylesheetTokens type);
	}

	// @interface PXText : PXShape
	[BaseType (typeof(PXShape))]
	[DisableDefaultCtor]
	interface PXText
	{
		// @property (nonatomic) CGPoint origin;
		[Export ("origin", ArgumentSemantic.Assign)]
		CGPoint Origin { get; set; }

		// @property (nonatomic, strong) NSString * text;
		[Export ("text", ArgumentSemantic.Strong)]
		string Text { get; set; }

		// @property (nonatomic, strong) NSString * fontName;
		[Export ("fontName", ArgumentSemantic.Strong)]
		string FontName { get; set; }

		// @property (nonatomic) CGFloat fontSize;
		[Export ("fontSize")]
		nfloat FontSize { get; set; }

		// +(instancetype)textWithString:(NSString *)text;
		[Static]
		[Export ("textWithString:")]
		PXText TextWithString (string text);

		// -(instancetype)initWithString:(NSString *)text __attribute__((objc_designated_initializer));
		[Export ("initWithString:")]
		[DesignatedInitializer]
		IntPtr Constructor (string text);
	}

	// @interface PXTextContentStyler : PXStylerBase
	[BaseType (typeof(PXStylerBase))]
	interface PXTextContentStyler
	{
	}

	// @interface PXTextShadowStyler : PXStylerBase
	[BaseType (typeof(PXStylerBase))]
	interface PXTextShadowStyler
	{
		// +(PXTextShadowStyler *)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		[Verify (MethodToProperty)]
		PXTextShadowStyler SharedInstance { get; }
	}

	// @interface PXTransformLexer : NSObject
	[BaseType (typeof(NSObject))]
	interface PXTransformLexer
	{
		// @property (nonatomic, strong) NSString * source;
		[Export ("source", ArgumentSemantic.Strong)]
		string Source { get; set; }

		// -(instancetype)initWithString:(NSString *)source;
		[Export ("initWithString:")]
		IntPtr Constructor (string source);

		// @property (readonly, nonatomic, strong) PXStylesheetLexeme * nextLexeme;
		[Export ("nextLexeme", ArgumentSemantic.Strong)]
		PXStylesheetLexeme NextLexeme { get; }
	}

	// @interface PXTransformParser : PXParserBase
	[BaseType (typeof(PXParserBase))]
	interface PXTransformParser
	{
		// -(CGAffineTransform)parse:(NSString *)source;
		[Export ("parse:")]
		CGAffineTransform Parse (string source);
	}

	// @interface PXTransformStyler : PXStylerBase
	[BaseType (typeof(PXStylerBase))]
	interface PXTransformStyler
	{
		// +(PXTransformStyler *)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		[Verify (MethodToProperty)]
		PXTransformStyler SharedInstance { get; }
	}

	// @interface PXTransformTokenType : NSObject
	[BaseType (typeof(NSObject))]
	interface PXTransformTokenType
	{
		// +(NSString *)typeNameForInt:(PXTransformTokens)type;
		[Static]
		[Export ("typeNameForInt:")]
		string TypeNameForInt (PXTransformTokens type);
	}

	// @interface PXTransitionRuleSetInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface PXTransitionRuleSetInfo
	{
		// @property (readonly, nonatomic, strong) NSArray * allMatchingRuleSets;
		[Export ("allMatchingRuleSets", ArgumentSemantic.Strong)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] AllMatchingRuleSets { get; }

		// @property (readonly, nonatomic, strong) NSArray * ruleSetsForState;
		[Export ("ruleSetsForState", ArgumentSemantic.Strong)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] RuleSetsForState { get; }

		// @property (readonly, nonatomic, strong) NSArray * nonAnimatingRuleSets;
		[Export ("nonAnimatingRuleSets", ArgumentSemantic.Strong)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] NonAnimatingRuleSets { get; }

		// @property (readonly, nonatomic, strong) NSArray * animatingRuleSets;
		[Export ("animatingRuleSets", ArgumentSemantic.Strong)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] AnimatingRuleSets { get; }

		// @property (readonly, nonatomic, strong) PXRuleSet * mergedRuleSet;
		[Export ("mergedRuleSet", ArgumentSemantic.Strong)]
		PXRuleSet MergedRuleSet { get; }

		// @property (readonly, nonatomic, strong) NSArray * transitions;
		[Export ("transitions", ArgumentSemantic.Strong)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Transitions { get; }

		// -(id)initWithStyleable:(id<PXStyleable>)styleable withStateName:(NSString *)stateName;
		[Export ("initWithStyleable:withStateName:")]
		IntPtr Constructor (PXStyleable styleable, string stateName);
	}

	// @interface PXTransitionStyler : PXStylerBase
	[BaseType (typeof(PXStylerBase))]
	interface PXTransitionStyler
	{
	}

	// @interface PXUIActionSheet : UIActionSheet
	[BaseType (typeof(UIActionSheet))]
	interface PXUIActionSheet
	{
	}

	// @interface PXUIActivityIndicatorView : UIActivityIndicatorView
	[BaseType (typeof(UIActivityIndicatorView))]
	interface PXUIActivityIndicatorView
	{
	}

	// @interface PXUIButton : UIButton
	[BaseType (typeof(UIButton))]
	interface PXUIButton
	{
	}

	// @interface PXUICollectionView : UICollectionView
	[BaseType (typeof(UICollectionView))]
	interface PXUICollectionView
	{
	}

	// @interface PXFreestyle (UICollectionView)
	[Category]
	[BaseType (typeof(UICollectionView))]
	interface UICollectionView_PXFreestyle
	{
	}

	// @interface PXUICollectionViewCell : UICollectionViewCell
	[BaseType (typeof(UICollectionViewCell))]
	interface PXUICollectionViewCell
	{
	}

	// @interface CGSizeWithFlag : NSObject
	[BaseType (typeof(NSObject))]
	interface CGSizeWithFlag
	{
		// @property (nonatomic) BOOL isSet;
		[Export ("isSet")]
		bool IsSet { get; set; }

		// @property (nonatomic) CGSize size;
		[Export ("size", ArgumentSemantic.Assign)]
		CGSize Size { get; set; }
	}

	// @interface PXUICollectionViewDelegate : NSObject <UICollectionViewDelegate, UICollectionViewDataSource, UICollectionViewDelegateFlowLayout>
	[BaseType (typeof(NSObject))]
	interface PXUICollectionViewDelegate : IUICollectionViewDelegate, IUICollectionViewDataSource, IUICollectionViewDelegateFlowLayout
	{
		// @property (nonatomic, strong) CGSizeWithFlag * itemSize;
		[Export ("itemSize", ArgumentSemantic.Strong)]
		CGSizeWithFlag ItemSize { get; set; }

		// @property (nonatomic, weak) UICollectionView * _Nullable collectionView;
		[NullAllowed, Export ("collectionView", ArgumentSemantic.Weak)]
		UICollectionView CollectionView { get; set; }
	}

	// @interface PXUIDatePicker : UIDatePicker
	[BaseType (typeof(UIDatePicker))]
	interface PXUIDatePicker
	{
	}

	// @interface PXUIImageView : UIImageView
	[BaseType (typeof(UIImageView))]
	interface PXUIImageView
	{
	}

	// @interface PXUILabel : UILabel
	[BaseType (typeof(UILabel))]
	interface PXUILabel
	{
	}

	// @interface PXUILayoutContainerView : UIView
	[BaseType (typeof(UIView))]
	interface PXUILayoutContainerView
	{
	}

	// @interface PXUINavigationBar : UINavigationBar
	[BaseType (typeof(UINavigationBar))]
	interface PXUINavigationBar
	{
	}

	// @interface PXUIPageControl : UIPageControl
	[BaseType (typeof(UIPageControl))]
	interface PXUIPageControl
	{
	}

	// @interface PXUIPickerView : UIPickerView
	[BaseType (typeof(UIPickerView))]
	interface PXUIPickerView
	{
	}

	// @interface PXUIPickerViewDelegate : NSObject
	[BaseType (typeof(NSObject))]
	interface PXUIPickerViewDelegate
	{
	}

	// @interface PXUIProgressView : UIProgressView
	[BaseType (typeof(UIProgressView))]
	interface PXUIProgressView
	{
	}

	// @interface PXUIRefreshControl : UIRefreshControl
	[BaseType (typeof(UIRefreshControl))]
	interface PXUIRefreshControl
	{
	}

	// @interface PXUIScrollView : UIScrollView
	[BaseType (typeof(UIScrollView))]
	interface PXUIScrollView
	{
	}

	// @interface PXUISearchBar : UISearchBar
	[BaseType (typeof(UISearchBar))]
	interface PXUISearchBar
	{
	}

	// @interface PXUISegmentedControl : UISegmentedControl
	[BaseType (typeof(UISegmentedControl))]
	interface PXUISegmentedControl
	{
	}

	// @interface PXUISlider : UISlider
	[BaseType (typeof(UISlider))]
	interface PXUISlider
	{
	}

	// @interface PXUIStepper : UIStepper
	[BaseType (typeof(UIStepper))]
	interface PXUIStepper
	{
	}

	// @interface PXUISwitch : UISwitch
	[BaseType (typeof(UISwitch))]
	interface PXUISwitch
	{
	}

	// @interface PXUITabBar : UITabBar
	[BaseType (typeof(UITabBar))]
	interface PXUITabBar
	{
	}

	// @interface PXUITableView : UITableView
	[BaseType (typeof(UITableView))]
	interface PXUITableView
	{
	}

	// @interface PXFreestyle (UITableView)
	[Category]
	[BaseType (typeof(UITableView))]
	interface UITableView_PXFreestyle
	{
	}

	// @interface PXUITableViewCell : UITableViewCell
	[BaseType (typeof(UITableViewCell))]
	interface PXUITableViewCell
	{
	}

	// @interface PXUITableViewCellContentView : UIView
	[BaseType (typeof(UIView))]
	interface PXUITableViewCellContentView
	{
	}

	// @interface PXUITableViewDelegate : NSObject <UITableViewDelegate>
	[BaseType (typeof(NSObject))]
	interface PXUITableViewDelegate : IUITableViewDelegate
	{
	}

	// @interface PXUITableViewHeaderFooterView : UITableViewHeaderFooterView
	[BaseType (typeof(UITableViewHeaderFooterView))]
	interface PXUITableViewHeaderFooterView
	{
	}

	// @interface PXUITextField : UITextField
	[BaseType (typeof(UITextField))]
	interface PXUITextField
	{
	}

	// @interface PXUITextView : UITextView
	[BaseType (typeof(UITextView))]
	interface PXUITextView
	{
	}

	// @interface PXUIToolbar : UIToolbar
	[BaseType (typeof(UIToolbar))]
	interface PXUIToolbar
	{
	}

	// @interface PXUIView : UIView
	[BaseType (typeof(UIView))]
	interface PXUIView
	{
	}

	// @interface PXUIWebView : UIWebView
	[BaseType (typeof(UIWebView))]
	interface PXUIWebView
	{
	}

	// @interface PXUIWindow : UIWindow
	[BaseType (typeof(UIWindow))]
	interface PXUIWindow
	{
	}

	// @interface PXURLMatcher : PXPatternMatcher
	[BaseType (typeof(PXPatternMatcher))]
	interface PXURLMatcher
	{
		// -(instancetype)initWithType:(int)type __attribute__((objc_designated_initializer));
		[Export ("initWithType:")]
		[DesignatedInitializer]
		IntPtr Constructor (int type);
	}

	// @interface PXUtils : NSObject
	[BaseType (typeof(NSObject))]
	interface PXUtils
	{
		// +(BOOL)isIOS6OrGreater;
		[Static]
		[Export ("isIOS6OrGreater")]
		[Verify (MethodToProperty)]
		bool IsIOS6OrGreater { get; }

		// +(BOOL)isBeforeIOS7O;
		[Static]
		[Export ("isBeforeIOS7O")]
		[Verify (MethodToProperty)]
		bool IsBeforeIOS7O { get; }

		// +(BOOL)isIOS7OrGreater;
		[Static]
		[Export ("isIOS7OrGreater")]
		[Verify (MethodToProperty)]
		bool IsIOS7OrGreater { get; }

		// +(BOOL)isIPhone;
		[Static]
		[Export ("isIPhone")]
		[Verify (MethodToProperty)]
		bool IsIPhone { get; }

		// +(BOOL)isSimulator;
		[Static]
		[Export ("isSimulator")]
		[Verify (MethodToProperty)]
		bool IsSimulator { get; }
	}

	// @interface PXValue : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PXValue
	{
		// @property (readonly, nonatomic) PXValueType type;
		[Export ("type")]
		PXValueType Type { get; }

		// -(instancetype)initWithBytes:(const void *)value type:(PXValueType)type __attribute__((objc_designated_initializer));
		[Export ("initWithBytes:type:")]
		[DesignatedInitializer]
		unsafe IntPtr Constructor (void* value, PXValueType type);

		// @property (readonly, nonatomic) CGRect CGRectValue;
		[Export ("CGRectValue")]
		CGRect CGRectValue { get; }

		// @property (readonly, nonatomic) CGSize CGSizeValue;
		[Export ("CGSizeValue")]
		CGSize CGSizeValue { get; }

		// @property (readonly, nonatomic) CGFloat CGFloatValue;
		[Export ("CGFloatValue")]
		nfloat CGFloatValue { get; }

		// @property (readonly, nonatomic) CGAffineTransform CGAffineTransformValue;
		[Export ("CGAffineTransformValue")]
		CGAffineTransform CGAffineTransformValue { get; }

		// @property (readonly, nonatomic) UIEdgeInsets UIEdgeInsetsValue;
		[Export ("UIEdgeInsetsValue")]
		UIEdgeInsets UIEdgeInsetsValue { get; }

		// @property (readonly, nonatomic) NSTextAlignment NSTextAlignmentValue;
		[Export ("NSTextAlignmentValue")]
		NSTextAlignment NSTextAlignmentValue { get; }

		// @property (readonly, nonatomic) NSLineBreakMode NSLineBreakModeValue;
		[Export ("NSLineBreakModeValue")]
		NSLineBreakMode NSLineBreakModeValue { get; }

		// @property (readonly, nonatomic) BOOL BooleanValue;
		[Export ("BooleanValue")]
		bool BooleanValue { get; }

		// @property (readonly, nonatomic) PXParseErrorDestination PXParseErrorDestinationValue;
		[Export ("PXParseErrorDestinationValue")]
		PXParseErrorDestination PXParseErrorDestinationValue { get; }

		// @property (readonly, nonatomic) PXCacheStylesType PXCacheStylesTypeValue;
		[Export ("PXCacheStylesTypeValue")]
		PXCacheStylesType PXCacheStylesTypeValue { get; }

		// @property (readonly, nonatomic) UITextBorderStyle UITextBorderStyleValue;
		[Export ("UITextBorderStyleValue")]
		UITextBorderStyle UITextBorderStyleValue { get; }

		// @property (readonly, nonatomic) CGColorRef CGColorRefValue __attribute__((cf_returns_not_retained));
		[Export ("CGColorRefValue")]
		unsafe CGColorRef* CGColorRefValue { get; }

		// @property (readonly, nonatomic) PXBorderStyle PXBorderStyleValue;
		[Export ("PXBorderStyleValue")]
		PXBorderStyle PXBorderStyleValue { get; }
	}

	// @interface PXValueParser : PXParserBase
	[BaseType (typeof(PXParserBase))]
	interface PXValueParser
	{
		// @property (nonatomic, strong) NSString * filename;
		[Export ("filename", ArgumentSemantic.Strong)]
		string Filename { get; set; }

		// +(NSArray *)lexemesForSource:(NSString *)source;
		[Static]
		[Export ("lexemesForSource:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] LexemesForSource (string source);

		// -(NSArray *)parseAnimationInfos:(NSArray *)lexemes;
		[Export ("parseAnimationInfos:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] ParseAnimationInfos (NSObject[] lexemes);

		// -(NSArray *)parseTransitionInfos:(NSArray *)lexemes;
		[Export ("parseTransitionInfos:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] ParseTransitionInfos (NSObject[] lexemes);

		// -(NSArray *)parseAnimationDirectionList:(NSArray *)lexemes;
		[Export ("parseAnimationDirectionList:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] ParseAnimationDirectionList (NSObject[] lexemes);

		// -(NSArray *)parseAnimationFillModeList:(NSArray *)lexemes;
		[Export ("parseAnimationFillModeList:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] ParseAnimationFillModeList (NSObject[] lexemes);

		// -(NSArray *)parseAnimationPlayStateList:(NSArray *)lexemes;
		[Export ("parseAnimationPlayStateList:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] ParseAnimationPlayStateList (NSObject[] lexemes);

		// -(NSArray *)parseAnimationTimingFunctionList:(NSArray *)lexemes;
		[Export ("parseAnimationTimingFunctionList:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] ParseAnimationTimingFunctionList (NSObject[] lexemes);

		// -(PXBorderInfo *)parseBorder:(NSArray *)lexemes;
		[Export ("parseBorder:")]
		[Verify (StronglyTypedNSArray)]
		PXBorderInfo ParseBorder (NSObject[] lexemes);

		// -(NSArray *)parseBorderRadiusList:(NSArray *)lexemes;
		[Export ("parseBorderRadiusList:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] ParseBorderRadiusList (NSObject[] lexemes);

		// -(PXBorderStyle)parseBorderStyle:(NSArray *)lexemes;
		[Export ("parseBorderStyle:")]
		[Verify (StronglyTypedNSArray)]
		PXBorderStyle ParseBorderStyle (NSObject[] lexemes);

		// -(NSArray *)parseBorderStyleList:(NSArray *)lexemes;
		[Export ("parseBorderStyleList:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] ParseBorderStyleList (NSObject[] lexemes);

		// -(UIColor *)parseColor:(NSArray *)lexemes;
		[Export ("parseColor:")]
		[Verify (StronglyTypedNSArray)]
		UIColor ParseColor (NSObject[] lexemes);

		// -(CGFloat)parseFloat:(NSArray *)lexemes;
		[Export ("parseFloat:")]
		[Verify (StronglyTypedNSArray)]
		nfloat ParseFloat (NSObject[] lexemes);

		// -(NSArray *)parseFloatList:(NSArray *)lexemes;
		[Export ("parseFloatList:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] ParseFloatList (NSObject[] lexemes);

		// -(NSArray *)parseNameList:(NSArray *)lexemes;
		[Export ("parseNameList:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] ParseNameList (NSObject[] lexemes);

		// -(id<PXPaint>)parsePaint:(NSArray *)lexemes;
		[Export ("parsePaint:")]
		[Verify (StronglyTypedNSArray)]
		PXPaint ParsePaint (NSObject[] lexemes);

		// -(NSArray *)parsePaints:(NSArray *)lexemes;
		[Export ("parsePaints:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] ParsePaints (NSObject[] lexemes);

		// -(NSArray *)parseSecondsList:(NSArray *)lexemes;
		[Export ("parseSecondsList:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		NSObject[] ParseSecondsList (NSObject[] lexemes);

		// -(id<PXShadowPaint>)parseShadow:(NSArray *)lexemes;
		[Export ("parseShadow:")]
		[Verify (StronglyTypedNSArray)]
		PXShadowPaint ParseShadow (NSObject[] lexemes);

		// -(CGSize)parseSize:(NSArray *)lexemes;
		[Export ("parseSize:")]
		[Verify (StronglyTypedNSArray)]
		CGSize ParseSize (NSObject[] lexemes);

		// -(CGFloat)parseSeconds:(NSArray *)lexemes;
		[Export ("parseSeconds:")]
		[Verify (StronglyTypedNSArray)]
		nfloat ParseSeconds (NSObject[] lexemes);

		// -(NSURL *)parseURL:(NSArray *)lexemes;
		[Export ("parseURL:")]
		[Verify (StronglyTypedNSArray)]
		NSUrl ParseURL (NSObject[] lexemes);

		// -(UIEdgeInsets)parseInsets:(NSArray *)lexemes;
		[Export ("parseInsets:")]
		[Verify (StronglyTypedNSArray)]
		UIEdgeInsets ParseInsets (NSObject[] lexemes);

		// -(PXOffsets *)parseOffsets:(NSArray *)lexemes;
		[Export ("parseOffsets:")]
		[Verify (StronglyTypedNSArray)]
		PXOffsets ParseOffsets (NSObject[] lexemes);
	}

	// @interface PXViewUtils : NSObject
	[BaseType (typeof(NSObject))]
	interface PXViewUtils
	{
		// +(NSString *)viewDescription:(UIView *)view;
		[Static]
		[Export ("viewDescription:")]
		string ViewDescription (UIView view);
	}

	// typedef void (^PXViewStyleUpdaterBlock)(PXRuleSet *, PXStylerContext *);
	delegate void PXViewStyleUpdaterBlock (PXRuleSet arg0, PXStylerContext arg1);

	// @interface PXVirtualStyleableControl : NSObject <PXVirtualControl>
	[BaseType (typeof(NSObject))]
	interface PXVirtualStyleableControl : IPXVirtualControl
	{
		// @property (copy, nonatomic) NSArray * pxStyleChildren;
		[Export ("pxStyleChildren", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] PxStyleChildren { get; set; }

		// @property (copy, nonatomic) NSArray * viewStylers;
		[Export ("viewStylers", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] ViewStylers { get; set; }

		// @property (copy, nonatomic) NSArray * supportedPseudoClasses;
		[Export ("supportedPseudoClasses", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] SupportedPseudoClasses { get; set; }

		// @property (copy, nonatomic) NSString * defaultPseudoClass;
		[Export ("defaultPseudoClass")]
		string DefaultPseudoClass { get; set; }

		// @property (nonatomic, weak) CALayer * _Nullable layer;
		[NullAllowed, Export ("layer", ArgumentSemantic.Weak)]
		CALayer Layer { get; set; }

		// -(instancetype)initWithParent:(id<PXStyleable>)parent elementName:(NSString *)elementName;
		[Export ("initWithParent:elementName:")]
		IntPtr Constructor (PXStyleable parent, string elementName);

		// -(instancetype)initWithParent:(id<PXStyleable>)parent elementName:(NSString *)elementName viewStyleUpdaterBlock:(PXViewStyleUpdaterBlock)block __attribute__((objc_designated_initializer));
		[Export ("initWithParent:elementName:viewStyleUpdaterBlock:")]
		[DesignatedInitializer]
		IntPtr Constructor (PXStyleable parent, string elementName, PXViewStyleUpdaterBlock block);
	}

	// @interface PXWordMatcher : PXPatternMatcher
	[BaseType (typeof(PXPatternMatcher))]
	[DisableDefaultCtor]
	interface PXWordMatcher
	{
		// -(instancetype)initWithDictionary:(NSDictionary *)dictionary;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dictionary);

		// -(instancetype)initWithDictionary:(NSDictionary *)dictionary usingSymbols:(BOOL)usingSymbols __attribute__((objc_designated_initializer));
		[Export ("initWithDictionary:usingSymbols:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSDictionary dictionary, bool usingSymbols);
	}

	// @interface STKTheme : NSObject
	[BaseType (typeof(NSObject))]
	interface STKTheme
	{
		// @property (nonatomic, strong) NSString * name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSString * stylesheetFileName;
		[Export ("stylesheetFileName", ArgumentSemantic.Strong)]
		string StylesheetFileName { get; set; }

		// @property (nonatomic, strong) NSBundle * bundle;
		[Export ("bundle", ArgumentSemantic.Strong)]
		NSBundle Bundle { get; set; }

		// @property (assign, nonatomic) BOOL optional;
		[Export ("optional")]
		bool Optional { get; set; }

		// @property (readonly, nonatomic) NSString * loadedFromPath;
		[Export ("loadedFromPath")]
		string LoadedFromPath { get; }

		// @property (assign, nonatomic) NSUInteger origin;
		[Export ("origin")]
		nuint Origin { get; set; }

		// +(instancetype)themeWithName:(NSString *)name bundle:(NSBundle *)bundle;
		[Static]
		[Export ("themeWithName:bundle:")]
		STKTheme ThemeWithName (string name, NSBundle bundle);

		// +(instancetype)themeWithName:(NSString *)name stylesheetFileName:(NSString *)stylesheetFileName bundle:(NSBundle *)bundle;
		[Static]
		[Export ("themeWithName:stylesheetFileName:bundle:")]
		STKTheme ThemeWithName (string name, string stylesheetFileName, NSBundle bundle);

		// -(BOOL)activate;
		[Export ("activate")]
		[Verify (MethodToProperty)]
		bool Activate { get; }

		// -(NSString *)description;
		[Export ("description")]
		[Verify (MethodToProperty)]
		string Description { get; }
	}

	// @interface STKThemesRegistry : NSObject
	[BaseType (typeof(NSObject))]
	interface STKThemesRegistry
	{
		// +(void)loadThemes;
		[Static]
		[Export ("loadThemes")]
		void LoadThemes ();
	}

	// @interface STK_UIAlertControllerView : UIView
	[BaseType (typeof(UIView))]
	interface STK_UIAlertControllerView
	{
		// +(Class)targetSuperclass;
		[Static]
		[Export ("targetSuperclass")]
		[Verify (MethodToProperty)]
		Class TargetSuperclass { get; }
	}

	// @interface StylingKit : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface StylingKit
	{
		// @property (readonly, nonatomic) STKTheme * currentTheme;
		[Export ("currentTheme")]
		STKTheme CurrentTheme { get; }

		// @property (readonly, nonatomic) STKCloud * cloud;
		[Export ("cloud")]
		STKCloud Cloud { get; }

		// +(instancetype)sharedKit;
		[Static]
		[Export ("sharedKit")]
		StylingKit SharedKit ();

		// -(void)startStyling;
		[Export ("startStyling")]
		void StartStyling ();

		// -(STKTheme *)registerThemeNamed:(NSString *)themeName inBundle:(NSBundle *)bundle;
		[Export ("registerThemeNamed:inBundle:")]
		STKTheme RegisterThemeNamed (string themeName, NSBundle bundle);
	}

	// @interface StylingKit (UIView)
	[Category]
	[BaseType (typeof(UIView))]
	interface UIView_StylingKit
	{
		// @property (copy, nonatomic) NSString * styleId;
		[Export ("styleId")]
		string StyleId { get; set; }

		// @property (copy, nonatomic) NSString * styleClass;
		[Export ("styleClass")]
		string StyleClass { get; set; }

		// @property (copy, nonatomic) NSString * styleCSS;
		[Export ("styleCSS")]
		string StyleCSS { get; set; }
	}

	// @interface PXStylingPrivate (UIBarButtonItem)
	[Category]
	[BaseType (typeof(UIBarButtonItem))]
	interface UIBarButtonItem_PXStylingPrivate
	{
		// +(PXDeclarationHandlerBlock)TintColorDeclarationHandlerBlock:(UIBarButtonItem *)target;
		[Static]
		[Export ("TintColorDeclarationHandlerBlock:")]
		PXDeclarationHandlerBlock TintColorDeclarationHandlerBlock (UIBarButtonItem target);

		// +(PXStylerCompletionBlock)FontStylerCompletionBlock:(UIBarButtonItem *)target;
		[Static]
		[Export ("FontStylerCompletionBlock:")]
		PXStylerCompletionBlock FontStylerCompletionBlock (UIBarButtonItem target);

		// +(PXStylerCompletionBlock)PXPaintStylerCompletionBlock:(UIBarButtonItem *)target;
		[Static]
		[Export ("PXPaintStylerCompletionBlock:")]
		PXStylerCompletionBlock PXPaintStylerCompletionBlock (UIBarButtonItem target);

		// +(void)UpdateStyleWithRuleSetHandler:(PXRuleSet *)ruleSet context:(PXStylerContext *)context target:(UIBarButtonItem *)target;
		[Static]
		[Export ("UpdateStyleWithRuleSetHandler:context:target:")]
		void UpdateStyleWithRuleSetHandler (PXRuleSet ruleSet, PXStylerContext context, UIBarButtonItem target);
	}

	// @interface PXStyling (UIBarItem) <PXStyleable>
	[Category]
	[BaseType (typeof(UIBarItem))]
	interface UIBarItem_PXStyling : IPXStyleable
	{
		// @property (nonatomic) PXStylingMode styleMode __attribute__((annotate("ui_appearance_selector")));
		[Export ("styleMode", ArgumentSemantic.Assign)]
		PXStylingMode StyleMode { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * styleElementName;
		[Export ("styleElementName")]
		string StyleElementName { get; set; }
	}

	// @interface STKStyling (UICollectionViewCell)
	[Category]
	[BaseType (typeof(UICollectionViewCell))]
	interface UICollectionViewCell_STKStyling
	{
		// @property (readwrite, nonatomic, weak) id _Nullable pxStyleParent;
		[NullAllowed, Export ("pxStyleParent", ArgumentSemantic.Weak)]
		NSObject PxStyleParent { get; set; }
	}

	// @interface PXStylingPrivate (UIView)
	[Category]
	[BaseType (typeof(UIView))]
	interface UIView_PXStylingPrivate
	{
		// +(void)setElementName:(NSString *)elementName forClass:(Class)class;
		[Static]
		[Export ("setElementName:forClass:")]
		void SetElementName (string elementName, Class @class);

		// +(NSString *)elementNameForClassName:(NSString *)className;
		[Static]
		[Export ("elementNameForClassName:")]
		string ElementNameForClassName (string className);

		// +(void)removeElementNameForClassName:(NSString *)className;
		[Static]
		[Export ("removeElementNameForClassName:")]
		void RemoveElementNameForClassName (string className);

		// +(void)addStylingSubclass:(NSString *)className;
		[Static]
		[Export ("addStylingSubclass:")]
		void AddStylingSubclass (string className);

		// +(BOOL)hasStylingSubclass:(NSString *)className;
		[Static]
		[Export ("hasStylingSubclass:")]
		bool HasStylingSubclass (string className);

		// +(void)removeStylingSubclass:(NSString *)className;
		[Static]
		[Export ("removeStylingSubclass:")]
		void RemoveStylingSubclass (string className);

		// +(void)registerDynamicSubclass:(Class)subclass withElementName:(NSString *)elementName;
		[Static]
		[Export ("registerDynamicSubclass:withElementName:")]
		void RegisterDynamicSubclass (Class subclass, string elementName);

		// +(void)registerDynamicSubclass:(Class)subclass forClass:(Class)superClass withElementName:(NSString *)elementName;
		[Static]
		[Export ("registerDynamicSubclass:forClass:withElementName:")]
		void RegisterDynamicSubclass (Class subclass, Class superClass, string elementName);

		// +(BOOL)subclassIfNeeded:(Class)superClass object:(NSObject *)object;
		[Static]
		[Export ("subclassIfNeeded:object:")]
		bool SubclassIfNeeded (Class superClass, NSObject @object);

		// +(BOOL)pxHasAncestor:(Class)acenstorClass forView:(UIView *)view;
		[Static]
		[Export ("pxHasAncestor:forView:")]
		bool PxHasAncestor (Class acenstorClass, UIView view);

		// -(BOOL)isSubclassable;
		[Export ("isSubclassable")]
		[Verify (MethodToProperty)]
		bool IsSubclassable { get; }
	}
}
