using System;

namespace Com.GenericPlatform.Services.Base
{
    public class GenericService
    {
        public static void Copy<TSource, TDestination>(TSource source, TDestination destination) 
            where TSource : class
            where TDestination : class
        {
            var parentProperties = source.GetType().GetProperties();
            var childProperties = destination.GetType().GetProperties();

            foreach (var parentProperty in parentProperties)
            {
                foreach (var childProperty in childProperties)
                {
                    if (parentProperty.Name == childProperty.Name && parentProperty.PropertyType == childProperty.PropertyType)
                    {
                        childProperty.SetValue(destination, parentProperty.GetValue(source));
                        break;
                    }
                }
            }
        }
    }
}
