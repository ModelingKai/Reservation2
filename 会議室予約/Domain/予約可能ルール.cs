using System;

namespace 会議室予約.Domain
{
    /// <summary>
    /// 利用可能日：名前付けられた式
    /// </summary>
    internal class 予約可能ルール
    {
        private const int 会議室オープン時刻 = 10;
        private const int 会議室クローズ時刻 = 19;


        private 開始年月日時分 _開始年月日時分;
        private 終了年月日時分 _終了年月日時分;
        // TODO: これは本当にDateTimeでいいのか?
        private readonly DateTime _予約可能期間の起点日;


        
        public 予約可能ルール(開始年月日時分 開始年月日時分, 終了年月日時分 終了年月日時分, DateTime 予約可能期間の起点日)
        {
            _開始年月日時分 = 開始年月日時分;
            _終了年月日時分 = 終了年月日時分;
            _予約可能期間の起点日 = 予約可能期間の起点日;
        }

        public bool IsSatisfied()
        {
            //// 10:00-19:00まではOK！
            if (会議室オープン時間になっていないか())
                return false;

            if (会議室クローズ時間を超えているか())
                return false;
            
            // TODO: 判定実装するべ。
            var 利用可能時間帯 = new 利用可能時間帯();
            //if (利用可能時間帯.範囲外(_利用期間)) {
            //    return false;
            //}

            var 利用可能日 = new 利用可能日(_予約可能期間の起点日);
            if (!利用可能日.含むのかしら(_開始年月日時分)) {
                return false;
            }

            return true;

        }

        private bool 会議室オープン時間になっていないか()
        {
            return _開始年月日時分.Value.Hour < 会議室オープン時刻;
        }

        private bool 会議室クローズ時間を超えているか()
        {
            return _終了年月日時分.Value.Hour > 会議室クローズ時刻 || 
                   (_終了年月日時分.Value.Hour == 会議室クローズ時刻 && _終了年月日時分.Value.Minute > 0);
        }
    }
}