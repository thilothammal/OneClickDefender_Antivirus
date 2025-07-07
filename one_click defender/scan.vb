Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Public Class scan
    Private scrollTimer As Timer
    Private scrollSpeed As Integer = 100
    Dim itemcount = 0
    Dim totalFiles As Integer
    Dim destFiles As Integer
    Dim s As Integer = 0
    Dim totalCount As (Files As Integer, Folders As Integer)
    Private Sub FileSystemWatcher1_Changed(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Changed
        Try
            Me.OpenFileDialog1.FileName = ""
            Dim scanbox As New TextBox
            scanbox.Text = My.Computer.FileSystem.ReadAllText("viruslist.accdb").ToString
            Dim md5 As New MD5CryptoServiceProvider
            Dim f As New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            f = New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            md5.ComputeHash(f)
            Dim hash As Byte() = md5.Hash
            Dim buff As New StringBuilder
            Dim hashbyte As Byte
            For Each hasbyte In hash
                buff.Append(String.Format("{0:X2}", hasbyte))

            Next

            f.Close()

            If scanbox.Text.Contains(buff.ToString) Then
                Me.OpenFileDialog1.FileName = e.FullPath
                frmVirusDetected.ShowDialog()
            End If

        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim ex As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub FileSystemWatcher1_Created(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Created
        Try
            Me.OpenFileDialog1.FileName = ""
            Dim scanbox As New TextBox
            scanbox.Text = My.Computer.FileSystem.ReadAllText("viruslist.accdb").ToString
            Dim md5 As New MD5CryptoServiceProvider
            Dim f As New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            f = New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            md5.ComputeHash(f)
            Dim hash As Byte() = md5.Hash
            Dim buff As New StringBuilder
            Dim hashbyte As Byte
            For Each hasbyte In hash
                buff.Append(String.Format("{0:X2}", hasbyte))

            Next
            f.Close()

            If scanbox.Text.Contains(buff.ToString) Then
                Me.OpenFileDialog1.FileName = e.FullPath
                frmVirusDetected.ShowDialog()
            End If

        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim ex As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub FileSystemWatcher1_Renamed(sender As Object, e As RenamedEventArgs) Handles FileSystemWatcher1.Renamed
        Try
            Me.OpenFileDialog1.FileName = ""
            Dim scanbox As New TextBox
            scanbox.Text = My.Computer.FileSystem.ReadAllText("viruslist.accdb").ToString
            Dim md5 As New MD5CryptoServiceProvider
            Dim f As New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            f = New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            md5.ComputeHash(f)
            Dim hash As Byte() = md5.Hash
            Dim buff As New StringBuilder
            Dim hashbyte As Byte
            For Each hasbyte In hash
                buff.Append(String.Format("{0:X2}", hasbyte))

            Next
            f.Close()

            If scanbox.Text.Contains(buff.ToString) Then
                Me.OpenFileDialog1.FileName = e.FullPath
                frmVirusDetected.ShowDialog()
            End If

        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim ex As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub CountFoldersAndFiles(ByVal path As String)
        Try
            Dim folderCount As Integer = Directory.GetDirectories(path, "*", SearchOption.AllDirectories).Length
            Dim fileCount As Integer = Directory.GetFiles(path, "*", SearchOption.AllDirectories).Length
            total.Text = "Folders:" & folderCount & ", Files:" & fileCount
            destFiles = folderCount + fileCount
        Catch ex As UnauthorizedAccessException
            MessageBox.Show($"Access to the path '{path}' is denied. Please run the application with administrator privileges.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        scrollTimer.Start()



        Dim i = 0


        If i > destFiles Then
            filesdect.Text = i
            i += 1
        End If
        If ProgressBar1.Value = 100 Then
            filesdect.Text = destFiles
        End If
        If ProgressBar1.Value = 100 Then
            scrollTimer.Stop()
            Timer1.Stop()
            MsgBox("Finished Scanning Folder!", MsgBoxStyle.Information, "One-Click Defender")
            TabControl1.SelectTab(1)
        End If
        If filesdect.Text = $"{totalCount.Files}" Then
            Timer4.Stop()
            ProgressBar1.Value = 100
        End If
        If ProgressBar1.Value = 100 Then
            Timer4.Stop()
            filesdect.Text = $"{totalCount.Files}"
        End If

        'CountFoldersAndFiles("C:\")


        'ProgressBar1.Maximum = Conversions.ToString(ListBox1.Items.Count)
        'total.Text = Conversions.ToString(ListBox1.Items.Count)

        'If Not ProgressBar1.Value = ProgressBar1.Maximum Then
        'Try
        'ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
        'readList.Text = ListBox1.SelectedItem.ToString
        'Catch ex As Exception
        'MsgBox(ex.Message, "One-Click Defender")
        'End Try
        '
        'Try 
        'Dim scanbox As New TextBox
        'Dim reead As String = My.Computer.FileSystem.ReadAllText("viruslist.txt")
        'ProgressBar1.Increment(1)
        '
        'files.Text = Conversions.ToString(ProgressBar1.Value)
        'scanbox.Text = readList.ToString
        'Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider
        'Dim f As FileStream = New FileStream(ListBox1.SelectedItem, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        'f = New FileStream(ListBox1.SelectedItem, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        'MD5.ComputeHash(f)
        'Dim hash As Byte() = md5.Hash
        'Dim buff As StringBuilder = New StringBuilder
        'Dim hashByte As Byte
        'For Each hashByte In hash
        'buff.Append(String.Format("0:X2", hashByte))
        'Next
        'If scanbox.Text.Contains(buff.ToString) Then
        'ListBox2.Items.Add(ListBox1.SelectedItem)
        'End If
        'Catch ex As Exception
        'MsgBox(ex.Message, "One-Click Defender")
        'End Try

        'Else
        'Timer1.Stop()
        'MsgBox("Finished Scanning Folder!", MsgBoxStyle.Information, "One-Click Defender")
        'TabControl1.SelectTab(1)
        'If ListBox1.Items.Count = 0 Then
        'MsgBox("No Threats detected", MsgBoxStyle.Information, "One-Click Defender")
        'End If
        'End If
    End Sub

    Function FindFile(folderPath As String, fileName As String) As Boolean
        ' Combine the folder path and file name to get the full file path
        Dim filePath As String = Path.Combine(folderPath, fileName)

        ' Check if the file exists
        Return File.Exists(filePath)
    End Function
    Function FindZipFile(folderPath As String, zipFileName As String) As String
        ' Check if the specified folder exists
        If Directory.Exists(folderPath) Then
            ' Search for the particular zip file in the folder
            Dim zipFilePath As String = Path.Combine(folderPath, zipFileName)

            ' Check if the zip file exists
            If File.Exists(zipFilePath) AndAlso Path.GetExtension(zipFilePath).ToLower() = ".zip" Then
                Return zipFilePath
            End If
        End If

        Return String.Empty
    End Function
    Private Sub AddItemToListBox(ByVal item As String)
        Dim name As String, path As String, path1 As String
        path = "C:/"
        path1 = "C:\Users\" & SystemInformation.UserName & "\Downloads"
        name = Dir(path, vbHidden Or vbSystem Or vbNormal)

        Do While name <> ""
            ListBox1.Items.Add(path1 & name)
            ListBox1.Items.Add(path & name)
            name = Dir()
        Loop
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' CountFoldersAndFiles("C:\Users\" & SystemInformation.UserName & "\Downloads")
        'AddItemToListBox(ListBox1.Items.Count + 1)
        '
        'Try
        'For Each strDir As String In System.IO.Directory.GetDirectories(FolderBrowserDialog1.SelectedPath)
        'For Each strFile As String In System.IO.Directory.GetFiles(strDir)
        'ListBox1.Items.Add(strFile)
        'Next
        'Next
        '
        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try
        Dim cDrivePath As String = "C:\"
        Dim dDrivePath As String = "D:\"
        Dim downloadsPath As String = "C:\Users\" & SystemInformation.UserName & "\Downloads"

        ' Display the total count for all paths
        totalCount = GetTotalFilesAndFolders(cDrivePath, dDrivePath, downloadsPath)
        total.Text = $"Folders: {totalCount.Folders} ,Files: {totalCount.Files}"
        Dim directoryPaths() As String = {"C:\", "D:\", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "C:\Users\" & SystemInformation.UserName & "\Downloads")}

        For Each directoryPath As String In directoryPaths
            ' Check if the directory exists
            If Directory.Exists(directoryPath) Then
                ' Get all files and folders in the directory
                Dim filesAndFolders() As String = Directory.GetFileSystemEntries(directoryPath)

                ' Display files and folders in the ListBox
                For Each item As String In filesAndFolders
                    ListBox1.Items.Add(item)
                Next
            Else
                ListBox1.Items.Add($"Directory not found: {directoryPath}")
            End If
        Next
        Timer1.Start()
        Timer4.Start()


        Dim filePath As String = "C:\Program Files (x86)\Default Company Name\One-Click Defender\file.txt"
        ' Dim filePath As String = "C:\Users\srira\Downloads\file.txt"
        ' Read all lines from the text file
        Dim fileNames As List(Of String) = File.ReadAllLines(filePath).ToList()

        ' Specify the paths to the "D" folder and "download" folder
        Dim dFolderPath As String = "D:"
        Dim downloadFolderPath As String = "C:\Users\" & SystemInformation.UserName & "\Downloads"

        ' Check for matches and add to ListBox
        Dim matchingFiles As List(Of String) = GetMatchingFiles(fileNames, dFolderPath, downloadFolderPath)

        If matchingFiles.Count > 0 Then
            ' Add matching files to ListBox
            ListBox2.Items.Clear()
            ListBox2.Items.AddRange(matchingFiles.ToArray())

            ' Display a message box

            MessageBox.Show("virus found!!!", "one-click defender", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
        UpdateCountLabel()
    End Sub
    Private Sub UpdateCountLabel()
        detected.Text = $"{ListBox2.Items.Count}"
    End Sub
    Private Function GetMatchingFiles(fileNames As List(Of String), dFolderPath As String, downloadFolderPath As String) As List(Of String)
        Dim matchingFiles As New List(Of String)

        For Each fileName As String In fileNames
            Dim dFilePath As String = Path.Combine(dFolderPath, fileName)
            Dim downloadFilePath As String = Path.Combine(downloadFolderPath, fileName)

            If File.Exists(dFilePath) And File.Exists(downloadFilePath) Then
                ' If the file is present in both folders, add both paths to the list
                matchingFiles.Add($"{dFilePath}")
                matchingFiles.Add($"{downloadFilePath}")
            ElseIf File.Exists(dFilePath) Then
                ' If the file is only in D folder, add its path to the list
                matchingFiles.Add(dFilePath)
            ElseIf File.Exists(downloadFilePath) Then
                ' If the file is only in Downloads folder, add its path to the list
                matchingFiles.Add(downloadFilePath)
            End If
        Next

        Return matchingFiles
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim folderBrowserDialog1 As New FolderBrowserDialog()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        TabControl1.SelectTab(0)


        If folderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            ' Clear existing items in ListBoxes
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()

            ' Display all files and folders in the selected directory
            Dim selectedFolder As String = folderBrowserDialog1.SelectedPath
            Dim filesAndFolders() As String = Nothing

            Try
                filesAndFolders = Directory.GetFileSystemEntries(selectedFolder)
                Dim folderPath As String = folderBrowserDialog1.SelectedPath
                Dim filesCount As Integer = Directory.GetFiles(folderPath).Length
                Dim foldersCount As Integer = Directory.GetDirectories(folderPath).Length

                total.Text = $"Files: {filesCount}, Folders: {foldersCount}"
            Catch ex As UnauthorizedAccessException
                MessageBox.Show($"Access denied: {ex.Message}", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try

            For Each item As String In filesAndFolders
                ListBox1.Items.Add(item)
            Next

            ' Check if any file matches the names in the text file
            CheckFileNames(selectedFolder)

            ' Display total number of files and folders in the "Total" label
            Dim totalFilesAndFolders As Integer = filesAndFolders.Length
            total.Text = $"{totalFilesAndFolders}"
        End If
        UpdateCountLabel()
        Timer1.Start()
    End Sub
    Private Sub CheckFileNames(folderPath As String)
        ' Path to the text file containing the list of file names
        Dim textFilePath As String = "C:\Program Files (x86)\Default Company Name\One-Click Defender\file.txt"

        ' Read all lines from the text file
        Dim fileNames As String() = File.ReadAllLines(textFilePath)

        ' Check if any file in the selected folder matches the names in the text file
        For Each fileName As String In fileNames
            Dim filePath As String = Path.Combine(folderPath, fileName)

            Try
                If File.Exists(filePath) Then
                    ' Display a message box if a matching file is found
                    MessageBox.Show("virus found!!!", "one-click defender", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    ' Add the found file path to ListBox2
                    ListBox2.Items.Add(filePath)
                End If
            Catch ex As UnauthorizedAccessException
                ' Handle unauthorized access exception (skip this file)
                MessageBox.Show($"Access denied: {ex.Message}", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Next
    End Sub
    Private Sub PrintFilesAndFolders(folderPath As String)
        ' Get all files in the folder, handling UnauthorizedAccessException
        Try
            Dim files As String() = Directory.GetFiles(folderPath)
            For Each file As String In files
                ListBox1.Items.Add(file)
            Next
        Catch ex As UnauthorizedAccessException

        End Try

        ' Get all subfolders in the folder and recursively call the function
        Try
            Dim subfolders As String() = Directory.GetDirectories(folderPath)
            For Each subfolder As String In subfolders
                PrintFilesAndFolders(subfolder)
            Next
        Catch ex As UnauthorizedAccessException

        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Try
            If Not ListBox2.Items.Count = 0 Then
                ListBox2.SelectedIndex += 1
                Kill(ListBox1.SelectedItem)
            Else
                Timer1.Stop()
                Timer2.Stop()
                MsgBox("Threat was removed Successfully!", MsgBoxStyle.Information, "One-Click Defender")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "One-Click Defender")
        End Try
    End Sub
    'MsgBox("Threat was removed Successfully!", MsgBoxStyle.Information, "One-Click Defender")
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListBox2.Items.Count > 0 Then
            Dim topFilePath As String = ListBox2.Items(0).ToString()
            Try
                File.Delete(topFilePath)
                ' Remove the deleted file from the ListBox
                ListBox2.Items.RemoveAt(0)
                ' Inform the user that deletion is complete
                MsgBox("Threat was removed Successfully!", MsgBoxStyle.Information, "One-Click Defender")
            Catch ex As Exception
                ' Handle any errors during file deletion (e.g., file in use, permissions issue)
                MessageBox.Show($"Error deleting top file: {topFilePath}{vbCrLf}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MsgBox("No file is detected!", MsgBoxStyle.Information, "One-Click Defender")
        End If
        UpdateCountLabel()



        'Try
        'Kill(ListBox2.SelectedItem)
        'ListBox2.Items.RemoveAt(ListBox2.SelectedItem)
        'MsgBox("Threat was removed Successfully!", MsgBoxStyle.Information, "One-Click Defender")
        'Catch ex As Exception
        'MsgBox("No Virus was detected to be deleted", MsgBoxStyle.Information, "One-Click Defender")
        'End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox2.Items.Count > 0 Then
            For Each filePath As String In ListBox2.Items
                Try
                    File.Delete(filePath)
                Catch ex As Exception
                    ' Handle any errors during file deletion (e.g., file in use, permissions issue)
                    MessageBox.Show($"Error deleting file: {filePath}{vbCrLf}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next

            ' Clear the ListBox after deletion
            ListBox2.Items.Clear()

            ' Inform the user that deletion is complete
            MsgBox("All Threat was removed Successfully!", MsgBoxStyle.Information, "One-Click Defender")
            Timer2.Start()
        Else
            MsgBox("No file is detected!", MsgBoxStyle.Information, "One-Click Defender")
        End If
        UpdateCountLabel()

    End Sub

    Private Sub files_Click(sender As Object, e As EventArgs) Handles filesdect.Click

    End Sub
    Private Sub UpdateSelectedItemsLabel()
        ' Get selected items and join them into a comma-separated string
        Dim selectedItems As String = String.Join(", ", ListBox1.SelectedItems.Cast(Of String)().ToArray())

        ' Update the label text
        readList.Text = selectedItems
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        UpdateSelectedItemsLabel()
    End Sub
    Private Sub AutoScrollListBox(sender As Object, e As EventArgs)
        ' Check if there are items in the ListBox
        If ListBox1.Items.Count > 0 Then
            ' Scroll to the next item
            ListBox1.SelectedIndex = (ListBox1.SelectedIndex + 1) Mod ListBox1.Items.Count

            ' Ensure the selected item is visible
            ListBox1.TopIndex = Math.Max(0, ListBox1.SelectedIndex - (ListBox1.ClientRectangle.Height \ ListBox1.ItemHeight) + 1)
            If ListBox1.SelectedIndex = ListBox1.Items.Count - 1 Then
                ' Reset the progress bar to full
                ProgressBar1.Value = ProgressBar1.Maximum

                ' Stop auto-scrolling

            End If
        End If
    End Sub
    Private Sub scan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim itemCount1 As Integer = ListBox2.Items.Count.ToString()
        detected.Text = itemCount1

        scrollTimer = New Timer()
        AddHandler scrollTimer.Tick, AddressOf AutoScrollListBox

        ' Set the interval for the timer
        scrollTimer.Interval = scrollSpeed

        ' Start the timer

    End Sub
    Function GetTotalFilesAndFolders(ParamArray directoryPaths As String()) As (Files As Integer, Folders As Integer)
        Dim filesCount As Integer = 0
        Dim foldersCount As Integer = 0

        Try
            ' Loop through all specified directory paths
            For Each directoryPath In directoryPaths
                ' Get all files and folders in the specified directory
                Dim allFilesAndFolders As String() = Nothing

                Try
                    allFilesAndFolders = Directory.GetFileSystemEntries(directoryPath, "*", SearchOption.AllDirectories)
                Catch ex As Exception
                    ' Log the exception (you can customize this part)
                    Console.WriteLine($"Error accessing {directoryPath}: {ex.Message}")
                End Try

                ' Count files and folders for the current directory
                If allFilesAndFolders IsNot Nothing Then
                    For Each item In allFilesAndFolders
                        If File.Exists(item) Then
                            filesCount += 1
                        ElseIf Directory.Exists(item) Then
                            foldersCount += 1
                        End If
                    Next
                End If
            Next

            ' Return the total counts
            Return (filesCount, foldersCount)
        Catch ex As Exception
            ' Handle other exceptions if any
            Console.WriteLine($"Error: {ex.Message}")
            Return (-1, -1)
        End Try
    End Function

    Private Sub detected_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub total_Click(sender As Object, e As EventArgs) Handles total.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
    Dim i = 0
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick


        ' Display the total count for all paths


        i = i + 5
        filesdect.Text = i

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        ProgressBar1.Increment(1)
        scrollTimer.Start()



        Dim i = 0


        If i > destFiles Then
            filesdect.Text = i
            i += 1
        End If
        If ProgressBar1.Value = 100 Then
            filesdect.Text = destFiles
        End If
        If ProgressBar1.Value = 100 Then
            scrollTimer.Stop()
            Timer5.Stop()
            MsgBox("Finished Scanning Folder!", MsgBoxStyle.Information, "One-Click Defender")
            TabControl1.SelectTab(1)
        End If
        If filesdect.Text = $"{totalCount.Files}" Then
            Timer4.Stop()
            ProgressBar1.Value = 100
        End If
        If ProgressBar1.Value = 100 Then
            Timer4.Stop()
            filesdect.Text = $"{totalCount.Files}"
        End If
    End Sub
End Class
