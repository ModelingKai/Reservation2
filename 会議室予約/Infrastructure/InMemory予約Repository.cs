using System.Collections.Generic;
using System.Threading.Tasks;
using 会議室予約.Domain.予約;
using 会議室予約.UseCase.RepositoryInterfaces;

namespace 会議室予約.Infrastructure
{
    public class InMemory予約Repository : I予約Repository
    {
        private Dictionary<予約Id, 予約> storage = new Dictionary<予約Id, 予約>(); 
        
        public Task Add(予約 よやく)
        {
            storage.Add(よやく.As予約Id(), よやく);
            return Task.CompletedTask;
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