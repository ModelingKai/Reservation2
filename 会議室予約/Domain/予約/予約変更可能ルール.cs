using System;

namespace 会議室予約.Domain.予約
{
    /// <summary>
    /// 利用可能日：名前付けられた式
    /// </summary>
    public class 予約変更可能ルール
    {
        private readonly 利用時間帯 会議室オープン時間;

        private 開始年月日時分 _開始年月日時分;
        private 終了年月日時分 _終了年月日時分;
        // TODO: これは本当にDateTimeでいいのか?
        private readonly DateTime _予約可能期間の起点日;


        
        public 予約変更可能ルール()
        {
            var start = new 時分(10, 0);
            var end = new 時分(19, 0);
            
            会議室オープン時間 = new 利用時間帯(start , end);
        }

        public bool IsSatisfied(利用期間 りようきかん)
        {
            // TODO: 日付を跨っている場合の判定は別で必要だと思う
            
            //// 10:00-19:00の間に、含まれていなかった場合は予約できない
            if (!会議室オープン時間.IsContains(りようきかん.りようじかんたい()))
            {
                return false;
            }

            // TODO: 判定実装するべ。
            var 利用可能時間帯 = new 利用可能時間帯();
            //if (利用可能時間帯.範囲外(_利用期間)) {
            //    return false;
            //}

            // 起点日から◯日後のやつ
            var 利用可能日 = new 利用可能日(_予約可能期間の起点日);
            if (!利用可能日.含むのかしら(_開始年月日時分)) {
                return false;
            }

            return true;
        }
    }
}