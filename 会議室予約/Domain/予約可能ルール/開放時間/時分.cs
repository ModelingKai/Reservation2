using System;

namespace 会議室予約.Domain.予約可能ルール.開放時間
{
    public class 時分 : IEquatable<時分>, IComparable<時分>
    {
        private DateTime Value { get; set; }

        public 時分(int hour, int minute)
        {
            // TODO: 2000, 1, 1で固定は怪しい。普通にintで持っていてもいいかもしれない
            this.Value = new DateTime(2000, 1, 1, hour, minute, 0);
        }

        public int Hour()
        {
            return Value.Hour;
        }

        public int Minute()
        {
            return Value.Minute;
        }

        public bool Equals(時分 other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return this.Hour() == other.Hour() && this.Minute() == other.Minute();
        }

        public int CompareTo(時分 other)
        {
            if (other == null) return 1;

            if (ReferenceEquals(this, other)) return 0;

            var hourCompareResult = this.Hour().CompareTo(other.Hour());
            if (hourCompareResult == 0)
            {
                return this.Minute().CompareTo(other.Minute());
            }
            else
            {
                return hourCompareResult;
            }
        }
        //
        // public static bool operator <(時分 self, 時分 other)
        // {
        //     if (self.CompareTo(other) > 0) return
        // }
    }
}