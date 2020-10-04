using System;
using Xunit;


namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void とりあえず動くことを確かめる()
        {
            1.Is(2);
        }

        [Fact]
        public void 会議室を予約する()
        {
            // どんなメソッド呼ぶ？
            usecase.会議室を予約をする();
            
            true.Is(false);
            
        }
    }
}