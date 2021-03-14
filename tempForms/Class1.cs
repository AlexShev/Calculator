using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace tempForms
{
    class Class1 : Panel
    {
        private Button mc = new Button(), mp = new Button(), mm = new Button();
        Class1(int width)
        {
            Height = 30;
            Width = width;

            mc.Size = new System.Drawing.Size(10, 10);
            mc.Location = new System.Drawing.Point(width/2, 15);

            mp.Size = new System.Drawing.Size(10, 10);
            mp.Location = new System.Drawing.Point(width / 2, 15);

            mm.Size = new System.Drawing.Size(10, 10);

        }


    }
}
