using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CompFix.Pages
{
    public partial class feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnSendComment_Click(object sender, EventArgs e)
        {
            using (RemontPkDataContext context=new RemontPkDataContext())
            {
                var feedback=new Feedback();
                feedback.DateMessage = DateTime.Now;
                feedback.Message = tbMessage.Text;
                context.Feedbacks.InsertOnSubmit(feedback);
                context.SubmitChanges();
            }
        }
    }
}