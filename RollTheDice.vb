'Ian Gunter
'RCET 0265
'RollTheDice
'Fall 2020
'https://github.com/IanGunter/Roll-The-Dice.git




Module RollTheDice

    Sub Main()
        Dim randomNumber As Integer
        Dim numberrolled(10) As Integer
        Dim text As String
        Randomize()
        Console.SetWindowSize(150, 40)



        Do

            Console.WriteLine("Press enter to roll dice or type Q to quit")
        If Console.ReadLine = "Q" Then Exit Sub

            'Rolls dice 1000 times
            For i = 1 To 1000

            randomNumber = CInt(GetRandomNumber(1, 6))
                numberrolled(randomNumber - 2) += 1

            Next

            'Formats location for text on console.
            For i = 2 To 12
            text = String.Format("{0, 10}", i) & "|"
                Console.Write(text)

            Next

        Console.WriteLine()
            'StrDup creates a specific amount of - for formatting console
            Console.Write(StrDup(122, "-"))

        Console.WriteLine()

            'Formats location for text on console.
            For i = 0 To 10
                text = String.Format("{0, 10}", numberrolled(i)) & "|"
                Console.Write(text)

            Next
            Console.ReadLine()
            'Erases Array then redims it
            Erase numberrolled
            ReDim numberrolled(10)
            Console.Clear()
        Loop

    End Sub

    'Function Generates a random number.
    Function GetRandomNumber(ByVal minimum As Single,
                             ByVal maximum As Single) As Single
        Dim diceOne As Single
        Dim diceTwo As Single
        Dim diceTotal As Single
        Do
            diceOne = ((maximum * Rnd()) + 0.5)
            diceTwo = ((maximum * Rnd()) + 0.5)

        Loop While diceOne < minimum - 0.5 Or diceOne >= maximum + 0.5 Or diceTwo < minimum - 0.5 Or diceTwo >= maximum + 0.5

        diceTotal = (CInt(diceOne) + CInt(diceTwo))

        Return CInt(diceTotal)
    End Function


End Module
