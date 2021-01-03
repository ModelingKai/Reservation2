using System;

namespace 会議室予約.Domain.予約
{
    public class 予約Id : IEquatable<予約Id>
    {
        private string Value { get; }
        
        public 予約Id(string value)
        {
            Value = value;
        }

        public string AsString() {
            return Value;
        }

        public bool Equals(予約Id other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((予約Id) obj);
        }

        public override int GetHashCode()
        {
            return (Value != null ? Value.GetHashCode() : 0);
        }
    }
}