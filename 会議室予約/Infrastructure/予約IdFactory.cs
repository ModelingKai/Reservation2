using System;
using System.Collections.Generic;
using System.Text;
using 会議室予約.Domain.予約;

namespace 会議室予約.Infrastructure
{
    public class 予約IdFactory : I予約IdFactory
    {
        public 予約Id Create()
        {
            return new 予約Id(Guid.NewGuid().ToString());
        }
    }
}
