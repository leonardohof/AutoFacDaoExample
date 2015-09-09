using Core.Services;
using System;

namespace WebApplication2
{
    public partial class ExamplePage : System.Web.UI.Page
    {
        // A mágica vai acontecer nessa propriedade
        public IExampleService ExampleService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            grid.DataSource = this.ExampleService.GetAll();
            grid.DataBind();
        }
    }
}