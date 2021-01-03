using System;
using 会議室予約.Domain.予約.利用期間;

namespace 会議室予約.Domain.予約可能ルール
{
    public class 予約可能期間
    {
        private DaitTime???? 始点;
        private DateTime???? 終点;

        public 予約可能期間(予約申請受付日 予約申請受付日) {
            _予約申請受付日 = 予約申請受付日;
        }

        public bool 含むのかしら(開始年月日時分 開始年月日時分) {
            return 開始年月日時分.Value < _予約申請受付日.AddDays(30);
        }
    }
}
