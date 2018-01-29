Module Module1

    Sub Main()
        Dim MemberID As Integer = 0
        Dim MemberName As String = " "
        Dim NameSearch As String = " "
        Dim isfound As Boolean
        Dim MoreSearch As Boolean = True

        While MoreSearch = True

            FileOpen(1, "E:\Assignment 1.txt", OpenMode.Input)
            isfound = False

            Console.Write("Member Name to search for?: ")
            NameSearch = Console.ReadLine

            While Not EOF(1)

                Input(1, MemberID)
                Input(1, MemberName)

                If MemberName = NameSearch Then
                    isfound = True

                    Console.WriteLine("the ID is: " & MemberID)
                    Console.WriteLine()

                    Console.Write("anymore members you want to search for? ")
                    MoreSearch = Console.ReadLine

                End If

            End While

            If isfound = False Then Console.WriteLine("Searched Member Doesnot Exist!!!")
            Console.WriteLine()
        End While

        FileClose(1)
    End Sub

End Module
