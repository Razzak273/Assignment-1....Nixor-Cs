Module Module1

    Sub Main()
        Dim MemberName As String = ""
        Dim MemberID As Integer = 0

        FileOpen(1, "E:\Assignment 1.txt", OpenMode.Input)

        While Not EOF(1)

            Input(1, MemberID)
            Input(1, MemberName)

            Console.WriteLine("identification Number Of The Member: " & MemberID)

            Console.WriteLine("name of the member: " & MemberName)



        End While

        FileClose(1)

        Console.ReadKey()
    End Sub

End Module
