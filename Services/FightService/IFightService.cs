using System.Threading.Tasks;
using DOTNET_RPG.Dtos.Fight;
using DOTNET_RPG.Models;

namespace DOTNET_RPG.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
    }
}