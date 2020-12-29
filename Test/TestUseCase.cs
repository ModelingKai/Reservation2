using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using 会議室予約.Infrastructure;
using 会議室予約.UseCase;
using 会議室予約.Domain.予約;

namespace Test
{
    public class TestUseCase
    {
        [Fact]
        public async Task 予約する()
        {
            var repository = new InMemory予約Repository();
            var useCase = new UseCase(repository);

            var request = new 予約Request();
            await useCase.会議室予約するAsync(request);


            var result = repository.Get(new 予約Id("Banana"));
        }
    }
}
