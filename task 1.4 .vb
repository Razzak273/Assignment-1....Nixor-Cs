Module Module1

    Sub Main()
        Dim MemberName As String = ""
        Dim MemberID As Integer = 0
        Dim AnyMore As Boolean = True

        FileOpen(1, "E:\Assignment 1.txt", OpenMode.Append)

        While AnyMore = True
            Console.WriteLine("ID for New Member: ")
            MemberID = Console.ReadLine

            Console.WriteLine("Enter Member's Name: ")
            MemberName = Console.ReadLine


            WriteLine(1, MemberID)
            WriteLine(1, MemberName)

            Console.Write("Anymore Members? ")
            AnyMore = Console.ReadLine


        End While

        FileClose(1)

    End Sub

End Module
