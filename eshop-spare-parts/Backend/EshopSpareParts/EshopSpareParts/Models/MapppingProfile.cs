using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using EshopSpareParts.Models.Db;
using EshopSpareParts.Models.DTO;

namespace EshopSpareParts.Models
{
    public class MapppingProfile : Profile
    {

        public MapppingProfile()
        {
            CreateMap<User, UserDto>()
            .ForMember(d => d.id, o => o.MapFrom(s => s.Id))
            .ForMember(d => d.email, o => o.MapFrom(s => s.Email))
            .ForMember(d => d.phoneNumber, o => o.MapFrom(s => s.PhoneNumber))
            .ForMember(d => d.agreeTransaction, o => o.MapFrom(s => s.AgreeTransaction))
            .ForMember(d => d.agreeRegistration, o => o.MapFrom(s => s.AgreeRegistration))
            .ForMember(d => d.isAnonymous, o => o.MapFrom(s => s.IsAnonymous))
            .ForMember(d => d.name, o => o.MapFrom(s => s.Name))
            .ForMember(d => d.surname, o => o.MapFrom(s => s.Surname))
            .ForMember(d => d.town, o => o.MapFrom(s => s.Town))
            .ForMember(d => d.townNumber, o => o.MapFrom(s => s.TownNumber))
            .ForMember(d => d.isAdmin, o => o.MapFrom(s => s.IsAdmin))
            .ForMember(d => d.townStreet, o => o.MapFrom(s => s.TownStreet));


            CreateMap<UserDto, User>()
            .ForMember(d => d.Id, o => o.MapFrom(s => s.id))
            .ForMember(d => d.Email, o => o.MapFrom(s => s.email))
            .ForMember(d => d.PhoneNumber, o => o.MapFrom(s => s.phoneNumber))
            .ForMember(d => d.AgreeTransaction, o => o.MapFrom(s => s.agreeTransaction))
            .ForMember(d => d.AgreeRegistration, o => o.MapFrom(s => s.agreeRegistration))
            .ForMember(d => d.IsAnonymous, o => o.MapFrom(s => s.isAnonymous))
            .ForMember(d => d.Name, o => o.MapFrom(s => s.name))
            .ForMember(d => d.Surname, o => o.MapFrom(s => s.surname))
            .ForMember(d => d.Town, o => o.MapFrom(s => s.town))
            .ForMember(d => d.TownNumber, o => o.MapFrom(s => s.townNumber))
            .ForMember(d => d.IsAdmin, o => o.MapFrom(s => s.isAdmin))
            .ForMember(d => d.TownStreet, o => o.MapFrom(s => s.townStreet));

            CreateMap<Item, Item>()
               .ForMember(f => f.Created, opt => opt.Ignore());

            CreateMap<Item, ItemDto>()
            .ForMember(d => d.id, o => o.MapFrom(s => s.Id))
            .ForMember(d => d.title, o => o.MapFrom(s => s.Title))
            .ForMember(d => d.description, o => o.MapFrom(s => s.Description))
            .ForMember(d => d.imagePath, o => o.MapFrom(s => s.ImagePath))
            .ForMember(d => d.price, o => o.MapFrom(s => s.Price))
            .ForMember(d => d.available, o => o.MapFrom(s => s.Available))
            .ForMember(d => d.fakeDiscount, o => o.MapFrom(s => s.FakeDiscount))
            .ForMember(d => d.weight, o => o.MapFrom(s => s.Weight))
            .ForMember(d => d.itemAvailabilityId, o => o.MapFrom(s => s.ItemAvailabilityId))
            .ForMember(d => d.itemStateId, o => o.MapFrom(s => s.ItemStateId))
            .ForMember(d => d.itemState, o => o.MapFrom(s => s.ItemState))
            .ForMember(d => d.itemAvailability, o => o.MapFrom(s => s.ItemAvailability))
            .ForMember(d => d.itemState, o => o.MapFrom(s => s.ItemState))
            .ForMember(d => d.deliveryDate, o => o.MapFrom(s => s.DeliveryDate))
            .ForMember(d => d.categoryId, o => o.MapFrom(s => s.CategoryId));

            CreateMap<ItemDto, Item>()
            .ForMember(d => d.Id, o => o.MapFrom(s => s.id))
            .ForMember(d => d.Title, o => o.MapFrom(s => s.title))
            .ForMember(d => d.Description, o => o.MapFrom(s => s.description))
            .ForMember(d => d.ImagePath, o => o.MapFrom(s => s.imagePath))
            .ForMember(d => d.Price, o => o.MapFrom(s => s.price))
            .ForMember(d => d.Available, o => o.MapFrom(s => s.available))
            .ForMember(d => d.FakeDiscount, o => o.MapFrom(s => s.fakeDiscount))
            .ForMember(d => d.Weight, o => o.MapFrom(s => s.weight))
            .ForMember(d => d.ItemAvailabilityId, o => o.MapFrom(s => s.itemAvailabilityId))
            .ForMember(d => d.ItemStateId, o => o.MapFrom(s => s.itemStateId))
            .ForMember(d => d.ItemState, o => o.MapFrom(s => s.itemState))
            .ForMember(d => d.ItemAvailability, o => o.MapFrom(s => s.itemAvailability))
            .ForMember(d => d.ItemState, o => o.MapFrom(s => s.itemState))
            .ForMember(d => d.DeliveryDate, o => o.MapFrom(s => s.deliveryDate))
            .ForMember(d => d.CategoryId, o => o.MapFrom(s => s.categoryId));

            CreateMap<Article, ArticleDto>()
              .ForMember(d => d.id, o => o.MapFrom(s => s.Id))
              .ForMember(d => d.header, o => o.MapFrom(s => s.Header))
              .ForMember(d => d.content, o => o.MapFrom(s => s.Content))
              .ForMember(d => d.imagePath, o => o.MapFrom(s => s.ImagePath))
              .ForMember(d => d.userId, o => o.MapFrom(s => s.UserId));

            CreateMap<ArticleDto, Article>()
              .ForMember(d => d.Id, o => o.MapFrom(s => s.id))
              .ForMember(d => d.Header, o => o.MapFrom(s => s.header))
              .ForMember(d => d.Content, o => o.MapFrom(s => s.content))
              .ForMember(d => d.ImagePath, o => o.MapFrom(s => s.imagePath))
              .ForMember(d => d.UserId, o => o.MapFrom(s => s.userId));

            CreateMap<ItemAvailability, ItemAvailabilityDto>()
               .ForMember(d => d.id, o => o.MapFrom(s => s.Id))
               .ForMember(d => d.title, o => o.MapFrom(s => s.Title));

            CreateMap<ItemAvailabilityDto, ItemAvailability>()
               .ForMember(d => d.Id, o => o.MapFrom(s => s.id))
               .ForMember(d => d.Title, o => o.MapFrom(s => s.title));

            CreateMap<TransportCompany, TransportCompanyDto>()
               .ForMember(d => d.id, o => o.MapFrom(s => s.Id))
               .ForMember(d => d.name, o => o.MapFrom(s => s.Name));

            CreateMap<TransportCompanyDto, TransportCompany>()
               .ForMember(d => d.Id, o => o.MapFrom(s => s.id))
               .ForMember(d => d.Name, o => o.MapFrom(s => s.name));

            CreateMap<PersonalData, PersonalDataDto>()
              .ForMember(d => d.id, o => o.MapFrom(s => s.Id))
              .ForMember(d => d.name, o => o.MapFrom(s => s.Name))
              .ForMember(d => d.surname, o => o.MapFrom(s => s.Surname))
              .ForMember(d => d.email, o => o.MapFrom(s => s.Email))
              .ForMember(d => d.phone, o => o.MapFrom(s => s.Phone));

            CreateMap<PersonalDataDto, PersonalData>()
              .ForMember(d => d.Id, o => o.MapFrom(s => s.id))
              .ForMember(d => d.Name, o => o.MapFrom(s => s.name))
              .ForMember(d => d.Surname, o => o.MapFrom(s => s.surname))
              .ForMember(d => d.Email, o => o.MapFrom(s => s.email))
              .ForMember(d => d.Phone, o => o.MapFrom(s => s.phone));

            CreateMap<BillingAddress, BillingAddressDto>()
              .ForMember(d => d.id, o => o.MapFrom(s => s.Id))
              .ForMember(d => d.town, o => o.MapFrom(s => s.Town))
              .ForMember(d => d.townNumber, o => o.MapFrom(s => s.TownNumber))
              .ForMember(d => d.townStreet, o => o.MapFrom(s => s.TownStreet));

            CreateMap<BillingAddressDto, BillingAddress>()
              .ForMember(d => d.Id, o => o.MapFrom(s => s.id))
              .ForMember(d => d.Town, o => o.MapFrom(s => s.town))
              .ForMember(d => d.TownNumber, o => o.MapFrom(s => s.townNumber))
              .ForMember(d => d.TownStreet, o => o.MapFrom(s => s.townStreet));

            CreateMap<OrderDifferentDataAndAddress, OrderDifferentDataAndAddressDto>()
              .ForMember(d => d.id, o => o.MapFrom(s => s.Id))
              .ForMember(d => d.town, o => o.MapFrom(s => s.Town))
              .ForMember(d => d.townNumber, o => o.MapFrom(s => s.TownNumber))
              .ForMember(d => d.townStreet, o => o.MapFrom(s => s.TownStreet))
              .ForMember(d => d.name, o => o.MapFrom(s => s.Name))
              .ForMember(d => d.surname, o => o.MapFrom(s => s.Surname))
              .ForMember(d => d.email, o => o.MapFrom(s => s.Email))
              .ForMember(d => d.phone, o => o.MapFrom(s => s.Phone));

            CreateMap<OrderDifferentDataAndAddressDto, OrderDifferentDataAndAddress>()
              .ForMember(d => d.Id, o => o.MapFrom(s => s.id))
              .ForMember(d => d.Town, o => o.MapFrom(s => s.town))
              .ForMember(d => d.TownNumber, o => o.MapFrom(s => s.townNumber))
              .ForMember(d => d.TownStreet, o => o.MapFrom(s => s.townStreet))
              .ForMember(d => d.Name, o => o.MapFrom(s => s.name))
              .ForMember(d => d.Surname, o => o.MapFrom(s => s.surname))
              .ForMember(d => d.Email, o => o.MapFrom(s => s.email))
              .ForMember(d => d.Phone, o => o.MapFrom(s => s.phone));

            CreateMap<TransportCompanyDto, TransportCompany>()
               .ForMember(d => d.Id, o => o.MapFrom(s => s.id))
               .ForMember(d => d.Name, o => o.MapFrom(s => s.name));

            CreateMap<Order, OrderDto>();

            CreateMap<OrderDto, Order>();

            CreateMap<Category, CategoryDto>();

            CreateMap<CategoryDto, Category>();

            CreateMap<CompleteOrderSummary, CompleteOrderSummaryDto>()
               .ForMember(d => d.id, o => o.MapFrom(s => s.Id))
               .ForMember(d => d.name, o => o.MapFrom(s => s.Name))
               .ForMember(d => d.surname, o => o.MapFrom(s => s.Surname))
               .ForMember(d => d.email, o => o.MapFrom(s => s.Email))
               .ForMember(d => d.phone, o => o.MapFrom(s => s.Phone))
               .ForMember(d => d.deliveryTown, o => o.MapFrom(s => s.DeliveryTown))
               .ForMember(d => d.deliveryTownNumber, o => o.MapFrom(s => s.DeliveryTownNumber))
               .ForMember(d => d.deliveryTownStreet, o => o.MapFrom(s => s.DeliveryTownStreet))
               .ForMember(d => d.invoiceTown, o => o.MapFrom(s => s.InvoiceTown))
               .ForMember(d => d.invoiceTownNumber, o => o.MapFrom(s => s.InvoiceTownNumber))
               .ForMember(d => d.invoiceTownStreet, o => o.MapFrom(s => s.InvoiceTownStreet))
               .ForMember(d => d.totalPrice, o => o.MapFrom(s => s.TotalPrice));

            CreateMap<CompleteOrderSummaryDto, CompleteOrderSummary>()
               .ForMember(d => d.Id, o => o.MapFrom(s => s.id))
               .ForMember(d => d.Name, o => o.MapFrom(s => s.name))
               .ForMember(d => d.Surname, o => o.MapFrom(s => s.surname))
               .ForMember(d => d.Email, o => o.MapFrom(s => s.email))
               .ForMember(d => d.Phone, o => o.MapFrom(s => s.phone))
               .ForMember(d => d.DeliveryTown, o => o.MapFrom(s => s.deliveryTown))
               .ForMember(d => d.DeliveryTownNumber, o => o.MapFrom(s => s.deliveryTownNumber))
               .ForMember(d => d.DeliveryTownStreet, o => o.MapFrom(s => s.deliveryTownStreet))
               .ForMember(d => d.InvoiceTown, o => o.MapFrom(s => s.invoiceTown))
               .ForMember(d => d.InvoiceTownNumber, o => o.MapFrom(s => s.invoiceTownNumber))
               .ForMember(d => d.InvoiceTownStreet, o => o.MapFrom(s => s.invoiceTownStreet))
               .ForMember(d => d.TotalPrice, o => o.MapFrom(s => s.totalPrice));


            CreateMap<ItemState, ItemStateDto>()
               .ForMember(d => d.id, o => o.MapFrom(s => s.Id))
               .ForMember(d => d.name, o => o.MapFrom(s => s.Name));


            CreateMap<ItemStateDto, ItemState>()
              .ForMember(d => d.Id, o => o.MapFrom(s => s.id))
              .ForMember(d => d.Name, o => o.MapFrom(s => s.name));
        }
    }
}