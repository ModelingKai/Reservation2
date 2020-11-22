using System.Threading.Tasks;
using 会議室予約.Domain;
using 会議室予約.Domain.DomainService;
using 会議室予約.Domain.Exceptions;
using 会議室予約.Domain.予約;
using 会議室予約.UseCase.Exceptions;
using 会議室予約.UseCase.RepositoryInterfaces;

namespace 会議室予約.UseCase
{
    public class UseCase
    {
        private readonly I予約Repository _repository;

        public UseCase(I予約Repository repository)
        {
            _repository = repository;
        }

        public async Task 会議室予約するAsync(予約Request request)
        {
            try
            {
                var よやく = new 予約(request.よやくしゃ,
                    request.りようきかん,
                    request.かいぎしつ,
                    request.かいぎさんかよていしゃ);
                            
                await _repository.Add(よやく);
            }
            catch (ルール違反Exception ex)
            {  
                // エラーで返す。
                throw new UseCaseException(ex);
            }

            // 終了
        }


        public async Task 予約をキャンセルする(予約Id 予約Id, 予約をキャンセルする人のId 予約をキャンセルする人のID) {
            //var 予約の一覧 = _repository.FetchAll();

            var domainService = new 予約キャンセルDomainService();
            if (await domainService.キャンセルできるか(予約Id, 予約をキャンセルする人のID)) {

                var 予約 = _repository.Get(予約Id);
                _repository.RemoveBy(予約Id);
            }
        }
    }
}