Imports System.IO

Public Class FileIODemoForm
    Sub DontBeDumb() Handles Me.Load
        FileOpen(1, "C:\Users\Jake Burrell\Documents\_FileDemoStuff\myfile.txt", OpenMode.Output) 'override
        'FileOpen(1, ""C:\Users\Jake Burrell\Documents\_FileDemoStuff\myfile.txt"", OpenMode.Input)
        FileOpen(1, ""C:\Users\Jake Burrell\Documents\_FileDemoStuff\myfile.txt"", OpenMode.Append) 'adds to the end of the flie
        WriteLine(1, "here is data")
        FileClose(1)
    End Sub


End Class
