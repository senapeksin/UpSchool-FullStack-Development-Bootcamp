using UpSchool.Domain.Services;

namespace UpSchool.Wasm.Services
{
    public class BlazoredToasterService : IToasterService
    {
        private readonly IToasterService _toasterService;

        public BlazoredToasterService(IToasterService toasterService)
        {
            _toasterService = toasterService;
        }

        public void ShowSuccess(string message)
        {
            _toasterService.ShowSuccess(message);
        }
    }
}
