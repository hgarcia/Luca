using Jint.Native;
using Machine.Specifications;

namespace Luca.Specs.Json
{
    [Subject("Serialize to Json a JsonExpando")]
    public class With_no_attributes
    {
        Establish context = () =>
        {
            _dynamicResult = new JsonExpando();
            _encoded = string.Empty;
        };

        private Because of = () => _encoded = new Luca.Core.Encoders.Json().Encode(_dynamicResult);

        private It should_be_an_empty_object = () => _encoded.ShouldEqual("{}");
        private static JsonExpando _dynamicResult;
        private static string _encoded;
    }

    [Subject("Serialize to Json a JsonExpando")]
    public class With_only_one_attribute
    {
        Establish context = () =>
        {
            _dynamicResult = new JsonExpando();
            _dynamicResult.SetMember("Name", "Hello World");
            _encoded = string.Empty;
        };

        private Because of = () => _encoded = new Luca.Core.Encoders.Json().Encode(_dynamicResult);

        private It should_contain_an_attribute = () => _encoded.ShouldEqual("{\"name\":\"Hello World\"}");
        private static JsonExpando _dynamicResult;
        private static string _encoded;
    }

    [Subject("Serialize to Json a JsonExpando")]
    public class With_more_than_one_attribute
    {
        Establish context = () =>
        {
            _dynamicResult = new JsonExpando();
            _dynamicResult.SetMember("Name", "Dynamic");
            _dynamicResult.SetMember("LastName", "Programmer");
            _encoded = string.Empty;
        };

        private Because of = () => _encoded = new Luca.Core.Encoders.Json().Encode(_dynamicResult);

        private It should_contain_two_attributes_separated_by_comma = () => _encoded.ShouldEqual("{\"name\":\"Dynamic\",\"lastname\":\"Programmer\"}");
        private static JsonExpando _dynamicResult;
        private static string _encoded;
    }

    [Subject("Serialize to Json a JsonExpando")]
    public class With_a_JsonExpando_as_an_attribute
    {
        Establish context = () =>
        {
            _dynamicResult = new JsonExpando();
            _dynamicResult.SetMember("Name", "Dynamic");
            _dynamicResult.SetMember("LastName", "Programmer");
            var dynamicAttribute = new JsonExpando();
            dynamicAttribute.SetMember("province", "Ontario");
            _dynamicResult.SetMember("Location", dynamicAttribute);
            _encoded = string.Empty;
        };

        private Because of = () => _encoded = new Luca.Core.Encoders.Json().Encode(_dynamicResult);

        private It should_contain_an_object_for_locations = () => _encoded.ShouldEqual("{\"name\":\"Dynamic\",\"lastname\":\"Programmer\",\"location\":{\"province\":\"Ontario\"}}");
        private static JsonExpando _dynamicResult;
        private static string _encoded;
    }


    [Subject("Serialize to Json a JsonExpando")]
    public class With_an_array_as_an_attribute
    {
        Establish context = () =>
        {
            _dynamicResult = new JsonExpando();
            _dynamicResult.SetMember("Id", 3);
            _dynamicResult.SetMember("Cities", new []{"London","Budapest","New york", "Toronto"});
            _dynamicResult.SetMember("Dimensions", new[]{new[]{2,3},new[]{4,5}});
            _encoded = string.Empty;
        };

        private Because of = () => _encoded = new Luca.Core.Encoders.Json().Encode(_dynamicResult);

        private It should_contain_cities_and_dimensions = () => _encoded.ShouldEqual("{\"id\":\"3\",\"cities\":[\"London\",\"Budapest\",\"New york\",\"Toronto\"],\"dimensions\":[[2,3],[4,5]]}");
        private static JsonExpando _dynamicResult;
        private static string _encoded;
    }
}
