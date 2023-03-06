using UpSchool.Domain.Services;

namespace UpSchool.Wasm.Services
{
    public class UrlHelperService : IUrlHeperService
    {
        public string ApiIrl { get; }
        public UrlHelperService(string apiUrl)
        {
            ApiIrl = apiUrl;
        }
    }
}
