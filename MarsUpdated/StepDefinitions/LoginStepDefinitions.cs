using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsUpdated;
[Binding]
public class LoginStepDefinitions
{
    [Given(@"The user is logged in to portal")]
    public void GivenTheUserIsLoggedInToPortal()
    {
        LoginToPortal LTP = new LoginToPortal();
        LTP.CreateLogin();
    }
}
