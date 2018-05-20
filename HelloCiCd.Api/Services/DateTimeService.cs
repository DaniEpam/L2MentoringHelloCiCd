using System;

namespace HelloCiCd.Api.Services
{
    public interface IDateTimeService
    {
        DateTime GetUtc();
    }

    public class DateTimeService : IDateTimeService
    {
        public DateTime GetUtc()
        {
            return DateTime.Now;
        }
    }
}
