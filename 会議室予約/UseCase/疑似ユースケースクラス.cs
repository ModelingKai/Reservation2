using 会議室予約.Domain;

namespace 会議室予約.UseCase
{
    public class 疑似ユースケースクラス
    {
        public void 会議室予約する(予約Request request)
        {
            // なんかリクエスト受け取る
            // 集約にわたす？

            予約者 よやくしゃ = new 予約者(request.よやくしゃ);
            利用期間 りようきかん = new 利用期間(request.りようきかん);
            会議室 かいぎしつ = new 会議室(request.かいぎしつ);
            会議参加予定者 かいぎさんかよていしゃ = new 会議参加予定者(request.かいぎさんかよていしゃ);
            
            予約 よやく =  new 予約(よやくしゃ, りようきかん, かいぎしつ, かいぎさんかよていしゃ);
            
            // リポジトリに予約を登録する
            repository.save(よやく);

            // 終了
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