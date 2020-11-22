using 会議室予約.Domain;
using 会議室予約.Domain.予約;
using 会議室予約.Domain.予約.利用期間;
using 会議室予約.Domain.会議室;

namespace 会議室予約.UseCase
{
    /// <summary>
    /// イメージ共有のための、予約者Requestのコード
    /// </summary>
    public class 予約Request
    {
        public 予約者Id よやくしゃ { get; set; }
        public 利用期間 りようきかん { get; set; }
        public 会議室Id かいぎしつ { get; set; }
        public 会議参加予定者 かいぎさんかよていしゃ { get; set; }
        
    }
}