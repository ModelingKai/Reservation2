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
        private 会議参加予定者 かいぎさんかよていしゃ;
        private 会議室 かいぎしつ;
        // TODO: これは会議参加予定者から算出できそう
        private 利用人数_むらさき りようにんずう;
    }

    internal class 予約期間_むらさき
    {
        private 利用日 りようび;
        private 利用開始時刻 りようかいしじこく;
        private 利用終了時刻 りようしゅうりょうじこく;
    }
}