Option Explicit On
Option Strict On

Imports System.Text.RegularExpressions

Module Benchmark
Sub Main()
    Dim Regex1 as Regex = New Regex("^(a|b|c|d|e|f|g)+$")
    Dim Regex2 as Regex = New Regex("^[a-g]+$")
    Dim TimesToDo as Integer = 1000
    Dim TestString as String = ""
    Dim I as Integer
    For I = 1 to 1000
        TestString = TestString & "abababdedfg"
    Next

    Dim StartTime as Double = Timer()
    For I = 1 to TimesToDo
        Regex1.Match(TestString)
    Next
    Dim Seconds as Double = Math.Round(Timer() - StartTime, 3)
    Console.WriteLine("Alternation takes " & Seconds & " seconds")

    StartTime = Timer()
    For I = 1 to TimesToDo
        Regex2.Match(TestString)
    Next
    Seconds = Math.Round(Timer() - StartTime, 3)
    Console.WriteLine("Character class takes " & Seconds & " seconds")
