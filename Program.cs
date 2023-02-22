using API.Contract;
using API.Service;
using SoapCore;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
services.AddSoapCore();
services.AddSingleton<IService, Service>();
services.AddMvc();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints => {
    endpoints.UseSoapEndpoint<IService>("/Service.svc", new SoapEncoderOptions(), SoapSerializer.DataContractSerializer, true);
    endpoints.UseSoapEndpoint<IService>("/Service.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer, true);
    endpoints.MapControllers();
});

app.Run();
