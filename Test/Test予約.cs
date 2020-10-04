using System;
using Xunit;
using Xunit.Sdk;
using 会議室予約.Domain;

namespace Test
{
    public class Test予約
    {
        [Fact]
        public void 利用期間が10時より前を含んでいると予約ができない()
        {
            var かいし = new 開始年月日時分(2020, 10, 20, 9, 0);
            var しゅうりょう = new 終了年月日時分(2020, 10, 20, 11,0);
            
            // TODO:DateTime.Nowはかなり怪しい。けど、頭がふやふやなので、いまはこれでいく。
            Assert.Throws<ArgumentException>(() =>  new 利用期間(かいし,しゅうりょう, DateTime.Now));
        }
        [Fact]
        public void 利用期間が19時より後を含んでいると予約ができない()
        {
            var かいし = new 開始年月日時分(2020, 10, 20, 10, 0);
            var しゅうりょう = new 終了年月日時分(2020, 10, 20, 19,15);
            
            // TODO:DateTime.Nowはかなり怪しい。けど、頭がふやふやなので、いまはこれでいく。
            Assert.Throws<ArgumentException>(() =>  new 利用期間(かいし,しゅうりょう, DateTime.Now));
            
        }
        [Fact]
        public void 利用期間が30日より先だと予約ができない()
        {
            var かいし = new 開始年月日時分(2021, 10, 20, 10, 0);
            var しゅうりょう = new 終了年月日時分(2021, 10, 20, 10,15);
            
            // TODO:DateTime.Nowはかなり怪しい。けど、頭がふやふやなので、いまはこれでいく。
            Assert.Throws<ArgumentException>(() =>  new 利用期間(かいし,しゅうりょう, DateTime.Now));
        }
        
    }
}