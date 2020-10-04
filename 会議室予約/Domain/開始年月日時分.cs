using System;

namespace 会議室予約.Domain
{
    public class 開始年月日時分
    {
        public DateTime Value { get; }

        public 開始年月日時分(DateTime value)
        {
            this.Value = value;
        }
    }
}