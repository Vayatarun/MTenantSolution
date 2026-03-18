using System.Runtime.Serialization;

namespace MTenantSolution.Model.Enums
{

    public enum Gender
    {
        [EnumMember(Value = "Male")]
        Male,
        [EnumMember(Value = "Female")]
        Female,
        [EnumMember(Value = "Other")]
        Other
    }


}
