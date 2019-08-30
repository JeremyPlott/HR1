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

class Solution {

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
        float countPos = 0.0f;
        float countNeg = 0.0f;
        float countZer = 0.0f;

        foreach (int i in arr) {
            if (i > 0) {
                countPos++;
            }
            if (i < 0) {
                countNeg++;
            }
            if (i == 0) {
                countZer++;
            }
        }

        float sumCount = countPos + countNeg + countZer;
        float posPart = countPos / sumCount;
        float negPart = countNeg / sumCount;
        float zerPart = countZer / sumCount;


        Console.WriteLine($"{posPart}");
        Console.WriteLine($"{negPart}");
        Console.WriteLine($"{zerPart}");
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
