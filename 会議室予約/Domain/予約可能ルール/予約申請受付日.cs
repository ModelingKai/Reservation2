using System;

namespace 会議室予約.Domain.予約可能ルール
{
    public class 予約申請受付日
    {
        private DateTime _value;

        public 予約申請受付日(DateTime value)
        {
            _value = value;
            
        }

        public DateTime 日付 {
            get => _value.Date;
        }
        
    }
}