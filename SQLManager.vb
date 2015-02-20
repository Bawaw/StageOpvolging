Imports MySql.Data.MySqlClient
Public Class SQLManager
    Dim SQLConnection As MySqlConnection = New MySqlConnection

    Dim ServerString As String = "Server=localhost;User Id=StageOpvolging;Password=BALDER6IICT;Database=stageopvolging"

    Sub OpenConnection()
        SQLConnection.ConnectionString = ServerString

        Try
            If SQLConnection.State = ConnectionState.Closed Then
                SQLConnection.Open()
            End If
        Catch ex As Exception
            MsgBox("Er kon geen verbinding gemaakt worden")
        End Try
    End Sub

    Sub CloseConnection()
        SQLConnection.Close()
        SQLConnection.Dispose()
    End Sub

    Public Sub NieuwAcount(ByVal Voornaam As String, ByVal Naam As String, ByVal klas As String, ByVal telefoon As String, ByVal eMail As String, ByVal TA As Integer, ByVal administrator As Integer)
        OpenConnection()
        Dim SQLStatement As String = "INSERT INTO accounts(VoorNaam, Naam, Klas, Telefoon, eMail, TA, Administrator) VALUES ('" & Voornaam & "', '" & Naam & "', '" & klas & "', '" & telefoon & "', '" & eMail & "', '" & TA & "', '" & administrator & "')"
        Dim command As MySqlCommand = New MySqlCommand

        With command
            .CommandText = SQLStatement
            .CommandType = CommandType.Text
            .Connection = SQLConnection
            .ExecuteNonQuery()
        End With

        CloseConnection()
    End Sub
    Public Sub NieuweLeerling(ByVal KlasNummer As Integer, ByVal VoorNaam As String, ByVal Achternaam As String, ByVal Klas As String, ByVal email As String, ByVal Telefoon As String, ByVal Adres As String, ByVal bedrijf As String, ByVal mentor As String, ByVal opmerkingen As String, ByVal toegevoegdjaar As String)

        OpenConnection()
        Dim SQLStatement As String = "INSERT INTO leerlingen(KlasNummer, VoorNaam, Achternaam, Klas, eMail, Telefoon, Adres, bedrijf, mentor, opmerkingen, toegevoegdjaar) VALUES ('" & KlasNummer & "', '" & VoorNaam & "', '" & Achternaam & "', '" & Klas & "', '" & email & "', '" & Telefoon & "', '" & Adres & "', '" & bedrijf & "', '" & mentor & "', '" & opmerkingen & "', '" & toegevoegdjaar & "')"
        Dim command As MySqlCommand = New MySqlCommand

        With command
            .CommandText = SQLStatement
            .CommandType = CommandType.Text
            .Connection = SQLConnection
            .ExecuteNonQuery()
        End With

        CloseConnection()
    End Sub
    Public Sub NieuweKlas(ByVal klasNaam As String)
        OpenConnection()

        Dim SQLStatement As String = "INSERT INTO klassen(Klas) VALUES ('" & klasNaam & "')"
        Dim command As MySqlCommand = New MySqlCommand

        With command
            .CommandText = SQLStatement
            .CommandType = CommandType.Text
            .Connection = SQLConnection
            .ExecuteNonQuery()
        End With

        CloseConnection()
    End Sub


    Public Sub NieuwBedrijf(ByVal BedrijfNaam As String, ByVal Plaats As String, ByVal Straat As String, ByVal Telefoon As String, ByVal eMail As String, ByVal ContactPersoon As String, ByVal Opmerkingen As String, ByVal Postcode As String, ByVal HuisNummer As String)
        OpenConnection()
        Dim SQLStatement As String = "INSERT INTO bedrijven(BedrijfNaam, Plaats, Straat, Postcode, HuisNummer, Telefoon, eMail, ContactPersoon, Opmerkingen) VALUES ('" & BedrijfNaam & "', '" & Plaats & "', '" & Straat & "', '" & Postcode & "', '" & HuisNummer & "', '" & Telefoon & "', '" & eMail & "', '" & ContactPersoon & "', '" & Opmerkingen & "')"
        Dim command As MySqlCommand = New MySqlCommand

        With command
            .CommandText = SQLStatement
            .CommandType = CommandType.Text
            .Connection = SQLConnection
            .ExecuteNonQuery()
        End With

        CloseConnection()
    End Sub

    Public Function LoadGrid(ByVal dataTable As String)
        OpenConnection()

        Dim sqlAdapter As New MySqlDataAdapter
        Dim Command As New MySqlCommand
        Dim Table As New DataTable

        With Command
            .CommandText = "SELECT * FROM " & dataTable
            .Connection = SQLConnection
        End With

        With sqlAdapter
            .SelectCommand = Command
            Try
                .Fill(Table)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End With

        CloseConnection()

        Return Table
    End Function

    Public Function LoadFilteredData(ByVal dataTable As String, ByVal Field As String, ByVal Value As String)
        OpenConnection()

        Dim sqlAdapter As New MySqlDataAdapter
        Dim Command As New MySqlCommand
        Dim Table As New DataTable

        With Command
            .CommandText = "SELECT * FROM " & dataTable & " WHERE " & Field & "='" & Value & "'"
            .Connection = SQLConnection
        End With

        With sqlAdapter
            .SelectCommand = Command

            Try
                .Fill(Table)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End With

        CloseConnection()

        Return Table
    End Function
    Public Function LoadDoubleFilteredData(ByVal dataTable As String, ByVal Field1 As String, ByVal field2 As String, ByVal Value1 As String, ByVal value2 As String)
        OpenConnection()

        Dim sqlAdapter As New MySqlDataAdapter
        Dim Command As New MySqlCommand
        Dim Table As New DataTable

        With Command
            .CommandText = "SELECT * FROM " & dataTable & " WHERE " & Field1 & "='" & Value1 & "' AND " & field2 & "='" & value2 & "'"
            .Connection = SQLConnection
        End With

        With sqlAdapter
            .SelectCommand = Command

            Try
                .Fill(Table)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End With

        CloseConnection()

        Return Table
    End Function

    Public Function CheckValidLogin(ByVal username As String, ByVal password As String) As Integer
        OpenConnection()
        Dim userPass As String = ""
        Dim DR As MySqlDataReader
        Dim found As Integer = 0
        Dim sqlAdapter As New MySqlDataAdapter
        Dim Command As New MySqlCommand

        With Command
            .CommandText = "SELECT * FROM accounts WHERE VoorNaam='" & username & "' AND Wachtwoord='" & password & "'"
            .Connection = SQLConnection
        End With

        DR = Command.ExecuteReader


        While DR.Read
            userPass = userPass & DR.Item("Ta") & Space(1) & DR("Administrator")
        End While

        CloseConnection()

        If (userPass = vbNullString) Then
            found = 0
        ElseIf userPass.Substring(5, userPass.IndexOf(" ")) = "True" Then
            found = 3 'admin
        ElseIf userPass.Substring(0, userPass.IndexOf(" ")) = "True" Then
            found = 2 'TA
        ElseIf userPass.Substring(0, userPass.IndexOf(" ")) = "False" And userPass.Substring(6, userPass.IndexOf(" ")) = "False" Then
            found = 1 'Teacher
        End If
        Return found
    End Function

    Public Sub UpdateData(ByVal dataTable As String, ByVal ID As Integer, ByVal Field As String, ByVal Value As String)
        OpenConnection()

        Dim Command As New MySqlCommand

        With Command
            .CommandText = "UPDATE " & dataTable & " SET " & Field & "='" & Value & "' WHERE ID='" & ID & "' "
            .Connection = SQLConnection
            .ExecuteNonQuery()
        End With

        CloseConnection()
    End Sub
    Public Sub UpdateKlas(ByVal OudeKlas As String, ByVal NieuweKlas As String)
        OpenConnection()

        Dim Command As New MySqlCommand

        With Command
            .CommandText = "UPDATE klassen SET Klas='" & NieuweKlas & "' WHERE Klas='" & OudeKlas & "' "
            .Connection = SQLConnection
            .ExecuteNonQuery()
        End With

        CloseConnection()
    End Sub

    Public Sub DeleteRow(ByVal dataTable As String, ByVal ID As Integer)
        OpenConnection()

        Dim Command As New MySqlCommand

        With Command
            .CommandText = "DELETE FROM " & dataTable & " WHERE ID='" & ID & "'"
            .Connection = SQLConnection
            .ExecuteNonQuery()
        End With

        CloseConnection()

    End Sub

    Public Sub DeleteKlas(ByVal KlasNaam As String)
        OpenConnection()

        Dim Command As New MySqlCommand

        With Command
            .CommandText = "DELETE FROM klassen WHERE Klas='" & KlasNaam & "'"
            .Connection = SQLConnection
            .ExecuteNonQuery()
        End With

        CloseConnection()

    End Sub

End Class
