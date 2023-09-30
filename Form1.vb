Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    ' 在 Form1.vb 中声明名为 nameList 的列表，用于存储全班名单
    Private nameList As List(Of String) = New List(Of String) From {
        "艾梦豪", "陈怡静", "代佳宁", "翟栋轩", "丁嘉祥", "董家乐", "杜宾杰", "段智慧",
        "冯茜茜", "高瑞康", "耿诗鉴", "耿一涵", "关艺洁", "郭起见", "郭子聪", "郭祖康",
        "胡世康", "黄茂洁", "李家倩", "李金", "李苏航", "李兴业", "李政航", "梁晨",
        "马楷杰", "马语嫣", "齐浩添", "任可心", "商钦博", "宋梓鑫", "孙梦欣", "陶政旗",
        "王靖雯", "王天佑", "王一菡", "王怡斐", "王奕锦", "王雨欣", "魏启武", "武博林",
        "肖光亚", "谢诗艺", "熊铜辉", "徐靖皓", "徐鲁豫", "薛依蕊", "杨奋瑞", "杨孟哲",
        "于家豪", "于润", "张聪", "张嘉豪", "张进", "张世维", "张硕彦", "张天祥", "张迎吉",
        "赵嘉航", "赵雅君", "赵炎晴", "郑博文", "周锦均", "周帅杰", "朱盈澳"
    }

    ' 在 Form1.vb 中声明名为 japaneseNameList 的列表，用于存储日语名单
    Private japaneseNameList As List(Of String) = New List(Of String) From {
        "张嘉豪", "赵炎晴", "梁晨", "熊铜辉", "郭子聪", "李苏航", "耿诗鉴", "武博林"
    }

    ' 布尔变量，用于跟踪是否排除日语名单

    Private isJapaneseExclusive As Boolean = False

    Private Sub RandomSelectButton_Click(sender As Object, e As EventArgs) Handles RandomSelectButton.Click
        If nameList.Count > 0 Then
            Dim random As New Random()
            Dim selectedIndex As Integer

            If isJapaneseExclusive Then
                Dim nonJapaneseStudents As New List(Of String)(nameList)
                For Each student As String In japaneseNameList
                    If nonJapaneseStudents.Contains(student) Then
                        nonJapaneseStudents.Remove(student)
                    End If
                Next

                If nonJapaneseStudents.Count > 0 Then
                    selectedIndex = random.Next(0, nonJapaneseStudents.Count)
                    Dim selectedStudent As String = nonJapaneseStudents(selectedIndex)
                    SelectedStudentLabel.Text = selectedStudent
                Else
                    SelectedStudentLabel.Text = "没有非日语学生可供选择"
                End If
            Else
                selectedIndex = random.Next(0, nameList.Count)
                Dim selectedStudent As String = nameList(selectedIndex)
                SelectedStudentLabel.Text = selectedStudent
            End If
        Else
            SelectedStudentLabel.Text = "没有学生可供选择"
        End If
    End Sub

    Private Sub EnglishExclusiveButton_Click(sender As Object, e As EventArgs) Handles EnglishExclusiveButton.Click
        ' 切换到英语专属模式
        isJapaneseExclusive = Not isJapaneseExclusive

        ' 更新按钮文本
        UpdateButtonLabels()
    End Sub

    Private Sub UniversalButton_Click(sender As Object, e As EventArgs)
        ' 切换回通用模式
        isJapaneseExclusive = False

        ' 更新按钮文本
        UpdateButtonLabels()
    End Sub

    Private Sub UpdateButtonLabels()
        If isJapaneseExclusive Then
            EnglishExclusiveButton.Text = "英语专属 (已启用)"
            UniversalButton.Text = "通用"
        Else
            EnglishExclusiveButton.Text = "英语专属"
            UniversalButton.Text = "通用 (已启用)"
        End If
    End Sub
End Class