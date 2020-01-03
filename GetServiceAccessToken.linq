<Query Kind="Program">
  <NuGetReference>Slb.Prism.Core.Library.Protocol</NuGetReference>
  <NuGetReference Version="2.5.0.761988">Slb.Prism.Core.Library.Security</NuGetReference>
  <Namespace>Slb.Prism.Core.Library.Security.Jwt</Namespace>
</Query>

void Main()
{
	P4DTokenForProvisioning();
	P4DTokenForConsumer();
	//ProductionProvisionToken();
	//ProductionConsumerToken();
}

// Define other methods and classes here
public void P4DTokenForProvisioning()
{
	var tokenUri = "https://tksvc-dot-cfsauth-preview.appspot.com/v1/svctk";
	var refreshTokenUri = "https://tksvc-dot-cfsauth-preview.appspot.com/v1/refresh";
	var tokenAPIkey = "AIzaSyDkZlfehVTPtigUJMvZwecEgRc14Wd8X18";
	var projectId = "prism4wl.slbapp.com";
	var serviceId = "prism4wl-integration-service-prism4wl.slbservice.com";
	var secret = "2654a4c34f1e465388785d6c6919a882b98076d13ece379571";
	var serverTag = "Primary";

	var stb = new ServiceTokenBroker(new Uri(tokenUri), new Uri(refreshTokenUri), tokenAPIkey, projectId, serviceId, secret, serverTag);

	stb.GetTokenAsync().Dump("P4DTokenForProvisioning");
}

public void P4DTokenForConsumer()
{
	var tokenUri = "https://tksvc-dot-cfsauth-preview.appspot.com/v1/svctk";
	var refreshTokenUri = "https://tksvc-dot-cfsauth-preview.appspot.com/v1/refresh";
	var tokenAPIkey = "AIzaSyDkZlfehVTPtigUJMvZwecEgRc14Wd8X18";
	var projectId = "prism4wl.slbapp.com";
	var serviceId = "prism4wl-data-service-prism4wl.slbservice.com";
	var secret = "fb2dd95a682b4206b91cb1550997be1124c4626d9";
	var serverTag = "Primary";

	var stb = new ServiceTokenBroker(new Uri(tokenUri), new Uri(refreshTokenUri), tokenAPIkey, projectId, serviceId, secret, serverTag);

	stb.GetTokenAsync().Dump("P4DTokenForConsumer");
}

public void ProductionProvisionToken()
{
	var tokenUri = "https://tksvc.cfs.slb.com/v1/svctk";
	var refreshTokenUri = "https://tksvc.cfs.slb.com/v1/refresh";
	var tokenAPIkey = "AIzaSyBSpI8AZSYiw2MlmGOsYgB4RjMynA9fCrc";
	var projectId = "prism4wl.slbapp.com";
	var serviceId = "prism4wl-integration-service-prism4wl.slbservice.com";
	var secret = "d5c223a3c119459ab902996fbe50182b8fe27fecc27afdfb";
	var serverTag = "Primary";

	var stb = new ServiceTokenBroker(new Uri(tokenUri), new Uri(refreshTokenUri), tokenAPIkey, projectId, serviceId, secret, serverTag);

	stb.GetTokenAsync().Dump("Provision");
}

public void ProductionConsumerToken()
{
	var tokenUri = "https://tksvc.cfs.slb.com/v1/svctk";
	var refreshTokenUri = "https://tksvc.cfs.slb.com/v1/refresh";
	var tokenAPIkey = "AIzaSyBSpI8AZSYiw2MlmGOsYgB4RjMynA9fCrc";
	var projectId = "prism4wl.slbapp.com";
	var serviceId = "prism4wl-data-service-prism4wl.slbservice.com";
	var secret = "e2e1d0a0a4b94c2ebec406d8f4a8ee5bd0ea6cfd0c3a20";
	var serverTag = "Primary";

	var stb = new ServiceTokenBroker(new Uri(tokenUri), new Uri(refreshTokenUri), tokenAPIkey, projectId, serviceId, secret, serverTag);

	stb.GetTokenAsync().Dump("Consumer");
}