using Luca.Core.Encoders;
using Machine.Specifications; 

namespace Luca.Specs.Core
{
	[Subject("Given_accept_json_returns_a_json_serialize")]
	public class JsonSerialize
	{
		private Establish context = () =>
										{
											_encoderFactory = new EncoderFactory();
										};

		private Because accept_json = () =>
								{
									_encoder = _encoderFactory.GetEncoderForContentType(new[] { "application/json" });
								};

		private It should_be_of_type_json_encoder = () => _encoder.ShouldBe(typeof(Luca.Core.Encoders.Json));
		private static EncoderFactory _encoderFactory;
		private static IEncoder _encoder;
	}
}
