using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using 会議室予約.Infrastructure;
using 会議室予約.UseCase;
using 会議室予約.Domain.予約;
using 会議室予約.Domain.予約.利用期間;
using 会議室予約.Domain.予約可能ルール;
using 会議室予約.Domain.会議室;

namespace Test
{
    public class TestUseCase
    {
        [Fact]
        public async Task 予約する()
        {
            var repository = new InMemory予約Repository();
            var factory = new 連番予約IdFactory();
            var useCase = new UseCase(repository, factory);

            var request = new 予約Request();
            request.よやくしゃ = new 予約者Id();
            
            var かいし = new 開始年月日時分(2021, 1, 20, 10, 0);
            var しゅうりょう = new 終了年月日時分(2021, 1, 20, 11,0);
            var 起点日 = new DateTime(2020, 12, 29);
            
            request.りようきかん = new 利用期間(かいし, しゅうりょう);
            request.かいぎさんかよていしゃ = new 会議参加予定者();
            request.かいぎしつ = new 会議室Id();
            
            await useCase.会議室予約するAsync(request, new 予約申請受付日(起点日));

            var result = repository.Get(new 予約Id("0"));
            
            result.IsNotNull();
        }
    }
}
