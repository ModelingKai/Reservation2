using System;

namespace 会議室予約.Domain
{
    /// <summary>
    /// 利用可能日：名前付けられた式
    /// </summary>
    internal class 予約可能ルール
    {
        private 開始年月日時分 _開始年月日時分;
        private 終了年月日時分 _終了年月日時分;
        // TODO: これは本当にDateTimeでいいのか?
        private DateTime _予約可能期間の起点日;
        
        public 予約可能ルール(開始年月日時分 かいしねんがっぴじふん, 終了年月日時分 しゅうりょうねんがっぴじふん, DateTime 予約可能期間の起点日)
        {
            this._開始年月日時分 = かいしねんがっぴじふん;
            this._終了年月日時分 = しゅうりょうねんがっぴじふん;
            this._予約可能期間の起点日 = 予約可能期間の起点日;
        }

        public bool IsSatisfied()
        {
            if (_開始年月日時分.Value.Hour < 10)
                return false;
            
            if (_終了年月日時分.Value.Hour > 19 || 
                (_終了年月日時分.Value.Hour == 19 && _終了年月日時分.Value.Minute > 0))
                return false;


            var 利用可能日 = new 利用可能日(_予約可能期間の起点日);
            if (!利用可能日.含むのかしら(_開始年月日時分)) {
                return false;
            }


            return true;

        }
    }
}