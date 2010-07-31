using Jint;
using Luca.Core;
using Luca.Prg;
using NUnit.Framework;
using SharpTestsEx;

namespace Luca.Specs.Prg
{
	[TestFixture]
	public class Luca_Prg_IronRubyExecutor_Tests
	{
		private string _templatePath = "Prg/templates/WalletFtu";

		const string RubyCode = @"self.output += ""		<div class=\""SureSidebarSectionTitle SureWalletLabel\"">\r\n""
self.output += ""			#{__.phrases.new_users}\r\n""
self.output += ""		</div>\r\n""
self.output += ""		<table class=\""SureSidebarSectionFrame\"" cellspacing=\""0\"" cellpadding=\""0\"">\r\n""
self.output += ""			<tr>\r\n""
self.output += ""				<td class=\""SureSidebarSectionInnerFrame\"" style=\""cursor:pointer\"" onclick=\""javascript:self.location='#{__.ftuUrl}'\"">\r\n""
self.output += ""					<p class=\""WalletFTUPromtionDisplay1\"">#{__.ftuValue if __.respond_to?('ftuValue')} #{__.phrases.free}*</p>\r\n""
self.output += ""					<p class=\""WalletFTUPromtionDisplay2\"">#{__.phrases.viewing_credit}</p>\r\n""
self.output += ""					<p class=\""WalletFTUPromtionDisplay3\"">*#{__.phrases.no_purchase_required}</p>\r\n""
self.output += ""				</td>\r\n""
self.output += ""			</tr>\r\n""
self.output += ""			<tr>\r\n""
self.output += ""				<td class=\""SureSidebarSectionInnerFrame\"">\r\n""
self.output += ""					<a id=\""SureWalletBulletStartHere#{__.idModifier}\"" class=\""SureWalletBullet\"" href=\""javascript:WalletLink('#{__.ftuUrl}')\"">#{__.phrases.start_here}</a>\r\n""
self.output += ""				</td>\r\n""
self.output += ""			</tr>\r\n""
self.output += ""		</table>\r\n""
";

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
			var model = new { ftuValue = "100 USD", ftuUrl = "LaunchPage", idModifier = "modifier", phrases = new { free = "FREE", viewing_credit = "Viewing Credit", new_users = "new users", no_purchase_required = "no purchase required", start_here = "start here" } };
			var html = ironRubyViewExecutor.Execute(code, model);
			Assert.That(html, Is.EqualTo(HtmlCode)); 
		}
		
		[Test]
		public void if_missing_some_objects_or_values_should_put_empty_string()
		{
			IViewExecutor ironRubyViewExecutor = new IronRubyViewExecutor();
			//var parser = new IronRubyViewParser();
			//var code = parser.Parse(_templatePath);
			var model = new { ftuUrl = "LaunchPage", idModifier = "modifier", phrases = new { free = "FREE", viewing_credit = "Viewing Credit", new_users = "new users", no_purchase_required = "no purchase required", start_here = "start here" } };
			var html = ironRubyViewExecutor.Execute(RubyCode, model);
			html.Should().Not.Contain("100 USD");
		}

		[Test]
		public void if_getting_a_json_object_from_Jint_should_be_able_to_consume_it()
		{
            var jint = new JintEngine();
		    dynamic result =
		        jint.Run(
		            @"function get() { return {ftuUrl: 'LaunchPage', idModifier: 'modifier', phrases: { free:'FREE', viewing_credit:'Viewing Credit', new_users:'new users', no_purchase_required:'no purchase required', start_here:'start here'} };} get();"); 
            IViewExecutor ironRubyViewExecutor = new IronRubyViewExecutor();
            //var parser = new IronRubyViewParser();
            //var code = parser.Parse(_templatePath);
            //var model = new { ftuUrl = "LaunchPage", idModifier = "modifier", phrases = new { free = "FREE", viewing_credit = "Viewing Credit", new_users = "new users", no_purchase_required = "no purchase required", start_here = "start here" } };
            var html = ironRubyViewExecutor.Execute(RubyCode, result);
            html.Should().Not.Contain("100 USD");
		}
	}
}