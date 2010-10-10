using System.Text;
using Luca.Specs.SpecHelpers;
using Machine.Specifications;
using Luca.Core;
using System.Web;

namespace Luca.Specs.Core
{
    public class LucaHandlerTest
    {
        private Establish context = () =>
                                        {
                                            _handler = new LucaHandler();
                                            _context = HttpContextFactory.GetHttpContext();
                                        };

        Because the_handler_is_called = () => _handler.ProcessRequest(_context);
        private It should_return_a_string = () => _context.Response.Output.ToString()
            .ShouldContain("hello cruel world18");

        private static LucaHandler _handler;
        private static HttpContext _context;
    }
}
