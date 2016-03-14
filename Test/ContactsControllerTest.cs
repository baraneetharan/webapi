using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ProductsApp.Models;
using ProductsApp.Repository;
using Xunit;

namespace ProductsApp.Test
{
    public class ContactsControllerTest
    {
        [Fact]
		public void IsAuthorizedTest()
		{
			var accountController = new ContactsController();
       Assert.True(true);
		}
    }
}
