using System.IO;
using System.Text;
using System.Web;

namespace Luca.Specs.SpecHelpers
{
    public class HttpContextFactory
    {
        public static HttpContext GetHttpContext(StringBuilder output)
        {
            var request = new HttpRequest("home.asp", "http://localhost/movie/12",
                                          "id=18");
            request.RequestType = "GET";
            request.Headers.Add("Accept", "text/plain");
            return new HttpContext(
                request
                , new HttpResponse(new StringWriter(output)));
        }
    }
}