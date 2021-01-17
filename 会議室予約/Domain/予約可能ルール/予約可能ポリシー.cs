using System;
using System.Collections.Generic;
using 会議室予約.Domain.Exceptions;
using 会議室予約.Domain.予約.利用期間;
using 会議室予約.Domain.予約可能ルール.開放時間;

namespace 会議室予約.Domain.予約可能ルール
{
    /// <summary>
    /// 利用可能日：名前付けられた式
    /// </summary>
    public class 予約可能ポリシー
    {
        private readonly 開放時間.開放時間 会議室オープン時間;
        private 予約可能期間 _予約可能期間;

        public 予約可能ポリシー(予約申請受付日 予約申請受付日)
        {
            _予約可能期間 =  new 予約可能期間(予約申請受付日);
            
            var start = new 時分(10, 0);
            var end = new 時分(19, 0);
            会議室オープン時間 = new 開放時間.開放時間(start , end);
        }

        public void ポリシー満たさなかったらExeption出す(予約.利用期間.利用期間 りようきかん)
        {
            // 10:00-19:00の間に、含まれていなかった場合は予約できない
            オープン時間内の予約であるか(りようきかん);

            // 起点日から◯日後のやつ
            予約受付期間内の予約であるか(りようきかん);
        }

        private void オープン時間内の予約であるか(利用期間 りようきかん)
        {
            if (!会議室オープン時間.IsContains(りようきかん.りようじかんたい()))
            {
                throw new ルール違反Exception("オープン時間内に予約してください");
            }
        }
        private void 予約受付期間内の予約であるか(利用期間 りようきかん)
        {
            // 途中で失敗したら、
            if (!_予約可能期間.IsContains(りようきかん.開始日付))
            {
                throw new ルール違反Exception("予約受付期間内で予約してください");
            } 
        }

        // TODO: 日付を跨っている場合の判定は別で必要だと思う
    }
}