Public Class Matrix

    Private M As Integer ' Horizontal Size = No. of Columns
    Private N As Integer ' Vertical Size = No. of Rows
    Public val(,) As Double
    Private currentX As Integer
    Private currentY As Integer



    Public Sub New(ByVal X As Integer, ByVal Y As Integer)
        SetDimensions(X, Y)
        currentX = 0
        currentY = 0
    End Sub

    Public Sub New(ByVal X As Integer)
        SetDimensions(X, X)
        currentX = 0
        currentY = 0
    End Sub
    Private Sub SetDimensions(ByVal X As Integer, ByVal Y As Integer)
        M = X
        N = Y
        ReDim val(M - 1, N - 1)
    End Sub


    Public Function Add(ByVal C As Matrix) As Matrix
        If M <> C.M Or N <> C.N Then
            Throw New Exception("Matrices size Mismatch.")
        End If
        Dim B As Matrix = New Matrix(M, N)
        For i As Integer = 0 To M - 1
            For j As Integer = 0 To N - 1
                B.val(i, j) = val(i, j) + C.val(i, j)
            Next
        Next
        Return B
    End Function


    Public Function Multiply(ByVal C As Matrix) As Matrix
        If M <> C.N Then
            Throw New Exception("Matrices size Mismatch.")
        End If
        Dim B As Matrix = New Matrix(N, C.M)
        For j As Integer = 0 To N - 1
            For i As Integer = 0 To C.M - 1
                For k As Integer = 0 To M - 1 ' or 0 to C.N -1
                    B.val(i, j) += val(k, j) * C.val(i, k)
                Next
            Next
        Next
        Return B
    End Function

End Class
