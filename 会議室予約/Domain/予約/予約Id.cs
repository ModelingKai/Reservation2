using System;

namespace 会議室予約.Domain.予約
{
    public class 予約Id
    {
        private string Value { get; }
        
        public 予約Id(string value)
        {
            Value = value;
        }

        public string AsString() {
            return Value;
        }
    }
}