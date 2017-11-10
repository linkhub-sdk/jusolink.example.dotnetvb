Public Class jusolinkTypeSelect
    Public zipcode As String
    Public sectionNum As String
    Public roadAddr As String
    Public roadAddr2 As String
    Public jibunAddr As String

    '폼 로드 이벤트
    Private Sub jusolinkTypeSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '구우편번호
        txtZipcode.Text = zipcode
        txtZipcode1.Text = zipcode

        '새우편번호
        txtSectionNum.Text = sectionNum
        txtSectionNum1.Text = sectionNum

        '도로명주소
        txtRoadAddr.Text = roadAddr
        '도로명주소, 부가정보
        txtRoadAddr2.Text = roadAddr2

        '지번주소
        txtJibunAddr.Text = jibunAddr

        radioRoadAddr.Checked = True
    End Sub


    Private Sub txtJibunDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJibunDetail.Click
        radioRoadAddr.Checked = False
        radioJibunAddr.Checked = True
    End Sub

    Private Sub txtRoadDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRoadDetail.Click
        radioJibunAddr.Checked = False
        radioRoadAddr.Checked = True
    End Sub

    Private Sub radioRoadAddr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioRoadAddr.Click
        txtRoadDetail.Focus()
    End Sub

    Private Sub radioJibunAddr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioJibunAddr.Click
        txtJibunDetail.Focus()
    End Sub

    '다시검색 버튼 클릭 이벤트
    Private Sub btnReSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReSearch.Click
        jusolinkSearch.Show()
        jusolinkSearch.txtIndex.Focus()

        Me.Dispose()
    End Sub

    '확인 버튼 클릭 이벤트
    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        '최초 생성폼
        jusolinkExample.Show()

        '구우편번호 전달
        jusolinkExample.txtZipcode.Text = zipcode

        '새우편번호 전달
        jusolinkExample.txtSectionNum.Text = sectionNum


        '선택 주소 타입에 따른 주소정보 처리
        If radioRoadAddr.Checked Then
            '표준화 지번주소 : 도로명주소, 상세주소 (부가정보)
            jusolinkExample.txtDetailAddr.Text = roadAddr + ", " + txtRoadDetail.Text + " " + roadAddr2
        Else
            '표준화 지번주소 : 지번주소, 상세주소
            jusolinkExample.txtDetailAddr.Text = jibunAddr + ", " + txtJibunDetail.Text
        End If

        Me.Dispose()

    End Sub

End Class