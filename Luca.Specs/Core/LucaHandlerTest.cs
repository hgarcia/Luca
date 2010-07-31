using System.IO;
using System.Text;
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
                                            _sb = new StringBuilder();
                                            var request = new HttpRequest("home.asp", "http://localhost/movie/12",
                                                                          "id=18");
                                            request.RequestType = "GET";
                                            request.ContentType = "text/plain";
                                            _context = new HttpContext(
                                                request
                                                , new HttpResponse(new StringWriter(_sb)));
                                        };

        Because the_handler_is_called = () => _handler.ProcessRequest(_context);
        private It should_return_a_string = () => _sb.ToString()
            .ShouldContain("hello cruel world");

        private static LucaHandler _handler;

        private static HttpContext _context;
        private static StringBuilder _sb;
    }
}
