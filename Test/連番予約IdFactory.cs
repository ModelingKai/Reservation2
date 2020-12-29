using System;
using System.Collections.Generic;
using System.Text;
using 会議室予約.Domain.予約;

namespace Test
{
    class 連番予約IdFactory : I予約IdFactory
    {
        private int nextNumber = 0;
        
        public 予約Id Create()
        {
            var よやくId = new 予約Id(nextNumber.ToString());
            nextNumber++;
            return よやくId;
        }
    }
}
