//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RCPSolution.Resx {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RCPSolution.Resx.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Podaj scieżke do lokalizacji z plikami RCP.
        /// </summary>
        internal static string ENTER_PATH {
            get {
                return ResourceManager.GetString("ENTER_PATH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Zakończono import. .
        /// </summary>
        internal static string IMPORT_ENDED {
            get {
                return ResourceManager.GetString("IMPORT_ENDED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rozpoczynam przetwarzanie pliku {0}..
        /// </summary>
        internal static string IMPORT_STARTED {
            get {
                return ResourceManager.GetString("IMPORT_STARTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Zaimportowano {0} z {1} wierszy..
        /// </summary>
        internal static string IMPORTED_LINES {
            get {
                return ResourceManager.GetString("IMPORTED_LINES", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to W wierszu {0} wykryto błędną liczbę kolumn..
        /// </summary>
        internal static string INCORRECT_ARGUMENT_COUNT {
            get {
                return ResourceManager.GetString("INCORRECT_ARGUMENT_COUNT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to W wierszu {0} wykryto dane o niepoprawnym formacie w kolumnie z {1}. Pomijam wiersz..
        /// </summary>
        internal static string INCORRECT_FORMAT {
            get {
                return ResourceManager.GetString("INCORRECT_FORMAT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nie odnaleziono wejścia dla pracownika {0} na dzień {1:d}..
        /// </summary>
        internal static string NO_ENTRY_FOUND {
            get {
                return ResourceManager.GetString("NO_ENTRY_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nie odnaleziono wyjścia dla pracownika {0} na dzień {1:d}..
        /// </summary>
        internal static string NO_EXIT_FOUND {
            get {
                return ResourceManager.GetString("NO_EXIT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wykryto zbyt wysoką liczbę wyjść dla pracownika {0} na dzień {1:d}..
        /// </summary>
        internal static string TOO_MANY_ENTRIES {
            get {
                return ResourceManager.GetString("TOO_MANY_ENTRIES", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wykryto zbyt wysoką liczbę wejść dla pracownika {0} na dzień {1:d}..
        /// </summary>
        internal static string TOO_MANY_EXITS {
            get {
                return ResourceManager.GetString("TOO_MANY_EXITS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dane w pliku {0} znajdują się w obcym formacie..
        /// </summary>
        internal static string UNKNOWN_FORMAT {
            get {
                return ResourceManager.GetString("UNKNOWN_FORMAT", resourceCulture);
            }
        }
    }
}
