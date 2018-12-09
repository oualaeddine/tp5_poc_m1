using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TcpChannel chnl = new TcpChannel(1234);
                ChannelServices.RegisterChannel(chnl, false);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(UsinePileImpl), "usinePile", WellKnownObjectMode.Singleton);
                Console.WriteLine("Serveur démarré...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Serveur:Erreur d'initialisation !" + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
