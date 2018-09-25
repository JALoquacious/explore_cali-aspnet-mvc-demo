using System;

namespace ExploreCalifornia.Infrastructure
{
    public class FormattingService
    {
        public string AsReadableDate(DateTime date)
        {
            return date.ToString("d");
        }
    }
}
