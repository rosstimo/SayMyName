﻿'Elliot Heiner
'RCET0265
'Fall 2021
'Say My Name
'https://github.com/heinelli/SayMyName.git

Option Explicit On
Option Strict On
Module SayMyName
    Sub Main()
        Dim name As String  'A variable called "name" is created
        Console.WriteLine("Hello there. What's your name?")
        name = Console.ReadLine()   'User input is saved as the variable "name"
        Console.WriteLine("Hello there " & name & ". What are you doing?")
        Console.ReadLine()  'Creates delay so that user can type response
        Console.Write("That sounds boring! " & name & ", can you press ENTER please so that I can go back to sleep?")
        Console.Read()  'Creates delay so that user can press ENTER.
    End Sub

End Module
