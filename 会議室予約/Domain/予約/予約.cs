using 会議室予約.Domain.Exceptions;
using 会議室予約.Domain.会議室;

namespace 会議室予約.Domain.予約
{
    /// <summary>
    /// 予約ルートエンティティ
    /// </summary>
    public class 予約
    {
        private 予約Id 予約Id;

        private 予約者Id よやくしゃ;
        private 利用期間 りようきかん;
        private 会議室Id かいぎしつ;
        // TODO: ファーストコレクションかな
        private 会議参加予定者 かいぎさんかよていしゃ;

        public 予約(予約者Id よやくしゃ, 利用期間 りようきかん, 会議室Id かいぎしつ, 会議参加予定者 かいぎさんかよていしゃ)
        {
            if (!new 予約可能ルール().IsSatisfied(りようきかん))
            {
                throw new ルール違反Exception("おまえ、値ちがうんやで");
            }

            // 予約可能かどうか判定する?
            予約Id = 予約Id.Create();
            this.よやくしゃ = よやくしゃ;
            this.りようきかん = りようきかん;
            this.かいぎしつ = かいぎしつ;
            this.かいぎさんかよていしゃ = かいぎさんかよていしゃ;
        }

        /// <summary>
        /// 変更用のコンストラクタ
        /// </summary>
        /// <param name="よやくid"></param>
        /// <param name="よやくしゃ"></param>
        /// <param name="りようきかん"></param>
        /// <param name="かいぎしつ"></param>
        /// <param name="かいぎさんかよていしゃ"></param>
        public 予約(予約Id よやくid, 予約者Id よやくしゃ, 利用期間 りようきかん, 会議室Id かいぎしつ, 会議参加予定者 かいぎさんかよていしゃ)
        {
            this.予約Id = よやくid;
            this.よやくしゃ = よやくしゃ;
            this.りようきかん = りようきかん;
            this.かいぎしつ = かいぎしつ;
            this.かいぎさんかよていしゃ = かいぎさんかよていしゃ;
        }

        public 利用時間帯 りようじかんたい()
        {
            return りようきかん.りようじかんたい();
        }

        public 予約 変更する(予約Id 予約Id, 予約者Id 予約者Id, 利用期間 利用期間, 会議室Id 会議室Id, 会議参加予定者 会議参加予定者)
        {
            if (!new 予約変更可能ルール().IsSatisfied(りようきかん))
            {
                throw new ルール違反Exception("おまえ、値ちがうんやで2");
            }
            
            return new 予約(予約Id, 予約者Id, 利用期間, 会議室Id, 会議参加予定者);
        }
    }
}

