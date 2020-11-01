using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;
using 会議室予約.Domain;

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
        [ClassData(typeof(時分テストデータ))]
        public void 利用時間帯の比較テストNGパターン(時分 sut_start, 時分 sut_end, 時分 other_start, 時分 other_end)
        {
            var sut = new 利用時間帯(sut_start, sut_end);
            var other = new 利用時間帯(other_start, other_end);

            Assert.True(sut.IsOverrap(other));
        }
        
        
    }

    public class 時分テストデータ : IEnumerable<object[]>
    {
        List<object[]> _testData = new List<object[]>();

        public 時分テストデータ()
        {
            _testData.Add(new object[]
            {
                new 時分(10,0),new 時分(12, 0),
                new 時分(13, 0), new 時分(14, 0),
            });
            _testData.Add(new object[]
            {
                new 時分(10,0),new 時分(12, 0),
                new 時分(9, 0), new 時分(11, 0),
            });
            _testData.Add(new object[]
            {
                new 時分(10,0),new 時分(12, 0),
                new 時分(10, 0), new 時分(12, 0),
            });
        }
        public IEnumerator<object[]> GetEnumerator() => _testData.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
}