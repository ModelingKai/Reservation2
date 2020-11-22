using System.Threading.Tasks;
using 会議室予約.Domain;
using 会議室予約.Domain.予約;

namespace 会議室予約.UseCase.RepositoryInterfaces
{
    public interface I予約Repository
    {
        Task Add(予約 よやく);

        予約 Get(予約Id 予約Id);

        void RemoveBy(予約Id 予約Id);
    }
}