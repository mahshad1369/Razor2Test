using System.Reflection;

namespace Razor2Test;

public static class Helper
{
    public static void Map<T1, T2>(T1 source, T2 destination)
    {
        Type sourceType = typeof(T1);
        Type destinationType = typeof(T2);

        PropertyInfo[] sourceProperties = sourceType.GetProperties();
        PropertyInfo[] destinationProperties = destinationType.GetProperties();

        foreach (var sourceProperty in sourceProperties)
        {
            foreach (var destinationProperty in destinationProperties)
            {
                if (sourceProperty.Name == destinationProperty.Name && sourceProperty.PropertyType == destinationProperty.PropertyType)
                {
                    object value = sourceProperty.GetValue(source);
                    destinationProperty.SetValue(destination, value);
                    break;
                }
            }
        }
    }
}
