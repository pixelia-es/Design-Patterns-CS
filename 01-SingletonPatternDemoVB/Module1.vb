Module Module1

    Sub Main()
        Console.WriteLine("***Singleton Pattern Demo***\n")
        Console.WriteLine("Trying to create instance s1.")
        Dim s1 As Singleton = Singleton.Instance
        Console.WriteLine("Trying to create instance s2.")
        Dim s2 As Singleton = Singleton.Instance
        If (s1.Equals(s2)) Then
            Console.WriteLine("Only one instance exists.")
        Else
            Console.WriteLine("Different instances exist.")
        End If
        Console.Read()
    End Sub

End Module

Public NotInheritable Class Singleton
    Private Shared ReadOnly _instance As Singleton = New Singleton()
    Private Shared numberOfInstances As Integer = 0

    Private Sub New()
        Console.WriteLine("Instantiating inside the private constructor.")
        numberOfInstances += 1
        Console.WriteLine("Number of instances ={0}", numberOfInstances)
    End Sub

    Public Shared ReadOnly Property Instance As Singleton
        Get
            Console.WriteLine("We already have an instance now. Use it.")
            Return _instance
        End Get
    End Property

End Class

