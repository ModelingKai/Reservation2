using System;
using System.Collections.Generic;
using System.Text;
using 会議室予約.Domain.予約;

namespace 会議室予約.Infrastructure
{
    class 予約IdFactory : I予約IdFactory
    {
        public 予約Id Create()
        {
            return new 予約Id(Guid.NewGuid().ToString());
        }
    }
}
