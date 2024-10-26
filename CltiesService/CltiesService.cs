namespace Services
{
    public class CltiesService
    {
        private List<string> _cities;
        public CltiesService()
        {
            _cities = new List<string>() { 
                "Kodugallur",
                "SN puram",
                "Cochin",
                "Paravur",
                "Mathilakam",
                "Thamarakulam"
            };
        }

        public List<string> GetCities()
        {
            return _cities;
        }

    }
}
