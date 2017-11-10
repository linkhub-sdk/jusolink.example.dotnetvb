<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jusolinkTypeSelect
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.radioRoadAddr = New System.Windows.Forms.RadioButton
        Me.radioJibunAddr = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtRoadAddr2 = New System.Windows.Forms.Label
        Me.txtRoadDetail = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtRoadAddr = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSectionNum = New System.Windows.Forms.Label
        Me.txtZipcode = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtJibunDetail = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtJibunAddr = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtSectionNum1 = New System.Windows.Forms.Label
        Me.txtZipcode1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.btnReSearch = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "* 주소 타입을 확인하시고 상세주소를 입력한 후 확인버튼을 누르세요."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(371, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "* 정확한 우편물 발송을 위해 표준화 도로명주소 사용을 권장합니다."
        '
        'radioRoadAddr
        '
        Me.radioRoadAddr.AutoSize = True
        Me.radioRoadAddr.Location = New System.Drawing.Point(39, 115)
        Me.radioRoadAddr.Name = "radioRoadAddr"
        Me.radioRoadAddr.Size = New System.Drawing.Size(123, 16)
        Me.radioRoadAddr.TabIndex = 2
        Me.radioRoadAddr.TabStop = True
        Me.radioRoadAddr.Text = "표준화 도로명주소"
        Me.radioRoadAddr.UseVisualStyleBackColor = True
        '
        'radioJibunAddr
        '
        Me.radioJibunAddr.AutoSize = True
        Me.radioJibunAddr.Location = New System.Drawing.Point(446, 115)
        Me.radioJibunAddr.Name = "radioJibunAddr"
        Me.radioJibunAddr.Size = New System.Drawing.Size(111, 16)
        Me.radioJibunAddr.TabIndex = 3
        Me.radioJibunAddr.TabStop = True
        Me.radioJibunAddr.Text = "표준화 지번주소"
        Me.radioJibunAddr.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRoadAddr2)
        Me.GroupBox1.Controls.Add(Me.txtRoadDetail)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtRoadAddr)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtSectionNum)
        Me.GroupBox1.Controls.Add(Me.txtZipcode)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 143)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'txtRoadAddr2
        '
        Me.txtRoadAddr2.AutoSize = True
        Me.txtRoadAddr2.Location = New System.Drawing.Point(72, 80)
        Me.txtRoadAddr2.Name = "txtRoadAddr2"
        Me.txtRoadAddr2.Size = New System.Drawing.Size(0, 12)
        Me.txtRoadAddr2.TabIndex = 8
        '
        'txtRoadDetail
        '
        Me.txtRoadDetail.Location = New System.Drawing.Point(81, 100)
        Me.txtRoadDetail.Name = "txtRoadDetail"
        Me.txtRoadDetail.Size = New System.Drawing.Size(277, 21)
        Me.txtRoadDetail.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "상세주소 : "
        '
        'txtRoadAddr
        '
        Me.txtRoadAddr.AutoSize = True
        Me.txtRoadAddr.Location = New System.Drawing.Point(78, 55)
        Me.txtRoadAddr.Name = "txtRoadAddr"
        Me.txtRoadAddr.Size = New System.Drawing.Size(0, 12)
        Me.txtRoadAddr.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "기본주소 : "
        '
        'txtSectionNum
        '
        Me.txtSectionNum.AutoSize = True
        Me.txtSectionNum.Location = New System.Drawing.Point(263, 27)
        Me.txtSectionNum.Name = "txtSectionNum"
        Me.txtSectionNum.Size = New System.Drawing.Size(0, 12)
        Me.txtSectionNum.TabIndex = 3
        '
        'txtZipcode
        '
        Me.txtZipcode.AutoSize = True
        Me.txtZipcode.Location = New System.Drawing.Point(86, 27)
        Me.txtZipcode.Name = "txtZipcode"
        Me.txtZipcode.Size = New System.Drawing.Size(0, 12)
        Me.txtZipcode.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(186, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 12)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "새우편번호 : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "구우편번호 :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtJibunDetail)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtJibunAddr)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtSectionNum1)
        Me.GroupBox2.Controls.Add(Me.txtZipcode1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(446, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(370, 143)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'txtJibunDetail
        '
        Me.txtJibunDetail.Location = New System.Drawing.Point(78, 100)
        Me.txtJibunDetail.Name = "txtJibunDetail"
        Me.txtJibunDetail.Size = New System.Drawing.Size(277, 21)
        Me.txtJibunDetail.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 12)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "상세주소 : "
        '
        'txtJibunAddr
        '
        Me.txtJibunAddr.AutoSize = True
        Me.txtJibunAddr.Location = New System.Drawing.Point(78, 55)
        Me.txtJibunAddr.Name = "txtJibunAddr"
        Me.txtJibunAddr.Size = New System.Drawing.Size(0, 12)
        Me.txtJibunAddr.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 12)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "기본주소 : "
        '
        'txtSectionNum1
        '
        Me.txtSectionNum1.AutoSize = True
        Me.txtSectionNum1.Location = New System.Drawing.Point(263, 27)
        Me.txtSectionNum1.Name = "txtSectionNum1"
        Me.txtSectionNum1.Size = New System.Drawing.Size(0, 12)
        Me.txtSectionNum1.TabIndex = 3
        '
        'txtZipcode1
        '
        Me.txtZipcode1.AutoSize = True
        Me.txtZipcode1.Location = New System.Drawing.Point(86, 27)
        Me.txtZipcode1.Name = "txtZipcode1"
        Me.txtZipcode1.Size = New System.Drawing.Size(0, 12)
        Me.txtZipcode1.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(180, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 12)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "새우편번호 : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 12)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "구우편번호 :"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(333, 275)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(88, 36)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "확인"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnReSearch
        '
        Me.btnReSearch.Location = New System.Drawing.Point(436, 275)
        Me.btnReSearch.Name = "btnReSearch"
        Me.btnReSearch.Size = New System.Drawing.Size(88, 36)
        Me.btnReSearch.TabIndex = 9
        Me.btnReSearch.Text = "다시검색"
        Me.btnReSearch.UseVisualStyleBackColor = True
        '
        'jusolinkTypeSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 323)
        Me.Controls.Add(Me.btnReSearch)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.radioJibunAddr)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.radioRoadAddr)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "jusolinkTypeSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "상세주소 입력"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents radioRoadAddr As System.Windows.Forms.RadioButton
    Friend WithEvents radioJibunAddr As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtZipcode As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRoadAddr As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSectionNum As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtJibunAddr As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSectionNum1 As System.Windows.Forms.Label
    Friend WithEvents txtZipcode1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnReSearch As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtRoadDetail As System.Windows.Forms.TextBox
    Friend WithEvents txtJibunDetail As System.Windows.Forms.TextBox
    Friend WithEvents txtRoadAddr2 As System.Windows.Forms.Label
End Class
