Option Explicit On
Option Strict On
Module SayMyName
    'Carson Bogart
    'RCET0265  
    'Spring 2022
    'Say My Name
    '
    Sub Main()
        'set userInput as string input
        Dim userInput As String
        'display text
        Console.WriteLine("What's your name?")
        'wait for user input
        userInput = Console.ReadLine
        'read user input 
        Console.WriteLine("Hello " & userInput & " I am the computer, nice to meet you!")
        'wait for user
        Console.ReadLine()
    End Sub

End Module
