﻿module internal Fantomas.AssemblyInfo

open System
open System.Reflection
open System.Resources
open System.Runtime.CompilerServices
open System.Runtime.InteropServices

let [<Literal>] version = "0.9.9.1"
    
// Version information
[<assembly: AssemblyVersion(version)>]
[<assembly: AssemblyFileVersion(version)>]
[<assembly: AssemblyInformationalVersion(version)>]

// Assembly information
[<assembly: AssemblyTitle("FantomasLib")>]
[<assembly: AssemblyDescription("Source code formatting library for F#")>]
[<assembly: NeutralResourcesLanguage("en-US")>]

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[<assembly: AssemblyCopyright("Copyright © Anh-Dung Phan 2013")>]
[<assembly: AssemblyTrademark("")>]
[<assembly: AssemblyCulture("")>]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[<assembly: ComVisible(false)>]

// Only allow types derived from System.Exception to be thrown --
// any other types should be automatically wrapped.
[<assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)>]

(* Dependency hints for Ngen *)
[<assembly: DependencyAttribute("FSharp.Core", LoadHint.Always)>]
[<assembly: DependencyAttribute("System", LoadHint.Always)>]
[<assembly: DependencyAttribute("System.Core", LoadHint.Always)>]
[<assembly: DefaultDependency(LoadHint.Always)>]

do()