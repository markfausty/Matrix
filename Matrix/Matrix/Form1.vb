Public Class Form1

    Dim ctr As Byte = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart_Stop.Click

        Dim btn As Button = btnStart_Stop

        If btn.Text = "Start" Then

            Timer1.Start()
            btn.Text = "Stop"
            btn.BackColor = Color.Red

        ElseIf btn.Text = "Stop" Then

            Timer1.Stop()
            ctr += 0
            btn.Text = "Start"
            btn.BackColor = Color.Green

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ctr = 1 Then

            a.BackColor = Color.Blue
            b.BackColor = Color.Blue
            c.BackColor = Color.Blue
            d.BackColor = Color.Blue
            e1.BackColor = Color.Blue
            f.BackColor = Color.Blue
            g.BackColor = Color.LightGray
            h.BackColor = Color.LightGray
            i.BackColor = Color.LightGray
            j.BackColor = Color.Blue
            k.BackColor = Color.Blue
            l.BackColor = Color.LightGray
            m.BackColor = Color.LightGray
            n.BackColor = Color.LightGray
            o.BackColor = Color.Blue
            p.BackColor = Color.Blue
            q.BackColor = Color.LightGray
            r.BackColor = Color.LightGray
            s.BackColor = Color.LightGray
            t.BackColor = Color.Blue
            u.BackColor = Color.Blue
            v.BackColor = Color.Blue
            w.BackColor = Color.Blue
            x.BackColor = Color.Blue
            y.BackColor = Color.Blue

        ElseIf ctr = 2 Then

            a.BackColor = Color.LightGray
            b.BackColor = Color.LightGray
            c.BackColor = Color.Blue
            d.BackColor = Color.LightGray
            e1.BackColor = Color.LightGray
            f.BackColor = Color.LightGray
            g.BackColor = Color.Blue
            h.BackColor = Color.Blue
            i.BackColor = Color.LightGray
            j.BackColor = Color.LightGray
            k.BackColor = Color.LightGray
            l.BackColor = Color.LightGray
            m.BackColor = Color.Blue
            n.BackColor = Color.LightGray
            o.BackColor = Color.LightGray
            p.BackColor = Color.LightGray
            q.BackColor = Color.LightGray
            r.BackColor = Color.Blue
            s.BackColor = Color.LightGray
            t.BackColor = Color.LightGray
            u.BackColor = Color.LightGray
            v.BackColor = Color.LightGray
            w.BackColor = Color.Blue
            x.BackColor = Color.LightGray
            y.BackColor = Color.LightGray

        ElseIf ctr = 3 Then

            a.BackColor = Color.Blue
            b.BackColor = Color.Blue
            c.BackColor = Color.Blue
            d.BackColor = Color.Blue
            e1.BackColor = Color.Blue
            f.BackColor = Color.LightGray
            g.BackColor = Color.LightGray
            h.BackColor = Color.LightGray
            i.BackColor = Color.LightGray
            j.BackColor = Color.Blue
            k.BackColor = Color.Blue
            l.BackColor = Color.Blue
            m.BackColor = Color.Blue
            n.BackColor = Color.Blue
            o.BackColor = Color.Blue
            p.BackColor = Color.Blue
            q.BackColor = Color.LightGray
            r.BackColor = Color.LightGray
            s.BackColor = Color.LightGray
            t.BackColor = Color.LightGray
            u.BackColor = Color.Blue
            v.BackColor = Color.Blue
            w.BackColor = Color.Blue
            x.BackColor = Color.Blue
            y.BackColor = Color.Blue

        ElseIf ctr = 4 Then

            a.BackColor = Color.Blue
            b.BackColor = Color.Blue
            c.BackColor = Color.Blue
            d.BackColor = Color.Blue
            e1.BackColor = Color.Blue
            f.BackColor = Color.LightGray
            g.BackColor = Color.LightGray
            h.BackColor = Color.LightGray
            i.BackColor = Color.LightGray
            j.BackColor = Color.Blue
            k.BackColor = Color.Blue
            l.BackColor = Color.Blue
            m.BackColor = Color.Blue
            n.BackColor = Color.Blue
            o.BackColor = Color.Blue
            p.BackColor = Color.LightGray
            q.BackColor = Color.LightGray
            r.BackColor = Color.LightGray
            s.BackColor = Color.LightGray
            t.BackColor = Color.Blue
            u.BackColor = Color.Blue
            v.BackColor = Color.Blue
            w.BackColor = Color.Blue
            x.BackColor = Color.Blue
            y.BackColor = Color.Blue

        ElseIf ctr = 5 Then

            a.BackColor = Color.Blue
            b.BackColor = Color.LightGray
            c.BackColor = Color.LightGray
            d.BackColor = Color.LightGray
            e1.BackColor = Color.Blue
            f.BackColor = Color.Blue
            g.BackColor = Color.LightGray
            h.BackColor = Color.LightGray
            i.BackColor = Color.LightGray
            j.BackColor = Color.Blue
            k.BackColor = Color.Blue
            l.BackColor = Color.Blue
            m.BackColor = Color.Blue
            n.BackColor = Color.Blue
            o.BackColor = Color.Blue
            p.BackColor = Color.LightGray
            q.BackColor = Color.LightGray
            r.BackColor = Color.LightGray
            s.BackColor = Color.LightGray
            t.BackColor = Color.Blue
            u.BackColor = Color.LightGray
            v.BackColor = Color.LightGray
            w.BackColor = Color.LightGray
            x.BackColor = Color.LightGray
            y.BackColor = Color.Blue

        ElseIf ctr = 6 Then

            a.BackColor = Color.Blue
            b.BackColor = Color.Blue
            c.BackColor = Color.Blue
            d.BackColor = Color.Blue
            e1.BackColor = Color.Blue
            f.BackColor = Color.Blue
            g.BackColor = Color.LightGray
            h.BackColor = Color.LightGray
            i.BackColor = Color.LightGray
            j.BackColor = Color.LightGray
            k.BackColor = Color.Blue
            l.BackColor = Color.Blue
            m.BackColor = Color.Blue
            n.BackColor = Color.Blue
            o.BackColor = Color.Blue
            p.BackColor = Color.LightGray
            q.BackColor = Color.LightGray
            r.BackColor = Color.LightGray
            s.BackColor = Color.LightGray
            t.BackColor = Color.Blue
            u.BackColor = Color.Blue
            v.BackColor = Color.Blue
            w.BackColor = Color.Blue
            x.BackColor = Color.Blue
            y.BackColor = Color.Blue

        ElseIf ctr = 7 Then

            a.BackColor = Color.Blue
            b.BackColor = Color.Blue
            c.BackColor = Color.Blue
            d.BackColor = Color.Blue
            e1.BackColor = Color.Blue
            f.BackColor = Color.Blue
            g.BackColor = Color.LightGray
            h.BackColor = Color.LightGray
            i.BackColor = Color.LightGray
            j.BackColor = Color.LightGray
            k.BackColor = Color.Blue
            l.BackColor = Color.Blue
            m.BackColor = Color.Blue
            n.BackColor = Color.Blue
            o.BackColor = Color.Blue
            p.BackColor = Color.Blue
            q.BackColor = Color.LightGray
            r.BackColor = Color.LightGray
            s.BackColor = Color.LightGray
            t.BackColor = Color.Blue
            u.BackColor = Color.Blue
            v.BackColor = Color.Blue
            w.BackColor = Color.Blue
            x.BackColor = Color.Blue
            y.BackColor = Color.Blue

        ElseIf ctr = 8 Then

            a.BackColor = Color.Blue
            b.BackColor = Color.Blue
            c.BackColor = Color.Blue
            d.BackColor = Color.Blue
            e1.BackColor = Color.Blue
            f.BackColor = Color.LightGray
            g.BackColor = Color.LightGray
            h.BackColor = Color.LightGray
            i.BackColor = Color.Blue
            j.BackColor = Color.LightGray
            k.BackColor = Color.LightGray
            l.BackColor = Color.LightGray
            m.BackColor = Color.Blue
            n.BackColor = Color.LightGray
            o.BackColor = Color.LightGray
            p.BackColor = Color.LightGray
            q.BackColor = Color.LightGray
            r.BackColor = Color.Blue
            s.BackColor = Color.LightGray
            t.BackColor = Color.LightGray
            u.BackColor = Color.LightGray
            v.BackColor = Color.LightGray
            w.BackColor = Color.Blue
            x.BackColor = Color.LightGray
            y.BackColor = Color.LightGray

        ElseIf ctr = 9 Then

            a.BackColor = Color.Blue
            b.BackColor = Color.Blue
            c.BackColor = Color.Blue
            d.BackColor = Color.Blue
            e1.BackColor = Color.Blue
            f.BackColor = Color.Blue
            g.BackColor = Color.LightGray
            h.BackColor = Color.LightGray
            i.BackColor = Color.LightGray
            j.BackColor = Color.Blue
            k.BackColor = Color.Blue
            l.BackColor = Color.Blue
            m.BackColor = Color.Blue
            n.BackColor = Color.Blue
            o.BackColor = Color.Blue
            p.BackColor = Color.Blue
            q.BackColor = Color.LightGray
            r.BackColor = Color.LightGray
            s.BackColor = Color.LightGray
            t.BackColor = Color.Blue
            u.BackColor = Color.Blue
            v.BackColor = Color.Blue
            w.BackColor = Color.Blue
            x.BackColor = Color.Blue
            y.BackColor = Color.Blue

        ElseIf ctr = 10 Then

            a.BackColor = Color.Blue
            b.BackColor = Color.Blue
            c.BackColor = Color.Blue
            d.BackColor = Color.Blue
            e1.BackColor = Color.Blue
            f.BackColor = Color.Blue
            g.BackColor = Color.LightGray
            h.BackColor = Color.LightGray
            i.BackColor = Color.LightGray
            j.BackColor = Color.Blue
            k.BackColor = Color.Blue
            l.BackColor = Color.Blue
            m.BackColor = Color.Blue
            n.BackColor = Color.Blue
            o.BackColor = Color.Blue
            p.BackColor = Color.LightGray
            q.BackColor = Color.LightGray
            r.BackColor = Color.LightGray
            s.BackColor = Color.LightGray
            t.BackColor = Color.Blue
            u.BackColor = Color.Blue
            v.BackColor = Color.Blue
            w.BackColor = Color.Blue
            x.BackColor = Color.Blue
            y.BackColor = Color.Blue

            ctr = 0

        End If

        ctr += 1

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
