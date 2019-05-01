using System.Linq;
using R = FTE.Hiring.Repos.Models;

namespace FTE.Hiring.Models.Converters
{
    public static class PropertyConverter
    {
        public static R.Property Convert(Property property)
        {
            return new R.Property
            {
                Id = property.Id,
                DataType = property.DataType,
                DefaultValue = property.DefaultValue,
                PossibleValues = property.PossibleValues,
                Required = property.Required,
                Title = property.Title
            };
        }

        public static Property Convert(R.Property property)
        {
            return new Property
            {
                Id = property.Id,
                DataType = property.DataType,
                DefaultValue = property.DefaultValue,
                PossibleValues = property.PossibleValues,
                Required = property.Required,
                Title = property.Title
            };
        }
    }
}
