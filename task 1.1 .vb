Module Module1

    Sub Main()
        Dim MemberName As String = ""
        Dim MemberID As Integer = 0
        Dim moremembers As Boolean = True

        FileOpen(1, "E:\assignment 1.txt", OpenMode.Output)

        While moremembers = True
            Console.Write("Enter member ID: ")
            MemberID = Console.ReadLine
            Console.Write("Enter member name: ")
            MemberName = Console.ReadLine
            Console.WriteLine()

            WriteLine(1, MemberID)
            WriteLine(1, MemberName)

            Console.Write("Any more members' data to add? ")
            moremembers = Console.ReadLine
            Console.WriteLine()

        End While

        FileClose(1)
    End Sub

End Module
