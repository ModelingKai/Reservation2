using System;

namespace 会議室予約.Domain
{
    public class 利用期間
    {
        // private 開始年月日時分 かいしねんがっぴじふん;
        // private 終了年月日時分 しゅうりょうねんがっぴじふん;
        private 開始年月日時分 かいしねんがっぴじふん;
        private 終了年月日時分 しゅうりょうねんがっぴじふん;

        public 利用期間(開始年月日時分 かいしねんがっぴじふん, 終了年月日時分 しゅうりょうねんがっぴじふん, DateTime きょうのひづけ)
        {
            if(!new 予約可能ルール(かいしねんがっぴじふん, しゅうりょうねんがっぴじふん, きょうのひづけ).IsSatisfied())
                throw new ArgumentException();
 
            this.かいしねんがっぴじふん = かいしねんがっぴじふん;
            this.しゅうりょうねんがっぴじふん = しゅうりょうねんがっぴじふん;
        }
    }
}