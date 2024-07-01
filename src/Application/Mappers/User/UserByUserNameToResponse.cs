using Application.Response.User;
using AutoMapper;
using Domain.Entities.User;

namespace Application.Mappers.User
{
    public class UserByUserNameToResponse : Profile
    {
        public UserByUserNameToResponse() => CreateMap<Users, UsersResponse>();
            //.ForMember(destinationMember: dest => dest.Id, memberOptions: opt => opt.MapFrom(src => src.Id.ToString()))
            //.ForMember(destinationMember: dest => dest.EmpNumber, memberOptions: opt => opt.MapFrom(src => src.emp_no.ToString()))
            //.ForMember(destinationMember: dest => dest.UserName, memberOptions: opt => opt.MapFrom(src => src.user_name.ToString()))
            //.ForMember(destinationMember: dest => dest.FirstName, memberOptions: opt => opt.MapFrom(src => src.first_name.ToString()))
            //.ForMember(destinationMember: dest => dest.LastName, memberOptions: opt => opt.MapFrom(src => src.last_name.ToString()))
            //.ForMember(destinationMember: dest => dest.Email, memberOptions: opt => opt.MapFrom(src => src.email.ToString()))
            //.ForMember(destinationMember: dest => dest.Contact, memberOptions: opt => opt.MapFrom(src => src.contact.ToString()))
            //.ForMember(destinationMember: dest => dest.Photo, memberOptions: opt => opt.MapFrom(src => System.Text.Encoding.UTF8.GetString(src.user_photo)))
            //.ForMember(destinationMember: dest => dest.CreatedBy, memberOptions: opt => opt.MapFrom(src => src.created_by.ToString()))
            //.ForMember(destinationMember: dest => dest.CreatedOn, memberOptions: opt => opt.MapFrom(src => src.created_on.ToString()))
            //.ForMember(destinationMember: dest => dest.LastModifiedBy, memberOptions: opt => opt.MapFrom(src => src.last_modified_by.ToString()))
            //.ForMember(destinationMember: dest => dest.LastModifiedOn, memberOptions: opt => opt.MapFrom(src => src.last_modified_on.ToString()))
            //.ForMember(destinationMember: dest => dest.IsActive, memberOptions: opt => opt.MapFrom(src => src.is_active.ToString()))
            //.ForMember(destinationMember: dest => dest.CustomerId, memberOptions: opt => opt.MapFrom(src => src.cust_id.ToString()))
            //.ForMember(destinationMember: dest => dest.CompanyId, memberOptions: opt => opt.MapFrom(src => src.comp_id.ToString()))
            //.ForMember(destinationMember: dest => dest.CustomerCode, memberOptions: opt => opt.MapFrom(src => src.cust_code.ToString()))
            //.ForMember(destinationMember: dest => dest.CompanyCode, memberOptions: opt => opt.MapFrom(src => src.comp_code.ToString()))
            //.ForMember(destinationMember: dest => dest.RoleId, memberOptions: opt => opt.MapFrom(src => src.role_id.ToString()))
            //.ForMember(destinationMember: dest => dest.RoleName, memberOptions: opt => opt.MapFrom(src => src.role_name.ToString()));
    }
}
