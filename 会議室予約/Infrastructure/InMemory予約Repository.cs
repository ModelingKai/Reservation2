using System.Threading.Tasks;
using 会議室予約.Domain.予約;
using 会議室予約.UseCase.RepositoryInterfaces;

namespace 会議室予約.Infrastructure
{
    public class InMemory予約Repository : I予約Repository
    {
        public Task Add(予約 よやく)
        {
            throw new System.NotImplementedException();
        }

        public 予約 Get(予約Id 予約Id)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(予約Id 予約Id)
        {
            throw new System.NotImplementedException();
        }
    }
}