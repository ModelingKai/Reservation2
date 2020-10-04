namespace 会議室予約.Domain
{
    /// <summary>
    /// 予約ルートエンティティ
    /// </summary>
    public class 予約
    {
        // どんなモノもっている？
        private 予約者 よやくしゃ;
        private 予約期間_むらさき よやくきかん;
        private 会議室 かいぎしつ;
        private 会議参加予定者 かいぎさんかよていしゃ;
    }

    internal class 予約期間_むらさき
    {
        private 利用開始年月日時分 りようかいしねんがっぴ;
        private 利用終了年月日時分 りようしゅうねんがっぴ;
    }
}