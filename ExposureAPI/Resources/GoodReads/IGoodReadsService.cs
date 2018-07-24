using ExposureAPI.Resources.Client;

namespace ExposureAPI.Resources.GoodReads
{
    public interface IGoodReadsService
    {
        Response<GoodreadsResponse> GetReviews(string userId);
    }
}