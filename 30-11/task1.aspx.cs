using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _30_11
{
    public partial class task1 : System.Web.UI.Page
    {

        class math { 
        public int sum(int x,int y)
            {
                return x + y;

            }
            public int m(int x, int y)
            {
                return x - y;

            }
            public int um(int x, int y)
            {
                return x * y;

            }
            public int su(int x, int y)
            {
                return x / y;

            }


        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            math sum1= new math();
          int result=  sum1.sum(Convert.ToInt32(x.Text), Convert.ToInt32(y.Text));
            Label1.Text = Convert.ToString( result);
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            math sum2 = new math();
            int result = sum2.m(Convert.ToInt32(x.Text), Convert.ToInt32(y.Text));
            Label1.Text = Convert.ToString(result);
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            math sum1 = new math();
            int result = sum1.um(Convert.ToInt32(x.Text), Convert.ToInt32(y.Text));
            Label1.Text = Convert.ToString(result);
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            math sum1 = new math();
            int result = sum1.su(Convert.ToInt32(x.Text), Convert.ToInt32(y.Text));
            Label1.Text = Convert.ToString(result);
        }

        protected void x_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}