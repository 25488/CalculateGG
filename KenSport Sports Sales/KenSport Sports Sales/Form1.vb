Public Class Form1

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCheckOut.Click
        Dim FootBalls As Integer
        Dim BasketBalls As Integer
        Dim VolleyBalls As Integer
        Dim TotalItem As Integer
        

        FootBalls = TxtFootBalls.Text
        BasketBalls = TxtBasketBalls.Text
        VolleyBalls = TxtVolleyBalls.Text
        TotalItem = FootBalls + BasketBalls + VolleyBalls
        TxtTotalItems.Text = TotalItem.ToString

        
        Dim KshA As Integer
        Dim KshB As Integer
        Dim KshC As Integer
        Dim SubTotal As Integer
        Dim Tax As Double
        Dim TotalSales As Double
        KshA = FootBalls * 44
        TxtKshA.Text = KshA.ToString()
        KshB = BasketBalls * 49
        TxtKshB.Text = KshB.ToString()
        KshC = VolleyBalls * 39
        TxtKshC.Text = KshC.ToString()
        SubTotal = KshA + KshB + KshC
        TxtSubTotal.Text = SubTotal.ToString()
        Tax = SubTotal * 0.05
        TxtTax.Text = Tax.ToString()
        TotalSales = SubTotal - Tax
        TxtTotalSales.Text = TotalSales.ToString()




    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub TxtKshA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtKshA.TextChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TxtFootBalls.Clear()
        TxtBasketBalls.Clear()
        TxtVolleyBalls.Clear()
        TxtTotalItems.Clear()
    End Sub
End Class
