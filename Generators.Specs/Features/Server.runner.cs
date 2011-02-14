using NUnit.Framework;

namespace Generators.Specs.Features 
{
    [TestFixture]
    public partial class Server 
    {
        
        [Test]
        public void RunningTheServerOnTheDefaultPort()
        {         
            Given_I_m_in_the_root_of_a_Luca_app();        
            When_I_type("start");        
            Then_the_server_should_start_on_port(3030);
        }
        
        [Test]
        public void RunningTheServerOnACustomPort()
        {         
            Given_I_m_in_the_root_of_a_Luca_app();        
            When_I_type("start -p:8080");        
            Then_the_server_should_start_on_port(8080);
        }
        
        [Test]
        public void StoppingTheServer()
        {         
            Given_the_server_is_running();        
            When_I_type("stop");        
            Then_the_server_should_stop();
        }

    }
}
