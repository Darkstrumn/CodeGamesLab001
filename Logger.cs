using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using com.darktechsystems;

namespace com.darktechsystems
{
public class Logger : ILogger {
    /*
    Supports second argument to specify if logging is to console or debug only
    */
    public void Log(string arg) {
        System.Diagnostics.Debug.Print($"*****(Debug){arg}\n");
        Console.WriteLine($"{arg}");
   	}
    }
}

