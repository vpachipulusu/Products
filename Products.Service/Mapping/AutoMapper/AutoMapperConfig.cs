using AutoMapper;
using Products.Domain.DataModels.Address;
using Products.Domain.DataModels.Customer;
using Products.Domain.DataModels.Organization;
using Products.Domain.DataModels.Product;
using Products.Domain.DataModels.Sales;
using Products.Domain.DataModels.Users;
using Products.Domain.Dto.Address;
using Products.Domain.Dto.Customer;
using Products.Domain.Dto.Organization;
using Products.Domain.Dto.Product;
using Products.Domain.Dto.Sales;
using Products.Domain.Dto.Users;

namespace Products.Service.Mapping.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            MapEntities();
        }

        private void MapEntities()
        {
            CreateMap<AddressBase, AddressBaseViewModel>().ReverseMap();
            CreateMap<AddressTypeBase, AddressTypeBaseViewModel>().ReverseMap();

            CreateMap<CustomerBase, CustomerBaseViewModel>().ReverseMap();
            CreateMap<OrganizationBase, OrganizationBaseViewModel>().ReverseMap();

            CreateMap<ProductBase, ProductBaseViewModel>().ReverseMap();

            CreateMap<SalesOrderBase, SalesOrderBaseViewModel>().ReverseMap();
            CreateMap<SalesOrderProductBase, SalesOrderProductBaseViewModel>().ReverseMap();
            CreateMap<SalesOrderProductStatusBase, SalesOrderProductStatusBaseViewModel>().ReverseMap();
            CreateMap<SalesOrderProductStatusBase, SalesOrderProductStatusBaseViewModel>().ReverseMap();

            CreateMap<UserBase, UserBaseViewModel>().ReverseMap();
            CreateMap<UserRoleBase, UserRoleBaseViewModel>().ReverseMap();
        }
    }
}
