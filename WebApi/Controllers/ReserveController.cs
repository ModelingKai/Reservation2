using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using 会議室予約.Domain.予約;
using 会議室予約.Domain.予約.利用期間;
using 会議室予約.Domain.予約可能ルール;
using 会議室予約.Domain.会議室;
using 会議室予約.Infrastructure;
using 会議室予約.UseCase;
using 会議室予約.UseCase.RepositoryInterfaces;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReserveController : ControllerBase
    {
        private static I予約Repository _repository;
        private static I予約IdFactory _factory;
        private static UseCase _useCase;
        static ReserveController()
        {
            _repository = new InMemory予約Repository();
            _factory = new 予約IdFactory();
            _useCase = new UseCase(_repository, _factory);
        }
        
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ReserveController> _logger;

        public ReserveController(ILogger<ReserveController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult> Post(Reserve reserve)
        {
            // var repository = new InMemory予約Repository();
            // var factory = new 予約IdFactory();
            // var useCase = new UseCase(_repository, factory);
            
            var request = new 予約Request();

            var かいし = new 開始年月日時分(reserve.start_datetime.Year,
                                        reserve.start_datetime.Month,
                                        reserve.start_datetime.Day,
                                        reserve.start_datetime.Hour,
                                        reserve.start_datetime.Minute);
            
            var しゅうりょう = new 終了年月日時分(reserve.end_datetime.Year,
                                        reserve.end_datetime.Month,
                                        reserve.end_datetime.Day,
                                        reserve.end_datetime.Hour,
                                        reserve.end_datetime.Minute);

            var 起点日 = DateTime.Now;
            
            request.りようきかん = new 利用期間(かいし, しゅうりょう);
            
            // Todo: パラメータ無視している
            request.かいぎさんかよていしゃ = new 会議参加予定者();
            request.よやくしゃ = new 予約者Id();
            request.かいぎしつ = new 会議室Id();

            try
            {
                await _useCase.会議室予約するAsync(request, new 予約申請受付日(起点日));
            }
            catch (Exception e) {

                var resp = new HttpResponseMessage(HttpStatusCode.Conflict)
                {
                    //Content = new StringContent(e.InnerException.Message),
                    ReasonPhrase = e.InnerException.Message
                };
                //throw new System.Web.Http.HttpResponseException(resp);
                return new JsonResult(resp);
            }
            return new JsonResult(reserve);
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var result = await _useCase.会議室一覧を取得するAsync();
            

            
            return new JsonResult(result);
        }
    }
}
