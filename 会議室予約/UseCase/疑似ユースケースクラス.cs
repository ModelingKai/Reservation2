using 会議室予約.Domain;

namespace 会議室予約.UseCase
{
    public class 疑似ユースケースクラス
    {
        public async Task 会議室予約するAsync(予約Request request)
        {
            予約 よやく = new 予約(request.よやくしゃ, request.りようきかん, request.かいぎしつ, request.かいぎさんかよていしゃ);

            予約可能ルール るーる = new 予約可能ルール();


            if (るーる.IsSatisfied(よやく))
            {
                // リポジトリに予約を登録する
                await repository.save(よやく);
            }
            else
            {
                // エラーで返す。
                throw new UseCaseException("??????????");
            }

            // 終了


            // memo: 予約成立ドメインサービスという風に、予約として可能かどうか、と他予約と被ってなくて保存できるかどうかを1つのサービスにしてしまうやり方
            // // 予約が成立するかどうかを判定する
            // // 予約が
            // 予約成立ドメインサービス(よやく, repository, るーる);
            //

        }
    }

    /// <summary>
    /// イメージ共有のための、予約者Requestのコード
    /// </summary>
    public class 予約Request
    {
        public string よやくしゃ { get; set; }
    }
}