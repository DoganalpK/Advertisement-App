using AspNetCore.AdvertisementApp.Common.Enums;

namespace AspNetCore.AdvertisementApp.Common
{
    public interface IResponse
    {
        string Message { get; set; }
        ResponseType ResponseType { get; set; }
    }
}
