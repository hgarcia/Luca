using System.Collections.Specialized;
using System.Web;
using Machine.Specifications;
using Luca.Core;

namespace Luca.Specs.Core
{
    [Subject("LucaRequest expose headers, Qs, Form, Cookies and Sessions")]
    public class LucaRequestWrappsProperties
    {
        private Establish context = () =>
                                        {
                                            _request = new LucaRequest(
                                                new HttpRequest(
                                                    "index", 
                                                    "http://localhost", 
                                                    "Id=12&Name=Inception&CategId=65&Token=123456789")
                                                    );
                                            _serializer =  new NameValueToJsonSerializer();
                                        };

        private It should_expose_qs = () => { _request.ToJson(_serializer).ShouldContain("query"); };
        private static ILucaRequest _request;
        private static NameValueToJsonSerializer _serializer;
    }

    [Subject("Serialize a name value collection to a Json object")]
    public class NameValueCollectionToObject
    {
        private Establish context = () =>
        {
            _collection = new NameValueCollection
                              {
                                  {"Id","12"},
                                  {"CategoryId","56"},
                                  {"token","1234567890"}
                              };
        };

        Because serialize_collection = () =>
        {
            _serialized = new NameValueToJsonSerializer();
        };

        private It generated_a_json_object_with_properties_for_keys = () =>
        {
            _serialized.ToString(_collection).ShouldContain("categoryid");
        };
       
        private static NameValueCollection _collection;
        private static NameValueToJsonSerializer _serialized;
    }
}
