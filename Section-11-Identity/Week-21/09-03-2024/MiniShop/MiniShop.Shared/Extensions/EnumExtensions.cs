using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace MiniShop.Shared.Extensions;

public static class EnumExtensions
{
    public static string GetDisplayName(this Enum value)
    {
        string result= value
            .GetType()
            .GetMember(value.ToString())
            .First()
            .GetCustomAttribute<DisplayAttribute>()
            ?.GetName();
        // buraya gelen enum tipinin içine baktığında display att varsa onun name'ini al. demek için.
        // ? ise oraya kadar olan kısım null değilse yap demek için.
        return result;
    }
}