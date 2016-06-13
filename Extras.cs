using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

namespace StylingKit_Xamarin
{
	public partial class StylingKit
	{
		//
		// styleId
		//
		public static string GetStyleId (NSObject obj)
		{
			return (NSString)obj.ValueForKey (new NSString ("styleId"));
		}
		public static void SetStyleId (NSObject obj, string id)
		{
			obj.SetValueForKeyPath (new NSString (id), new NSString ("styleId"));
		}

		//
		// styleClass
		//
		public static string GetStyleClass (NSObject obj)
		{
			return (NSString)obj.ValueForKey (new NSString ("styleClass"));
		}
		public static void SetStyleClass (NSObject obj, string id)
		{
			obj.SetValueForKeyPath (new NSString (id), new NSString ("styleClass"));
		}

		//
		// styleCSS
		//
		public static string GetStyleCSS (NSObject obj)
		{
			return (NSString)obj.ValueForKey (new NSString ("styleCSS"));
		}
		public static void SetStyleCSS (NSObject obj, string id)
		{
			obj.SetValueForKeyPath (new NSString (id), new NSString ("styleCSS"));
		}

		//
		// styleMode
		//
		public static PXStylingMode GetStyleMode (NSObject obj)
		{
			var mode = obj.ValueForKey (new NSString ("styleMode"));
			var modeString = mode.ToString ();
			return (PXStylingMode)Enum.Parse (typeof (PXStylingMode), modeString);
		}
		public static void SetStyleMode (NSObject obj, PXStylingMode mode)
		{
			var modeNum = new NSNumber ((int)mode);
			obj.SetValueForKeyPath (modeNum, new NSString ("styleMode"));
		}
	}

	public static class PXUIViewExtensions
	{
		//
		// StyleClass
		//
		public static string GetStyleClass (this UIView view)
		{
			return StylingKit.GetStyleClass (view);
		}
		public static void SetStyleClass (this UIView view, string styleClass)
		{
			StylingKit.SetStyleClass (view, styleClass);
		}

		//
		// StyleCSS
		//
		public static string GetStyleCSS (this UIView view)
		{
			return StylingKit.GetStyleCSS (view);
		}
		public static void SetStyleCSS (this UIView view, string styleCss)
		{
			StylingKit.SetStyleCSS (view, styleCss);
		}

		//
		// StyleId
		//
		public static string GetStyleId (this UIView view)
		{
			return StylingKit.GetStyleId (view);
		}
		public static void SetStyleId (this UIView view, string styleId)
		{
			StylingKit.SetStyleId (view, styleId);
		}

		//
		// StyleMode
		//
		public static PXStylingMode GetStyleMode (this UIView view)
		{
			return StylingKit.GetStyleMode (view);
		}
		public static void SetStyleMode (this UIView view, PXStylingMode mode)
		{
			StylingKit.SetStyleMode (view, mode);
		}

		//
		// Update Styles Methods
		//
		/*public static void UpdateStyles (this UIView view)
		{
			StylingKit.UpdateStyles (view);
		}

		public static void UpdateStylesNonRecursively (this UIView view)
		{
			StylingKit.UpdateStylesNonRecursively (view);
		}

		public static void UpdateStylesAsync (this UIView view)
		{
			StylingKit.UpdateStylesAsync (view);
		}

		public static void UpdateStylesNonRecursivelyAsync (this UIView view)
		{
			StylingKit.UpdateStylesNonRecursivelyAsync (view);
		}
*/
		//
		// Add / Remove Classes to a UIView
		//
		public static void AddStyleClass (this UIView view, string styleClass)
		{
			// Store result of kvp to check if a value exists
			object classesObject = view.GetStyleClass ();

			// Get current classes from this view
			string classes = classesObject != null ? classesObject.ToString () : string.Empty;

			// Append our requested class/es
			List<String> splits = classes.Split ().ToList ();
			splits.Add (styleClass);

			// Remove duplicate classes and re-stringify
			classes = string.Join (" ", splits.Distinct ().ToArray ());

			// Refresh view
			view.SetStyleClass (classes);
			//view.UpdateStyles ();
		}

		public static void RemoveStyleClass (this UIView view, string styleClass)
		{
			// Store result of kvp to check if a value exists
			object classesObject = view.GetStyleClass ();

			// Get current classes from this view
			string classes = classesObject != null ? classesObject.ToString () : string.Empty;

			// Remove our requested class
			List<String> splits = classes.Split ().ToList ();
			splits.Remove (styleClass);

			// Re-stringify
			classes = string.Join (" ", splits.ToArray ());

			// Refresh view
			view.SetStyleClass (classes);
			//view.UpdateStyles ();
		}
	}

	// Category extension on UIBarButtonItem
	public static class PXUIBarButtonItemExtensions
	{
		//
		// StyleClass
		//
		public static string GetStyleClass (this UIBarButtonItem view)
		{
			return StylingKit.GetStyleClass (view);
		}
		public static void SetStyleClass (this UIBarButtonItem view, string styleClass)
		{
			StylingKit.SetStyleClass (view, styleClass);
		}

		//
		// StyleCSS
		//
		public static string GetStyleCSS (this UIBarButtonItem view)
		{
			return StylingKit.GetStyleCSS (view);
		}
		public static void SetStyleCSS (this UIBarButtonItem view, string styleCss)
		{
			StylingKit.SetStyleCSS (view, styleCss);
		}

