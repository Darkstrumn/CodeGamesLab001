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
using System;
using com.darktechsystems;

class Solution {

   public static List<int> Challenge(List<int> grades) {
        var logger = new Logger();
        var model = grades
        .Select(g => g < 38 ? g : (g + 5) - ((g + 5) % 5) - g < 3 ? (g + 5) - ((g + 5) % 5) : g )
        .ToList<int>();
        //TL;DR ;P
        // var model = new List<int>();
        // foreach( var grade in grades.Select((v, i) => new {index = i, value = v}))
        // {
        //     if (grade.value < 38)
        //         {model.Add(grade.value);}
        //     else
        //         {
        //         var nextRoundUp = (grade.value + 5) - ((grade.value + 5) % 5);
        //         if (nextRoundUp - grade.value < 3)
        //             {model.Add(nextRoundUp);}
        //         else
        //             {model.Add(grade.value);}
        //         }
        // }
        return model;
    }

    static void Main(string[] args) {
        var logger = new Logger();
        List<int> grades = new List<int>{73,67,38,33};
        var result = Challenge(grades);
        logger.Log(String.Join("\n", result));
    }
}