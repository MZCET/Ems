﻿'Check Password Expiry
'Check Lockout


Imports System.Diagnostics.Eventing.Reader

Public Class Main
    Dim cb As New CodeBank
    Public cstring As String
    Public UID As Integer
    Public UName As String
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        cstring = "Data Source=103.207.1.91;Initial Catalog=EMSDB;User ID=EMS;Password=EMS1234;Encrypt=False;"


        'Check SW Version
        If cb.vercheck() = False Then
            MsgBox("This version of software has expired. You need to upgrade to the latest version.", vbOKOnly + vbCritical, "Please upgrade the software.")
            Me.Close()
        End If

        'User Login
        Dim LF As New Main_Login()
        If LF.ShowDialog() = DialogResult.OK Then
            If LF.Result = 0 Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If


    End Sub

    Private Sub ManageRegulationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageRegulationsToolStripMenuItem.Click
        Reg_Mgmt.ShowDialog()
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click
        TestForm.ShowDialog()

    End Sub

    Private Sub ManageProgramsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageProgramsToolStripMenuItem.Click
        Dim frm2 = Reg_PrgCourses
        frm2.Show()
        frm2.MdiParent = Me
    End Sub

    Private Sub ManageCoursesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageCoursesToolStripMenuItem.Click
        Dim frm2 = ManageStudentCourse
        frm2.Show()
        frm2.MdiParent = Me
    End Sub

    Private Sub ManageCourseFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageCourseFileToolStripMenuItem.Click
        Dim frm2 = CourseAttachment
        frm2.Show()
        frm2.MdiParent = Me
    End Sub

    Private Sub AddStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStudentToolStripMenuItem.Click

        Dim frm2 = studentDetails_page1
        frm2.Show()
        frm2.MdiParent = Me
    End Sub

    Private Sub PdfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PdfToolStripMenuItem.Click
        Dim frm2 = pdf
        frm2.Show()
        frm2.MdiParent = Me
    End Sub

    Private Sub ViewStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewStudentsToolStripMenuItem.Click
        Dim frm2 = view_students
        frm2.Show()
        frm2.MdiParent = Me
    End Sub
End Class