using Business.Abstract;
using Entities.Conrete;
using MernisServiceReference;

namespace Business.Concrete
{
    // Çıplak class kalmasın
    public class PersonManager:IApplicantService
    {
        
        //encapsulation
        public void ApplyForMask(Person person)

        {

        }

        public List<Person> GetList() 
        {
            return null;
        }

        public bool CheckPerson(Person person) // ptt vatandaş mı kontrol edecek.
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear ))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
