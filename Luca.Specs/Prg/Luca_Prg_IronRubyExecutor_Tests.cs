using Luca.Prg;
using NUnit.Framework;
using SharpTestsEx;

namespace Luca.Specs.Prg
{
	[TestFixture]
	public class Luca_Prg_IronRubyExecutor_Tests
	{
		private string _templatePath = "templates/WalletFtu";

		private const string HtmlCode =
			@"		<div class=""SureSidebarSectionTitle SureWalletLabel"">
			new users
		</div>
		<table class=""SureSidebarSectionFrame"" cellspacing=""0"" cellpadding=""0"">
			<tr>
				<td class=""SureSidebarSectionInnerFrame"" style=""cursor:pointer"" onclick=""javascript:self.location='LaunchPage'"">
					<p class=""WalletFTUPromtionDisplay1"">100 USD FREE*</p>
					<p class=""WalletFTUPromtionDisplay2"">Viewing Credit</p>
					<p class=""WalletFTUPromtionDisplay3"">*no purchase required</p>
				</td>
			</tr>
			<tr>
				<td class=""SureSidebarSectionInnerFrame"">
					<a id=""SureWalletBulletStartHeremodifier"" class=""SureWalletBullet"" href=""javascript:WalletLink('LaunchPage')"">start here</a>
				</td>
			</tr>
		</table>
"; 
		[Test]
		public void When_passing_code_Should_Execute_It_and_return_text()
		{
			IViewExecutor ironRubyViewExecutor = new IronRubyViewExecutor();
			var parser = new IronRubyViewParser();
			var code = parser.Parse(_templatePath);
		  /* var model = new DynamicModel();
			model.SetAttributeValue("ftuValue","100 USD");
			model.SetAttributeValue("ftuUrl", "LaunchPage");
			model.SetAttributeValue("idModifier", "modifier");
			model.SetAttributeValue("phrases", new {FREE = "FREE", viewing_credit = "Viewing Credit", new_users = "new users", no_purchase_required = "no purchase required", start_here = "start here" });
			var html = ironRubyViewExecutor.Execute(code, model);
			Assert.That(html, Is.EqualTo(HtmlCode));
		   */
		}
		
		[Test]
		public void if_missing_some_objects_or_values_should_put_empty_string()
		{
			IViewExecutor ironRubyViewExecutor = new IronRubyViewExecutor();
			var parser = new IronRubyViewParser();
			var code = parser.Parse(_templatePath);
			var model = new { ftuValue = "100 USD", ftuUrl = "LaunchPage", idModifier = "modifier", phrases = new { FREE = "FREE", viewing_credit = "Viewing Credit", new_users = "new users", no_purchase_required = "no purchase required", start_here = "start here" } };
			var html = ironRubyViewExecutor.Execute(code, model);
			html.Should().Not.Contain("100 USD");
		}
	}
}