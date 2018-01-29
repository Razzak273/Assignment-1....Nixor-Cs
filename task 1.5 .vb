Module Module1

    Sub Main()
        Dim MemberName As String = " "
        Dim MemberID As Integer = 0
        Dim MobileNO As String = ""
        Dim MembershipDate As Date

        FileOpen(1, "E:\Assignment 1.txt", OpenMode.Input)
        FileOpen(2, "E:\temporary.txt", OpenMode.Output)

        While Not EOF(1)

            Input(1, MemberID)
            Input(1, MemberName)

            Console.WriteLine("For member " & MemberID & ", name " & MemberName)
            Console.Write("Enter your mobile number: ")
            MobileNO = Console.ReadLine

            Console.Write("Staring Date Of Membership: ")
            MembershipDate = Console.ReadLine


            WriteLine(2, MemberID)
            WriteLine(2, MemberName)
            WriteLine(2, MobileNO)
            WriteLine(2, MembershipDate)

        End While

        FileClose(1)
        FileClose(2)

        My.Computer.FileSystem.DeleteFile("E:\Assignment 1.txt")
        My.Computer.FileSystem.RenameFile("E:\temporary.txt", "Assignment 1.txt")
    End Sub

End Module
