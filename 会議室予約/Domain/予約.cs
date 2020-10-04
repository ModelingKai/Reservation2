namespace 会議室予約.Domain
{
    /// <summary>
    /// 予約ルートエンティティ
    /// </summary>
    public class 予約
    {
        private 予約者 よやくしゃ;
        private 利用期間 りようきかん;
        private 会議室 かいぎしつ;
        private 会議参加予定者 かいぎさんかよていしゃ;
        
        
        // 操作・メソッド考える？
        // public 予約()
        // {
        //     if(予約可能ルール().isOK())
        // }
    }

    /// <summary>
    /// 利用可能日：名前付けられた式
    /// </summary>
    internal class 予約可能ルール
    {
        public bool IsOk() => true;
    }
    
    internal class 予約者
    {
    }

    internal class 利用期間
    {
        private 開始年月日時分 かいしねんがっぴ;
        private 終了年月日時分 しゅうねんがっぴ;
    }
}

