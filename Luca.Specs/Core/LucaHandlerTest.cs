using System.IO;
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
        private It should_return_a_string = () =>
                                                {
                                                    var response = _context.Response.Output.ToString();
                                                    response.ShouldContain("hello cruel world18");
                                                };

        private static LucaHandler _handler;
        private static HttpContext _context;
    }

    public class InterpretARealPayload
    {
        private Establish context = () =>
                                        {
                                            _payload = File.ReadAllText("payload.txt",Encoding.ASCII);
    //                                        _jint = new JintEngine();
                                        };

      //  private Because we_pass_the_the_payload = () => _jint.SetDebugMode(true);

        private It should_work_as_expected = () =>
                                                 {
        //                                             var response = _jint.Run(_payload);
        //                                             var content = response.ToString();
                                                 };
        private static  string _payload;
        //private static JintEngine _jint;
    }
}
