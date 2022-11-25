namespace ClassAdapter
{
    public class CityFromExternalSystem
    {
        public string Name { get; set; }

        public string NickName { get; set; }

        public int Inhabitants { get; set; }

        public CityFromExternalSystem(string name, string nickName, int inhabitants)
        {
            Name = name;
            NickName = nickName;
            Inhabitants = inhabitants;
        }
    }

    public class ExternalSystem
    {
        public CityFromExternalSystem GetCity()
        {
            return new CityFromExternalSystem("Antwerp", "t stad", 500000);
        }
    }

    public class City
    {
        public string FullName { get; set; }

        public long Inhabitants { get; set; }

        public City(string fullName, long inhabitants)
        {
            FullName = fullName;
            Inhabitants = inhabitants;
        }
    }

    public interface ICityAdapter
    {
        City GetCity();
    }

    public class CityAdapter : ExternalSystem, ICityAdapter
    {
        public City GetCity()
        {
            //Call into the external system
            var cityFromExternalSystem = base.GetCity();

            return new City(
                $"{cityFromExternalSystem.Name} - {cityFromExternalSystem.NickName}",
                cityFromExternalSystem.Inhabitants);
        }
    }
}