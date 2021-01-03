using System;
using 会議室予約.Domain.予約.利用期間;
using 会議室予約.Domain.予約可能ルール.開放時間;

namespace 会議室予約.Domain.予約可能ルール
{
    /// <summary>
    /// 利用可能日：名前付けられた式
    /// </summary>
    public class 予約可能ルール
    {
        private readonly 開放時間.開放時間 会議室オープン時間;

        private 開始年月日時分 _開始年月日時分;
        private 終了年月日時分 _終了年月日時分;

        private 予約可能期間 _予約可能期間;

        public 予約可能ルール(予約申請受付日 予約申請受付日)
        {
            _予約可能期間 =  new 予約可能期間(予約申請受付日);
            
            var start = new 時分(10, 0);
            var end = new 時分(19, 0);
            会議室オープン時間 = new 開放時間.開放時間(start , end);
        }

        public bool IsSatisfied(予約.利用期間.利用期間 りようきかん)
        {
            // TODO: 日付を跨っている場合の判定は別で必要だと思う
            
            //// 10:00-19:00の間に、含まれていなかった場合は予約できない
            // ルール①
            if (!会議室オープン時間.IsContains(りようきかん.りようじかんたい()))
            {
                return false;
            }

            // 起点日から◯日後のやつ
            // ルール②
            if (!_予約可能期間.含むのかしら(_開始年月日時分)) {
                return false;
            }

            return true;
        }
    }
}