Public Class jusolinkExample

    ' 링크아이디
    Private LinkID As String = "TESTER_JUSO"

    ' 비밀키
    Private SecretKey As String = "FjaRgAfVUPvSDHTrdd/uw/dt/Cdo3GgSFKyE1+NQ+bc="

    ' 주소링크 서비스 변수 선언
    Public jusolinService As JusolinkService

    ' 연동환경 초기화
    Private Sub jusolinkExample_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '주소링크 서비스 연동환경 초기화
        jusolinService = New JusolinkService(LinkID, SecretKey)

        btnOpenSearchForm.Select()

    End Sub

    ' 주소링크 잔여포인트 조회
    Private Sub btnGetBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetBalance.Click
        Try
            Dim remainPoint As Double = jusolinService.GetBalance()


            MsgBox("주소링크 잔여포인트 : " + remainPoint.ToString())


        Catch ex As JusolinkException
            MsgBox("오류코드 : " + ex.code.ToString() + vbCrLf + "오류메시지 : " + ex.Message)

        End Try
    End Sub


    '주소링크 조회단가 확인
    Private Sub btnGetUnitCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetUnitCost.Click
        Try
            Dim unitCost As Single = jusolinService.GetUnitCost()


            MsgBox("주소링크 조회단가 : " + unitCost.ToString())


        Catch ex As JusolinkException
            MsgBox("오류코드 : " + ex.code.ToString() + vbCrLf + "오류메시지 : " + ex.Message)

        End Try
    End Sub

    '주소검색 윈도우 출력
    Private Sub btnOpenSearchForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenSearchForm.Click
        jusolinkSearch.Show()

        '검색 윈도우에 주소검색 서비스 인스턴스 전달
        jusolinkSearch.jusolinkService = New JusolinkService(LinkID, SecretKey)
    End Sub


End Class
