using System;
using System.Collections.Generic;
using System.Text;

namespace 会議室予約.Domain.予約.Query
{
    public class 予約QueryModel
    {
        public string 予約Id { get; private set; }
        public 利用期間.利用期間 りようきかん { get; private set; }

        public 予約QueryModel(予約Id 予約Id, 利用期間.利用期間 りようきかん)
        {
            this.予約Id = 予約Id.AsString();
            this.りようきかん = りようきかん;
        }
    }
}
