Public Class Form1
    Dim check As String

    Private Sub lyrics_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lyrics.TextChanged
        Dim lyr As String
        Dim ic As Integer
        Dim tmp As Integer
        rna.Text = ""
        dna.Text = ""

        lyr = lyrics.Text
        check = lyrics.Text

        'RNA Values
        Dim codonA() As String = {" ", "CGA ", "CGG ", "CGT ", "CGC "}
        Dim codonB = " [b] "
        Dim codonC() As String = {" ", "ACA ", "ACG "}
        Dim codonD() As String = {" ", "CTA ", "CTG "}
        Dim codonE() As String = {" ", "CTT ", "CTC "}
        Dim codonF() As String = {" ", "AAA ", "AAG "}
        Dim codonG() As String = {" ", "CCA ", "CCG ", "CCT ", "CCC "}
        Dim codonH() As String = {" ", "GTA ", "GTG "}
        Dim codonI() As String = {" ", "TAA ", "TAG ", "TAT "}
        Dim codonJ = " [j] "
        Dim codonK() As String = {" ", "TTT ", "TTC "}
        Dim codonL() As String = {" ", "AAT ", "AAC ", "GAA ", "GAG ", "GAT ", "GAC "}
        Dim codonM = "TAC "
        Dim codonN() As String = {" ", "TTA ", "TTG "}
        Dim codonO = " [o] "
        Dim codonP() As String = {" ", "GGA ", "GGG ", "GGT ", "GGC "}
        Dim codonQ() As String = {" ", "GTT ", "GTC "}
        Dim codonR() As String = {" ", "GCA ", "GCG ", "GCT ", "GCC ", "TCT ", "TCC "}
        Dim codonS() As String = {" ", "AGA ", "AGG ", "AGT ", "AGC ", "TCA ", "TCG "}
        Dim codonT() As String = {" ", "TGA ", "TGG ", "TGT ", "TGC "}
        Dim codonU = " [u] "
        Dim codonV() As String = {" ", "CAA ", "CAG ", "CAT ", "CAC "}
        Dim codonW = "ACC "
        Dim codonX = " [x] "
        Dim codonY() As String = {" ", "ATA ", "ATG "}
        Dim codonZ = " [z] "
        Dim codonSS() As String = {" ", "ATT ", "ATC ", "ACT "}

        'DNA Values

        Dim codonA_() As String = {" ", "GCU ", "GCC ", "GCA ", "GCG "}
        Dim codonC_() As String = {" ", "UGU ", "UGC "}
        Dim codonD_() As String = {" ", "GAU ", "GAC "}
        Dim codonE_() As String = {" ", "GAA ", "GAG "}
        Dim codonF_() As String = {" ", "UUU ", "UUC "}
        Dim codonG_() As String = {" ", "GGU ", "GGC ", "GGA ", "GGG "}
        Dim codonH_() As String = {" ", "CAU ", "CAC "}
        Dim codonI_() As String = {" ", "AUU ", "AUC ", "AUA "}
        Dim codonK_() As String = {" ", "AAA ", "AAG "}
        Dim codonL_() As String = {" ", "UUA ", "UUG ", "CUU ", "CUC ", "CUA ", "CUG "}
        Dim codonM_ = "AUG "
        Dim codonN_() As String = {" ", "AAU ", "AAC "}
        Dim codonP_() As String = {" ", "CCU ", "CCC ", "CCA ", "CCG "}
        Dim codonQ_() As String = {" ", "CAA ", "CAG "}
        Dim codonR_() As String = {" ", "CGU ", "CGC ", "CGA ", "CGG ", "AGA ", "AGG "}
        Dim codonS_() As String = {" ", "UCU ", "UCC ", "UCA ", "UCG ", "AGU ", "AGC "}
        Dim codonT_() As String = {" ", "ACU ", "ACC ", "ACA ", "ACG "}
        Dim codonV_() As String = {" ", "GUU ", "GUC ", "GUA ", "GUG "}
        Dim codonW_ = "UGG "
        Dim codonY_() As String = {" ", "UAU ", "UAC "}
        Dim codonSS_() As String = {" ", "UAA ", "UAG ", "UGA "}


        'Special Characters
        Dim codonSSS As String = " [']  "
        Dim codonQM As String = " [?]  "
        Dim codonQT As String = " [,]  "
        Dim codonHT As String = " [!]  "
        Dim codonPoint As String = " [.]  "
        Dim codonHY As String = " [-]  "

        For ic = 0 To lyr.Length - 1

            'UCAG VALUES
            If lyr.Chars(ic).ToString.ToUpper = "A" Then
                tmp = CInt(Math.Ceiling(Rnd() * 4))
                rna.Text = rna.Text + codonA(tmp)
                dna.Text = dna.Text + codonA_(tmp)
            End If

            If lyr.Chars(ic).ToString.ToUpper = "B" Then
                rna.Text = rna.Text + codonB
                dna.Text = dna.Text + codonB
            End If

            If lyr.Chars(ic).ToString.ToUpper = "C" Then
                tmp = CInt(Math.Ceiling(Rnd() * 2))
                rna.Text = rna.Text + codonC(tmp)
                dna.Text = dna.Text + codonC_(tmp)
            End If

            If lyr.Chars(ic).ToString.ToUpper = "D" Then
                tmp = CInt(Math.Ceiling(Rnd() * 2))
                rna.Text = rna.Text + codonD(tmp)
                dna.Text = dna.Text + codonD_(tmp)
            End If

            If lyr.Chars(ic).ToString.ToUpper = "E" Then
                tmp = CInt(Math.Ceiling(Rnd() * 2))
                rna.Text = rna.Text + codonE(tmp)
                dna.Text = dna.Text + codonE_(tmp)
            End If

            If lyr.Chars(ic).ToString.ToUpper = "F" Then
                tmp = CInt(Math.Ceiling(Rnd() * 2))
                rna.Text = rna.Text + codonF(tmp)
                dna.Text = dna.Text + codonF_(tmp)
            End If

            If lyr.Chars(ic).ToString.ToUpper = "G" Then
                tmp = CInt(Math.Ceiling(Rnd() * 4))
                rna.Text = rna.Text + codonG(tmp)
                dna.Text = dna.Text + codonG_(tmp)
            End If

            If lyr.Chars(ic).ToString.ToUpper = "H" Then
                tmp = CInt(Math.Ceiling(Rnd() * 2))
                rna.Text = rna.Text + codonH(tmp)
                dna.Text = dna.Text + codonH_(tmp)
            End If

            If lyr.Chars(ic).ToString.ToUpper = "I" Then
                tmp = CInt(Math.Ceiling(Rnd() * 3))
                rna.Text = rna.Text + codonI(tmp)
                dna.Text = dna.Text + codonI_(tmp)
            End If

            If lyr.Chars(ic).ToString.ToUpper = "J" Then
                rna.Text = rna.Text + codonJ
                dna.Text = dna.Text + codonJ
            End If

            If lyr.Chars(ic).ToString.ToUpper = "K" Then
                tmp = CInt(Math.Ceiling(Rnd() * 2))
                rna.Text = rna.Text + codonK(tmp)
                dna.Text = dna.Text + codonK_(tmp)
            End If

            If lyr.Chars(ic).ToString.ToUpper = "L" Then
                tmp = CInt(Math.Ceiling(Rnd() * 6))
                rna.Text = rna.Text + codonL(tmp)
                dna.Text = dna.Text + codonL_(tmp)
            End If

            If lyr.Chars(ic).ToString.ToUpper = "M" Then
                rna.Text = rna.Text + codonM
                dna.Text = dna.Text + codonM_

            End If

            If lyr.Chars(ic).ToString.ToUpper = "N" Then
                tmp = CInt(Math.Ceiling(Rnd() * 2))
                rna.Text = rna.Text + codonN(tmp)
                dna.Text = dna.Text + codonN_(tmp)
            End If

            If lyr.Chars(ic).ToString.ToUpper = "O" Then
                rna.Text = rna.Text + codonO
                dna.Text = dna.Text + codonO
            End If

            If lyr.Chars(ic).ToString.ToUpper = "P" Then
                tmp = CInt(Math.Ceiling(Rnd() * 4))
                rna.Text = rna.Text + codonP(tmp)
                dna.Text = dna.Text + codonP_(tmp)
            End If

            If lyr.Chars(ic).ToString.ToUpper = "Q" Then
                tmp = CInt(Math.Ceiling(Rnd() * 2))
                rna.Text = rna.Text + codonQ(tmp)
                dna.Text = dna.Text + codonQ_(tmp)
            End If

            If lyr.Chars(ic).ToString.ToUpper = "R" Then
                tmp = CInt(Math.Ceiling(Rnd() * 6))
                rna.Text = rna.Text + codonR(tmp)
                dna.Text = dna.Text + codonR_(tmp)
            End If

            If lyr.Chars(ic).ToString.ToUpper = "S" Then
                tmp = CInt(Math.Ceiling(Rnd() * 6))
                rna.Text = rna.Text + codonS(tmp)
                dna.Text = dna.Text + codonS_(tmp)
            End If

            If lyr.Chars(ic).ToString.ToUpper = "T" Then
                tmp = CInt(Math.Ceiling(Rnd() * 4))
                rna.Text = rna.Text + codonT(tmp)
                dna.Text = dna.Text + codonT_(tmp)
            End If

            If lyr.Chars(ic).ToString.ToUpper = "U" Then
                rna.Text = rna.Text + codonU
                dna.Text = dna.Text + codonU

            End If

            If lyr.Chars(ic).ToString.ToUpper = "V" Then
                tmp = CInt(Math.Ceiling(Rnd() * 4))
                rna.Text = rna.Text + codonV(tmp)
                dna.Text = dna.Text + codonV_(tmp)
            End If

            If lyr.Chars(ic).ToString.ToUpper = "W" Then
                rna.Text = rna.Text + codonW
                dna.Text = dna.Text + codonW_
            End If

            If lyr.Chars(ic).ToString.ToUpper = "X" Then
                rna.Text = rna.Text + codonX
                dna.Text = dna.Text + codonX

            End If

            If lyr.Chars(ic).ToString.ToUpper = "Y" Then
                tmp = CInt(Math.Ceiling(Rnd() * 2))
                rna.Text = rna.Text + codonY(tmp)
                dna.Text = dna.Text + codonY_(tmp)
            End If

            If lyr.Chars(ic).ToString.ToUpper = "Z" Then
                rna.Text = rna.Text + codonZ
                dna.Text = dna.Text + codonZ

            End If

            If lyr.Chars(ic).ToString.ToUpper = " " Then
                tmp = CInt(Math.Ceiling(Rnd() * 3))
                rna.Text = rna.Text + codonSS(tmp)
                dna.Text = dna.Text + codonSS_(tmp)
            End If




            'special characters
            If lyr.Chars(ic).ToString.ToUpper = "'" Then
                rna.Text = rna.Text + codonSSS
                dna.Text = dna.Text + codonSSS
            End If
            If lyr.Chars(ic).ToString.ToUpper = "-" Then
                rna.Text = rna.Text + codonHY
                dna.Text = dna.Text + codonHY
            End If

            If lyr.Chars(ic).ToString.ToUpper = "?" Then
                rna.Text = rna.Text + codonQM
                dna.Text = dna.Text + codonQM
            End If

            If lyr.Chars(ic).ToString.ToUpper = "," Then
                rna.Text = rna.Text + codonQT
                dna.Text = dna.Text + codonQT
            End If

            If lyr.Chars(ic).ToString.ToUpper = "!" Then
                rna.Text = rna.Text + codonHT
                dna.Text = dna.Text + codonHT
            End If

            If lyr.Chars(ic).ToString.ToUpper = "." Then
                rna.Text = rna.Text + codonPoint
                dna.Text = dna.Text + codonPoint

            End If
            If IsNumeric(lyr.Chars(ic)) = True Then
                rna.Text = rna.Text + "[" + lyr.Chars(ic) + "] "
                dna.Text = dna.Text + "[" + lyr.Chars(ic) + "] "

            End If

        Next
        Label3.Text = lyrics.TextLength
        Label5.Text = rna.TextLength
        Label6.Text = dna.TextLength

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


End Class
