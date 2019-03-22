export class OrderTransport {
    
  constructor(transportCompanyId, transportPrice,weight, name) {
      this.transportCompanyId = transportCompanyId;
      this.transportPrice = transportPrice;
      this.weight = weight;
      this.name = name;
  }

  public id: string;

  public name: string;

  public transportCompanyId: string;

  public transportPrice: string;

  public weight: string;
}
