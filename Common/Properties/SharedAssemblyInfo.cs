﻿using System.Reflection;

// common assembly attributes
[assembly: AssemblyDescription("Lean Algorithmic Trading Engine - QuantConnect.com")]
[assembly: AssemblyCopyright("Copyright ©  2015")]
[assembly: AssemblyCompany("QuantConnect")]
[assembly: AssemblyTrademark("QuantConnect")]
[assembly: AssemblyVersion("2.1.0.31")]
#if DEBUG
    [assembly: AssemblyConfiguration("Debug")]
#else
    [assembly: AssemblyConfiguration("Release")]
#endif