Public Class jusolinkSearch
    
    '주소링크 서비스 변수 (변수는 이전 폼에서 생성해서 전달됨)
    Public jusolinkService As JusolinkService

    ' 현제 페이지수 표시를 위한 전역변수
    Private pageNum As Integer

    ' 전체 페이지수 표시를 위한 전역변수
    Private totalPage As Integer

    'LIstView Item의 높이조절을 위한 ImageList 선언, Item 높이설정은 jusolinkSearch_Load 참조
    Private imageList1 As ImageList

    '폼 로드, ListView 높이 조정
    Private Sub jusolinkSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '주소정보 레코드의 높이조정을 위해 높이값을 가진 imageList 추가
        imageList1 = New ImageList()
        imageList1.ImageSize = New Size(1, 21)
        listView1.SmallImageList = imageList1

    End Sub

    '주소 검색버튼 클릭 이벤트 처리
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim searchInfoList As SearchResult
        Dim perPage As Integer
        Dim noSuggest As Boolean
        Dim noDiffer As Boolean
        Dim relatedJibun As String

        txtIndex.Focus()

        ' 페이지당 목록개수
        perPage = 20

        ' 차등검색 끄기옵션
        noDiffer = False

        ' 수정제시어 끄기 옵션
        noSuggest = False


        ' 페이지 번호
        If pageNum <= 0 Then
            pageNum = 1
        End If

        Try
            '검색 호출
            searchInfoList = jusolinkService.search(txtIndex.Text, pageNum, perPage, noDiffer, noSuggest)

            'listView 초기화
            listView1.Items.Clear()

            ' 검색결과가 1건이상 존재하는 경우처리
            If searchInfoList.numFound > 0 Then

                '검색결과 - 페이지 번호
                pageNum = searchInfoList.page
                txtPageNum.Text = searchInfoList.page

                '검색결과 - 전체 페이지수
                totalPage = searchInfoList.totalPage
                txtTotalPage.Text = totalPage


                Dim jusoInfos As List(Of JusoInfo) = searchInfoList.juso


                'listView 출력을 위한 반복문 처리
                For i As Integer = 0 To jusoInfos.Count - 1

                    '구우편번호
                    Dim jusoToItem As New ListViewItem(jusoInfos.Item(i).zipcode)

                    '새우편번호
                    jusoToItem.SubItems.Add(jusoInfos.Item(i).sectionNum)

                    '도로명주소
                    jusoToItem.SubItems.Add(jusoInfos.Item(i).roadAddr1)

                    '도로명주소(부가정보)
                    jusoToItem.SubItems.Add(jusoInfos.Item(i).roadAddr2)

                    '지번주소
                    jusoToItem.SubItems.Add(jusoInfos.Item(i).jibunAddr)

                    '지번주소(관련지번주소목록)
                    If jusoInfos.Item(i).relatedJibun IsNot Nothing Then
                        relatedJibun = ""

                        For Each jibun As String In jusoInfos.Item(i).relatedJibun
                            relatedJibun += jibun + ", "
                        Next

                        jusoToItem.SubItems.Add(relatedJibun)
                    End If

                    '리스트뷰 추가
                    listView1.Items.Add(jusoToItem)

                Next '반복문 끝

                '검색결과가 0건인 경우 처리
            Else
                txtPageNum.Text = ""
                txtTotalPage.Text = ""
                MsgBox("조회된 주소정보가 존재하지 않습니다.")

            End If '조건문 끝

        Catch ex As JusolinkException
            MsgBox("오류코드 : " + ex.code.ToString() + vbCrLf + "오류메시지 : " + ex.Message)

        End Try



    End Sub

    '다음페이지 클릭 이벤트
    Private Sub btnNextPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextPage.Click
        If pageNum < totalPage Then
            pageNum = pageNum + 1
            btnSearch.PerformClick()
        Else
            MsgBox("마지막 페이지 입니다.")
        End If
        
    End Sub

    '이전페이지 클릭 이벤트
    Private Sub btnPrevPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevPage.Click
        If pageNum > 1 Then
            pageNum = pageNum - 1
            btnSearch.PerformClick()
        Else
            MsgBox("첫 페이지 입니다.")
        End If

    End Sub

    '검색어 수정시 주소검색 요청 페이지번호는 1로 초기화
    Private Sub txtIndex_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIndex.TextChanged
        pageNum = 1
    End Sub

    '검색어 입력중 엔터 이벤트 처리
    Private Sub txtIndex_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIndex.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call btnSearch.PerformClick()
        End If
    End Sub

    '주소목록 선택 이벤트
    Private Sub listView1_ItemSelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles listView1.ItemSelectionChanged

        '다음 폼에 [구우편번호] 전달
        jusolinkTypeSelect.zipcode = listView1.SelectedItems.Item(0).Text

        '다음 폼에 [새우편번호] 전달
        jusolinkTypeSelect.sectionNum = listView1.SelectedItems.Item(0).SubItems(1).Text

        '다음 폼에 [도로명주소] 전달
        jusolinkTypeSelect.roadAddr = listView1.SelectedItems.Item(0).SubItems(2).Text

        '다음 폼에 [도로명주소-부가정보] 전달
        jusolinkTypeSelect.roadAddr2 = listView1.SelectedItems.Item(0).SubItems(3).Text

        '다음 폼에 [지번주소] 전달
        jusolinkTypeSelect.jibunAddr = listView1.SelectedItems.Item(0).SubItems(4).Text

        '상세주소 입력폼 
        jusolinkTypeSelect.Show()
        jusolinkTypeSelect.txtRoadDetail.Focus()

        '현재 폼 종료
        Me.Dispose()
    End Sub
End Class