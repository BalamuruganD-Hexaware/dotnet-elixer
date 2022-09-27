using MongoDB.Driver;

namespace appdesigner.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
