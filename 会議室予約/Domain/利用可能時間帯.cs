using System;
using System.Collections.Generic;
using System.Text;

namespace 会議室予約.Domain
{
    class 利用可能時間帯
    {
        internal bool 範囲外(利用期間 利用期間)
        {
            // TODO: 実装するぞ。
            //            利用期間.
            return false;
        }
/*
        private bool 会議室オープン時間になっていないか()
        {
            return _開始年月日時分.Value.Hour < 会議室オープン時刻;
        }

        private bool 会議室クローズ時間を超えているか()
        {
            return _終了年月日時分.Value.Hour > 会議室クローズ時刻 ||
                   (_終了年月日時分.Value.Hour == 会議室クローズ時刻 && _終了年月日時分.Value.Minute > 0);
        }
*/

    }
}
