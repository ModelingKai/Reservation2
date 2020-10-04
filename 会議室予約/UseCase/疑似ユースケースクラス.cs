namespace 会議室予約.UseCase
{
    public class 疑似ユースケースクラス
    {
        public void 会議室予約する(Request request)
        {
            // なんかリクエスト受け取る
            // 集約にわたす？

            予約 よやく =  new 予約(request);
            
            // リポジトリに予約を登録する
            repository.save(よやく);

            // 終了
        }
    }
}