Imports System.Data
Imports System.Data.Odbc
Imports System.IO
Imports System.Data.SqlClient

Public Class frmM�X�֔ԍ��捞
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Private Sub frm�X�֔ԍ��捞_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Call frm���j���[.Show()
    End Sub

    Private Sub frm�X�֔ԍ��捞_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn�I��_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn�I��.Click
        Call Me.Close()
    End Sub

    Private Sub btn�o�^_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn�o�^.Click
        Dim strPrint As String = 0 ''����l
        Dim str���p�� As String = 0 ''����l

        With txtCSV�p�X
            Select Case .Text
                Case ""
                    sfrm���b�Z�[�W.ShowDialog("�捞CSV�t�@�C����I�����Ă��������B", "�m�F", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    Exit Sub
                Case Else

            End Select
        End With

        Select Case sfrm���b�Z�[�W.ShowDialog("CSV�̎捞���s���܂��B��낵���ł����H", "�m�F", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.OK
            Case Else : Exit Sub
        End Select

        Call �S���폜()
        Call �Ǎ���()

    End Sub


    Private Sub btn�I��_Click(sender As Object, e As EventArgs) Handles btn�I��.Click
        'FolderBrowserDialog�N���X�̃C���X�^���X���쐬
        Dim ofd As New OpenFileDialog

        '�㕔�ɕ\����������e�L�X�g���w�肷��
        ofd.Title = "CSV�t�@�C�����w�肵�Ă��������B"
        '���[�g�t�H���_���w�肷��
        '�f�t�H���g��Desktop
        ofd.InitialDirectory = Environment.SpecialFolder.Desktop
        '�ŏ��ɑI������t�H���_���w�肷��
        'RootFolder�ȉ��ɂ���t�H���_�ł���K�v������
        'fbd.SelectedPath = "C:\Windows"
        '���[�U�[���V�����t�H���_���쐬�ł���悤�ɂ���
        '�f�t�H���g��True
        ofd.RestoreDirectory = True

        '�_�C�A���O��\������
        Select Case ofd.ShowDialog(Me)
            Case DialogResult.OK
                '�I�����ꂽ�t�H���_��\������
                txtCSV�p�X.Text = ofd.FileName

            Case DialogResult.Cancel
                txtCSV�p�X.Text = ""

        End Select
    End Sub

    ''�Ǎ���
    Private Sub �Ǎ���()
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim getCSV�f�[�^ As New StreamReader(txtCSV�p�X.Text, System.Text.Encoding.Default)    ''�C���X�^���X�𐶐�����
        Dim getCSV�s() As String
        Dim getCSV����() As String

        ''CSV�̑S�f�[�^�擾���A���s�ŋ��
        getCSV�s = Split(getCSV�f�[�^.ReadToEnd, vbCrLf)
        ProgressBar1.Maximum = getCSV�s.Length

        ''�s�����擾
        Dim get���� As Integer = getCSV�s.Length - 1

        ' �ǂݍ��݂ł��镶�����Ȃ��Ȃ�܂ŌJ��Ԃ�
        For rowCount As Integer = 0 To get����
            Dim mySQLDB_SUB As New clsDB

            ''�t�@�C���� 1 �s���ǂݍ���
            Dim get�s As String = getCSV�s(rowCount)

            ''�󔒍s�͔�΂�
            If get�s = "" Then Exit For

            ''���ڎ擾�i��؂蕶���ɂ���ďC������j
            getCSV���� = Split(get�s, """,""")

            ''�擾�����f�[�^���ǂ����邩�����͂��̕ӂɂ����
            msSQL = " INSERT INTO MST_�X�֔ԍ�("
            msSQL += " �X�֔ԍ�,"
            msSQL += " �s���{��,"
            msSQL += " �s�撬��,"
            msSQL += " �n��"
            msSQL += " )"
            msSQL += " VALUES"
            msSQL += " ("
            msSQL += "'" & getCSV����(0).Substring(1, 7) & "',"
            msSQL += "'" & getCSV����(1) & "',"
            msSQL += "'" & getCSV����(2) & "',"
            msSQL += "'" & getCSV����(3) & "'"
            msSQL += " )"

            mCommand = mySQLDB_SUB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()

            Call mySQLDB_SUB.Close()
            ProgressBar1.Value += 1
        Next

        ''����
        getCSV�f�[�^.Close()

        sfrm���b�Z�[�W.ShowDialog("�X�֔ԍ��̎捞���������܂����B", "���", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub �S���폜()
        Dim mySQLDB_SUB As New clsDB

        msSQL = "DELETE FROM MST_�X�֔ԍ�"
        mCommand = mySQLDB_SUB.getsqlComand(msSQL)
        Call mCommand.ExecuteNonQuery()

        Call mySQLDB_SUB.Close()
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        '�����N��Ɉړ��������Ƃɂ���
        LinkLabel1.LinkVisited = True
        '�u���E�U�ŊJ��
        System.Diagnostics.Process.Start("http://www.post.japanpost.jp/zipcode/dl/roman-zip.html")


    End Sub
End Class
