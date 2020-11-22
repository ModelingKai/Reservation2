using System;
using 会議室予約.Domain.予約.利用期間;

namespace 会議室予約.Domain.予約可能ルール
{
    public class 利用可能日
    {
        private readonly DateTime _予約可能期間の起点日;

        public 利用可能日(DateTime 予約可能期間の起点日) {
            _予約可能期間の起点日 = 予約可能期間の起点日;
        }


        public bool 含むのかしら(開始年月日時分 開始年月日時分) {
            return 開始年月日時分.Value < _予約可能期間の起点日.AddDays(30);
        }
    }
}
