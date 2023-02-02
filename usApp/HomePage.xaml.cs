namespace usApp;

public partial class HomePage : ContentPage
{
    public int count = 0;
    public HomePage()
    {
        InitializeComponent();
    }
    private void Tomatobtn(object sender, EventArgs e)
    {
        try
        {

            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Tomato;
            Tomato.Text = $"{Convert.ToString(namelbl.Text[count])}";
            count++;
        }

        catch (System.IndexOutOfRangeException)
        {

            count = 0;
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Tomato;
            Tomato.Text = $"{Convert.ToString(namelbl.Text[count])}";
            count++;

        }
        catch
        {
            count = 0;
            namelbl.Text = "Hali hechnima kiritmadingiz";
        }

    }
    private void Greenbtn(object sender, EventArgs e)
    {
        try
        {
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Green;
            Green.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch (System.IndexOutOfRangeException)
        {
            count = 0;
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Green;
            Green.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch
        {
            count = 0;
            namelbl.Text = "Hali hechnima kiritmadingiz";
        }


    }
    private void Brownbtn(object sender, EventArgs e)
    {
        try
        {
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Brown;
            Brown.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch (System.IndexOutOfRangeException)
        {
            count = 0;
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Brown;
            Brown.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch
        {
            count = 0;
            namelbl.Text = "Hali hechnima kiritmadingiz";
        }

    }
    private void Yellowbtn(object sender, EventArgs e)
    {
        try
        {

            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Yellow;
            Yellow.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch (System.IndexOutOfRangeException)
        {
            count = 0;
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Yellow;
            Yellow.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch
        {
            count = 0;
            namelbl.Text = "Hali hechnima kiritmadingiz";
        }

    }
    private void Orangebtn(object sender, EventArgs e)
    {
        try
        {
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Orange;
            Orange.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch (System.IndexOutOfRangeException)
        {
            count = 0;
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Orange;
            Orange.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch
        {
            count = 0;
            namelbl.Text = "Hali hechnima kiritmadingiz";
        }

    }
    private void Redbtn(object sender, EventArgs e)
    {
        try
        {
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Red;
            Red.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch (System.IndexOutOfRangeException)
        {
            count = 0;
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Red;
            Red.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch
        {
            count = 0;
            namelbl.Text = "Hali hechnima kiritmadingiz";
        }

    }
    private void Pinkbtn(object sender, EventArgs e)
    {
        try
        {
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Pink;
            Pink.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch (System.IndexOutOfRangeException)
        {
            count = 0;
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Pink;
            Pink.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch
        {
            count = 0;
            namelbl.Text = "Hali hechnima kiritmadingiz";
        }

    }
    private void Purplebtn(object sender, EventArgs e)
    {
        try
        {
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Purple;
            Purple.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch (System.IndexOutOfRangeException)
        {
            count = 0;
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Purple;
            Purple.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch
        {
            count = 0;
            namelbl.Text = "Hali hechnima kiritmadingiz";
        }

    }
    private void Bluebtn(object sender, EventArgs e)
    {
        try
        {
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Blue;
            Blue.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch (System.IndexOutOfRangeException)
        {
            count = 0;
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Blue;
            Blue.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch
        {
            count = 0;
            namelbl.Text = "Hali hechnima kiritmadingiz";
        }

    }
    private void Blackbtn(object sender, EventArgs e)
    {
        try
        {
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Black;
            Black.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch (System.IndexOutOfRangeException)
        {
            count = 0;
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Black;
            Black.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch
        {
            count = 0;
            namelbl.Text = "Hali hechnima kiritmadingiz";
        }

    }
    private void Chocolatebtn(object sender, EventArgs e)
    {
        try
        {
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Chocolate;
            Chocolate.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch (System.IndexOutOfRangeException)
        {
            count = 0;
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Chocolate;
            Chocolate.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch
        {
            count = 0;
            namelbl.Text = "Hali hechnima kiritmadingiz";
        }

    }
    private void Greybtn(object sender, EventArgs e)
    {
        try
        {

            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Grey;
            Grey.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch (System.IndexOutOfRangeException)
        {
            count = 0;
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Grey;
            Grey.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch
        {
            count = 0;
            namelbl.Text = "Hali hechnima kiritmadingiz";
        }
    }
    private void Limebtn(object sender, EventArgs e)
    {
        try
        {
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Lime;
            Lime.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch (System.IndexOutOfRangeException)
        {
            count = 0;
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Lime;
            Lime.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch
        {
            count = 0;
            namelbl.Text = "Hali hechnima kiritmadingiz";
        }

    }
    private void Olivebtn(object sender, EventArgs e)
    {
        try
        {
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Olive;
            Olive.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch (System.IndexOutOfRangeException)
        {
            count = 0;
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.Olive;
            Olive.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch
        {
            count = 0;
            namelbl.Text = "Hali hechnima kiritmadingiz";
        }

    }
    private void DarkKhakibtn(object sender, EventArgs e)
    {
        try
        {
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.DarkKhaki;
            DarkKhaki.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch (System.IndexOutOfRangeException)
        {
            count = 0;
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.DarkKhaki;
            DarkKhaki.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch
        {
            count = 0;
            namelbl.Text = "Hali hechnima kiritmadingiz";
        }

    }
    private void DeepSkyBluebtn(object sender, EventArgs e)
    {
        try
        {
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.DeepSkyBlue;
            DeepSkyBlue.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch (System.IndexOutOfRangeException)
        {
            count = 0;
            namelbl.Text = userentry.Text;
            namelbl.TextColor = Colors.DeepSkyBlue;
            DeepSkyBlue.Text = Convert.ToString(namelbl.Text[count]);
            count++;
        }
        catch
        {
            count = 0;
            namelbl.Text = "Hali hechnima kiritmadingiz";
        }

    }
}