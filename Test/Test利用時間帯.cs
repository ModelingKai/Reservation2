using System.Collections;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;
using 会議室予約.Domain;
using 会議室予約.Domain.予約;

namespace Test
{
    public class Test利用時間帯
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public Test利用時間帯(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Theory]
        [ClassData(typeof(利用時間帯テストデータ))]
        public void 利用時間帯の比較テストNGパターン(時分 sut_start, 時分 sut_end, 時分 other_start, 時分 other_end)
        {
            var sut = new 利用時間帯(sut_start, sut_end);
            var other = new 利用時間帯(other_start, other_end);

            Assert.True(sut.IsOverrap(other));
        }

        [Theory]
        [ClassData(typeof(利用時間帯IsContainsデータ))]
        public void 利用時間帯のIsContains成功パターン(時分 sut_start, 時分 sut_end, 時分 other_start, 時分 other_end)
        {
            var sut = new 利用時間帯(sut_start, sut_end);
            var other = new 利用時間帯(other_start, other_end);

            Assert.True(sut.IsContains(other));
        }
        [Theory]
        [ClassData(typeof(利用時間帯IsContains失敗データ))]
        public void 利用時間帯のIsContains失敗パターン(時分 sut_start, 時分 sut_end, 時分 other_start, 時分 other_end)
        {
            var sut = new 利用時間帯(sut_start, sut_end);
            var other = new 利用時間帯(other_start, other_end);

            Assert.False(sut.IsContains(other));
        }
    }

    public class 利用時間帯テストデータ : IEnumerable<object[]>
    {
        List<object[]> _testData = new List<object[]>();

        public 利用時間帯テストデータ()
        {
            _testData.Add(new object[]
            {
                new 時分(10,0),new 時分(12, 0),  // |========    |
                new 時分(11, 0), new 時分(14, 0),// |    ========|
            });
            _testData.Add(new object[]
            {
                new 時分(10,0),new 時分(12, 0),  // |    ========|
                new 時分(9, 0), new 時分(11, 0), // |========    |
            });
            _testData.Add(new object[]
            {
                new 時分(10,0),new 時分(12, 0),  // |============|
                new 時分(10, 0), new 時分(12, 0),// |============|
            });
            _testData.Add(new object[]
            {
                new 時分(10,0),new 時分(12, 0),   // |============|
                new 時分(11, 0), new 時分(11, 45),// |    =====   |
            });
            _testData.Add(new object[]
            {
                new 時分(10,0),new 時分(12, 0),  // |    =====   |
                new 時分(9, 0), new 時分(16, 0), // |============|
            });
            
        }
        public IEnumerator<object[]> GetEnumerator() => _testData.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
    
    public class 利用時間帯IsContainsデータ : IEnumerable<object[]>
    {
        List<object[]> _testData = new List<object[]>();

        public 利用時間帯IsContainsデータ()
        {
            _testData.Add(new object[]
            {
                new 時分(10,0),new 時分(12, 0),  // |============|
                new 時分(10, 0), new 時分(12, 0),// |============|
            });
            _testData.Add(new object[]
            {
                new 時分(10,0),new 時分(12, 0),   // |============|
                new 時分(11, 0), new 時分(11, 45),// |    =====   |
            });
            
        }
        public IEnumerator<object[]> GetEnumerator() => _testData.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
    
    public class 利用時間帯IsContains失敗データ : IEnumerable<object[]>
    {
        List<object[]> _testData = new List<object[]>();

        public 利用時間帯IsContains失敗データ()
        {    
            _testData.Add(new object[]
            {
                new 時分(10,0),new 時分(12, 0),  // |========    |
                new 時分(11, 0), new 時分(14, 0),// |    ========|
            });
            _testData.Add(new object[]
            {
                new 時分(10,0),new 時分(12, 0),  // |    ========|
                new 時分(9, 0), new 時分(11, 0), // |========    |
            });
            _testData.Add(new object[]
            {
                new 時分(10,0),new 時分(12, 0),  // |    =====   |
                new 時分(9, 0), new 時分(16, 0), // |============|
            });
            
        }
        public IEnumerator<object[]> GetEnumerator() => _testData.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }

}