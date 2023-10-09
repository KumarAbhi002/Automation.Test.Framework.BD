using BD.ASA.Pages.PageInterface;
using BD.ASA.Pages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.ASA.Pages
{
    public class PageRepository
    {
        public ILoginPage loginPage;


        public PageRepository()
        {
            loginPage = new LoginPage();
        }

    }
}
