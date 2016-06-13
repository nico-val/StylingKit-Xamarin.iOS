using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace StylingKit_Xamarin
{

	[BaseType (typeof (NSObject))]
	interface StylingKit
	{

		[Static, Export ("sharedKit")]
		StylingKit sharedKit ();

		[Static, Export ("version")]
		string Version { get; }

		[Static, Export ("apiVersion")]
		string APIVersion { get; }

		[Static, Export ("buildDate")]
		NSDate BuildDate { get; }

		[Static, Export ("refreshStylesWithOrientationChange")]
		bool RefreshStylesWithOrientationChange { get; set; }

		[Static, Export ("configuration")]
		PixateFreestyleConfiguration Configuration { get; }

		[Export ("startStyling")]
		void StartStyling ();

		[Static, Export ("selectFromStyleable:usingSelector:")]
		NSObject [] SelectFromStyleableUsingSelector (NSObject styleable, string stylableSelector);

		[Static, Export ("matchingRuleSetsForStyleable:")]
		string MatchingRuleSetsForStyleable (NSObject styleable);

		[Static, Export ("matchingDeclarationsForStyleable:")]
		string MatchingDeclarationsForStyleable (NSObject styleable);

		[Static, Export ("styleSheetFromFilePath:withOrigin:")]
		PXStylesheet StyleSheetFromFilePathWithOrigin (string path, PXStylesheetOrigin origin);

		[Static, Export ("styleSheetFromSource:withOrigin:")]
		PXStylesheet StyleSheetFromSourceWithOrigin (string source, PXStylesheetOrigin origin);

		[Static, Export ("currentApplicationStylesheet")]
		PXStylesheet CurrentApplicationStylesheet ();

		[Static, Export ("currentUserStylesheet")]
		PXStylesheet CurrentUserStylesheet ();

		[Static, Export ("currentViewStylesheet")]
		PXStylesheet CurrentViewStylesheet ();

		/*[Static, Export ("updateStylesForAllViews")]
		void UpdateStylesForAllViews ();

		[Static, Export ("updateStyles:")]
		void UpdateStyles (NSObject styleable);

		[Static, Export ("updateStylesNonRecursively:")]
		void UpdateStylesNonRecursively (NSObject styleable);

		[Static, Export ("updateStylesAsync:")]
		void UpdateStylesAsync (NSObject styleable);

		[Static, Export ("updateStylesNonRecursivelyAsync:")]
		void UpdateStylesNonRecursivelyAsync (NSObject styleable);
*/
		// DEPRECATED applyStylesheets is deprecated as of 2.0RC2
		[Static, Export ("applyStylesheets")]
		void ApplyStylesheets ();
	}

	[BaseType (typeof (NSObject))]
	interface PXStylesheet
	{

		[Export ("errors")]
		string [] Errors { get; }

		[Export ("filePath")]
		string FilePath { get; set; }

		[Export ("monitorChanges")]
		bool MonitorChanges { get; set; }
	}

	[BaseType (typeof (NSObject))]
	interface PixateFreestyleConfiguration
	{
		[Export ("parseErrorDestination")]
		PXParseErrorDestination ParseErrorDestination { get; set; }

		[Export ("cacheStylesType")]
		PXCacheStylesType CacheStylesType { get; set; }
	}
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     CGPoint Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/
	//
}

