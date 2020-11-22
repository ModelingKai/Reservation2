using System;
using Xunit;
using Xunit.Sdk;
using 会議室予約.Domain;
using 会議室予約.Domain.Exceptions;
using 会議室予約.Domain.予約;
using 会議室予約.Domain.予約.利用期間;
using 会議室予約.Domain.会議室;

namespace Test
{
    public class Test予約
    {
        [Fact]
        public void 利用期間が10時より前を含んでいると予約ができない()
        {
            var かいし = new 開始年月日時分(2020, 10, 20, 9, 0);
            var しゅうりょう = new 終了年月日時分(2020, 10, 20, 11,0);
            var 起点日 = new DateTime(2020, 10, 19);

            var 利用期間 = new 利用期間(かいし, しゅうりょう, 起点日);


            Assert.Throws<ルール違反Exception>(() =>
                new 予約(new 予約者Id(), 利用期間, new 会議室Id(), new 会議参加予定者())
            );
        }

        [Fact]
        public void 利用期間が19時より後を含んでいると予約ができない()
        {
            var かいし = new 開始年月日時分(2020, 10, 20, 10, 0);
            var しゅうりょう = new 終了年月日時分(2020, 10, 20, 19,15);
            var 起点日 = new DateTime(2020, 10, 19);

            var 利用期間 = new 利用期間(かいし, しゅうりょう, 起点日);

            Assert.Throws<ルール違反Exception>(() =>
                new 予約(new 予約者Id(), 利用期間, new 会議室Id(), new 会議参加予定者())
            );
        }
        [Fact]
        public void 利用期間が30日より先だと予約ができない()
        {
            var かいし = new 開始年月日時分(2021, 10, 20, 10, 0);
            var しゅうりょう = new 終了年月日時分(2021, 10, 20, 10,15);
            var 起点日 = new DateTime(2020, 10, 19);

            var 利用期間 = new 利用期間(かいし, しゅうりょう, 起点日);

            Assert.Throws<ルール違反Exception>(() =>
                new 予約(new 予約者Id(), 利用期間, new 会議室Id(), new 会議参加予定者())
            );
        }
        
    }
}