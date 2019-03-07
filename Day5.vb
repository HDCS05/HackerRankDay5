Module Solution
    
    Public Shared Sub Main()

        'Enter your code here. Read input from STDIN. Print output to STDOUT
        Dim n As Integer
        Dim multiple As Integer

        n = Console.ReadLine()

        For i As Integer = 1 To 10
            multiple = n * i
            Console.WriteLine(n & " x " & i & " = " & multiple)
        Next

    End Sub
    
End Module
