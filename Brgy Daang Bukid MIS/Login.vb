Imports System.ComponentModel
Imports System.Data
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class Login

    Public mySqlConn As String = My.Resources.constring
    Dim isValidated As Boolean = False
    Dim userClick As Integer = 0
    Dim passClick As Integer = 0

    Private visibilityImage As Image
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isAccountAvailable() = False Then
            createAccountForAdmin()
            insertInitialSystemVariables()
        End If
    End Sub
    Private Sub createAccountForAdmin()
        Dim mySql As MySqlConnection
        mySql = New MySqlConnection(mySqlConn)
        On Error Resume Next
        mySql.Open()

        Select Case Err.Number
            Case 0
            Case Else
                MsgBox("Cannot connect to the Database!", vbExclamation, "Database Error")
                Application.Exit()
                End
                Exit Sub
        End Select

        Dim cmd As MySqlCommand
        cmd = mySql.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "INSERT INTO accounts (account_id, account_name, account_password, user_level, question, answer, first_login) VALUES (1, 'admin', 'admin', 'Administrator', 'What was your childhood nickname?', 'admin', 'No')"

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub
    Private Sub insertInitialSystemVariables()
        Dim mySql As MySqlConnection
        mySql = New MySqlConnection(mySqlConn)
        On Error Resume Next
        mySql.Open()

        Select Case Err.Number
            Case 0
            Case Else
                MsgBox("Cannot connect to the Database!", vbExclamation, "Database Error")
                Application.Exit()
                End
                Exit Sub
        End Select

        Dim cmd As MySqlCommand
        cmd = mySql.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "INSERT  INTO `system_variables`(`id`,`variable_name`,`variable_type`) VALUES (1,'Batanes','Birthplace'),(2,'Ilocos Norte','Birthplace'),(3,'Apayao','Birthplace'),(4,'Cagayan','Birthplace'),(5,'Abra','Birthplace'),(6,'Kalinga','Birthplace'),(7,'Ilocos Sur','Birthplace'),(8,'Mountain Province','Birthplace'),(9,'Ifugao','Birthplace'),(10,'Isabela','Birthplace'),(11,'La Union','Birthplace'),(12,'Benguet','Birthplace'),(13,'Nueva Vizcaya','Birthplace'),(14,'Quirino','Birthplace'),(15,'Pangasinan','Birthplace'),(16,'Tarlac','Birthplace'),(17,'Nueva Ecija','Birthplace'),(18,'Aurora','Birthplace'),(19,'Zambales','Birthplace'),(20,'Pampanga','Birthplace'),(21,'Bulacan','Birthplace'),(22,'Bataan','Birthplace'),(23,'Rizal','Birthplace'),(24,'Cavite','Birthplace'),(25,'Laguna','Birthplace'),(26,'Batangas','Birthplace'),(27,'Quezon','Birthplace'),(28,'Camarines Norte','Birthplace'),(29,'Marinduque','Birthplace'),(30,'Camarines Sur','Birthplace'),(31,'Catanduanes','Birthplace'),(32,'Albay','Birthplace'),(33,'Occidental Mindoro','Birthplace'),(34,'Oriental Mindoro','Birthplace'),(35,'Romblon','Birthplace'),(36,'Sorsogon','Birthplace'),(37,'Masbate','Birthplace'),(38,'Northern Samar','Birthplace'),(39,'Samar','Birthplace'),(40,'Eastern Samar','Birthplace'),(41,'Aklan','Birthplace'),(42,'Capiz','Birthplace'),(43,'Antique','Birthplace'),(44,'Iloilo','Birthplace'),(45,'Biliran','Birthplace'),(46,'Guimaras','Birthplace'),(47,'Negros Occidental','Birthplace'),(48,'Cebu','Birthplace'),(49,'Leyte','Birthplace'),(50,'Southern Leyte','Birthplace'),(51,'Palawan','Birthplace'),(52,'Negros Oriental','Birthplace'),(53,'Bohol','Birthplace'),(54,'Siquijor','Birthplace'),(55,'Camiguin','Birthplace'),(56,'Dinagat Islands','Birthplace'),(57,'Surigao del Norte','Birthplace'),(58,'Zamboanga del Norte','Birthplace'),(59,'Zamboanga Sibugay','Birthplace'),(60,'Zamboanga del Sur','Birthplace'),(61,'Misamis Occidental','Birthplace'),(62,'Lanao del Norte','Birthplace'),(63,'Lanao del Sur','Birthplace'),(64,'Misamis Oriental','Birthplace'),(65,'Bukidnon','Birthplace'),(66,'Agusan del Norte','Birthplace'),(67,'Agusan del Sur','Birthplace'),(68,'Surigao del Sur','Birthplace'),(69,'Cotabato','Birthplace'),(70,'Davao del Sur','Birthplace'),(71,'Davao del Norte','Birthplace'),(72,'Davao de Oro','Birthplace'),(73,'Davao Oriental','Birthplace'),(74,'Maguindanao del Norte','Birthplace'),(75,'Maguindanao del Sur','Birthplace'),(76,'Sultan Kudarat','Birthplace'),(77,'South Cotabato','Birthplace'),(78,'Sarangani','Birthplace'),(79,'Davao Occidental','Birthplace'),(80,'Basilan','Birthplace'),(81,'Sulu','Birthplace'),(82,'Tawi-Tawi','Birthplace'),(84,'Zamboanga City','Birthplace'),(85,'Natural born Filipino','Citizenship'),(86,'Naturalized Filipino','Citizenship'),(87,'Dual Citizenship','Citizenship'),(88,'Single','Civil Status'),(89,'Married','Civil Status'),(90,'Divorced','Civil Status'),(91,'Separated','Civil Status'),(92,'Widowed','Civil Status'),(93,'Roman Catholic','Religion'),(94,'Iglesia ni Cristo','Religion'),(95,'Muslim','Religion'),(96,'Buddhism','Religion'),(97,'Jehovah\'s Witnesses','Religion'),(98,'A. Aragon','Street Name'),(99,'Evangelista','Street Name'),(100,'E. Gomez','Street Name'),(101,'F. Gaudier','Street Name'),(102,'Casimiro Ave, Westbay','Street Name'),(103,'Baht, Westbay','Street Name'),(104,'Dinar, Westbay','Street Name'),(105,'Dirham, Westbay','Street Name'),(106,'Dollar, Westbay','Street Name'),(107,'Euro, Westbay','Street Name'),(108,'Franc, Westbay','Street Name'),(109,'Lira, Westbay','Street Name'),(110,'Peso, Westbay','Street Name'),(111,'Pound, Westbay','Street Name'),(112,'Ringgit, Westbay','Street Name'),(113,'Riyal, Westbay','Street Name'),(114,'Ruble, Westbay','Street Name'),(115,'Rupee, Westbay','Street Name'),(116,'Shekel, Westbay','Street Name'),(117,'Won, Westbay','Street Name'),(118,'Yen, Westbay','Street Name'),(119,'Yuan, Westbay','Street Name'),(120,'Owned','Residence Type'),(121,'Rent','Residence Type'),(122,'Tenancy','Residence Type'),(123,'Informal Settler','Residence Type'),(124,'Co Owned','Residence Type'),(125,'Wood','House Type'),(126,'Concrete','House Type'),(127,'Bricks','House Type'),(128,'Metal','House Type'),(129,'Maynilad','Water Source'),(130,'Manila Water','Water Source'),(131,'Deep Well','Water Source'),(132,'Water Station','Water Source'),(133,'Meralco','Electricity Source'),(134,'Solar Panels','Electricity Source'),(135,'Coal Energy','Electricity Source'),(136,'Nuclear Energy','Electricity Source'),(137,'What was your childhood nickname?','Recovery Question'),(138,'In what city did you meet your spouse/significant other?','Recovery Question'),(139,'What is the name of your favorite childhood friend?','Recovery Question'),(140,'What street did you live on in third grade?','Recovery Question'),(141,'What was your childhood nickname?','Recovery Question'),(142,'In what city did you meet your spouse/significant other?','Recovery Question'),(143,'What is the name of your favorite childhood friend?','Recovery Question'),(144,'What street did you live on in third grade?','Recovery Question'),(145,'In what city or town did your mother and father meet?','Recovery Question'),(146,'Where were you when you had your first kiss?','Recovery Question'),(155,'Deceased','Reason For Archive'),(156,'Moved Residency','Reason For Archive'),(157,'Good','Return Item State'),(158,'Damaged','Return Item State'),(159,'Defective','Return Item State'),(160,'Damaged','Stock Out Reason'),(161,'Defective','Stock Out Reason'),(162,'Lost','Stock Out Reason'),(163,'Replaced','Stock Out Reason'),(164,'Legal Purpose','Certificate Purpose'),(165,'Local Employment','Certificate Purpose'),(166,'Police Clearance','Certificate Purpose'),(167,'Enrollment','Certificate Purpose'),(168,'Scholarship Program','Certificate Purpose'),(169,'Bank Requirement','Certificate Purpose'),(170,'Financial Assistance','Certificate Purpose'),(171,'Medical Assistance','Certificate Purpose'),(172,'Destruction of property','Blottered for'),(173,'Violence or injury','Blottered for'),(174,'Theft or larceny','Blottered for'),(175,'Extortion or Scam','Blottered for'),(176,'Threatening','Blottered for'),(190,'Blind','Disability'),(191,'Deaf or hard hearing','Disability'),(192,'Intellectual Disability','Disability'),(193,'Autism Disability','Disability'),(194,'Physical Disability','Disability');"

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Sub
    Private Function isAccountAvailable() As Boolean
        Dim mySql As MySqlConnection
        mySql = New MySqlConnection(mySqlConn)
        On Error Resume Next
        mySql.Open()

        Select Case Err.Number
            Case 0
            Case Else
                MsgBox("Cannot connect to the Database!", vbExclamation, "Database Error")
                Application.Exit()
                End
        End Select

        Dim cmd As MySqlCommand
        cmd = mySql.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT count(*) FROM accounts"
        If cmd.ExecuteScalar() = 0 Then
            Return False
        Else
            Return True
        End If
        cmd.Dispose()
        mySql.Close()
        mySql.Dispose()
    End Function


    Private Function GetVisibilityImage(ByVal imageName As String) As Image
        If imageName = "visible" Then
            visibilityImage = My.Resources.visi_off
        Else
            visibilityImage = My.Resources.visi
        End If
        Return visibilityImage
    End Function

    Private Sub txtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        If txtUsername.Text = "Username*" Then
            txtUsername.Clear()
        End If
    End Sub

    Private Sub txtPassword_Click(sender As Object, e As EventArgs) Handles txtPassword.Click
        If txtPassword.Text = "Password*" Then
            txtPassword.Clear()
        End If
    End Sub

    Private Sub labelNoAccount_Click(sender As Object, e As EventArgs) Handles labelNoAccount.Click
        NoAccount.ShowDialog()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Me.Enabled = False

        Dim mySql As MySqlConnection
        mySql = New MySqlConnection(mySqlConn)
        On Error Resume Next
        mySql.Open()

        Select Case Err.Number
            Case 0
            Case Else
                MsgBox("Cannot connect to the Database!", vbExclamation, "Database Error")
                Me.Enabled = True
                mySql.Close()
                mySql.Dispose()
                txtUsername.Clear()
                txtPassword.Clear()
                txtUsername.Select()
                Exit Sub
        End Select

        If Len(txtUsername.Text.Trim) = 0 Or Len(txtPassword.Text.Trim) = 0 Then
            MsgBox("Please fill out the required fields!", vbCritical, "Warning")
            Me.Enabled = True
            txtUsername.Text = "Username*"
            txtUsername.Select()
            txtPassword.Text = "Password*"
        Else

            Dim mySQLCommand As MySqlCommand
            Dim mySQLReader As MySqlDataReader
            mySQLCommand = mySql.CreateCommand()
            mySQLCommand.CommandType = CommandType.Text

            mySQLCommand.CommandText = "SELECT * FROM accounts WHERE BINARY account_name=@username AND BINARY account_password=@password"
            mySQLCommand.Parameters.AddWithValue("@username", txtUsername.Text)
            mySQLCommand.Parameters.AddWithValue("@password", txtPassword.Text)


            mySQLReader = mySQLCommand.ExecuteReader
            If mySQLReader.HasRows Then
                While mySQLReader.Read
                    Main_Form.account_id = mySQLReader!account_id
                    Main_Form.user_name = mySQLReader!account_name
                    Main_Form.user_level = mySQLReader!user_level
                End While

                addLog(Main_Form.user_name & " [" & Main_Form.user_level & "]", "Logged In")
                Main_Form.Show()
                Me.Close()
            Else
                txtUsername.Clear()
                txtPassword.Clear()
                Me.Enabled = True
                MsgBox("Incorrect login credentials!, Please try again", vbCritical, "Warning")
                txtUsername.Select()
            End If
            mySQLCommand.Dispose()
            mySQLReader.Dispose()
            mySql.Close()
            mySql.Dispose()
        End If

    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    'handles the action whenever the user 'enter' in the password
    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.btnLogin.PerformClick()
        End If
    End Sub

    Private Sub btnVisibility_Click(sender As Object, e As EventArgs) Handles btnVisibility.Click
        If txtPassword.PasswordChar = "*" Then
            txtPassword.PasswordChar = ""
            btnVisibility.Image = GetVisibilityImage("visible")
        Else
            txtPassword.PasswordChar = "*"
            btnVisibility.Image = GetVisibilityImage("invisible")
        End If
    End Sub

    Private Sub labelForgotPassword_Click(sender As Object, e As EventArgs) Handles labelForgotPassword.Click
        ForgotPassword.ShowDialog()
    End Sub
End Class
