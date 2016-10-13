Imports System.Security.Cryptography
Imports System.Text

Public Module Hashing
    ' Contains tools used to hash a string with a given Hashing Algorithm.
    Public Class Hasher
        Private _algorithm As HashAlgorithm
        Private _useSalt As Boolean = True
        Private _random As New Random()

        Public Sub New(ByVal algorithm As HashAlgorithm)
            Me.Algorithm = algorithm
        End Sub

        Public Sub New(ByVal algorithm As HashAlgorithm, useSalt As Boolean)
            Me.Algorithm = algorithm
            Me.UseSalt = useSalt
        End Sub

        ' Hashes given password with wanted algorithm and salt if wanted.
        ' Default salt size is 20 characters.
        Public Function Hash(ByVal password As String, Optional saltSize As Integer = 20) As Hash
            Dim salt As String = String.Empty
            If _useSalt Then
                salt = GenerateSalt(saltSize - 1)
            End If

            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password & salt)
            Dim hashBytes As Byte() = Algorithm.ComputeHash(bytes)
            Return New Hash(Convert.ToBase64String(hashBytes), salt, Algorithm)
        End Function

        ' Generates salt with the desired length.
        Public Function GenerateSalt(ByVal saltSize As Integer) As String
            Dim salt As New StringBuilder

            For i As Integer = 0 To saltSize
                Dim randomIndex As Integer = _random.Next(0, ALL_CHARACTERS.Length - 1)
                salt.Append(ALL_CHARACTERS.Substring(randomIndex, 1))
            Next
            Return salt.ToString()
        End Function

        ' Class Properties
        ' The algorithm that will be used to hash.
        Public Property Algorithm As HashAlgorithm
            Get
                Return _algorithm
            End Get
            Set(value As HashAlgorithm)
                _algorithm = value
            End Set
        End Property

        ' Determines if a salt should be used or not.
        Public Property UseSalt As Boolean
            Get
                Return _useSalt
            End Get
            Set(value As Boolean)
                _useSalt = value
            End Set
        End Property
    End Class


    ' Holds information regarding a hash.
    Public Class Hash
        Private _hash As String
        Private _salt As String
        Private _type As HashAlgorithm

        Public Sub New(ByVal hash As String, salt As String, type As HashAlgorithm)
            Me.Hash = hash
            Me.Salt = salt
            Me.Type = type
        End Sub

        ' Class Properties
        ' The hash.
        Public Property Hash As String
            Get
                Return _hash
            End Get
            Set(value As String)
                _hash = value
            End Set
        End Property

        ' The salt that was used before hashing.
        Public Property Salt As String
            Get
                Return _salt
            End Get
            Set(value As String)
                _salt = value
            End Set
        End Property

        ' The hashing algorithm that was use to generate the hash.
        Public Property Type As HashAlgorithm
            Get
                Return _type
            End Get
            Set(value As HashAlgorithm)
                _type = value
            End Set
        End Property
    End Class
End Module
