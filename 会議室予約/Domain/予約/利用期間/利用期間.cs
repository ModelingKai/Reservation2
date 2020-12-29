using System;
using 会議室予約.Domain.予約可能ルール.開放時間;

namespace 会議室予約.Domain.予約.利用期間
{
    public class 利用期間
    {
        private 開始年月日時分 _開始年月日時分;
        private 終了年月日時分 _終了年月日時分;

        public 利用期間(開始年月日時分 開始年月日時分, 終了年月日時分 終了年月日時分)
        {
            this._開始年月日時分 = 開始年月日時分;
            this._終了年月日時分 = 終了年月日時分;
        }

        public 開放時間 りようじかんたい()
        {
            時分 かいしじふん = new 時分(_開始年月日時分.Value.Hour, _開始年月日時分.Value.Minute);
            時分 しゅうりょうじふん = new 時分(_終了年月日時分.Value.Hour, _終了年月日時分.Value.Minute);
            return new 開放時間(かいしじふん, しゅうりょうじふん);
        }
    }
}