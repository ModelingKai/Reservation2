using 会議室予約.Domain.Exceptions;

namespace 会議室予約.Domain
{
    /// <summary>
    /// 予約ルートエンティティ
    /// </summary>
    public class 予約
    {
        private 予約者Id よやくしゃ;
        private 利用期間 りようきかん;
        private 会議室Id かいぎしつ;
        // TODO: ファーストコレクションかな
        private 会議参加予定者 かいぎさんかよていしゃ;
        private 予約ステータス すてーたす;

        public 予約(予約者Id よやくしゃ, 利用期間 りようきかん, 会議室Id かいぎしつ, 会議参加予定者 かいぎさんかよていしゃ, 予約可能ルール るーる)
        {
            if (!るーる.IsSatisfied(りようきかん))
            {
                throw new ルール違反Exception("おまえ、値ちがうんやで");
            }
            
            // 予約可能かどうか判定する?
            
            this.よやくしゃ = よやくしゃ;
            this.りようきかん = りようきかん;
            this.かいぎしつ = かいぎしつ;
            this.かいぎさんかよていしゃ = かいぎさんかよていしゃ;
        }

        public 利用時間帯 りようじかんたい()
        {
            return りようきかん.りようじかんたい();
        }

        public void 変更する()
        {
            
        }

        public void キャンセルする()
        {
            // ステータスがキャンセルになる
        }

        public void 強制キャンセルする()
        {
            // ステータスが強制キャンセルする
        }
    }

    internal enum 予約ステータス
    {
    }
}

