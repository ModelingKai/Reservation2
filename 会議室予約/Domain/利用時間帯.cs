using System;

namespace 会議室予約.Domain
{
    public class 利用時間帯 : IEquatable<利用時間帯>
    {
        public 時分 _かいしじふん { get; }
        public 時分 _しゅうりょうじふん { get; }

        public 利用時間帯(時分 かいしじふん, 時分 しゅうりょうじふん )
        {
            _かいしじふん = かいしじふん;
            _しゅうりょうじふん = しゅうりょうじふん;
        }
        
        // public class 利用時間帯

        public bool IsOverrap(利用時間帯 other)
        {
            if (this.Equals(other)) return true;
            if (this._しゅうりょうじふん.CompareTo(other._かいしじふん) > 0) return true;
            return false;
        }


        public bool Equals(利用時間帯 other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return this._かいしじふん.Equals(other._かいしじふん) && 
                   this._しゅうりょうじふん.Equals(other._しゅうりょうじふん);
        }
    }
}