<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jusolinkSearch
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtIndex = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.listView1 = New System.Windows.Forms.ListView
        Me.zipcode = New System.Windows.Forms.ColumnHeader
        Me.sectionNum = New System.Windows.Forms.ColumnHeader
        Me.roadAddr1 = New System.Windows.Forms.ColumnHeader
        Me.roadAddr2 = New System.Windows.Forms.ColumnHeader
        Me.jibunAddr = New System.Windows.Forms.ColumnHeader
        Me.relatedJibun = New System.Windows.Forms.ColumnHeader
        Me.btnPrevPage = New System.Windows.Forms.Button
        Me.btnNextPage = New System.Windows.Forms.Button
        Me.txtPageNum = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTotalPage = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtIndex)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(471, 61)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "주소검색"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(386, 18)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 30)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "검색"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtIndex
        '
        Me.txtIndex.Location = New System.Drawing.Point(16, 22)
        Me.txtIndex.Name = "txtIndex"
        Me.txtIndex.Size = New System.Drawing.Size(361, 21)
        Me.txtIndex.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(507, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "> 검색결과 목록에서 원하는 주소정보 셀을 선택하십시오."
        '
        'listView1
        '
        Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.zipcode, Me.sectionNum, Me.roadAddr1, Me.roadAddr2, Me.jibunAddr, Me.relatedJibun})
        Me.listView1.FullRowSelect = True
        Me.listView1.GridLines = True
        Me.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.listView1.Location = New System.Drawing.Point(30, 96)
        Me.listView1.MultiSelect = False
        Me.listView1.Name = "listView1"
        Me.listView1.Size = New System.Drawing.Size(1035, 474)
        Me.listView1.TabIndex = 2
        Me.listView1.UseCompatibleStateImageBehavior = False
        Me.listView1.View = System.Windows.Forms.View.Details
        '
        'zipcode
        '
        Me.zipcode.Text = "우편번호"
        Me.zipcode.Width = 74
        '
        'sectionNum
        '
        Me.sectionNum.Text = "새우편번호"
        Me.sectionNum.Width = 80
        '
        'roadAddr1
        '
        Me.roadAddr1.Text = "도로명주소"
        Me.roadAddr1.Width = 290
        '
        'roadAddr2
        '
        Me.roadAddr2.Text = "참고항목"
        Me.roadAddr2.Width = 122
        '
        'jibunAddr
        '
        Me.jibunAddr.Text = "지번주소"
        Me.jibunAddr.Width = 290
        '
        'relatedJibun
        '
        Me.relatedJibun.Text = "관련지번목록"
        Me.relatedJibun.Width = 170
        '
        'btnPrevPage
        '
        Me.btnPrevPage.Location = New System.Drawing.Point(354, 576)
        Me.btnPrevPage.Name = "btnPrevPage"
        Me.btnPrevPage.Size = New System.Drawing.Size(101, 35)
        Me.btnPrevPage.TabIndex = 3
        Me.btnPrevPage.Text = "이전페이지"
        Me.btnPrevPage.UseVisualStyleBackColor = True
        '
        'btnNextPage
        '
        Me.btnNextPage.Location = New System.Drawing.Point(641, 576)
        Me.btnNextPage.Name = "btnNextPage"
        Me.btnNextPage.Size = New System.Drawing.Size(101, 35)
        Me.btnNextPage.TabIndex = 4
        Me.btnNextPage.Text = "다음페이지"
        Me.btnNextPage.UseVisualStyleBackColor = True
        '
        'txtPageNum
        '
        Me.txtPageNum.AutoSize = True
        Me.txtPageNum.Font = New System.Drawing.Font("굴림", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.txtPageNum.Location = New System.Drawing.Point(505, 587)
        Me.txtPageNum.Name = "txtPageNum"
        Me.txtPageNum.Size = New System.Drawing.Size(0, 19)
        Me.txtPageNum.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("굴림", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.Location = New System.Drawing.Point(535, 587)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "/"
        '
        'txtTotalPage
        '
        Me.txtTotalPage.AutoSize = True
        Me.txtTotalPage.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.txtTotalPage.Location = New System.Drawing.Point(552, 589)
        Me.txtTotalPage.Name = "txtTotalPage"
        Me.txtTotalPage.Size = New System.Drawing.Size(0, 16)
        Me.txtTotalPage.TabIndex = 7
        '
        'jusolinkSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 623)
        Me.Controls.Add(Me.txtTotalPage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPageNum)
        Me.Controls.Add(Me.btnNextPage)
        Me.Controls.Add(Me.btnPrevPage)
        Me.Controls.Add(Me.listView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "jusolinkSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "주소정보 조회"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIndex As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents listView1 As System.Windows.Forms.ListView
    Private WithEvents zipcode As System.Windows.Forms.ColumnHeader
    Private WithEvents sectionNum As System.Windows.Forms.ColumnHeader
    Private WithEvents roadAddr2 As System.Windows.Forms.ColumnHeader
    Private WithEvents jibunAddr As System.Windows.Forms.ColumnHeader
    Private WithEvents relatedJibun As System.Windows.Forms.ColumnHeader
    Private WithEvents roadAddr1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPrevPage As System.Windows.Forms.Button
    Friend WithEvents btnNextPage As System.Windows.Forms.Button
    Friend WithEvents txtPageNum As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotalPage As System.Windows.Forms.Label
End Class
