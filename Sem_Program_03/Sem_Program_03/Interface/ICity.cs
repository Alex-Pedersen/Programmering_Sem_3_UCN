using Sem_Program_03.Classes;

namespace Sem_Program_03.Interface
{
    internal interface ICity
    {
        City CreateCity(string cityName, string cityLocation, int cityTaxAmount, Person person);
        City ReadCity(string cityName, string cityLocation);
        void UpdateCity(string cityName, string cityLocation, int cityTaxAmount, Person person);
        void DeleteCity(string cityName, string cityLocation);
    }
}