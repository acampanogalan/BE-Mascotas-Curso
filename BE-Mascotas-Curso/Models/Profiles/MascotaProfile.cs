using AutoMapper;

namespace BE_Mascotas_Curso.Models.Profiles
{
    public class MascotaProfile: Profile
    {
        public MascotaProfile()
        {
            CreateMap<Mascota, MascotaDTO>();
            CreateMap<MascotaDTO, Mascota>();
        }
    }
}
