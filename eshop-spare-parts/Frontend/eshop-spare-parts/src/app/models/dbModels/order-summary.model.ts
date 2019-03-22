export class OrderSummary {
  public id: string;

  public name: string;
  public surname: string;

  public email: string;
  public phone: string;

  public deliveryTown: string;
  public deliveryTownNumber: string;
  public deliveryTownStreet: string;

  public invoiceTown: string;
  public invoiceTownNumber: string;
  public invoiceTownStreet: string;

  public totalPrice: string;

  constructor(
    name,
    surname,
    email,
    phone,
    deliveryTown,
    deliveryTownNumber,
    deliveryTownStreet,
    invoiceTown,
    invoiceTownNumber,
    invoiceTownStreet,
    totalPrice
  ) {
      this.name = name;
      this.surname = surname;
      this.email = email;
      this.phone = phone;
      this.deliveryTown = deliveryTown;
      this.deliveryTownNumber = deliveryTownNumber;
      this.deliveryTownStreet = deliveryTownStreet;
      this.invoiceTown = invoiceTown;
      this.invoiceTownNumber = invoiceTownNumber;
      this.invoiceTownStreet = invoiceTownStreet;
      this.totalPrice = totalPrice;
  }
}