		//
		// StyleId
		//
		public static string GetStyleId (this UIBarButtonItem view)
		{
			return StylingKit.GetStyleId (view);
		}
		public static void SetStyleId (this UIBarButtonItem view, string styleId)
		{
			StylingKit.SetStyleId (view, styleId);
		}

		//
		// StyleMode
		//
		public static PXStylingMode GetStyleMode (this UIBarButtonItem view)
		{
			return StylingKit.GetStyleMode (view);
		}
		public static void SetStyleMode (this UIBarButtonItem view, PXStylingMode mode)
		{
			StylingKit.SetStyleMode (view, mode);
		}

		//
		// Update Styles Methods
		//
		/*public static void UpdateStyles (this UIBarButtonItem view)
		{
			StylingKit.UpdateStyles (view);
		}

		public static void UpdateStylesNonRecursively (this UIBarButtonItem view)
		{
			StylingKit.UpdateStylesNonRecursively (view);
		}

		public static void UpdateStylesAsync (this UIBarButtonItem view)
		{
			StylingKit.UpdateStylesAsync (view);
		}

		public static void UpdateStylesNonRecursivelyAsync (this UIBarButtonItem view)
		{
			StylingKit.UpdateStylesNonRecursivelyAsync (view);
		}*/
	}

	// Category extension on UITabBarItem
	public static class PXUITabBarItemExtensions
	{
		//
		// StyleClass
		//
		public static string GetStyleClass (this UITabBarItem view)
		{
			return StylingKit.GetStyleClass (view);
		}
		public static void SetStyleClass (this UITabBarItem view, string styleClass)
		{
			StylingKit.SetStyleClass (view, styleClass);
		}

		//
		// StyleCSS
		//
		public static string GetStyleCSS (this UITabBarItem view)
		{
			return StylingKit.GetStyleCSS (view);
		}
		public static void SetStyleCSS (this UITabBarItem view, string styleCss)
		{
			StylingKit.SetStyleCSS (view, styleCss);
		}

		//
		// StyleId
		//
		public static string GetStyleId (this UITabBarItem view)
		{
			return StylingKit.GetStyleId (view);
		}
		public static void SetStyleId (this UITabBarItem view, string styleId)
		{
			StylingKit.SetStyleId (view, styleId);
		}

		//
		// StyleMode
		//
		public static PXStylingMode GetStyleMode (this UITabBarItem view)
		{
			return StylingKit.GetStyleMode (view);
		}
		public static void SetStyleMode (this UITabBarItem view, PXStylingMode mode)
		{
			StylingKit.SetStyleMode (view, mode);
		}

		//
		// Update Styles Methods
		//
		/*
		public static void UpdateStyles (this UITabBarItem view)
		{
			StylingKit.UpdateStyles (view);
		}

		public static void UpdateStylesNonRecursively (this UITabBarItem view)
		{
			StylingKit.UpdateStylesNonRecursively (view);
		}

		public static void UpdateStylesAsync (this UITabBarItem view)
		{
			StylingKit.UpdateStylesAsync (view);
		}

		public static void UpdateStylesNonRecursivelyAsync (this UITabBarItem view)
		{
			StylingKit.UpdateStylesNonRecursivelyAsync (view);
		}*/
	}

	// Category extension on UINavigationItem
	public static class PXUINavigationItemExtensions
	{
		//
		// StyleClass
		//
		public static string GetStyleClass (this UINavigationItem view)
		{
			return StylingKit.GetStyleClass (view);
		}
		public static void SetStyleClass (this UINavigationItem view, string styleClass)
		{
			StylingKit.SetStyleClass (view, styleClass);
		}

		//
		// StyleCSS
		//
		public static string GetStyleCSS (this UINavigationItem view)
		{
			return StylingKit.GetStyleCSS (view);
		}
		public static void SetStyleCSS (this UINavigationItem view, string styleCss)
		{
			StylingKit.SetStyleCSS (view, styleCss);
		}

		//
		// StyleId
		//
		public static string GetStyleId (this UINavigationItem view)
		{
			return StylingKit.GetStyleId (view);
		}
		public static void SetStyleId (this UINavigationItem view, string styleId)
		{
			StylingKit.SetStyleId (view, styleId);
		}

		//
		// StyleMode
		//
		public static PXStylingMode GetStyleMode (this UINavigationItem view)
		{
			return StylingKit.GetStyleMode (view);
		}
		public static void SetStyleMode (this UINavigationItem view, PXStylingMode mode)
		{
			StylingKit.SetStyleMode (view, mode);
		}

		//
		// Update Styles Methods
		//
		/*
		public static void UpdateStyles (this UINavigationItem view)
		{
			StylingKit.UpdateStyles (view);
		}

		public static void UpdateStylesNonRecursively (this UINavigationItem view)
		{
			StylingKit.UpdateStylesNonRecursively (view);
		}

		public static void UpdateStylesAsync (this UINavigationItem view)
		{
			StylingKit.UpdateStylesAsync (view);
		}

		public static void UpdateStylesNonRecursivelyAsync (this UINavigationItem view)
		{
			StylingKit.UpdateStylesNonRecursivelyAsync (view);
		}*/
	}
}

