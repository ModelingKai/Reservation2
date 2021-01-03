using System;
using 会議室予約.Domain.予約.利用期間;

namespace 会議室予約.Domain.予約可能ルール
{
    public class 予約可能期間
    {
        private readonly DateTime _開始日;
        private readonly DateTime _終了日;

        public 予約可能期間(予約申請受付日 予約申請受付日) {
            _開始日 = 予約申請受付日.日付;
            _終了日 = _開始日.AddDays(30);
        }

        public bool IsContains(開始年月日時分 開始年月日時分) {
            return (_開始日 <= 開始年月日時分.日付) && (開始年月日時分.日付 <= _終了日);
        }
    }
}
