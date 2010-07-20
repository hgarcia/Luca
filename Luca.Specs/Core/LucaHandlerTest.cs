using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
                                            _context = new HttpContext(
                                                new HttpRequest("home.asp","http://localhost/home","qs=my")
                                                , new HttpResponse(new StringWriter()));
                                        };

        private It test = () =>
                              {
                                  _handler.ProcessRequest(_context);
                              };

        private static LucaHandler _handler;

        private static HttpContext _context;
    }
}
