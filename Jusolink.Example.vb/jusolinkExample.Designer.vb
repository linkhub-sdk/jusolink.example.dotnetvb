<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jusolinkExample
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
        Me.btnGetUnitCost = New System.Windows.Forms.Button
        Me.btnGetBalance = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnOpenSearchForm = New System.Windows.Forms.Button
        Me.txtDetailAddr = New System.Windows.Forms.TextBox
        Me.txtSectionNum = New System.Windows.Forms.TextBox
        Me.txtZipcode = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnGetUnitCost)
        Me.GroupBox1.Controls.Add(Me.btnGetBalance)
        Me.GroupBox1.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(40, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 70)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "포인트 관리"
        '
        'btnGetUnitCost
        '
        Me.btnGetUnitCost.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnGetUnitCost.Location = New System.Drawing.Point(169, 21)
        Me.btnGetUnitCost.Name = "btnGetUnitCost"
        Me.btnGetUnitCost.Size = New System.Drawing.Size(123, 29)
        Me.btnGetUnitCost.TabIndex = 1
        Me.btnGetUnitCost.Text = "검색단가 조회"
        Me.btnGetUnitCost.UseVisualStyleBackColor = True
        '
        'btnGetBalance
        '
        Me.btnGetBalance.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnGetBalance.Location = New System.Drawing.Point(30, 21)
        Me.btnGetBalance.Name = "btnGetBalance"
        Me.btnGetBalance.Size = New System.Drawing.Size(123, 29)
        Me.btnGetBalance.TabIndex = 0
        Me.btnGetBalance.Text = "잔여포인트 조회"
        Me.btnGetBalance.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnOpenSearchForm)
        Me.GroupBox2.Controls.Add(Me.txtDetailAddr)
        Me.GroupBox2.Controls.Add(Me.txtSectionNum)
        Me.GroupBox2.Controls.Add(Me.txtZipcode)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(40, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(646, 110)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "주소검색"
        '
        'btnOpenSearchForm
        '
        Me.btnOpenSearchForm.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnOpenSearchForm.Location = New System.Drawing.Point(552, 32)
        Me.btnOpenSearchForm.Name = "btnOpenSearchForm"
        Me.btnOpenSearchForm.Size = New System.Drawing.Size(69, 52)
        Me.btnOpenSearchForm.TabIndex = 6
        Me.btnOpenSearchForm.Text = "주소검색"
        Me.btnOpenSearchForm.UseVisualStyleBackColor = True
        '
        'txtDetailAddr
        '
        Me.txtDetailAddr.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.txtDetailAddr.Location = New System.Drawing.Point(112, 62)
        Me.txtDetailAddr.Name = "txtDetailAddr"
        Me.txtDetailAddr.Size = New System.Drawing.Size(434, 22)
        Me.txtDetailAddr.TabIndex = 5
        '
        'txtSectionNum
        '
        Me.txtSectionNum.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.txtSectionNum.Location = New System.Drawing.Point(398, 34)
        Me.txtSectionNum.Name = "txtSectionNum"
        Me.txtSectionNum.Size = New System.Drawing.Size(148, 22)
        Me.txtSectionNum.TabIndex = 4
        '
        'txtZipcode
        '
        Me.txtZipcode.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.txtZipcode.Location = New System.Drawing.Point(112, 34)
        Me.txtZipcode.Name = "txtZipcode"
        Me.txtZipcode.Size = New System.Drawing.Size(148, 22)
        Me.txtZipcode.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "상세주소 :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.Location = New System.Drawing.Point(304, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "새 우편번호 : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "구 우편번호 : "
        '
        'jusolinkExample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 260)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "jusolinkExample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "주소링크 API SDK 예제"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtZipcode As System.Windows.Forms.TextBox
    Friend WithEvents txtDetailAddr As System.Windows.Forms.TextBox
    Friend WithEvents txtSectionNum As System.Windows.Forms.TextBox
    Friend WithEvents btnGetUnitCost As System.Windows.Forms.Button
    Friend WithEvents btnGetBalance As System.Windows.Forms.Button
    Friend WithEvents btnOpenSearchForm As System.Windows.Forms.Button

End Class
