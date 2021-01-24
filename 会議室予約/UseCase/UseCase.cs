using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using 会議室予約.Domain;
using 会議室予約.Domain.DomainService;
using 会議室予約.Domain.Exceptions;
using 会議室予約.Domain.予約;
using 会議室予約.Domain.予約.Query;
using 会議室予約.Domain.予約可能ルール;
using 会議室予約.UseCase.Exceptions;
using 会議室予約.UseCase.RepositoryInterfaces;

namespace 会議室予約.UseCase
{
    public class UseCase
    {
        private readonly I予約Repository _repository;
        private readonly I予約IdFactory _factory;

        public UseCase(I予約Repository repository, I予約IdFactory factory)
        {
            _repository = repository;
            _factory = factory;
        }

        public async Task<List<予約QueryModel>> 会議室一覧を取得するAsync()
        {
            var 予約List = _repository.GetAll();
            return 予約List.Select(x => x.As予約QueryModel()).ToList();
        }
        
        public async Task 会議室予約するAsync(予約Request request, 予約申請受付日 よやくしんせいうけつけび)
        {
            // Todo: 予約Requestという名前がかなりやばい
            try
            {
                var 予約Id = _factory.Create();

                var よやく = 予約.Create(予約Id,
                    request.よやくしゃ,
                    request.りようきかん,
                    request.かいぎしつ,
                    request.かいぎさんかよていしゃ,
                    よやくしんせいうけつけび);
                            
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
                _repository.Remove(予約Id);
            }
        }
    }
}