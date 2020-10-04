using System;

namespace 会議室予約.Domain
{
    /// <summary>
    /// 利用可能日：名前付けられた式
    /// </summary>
    internal class 予約可能ルール
    {
        private 開始年月日時分 かいしねんがっぴじふん;
        private 終了年月日時分 しゅうりょうねんがっぴじふん;
        // TODO: これは本当にDateTimeでいいのか?
        private DateTime きょうのひづけ;
        
        public 予約可能ルール(開始年月日時分 かいしねんがっぴじふん, 終了年月日時分 しゅうりょうねんがっぴじふん, DateTime きょうのひづけ)
        {
            this.かいしねんがっぴじふん = かいしねんがっぴじふん;
            this.しゅうりょうねんがっぴじふん = しゅうりょうねんがっぴじふん;
            this.きょうのひづけ = きょうのひづけ;
        }

        public bool isSatisfied()
        {
            if (かいしねんがっぴじふん.Value.Hour < 10)
                return false;
            
            if (しゅうりょうねんがっぴじふん.Value.Hour > 19 || 
                (しゅうりょうねんがっぴじふん.Value.Hour == 19 && しゅうりょうねんがっぴじふん.Value.Minute > 0))
                return false;

            return true;

        }
    }
}