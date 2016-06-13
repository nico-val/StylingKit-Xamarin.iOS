//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using Security;
using SceneKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace StylingKit_Xamarin {
	[Register("StylingKit", true)]
	public unsafe partial class StylingKit : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("StylingKit");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public StylingKit () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected StylingKit (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal StylingKit (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("applyStylesheets")]
		[CompilerGenerated]
		public static void ApplyStylesheets ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("applyStylesheets"));
		}
		
		[Export ("currentApplicationStylesheet")]
		[CompilerGenerated]
		public static PXStylesheet CurrentApplicationStylesheet ()
		{
			return  Runtime.GetNSObject<PXStylesheet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("currentApplicationStylesheet")));
		}
		
		[Export ("currentUserStylesheet")]
		[CompilerGenerated]
		public static PXStylesheet CurrentUserStylesheet ()
		{
			return  Runtime.GetNSObject<PXStylesheet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("currentUserStylesheet")));
		}
		
		[Export ("currentViewStylesheet")]
		[CompilerGenerated]
		public static PXStylesheet CurrentViewStylesheet ()
		{
			return  Runtime.GetNSObject<PXStylesheet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("currentViewStylesheet")));
		}
		
		[Export ("matchingDeclarationsForStyleable:")]
		[CompilerGenerated]
		public static string MatchingDeclarationsForStyleable (NSObject styleable)
		{
			if (styleable == null)
				throw new ArgumentNullException ("styleable");
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("matchingDeclarationsForStyleable:"), styleable.Handle));
		}
		
		[Export ("matchingRuleSetsForStyleable:")]
		[CompilerGenerated]
		public static string MatchingRuleSetsForStyleable (NSObject styleable)
		{
			if (styleable == null)
				throw new ArgumentNullException ("styleable");
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("matchingRuleSetsForStyleable:"), styleable.Handle));
		}
		
		[Export ("selectFromStyleable:usingSelector:")]
		[CompilerGenerated]
		public static NSObject[] SelectFromStyleableUsingSelector (NSObject styleable, string stylableSelector)
		{
			if (styleable == null)
				throw new ArgumentNullException ("styleable");
			if (stylableSelector == null)
				throw new ArgumentNullException ("stylableSelector");
			var nsstylableSelector = NSString.CreateNative (stylableSelector);
			
			NSObject[] ret;
			ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("selectFromStyleable:usingSelector:"), styleable.Handle, nsstylableSelector));
			NSString.ReleaseNative (nsstylableSelector);
			
			return ret;
		}
		
		[Export ("sharedKit")]
		[CompilerGenerated]
		public static StylingKit sharedKit ()
		{
			return  Runtime.GetNSObject<StylingKit> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedKit")));
		}
		
		[Export ("startStyling")]
		[CompilerGenerated]
		public virtual void StartStyling ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("startStyling"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startStyling"));
			}
		}
		
		[Export ("styleSheetFromFilePath:withOrigin:")]
		[CompilerGenerated]
		public static PXStylesheet StyleSheetFromFilePathWithOrigin (string path, PXStylesheetOrigin origin)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = NSString.CreateNative (path);
			
			PXStylesheet ret;
			ret =  Runtime.GetNSObject<PXStylesheet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_int (class_ptr, Selector.GetHandle ("styleSheetFromFilePath:withOrigin:"), nspath, (int)origin));
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[Export ("styleSheetFromSource:withOrigin:")]
		[CompilerGenerated]
		public static PXStylesheet StyleSheetFromSourceWithOrigin (string source, PXStylesheetOrigin origin)
		{
			if (source == null)
				throw new ArgumentNullException ("source");
			var nssource = NSString.CreateNative (source);
			
			PXStylesheet ret;
			ret =  Runtime.GetNSObject<PXStylesheet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_int (class_ptr, Selector.GetHandle ("styleSheetFromSource:withOrigin:"), nssource, (int)origin));
			NSString.ReleaseNative (nssource);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static string APIVersion {
			[Export ("apiVersion")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("apiVersion")));
			}
			
		}
		
		[CompilerGenerated]
		public static NSDate BuildDate {
			[Export ("buildDate")]
			get {
				NSDate ret;
				ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("buildDate")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static PixateFreestyleConfiguration Configuration {
			[Export ("configuration")]
			get {
				PixateFreestyleConfiguration ret;
				ret =  Runtime.GetNSObject<PixateFreestyleConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("configuration")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static bool RefreshStylesWithOrientationChange {
			[Export ("refreshStylesWithOrientationChange")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("refreshStylesWithOrientationChange"));
			}
			
			[Export ("setRefreshStylesWithOrientationChange:")]
			set {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setRefreshStylesWithOrientationChange:"), value);
			}
		}
		
		[CompilerGenerated]
		public static string Version {
			[Export ("version")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("version")));
			}
			
		}
		
	} /* class StylingKit */
}
