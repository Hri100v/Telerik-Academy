using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
        }
    }

//some code from MSDN

    //A    
            /* [HostProtectionAttribute(SecurityAction.LinkDemand, UI = true)]
                public static void WriteLine(
	                string format,
	                Object arg0
                ) */

    //B 
            //public static class Console

    //C
            /*    class TestClass
                  {
                        // Methods, properties, fields, events, delegates 
                        // and nested classes go here.
                  } */

            //...Class members, including nested classes, can be public, protected internal, protected, internal, or private. Members are private by default.



//another example

/*PictureBox pictureBox1 = new PictureBox();
public void CreateBitmapAtRuntime()
{
pictureBox1.Size = new Size(210, 110);
this.Controls.Add(pictureBox1);

Bitmap flag = new Bitmap(200, 100);
Graphics flagGraphics = Graphics.FromImage(flag);
int red = 0;
int white = 11;
while (white <= 100) {
flagGraphics.FillRectangle(Brushes.Red, 0, red, 200,10);
flagGraphics.FillRectangle(Brushes.White, 0, white, 200, 10);
red += 20;
white += 20;
}
pictureBox1.Image = flag;

}*/

//this create bitmap, but need time to fine setUp