using System.Threading.Tasks;
using 会議室予約.Domain;
using 会議室予約.Domain.Exceptions;
using 会議室予約.UseCase.Exceptions;

namespace 会議室予約.UseCase
{
    public class 疑似ユースケースクラス
    {
        public class 疑似ユースケースクラス()
        {
            
        }
        
        public async Task 会議室予約するAsync(予約Request request)
        {
            try
            {
                var よやく = new 予約(request.よやくしゃ,
                    request.りようきかん,
                    request.かいぎしつ,
                    request.かいぎさんかよていしゃ,
                    new 予約可能ルール());
                            
                await repository.save(よやく);
            }
            catch (ルール違反Exception ex)
            {  
                // エラーで返す。
                throw new UseCaseException(ex);
            }

            // 終了
        }
    }
}