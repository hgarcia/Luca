using System.Collections.Specialized;
using System.IO;
using System.Text;
using System.Web;

namespace Luca.Specs.SpecHelpers
{
    public static class HttpContextFactory
    {
        public static HttpContext GetHttpContext()
        {
            return new HttpMock("home.asp", "http://localhost/movie/12", "id=18")
                              {
                                  Response = new HttpResponse(new StringWriter(new StringBuilder())),
                                  Headers = new NameValueCollection { { "Accept","text/plain"} }
                              }
                              .GetContext();
        }
    }
}