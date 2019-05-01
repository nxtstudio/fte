using R = FTE.Hiring.Repos.Models;

namespace FTE.Hiring.Models.Converters
{
    public static class VacancyConverters
    {
        public static R.Vacancy Convert(Vacancy vacancy)
        {
            return new R.Vacancy
            {
                Id = vacancy.Id,
                Title = vacancy.Title
            };
        }

        public static Vacancy Convert(R.Vacancy vacancy)
        {
            return new Vacancy
            {
                Id = vacancy.Id,
                ProcessId = vacancy.Process.Id,
                Title = vacancy.Title
            };
        }
    }
}
