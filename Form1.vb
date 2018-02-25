Public Class Form1
	Public st As String
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Button2.Enabled = False
		DataGridView1.Rows.Clear()
		Dim setx, sety As Integer
		Dim encontrado As Boolean
		encontrado = False
		setx = 1
		sety = 1
		OpenFileDialog1.ShowDialog()
		PictureBox1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
		PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
		Dim b As Bitmap = Me.PictureBox1.BackgroundImage
		For setx = 1 To (PictureBox1.BackgroundImage.Width - 1) Step (PictureBox1.BackgroundImage.Width / 25)
			For sety = 1 To (PictureBox1.BackgroundImage.Height - 1) Step (PictureBox1.BackgroundImage.Height / 25)
				encontrado = False
				For a = 0 To DataGridView1.Rows.Count - 1
					Application.DoEvents()
					If DataGridView1.Rows(a).Cells(0).Value = b.GetPixel(setx, sety) Then
						DataGridView1.Rows(a).Cells(1).Value = DataGridView1.Rows(a).Cells(1).Value + 1
						encontrado = True
					End If
				Next
				If encontrado = False Then
					DataGridView1.Rows.Add(b.GetPixel(setx, sety), 1)
				End If
			Next
		Next
		setcolor()
	End Sub

	Sub setcolor()
		Button2.Enabled = True
		Dim shcolor As String()
		Dim fshcolor As String
		Pre1.BackColor = DataGridView1.Rows(0).Cells(0).Value
		shcolor = Split((DataGridView1.Rows(0).Cells(0).Value.ToString), "=")
		fshcolor = "R" & Replace(shcolor(2), ", G", "") & "G" & Replace(shcolor(3), ", B", "") & "B" & Replace(shcolor(4), "]", "")
		Pre1.Text = fshcolor

		Pre2.BackColor = DataGridView1.Rows(2).Cells(0).Value
		shcolor = Split((DataGridView1.Rows(2).Cells(0).Value.ToString), "=")
		fshcolor = "R" & Replace(shcolor(2), ", G", "") & "G" & Replace(shcolor(3), ", B", "") & "B" & Replace(shcolor(4), "]", "")
		Pre2.Text = fshcolor

		Pre3.BackColor = DataGridView1.Rows(4).Cells(0).Value
		shcolor = Split((DataGridView1.Rows(4).Cells(0).Value.ToString), "=")
		fshcolor = "R" & Replace(shcolor(2), ", G", "") & "G" & Replace(shcolor(3), ", B", "") & "B" & Replace(shcolor(4), "]", "")
		Pre3.Text = fshcolor

		Pre4.BackColor = DataGridView1.Rows(6).Cells(0).Value
		shcolor = Split((DataGridView1.Rows(6).Cells(0).Value.ToString), "=")
		fshcolor = "R" & Replace(shcolor(2), ", G", "") & "G" & Replace(shcolor(3), ", B", "") & "B" & Replace(shcolor(4), "]", "")
		Pre4.Text = fshcolor

		Pre5.BackColor = DataGridView1.Rows(8).Cells(0).Value
		shcolor = Split((DataGridView1.Rows(8).Cells(0).Value.ToString), "=")
		fshcolor = "R" & Replace(shcolor(2), ", G", "") & "G" & Replace(shcolor(3), ", B", "") & "B" & Replace(shcolor(4), "]", "")
		Pre5.Text = fshcolor
	End Sub

	Private Sub DataGridView1_Sorted(sender As Object, e As EventArgs) Handles DataGridView1.Sorted
		setcolor()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		If st = "Up" Then
			DataGridView1.Sort(DataGridView1.Columns(1), SortOrder.None)
			st = "down"
		Else
			DataGridView1.Sort(DataGridView1.Columns(1), SortOrder.Ascending)
			st = "Up"
		End If
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
		st = "up"
		Button2.Enabled = False
	End Sub
End Class
