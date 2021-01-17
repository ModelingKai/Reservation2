using 会議室予約.Domain.Exceptions;
using 会議室予約.Domain.予約可能ルール;
using 会議室予約.Domain.予約可能ルール.開放時間;
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
        private 利用期間.利用期間 りようきかん;
        private 会議室Id かいぎしつ;
        // TODO: ファーストコレクションかな
        private 会議参加予定者 かいぎさんかよていしゃ;

        public static 予約 Create(予約Id 予約Id,
                                予約者Id 予約者Id,
                                利用期間.利用期間 利用期間,
                                会議室Id 会議室Id,
                                会議参加予定者 会議参加予定者,
                                予約申請受付日 予約申請受付日)
        {
            new 予約可能ポリシー(予約申請受付日).ポリシー満たさなかったらExeption出す(利用期間);
          
            return new 予約(予約Id, 予約者Id, 利用期間, 会議室Id, 会議参加予定者);
        }

        public 予約Id As予約Id()
        {
            return this.予約Id;
        }

        /// <summary>
        /// 変更用のコンストラクタ
        /// </summary>
        /// <param name="よやくid"></param>
        /// <param name="よやくしゃ"></param>
        /// <param name="りようきかん"></param>
        /// <param name="かいぎしつ"></param>
        /// <param name="かいぎさんかよていしゃ"></param>
        private 予約(予約Id よやくid, 予約者Id よやくしゃ, 利用期間.利用期間 りようきかん, 会議室Id かいぎしつ, 会議参加予定者 かいぎさんかよていしゃ)
        {
            this.予約Id = よやくid;
            this.よやくしゃ = よやくしゃ;
            this.りようきかん = りようきかん;
            this.かいぎしつ = かいぎしつ;
            this.かいぎさんかよていしゃ = かいぎさんかよていしゃ;
        }


        public 開放時間 りようじかんたい()
        {
            return りようきかん.りようじかんたい();
        }

        public 予約 変更する(予約Id 予約Id,
                        予約者Id 予約者Id,
                        利用期間.利用期間 利用期間,
                        会議室Id 会議室Id,
                        会議参加予定者 会議参加予定者,
                        予約申請受付日 予約申請受付日)
        {
            if (!new 予約変更可能ルール.予約変更可能ルール(予約申請受付日).IsSatisfied(りようきかん))
            {
                throw new ルール違反Exception("おまえ、値ちがうんやで2");
            }
            
            return new 予約(予約Id, 予約者Id, 利用期間, 会議室Id, 会議参加予定者);
        }
    }
}

