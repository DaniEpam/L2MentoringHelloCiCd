using System;
using HelloCiCd.Api.Services;

namespace HelloCiCd.Api.Test.Mocks
{
    public class MockDateTimeService : IDateTimeService
    {
        private readonly DateTime _resultDateTime;

        public MockDateTimeService(DateTime resultDateTime)
        {
            _resultDateTime = resultDateTime;
        }


        public DateTime GetUtc()
        {
            return _resultDateTime;
        }
    }
}
