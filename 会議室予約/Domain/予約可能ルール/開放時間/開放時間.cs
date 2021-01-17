using System;

namespace 会議室予約.Domain.予約可能ルール.開放時間
{
    public class 開放時間 : IEquatable<開放時間>
    {
        public 時分 _かいしじふん { get; }
        public 時分 _しゅうりょうじふん { get; }

        public 開放時間(時分 かいしじふん, 時分 しゅうりょうじふん )
        {
            _かいしじふん = かいしじふん;
            _しゅうりょうじふん = しゅうりょうじふん;
        }
        
        // public class 利用時間帯

        public bool IsOverrap(開放時間 other)
        {
            if (this.Equals(other)) return true;
            if (this._しゅうりょうじふん.CompareTo(other._かいしじふん) > 0) return true;
            return false;
        }


        public bool Equals(開放時間 other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return this._かいしじふん.Equals(other._かいしじふん) 
                   && this._しゅうりょうじふん.Equals(other._しゅうりょうじふん);
        }

        public bool IsContains(開放時間 other)
        {
            if (this.Equals(other)) return true;
            return this._かいしじふん.CompareTo(other._かいしじふん) <= 0
                   && this._しゅうりょうじふん.CompareTo(other._しゅうりょうじふん) >= 0;
        }
    }
}