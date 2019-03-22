import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import { ServiceService } from './service.service';

@Injectable({
  providedIn: 'root'
})
export class OrderService extends ServiceService {

  public getDeliveryCompaniesUrl = "api/get/order/transport/companies";

  public getCreateOrderUrl = "api/create/order";

  public getOrderDetailUrl = "api/get/order/";

  public getOrdersForUserUrl = "api/get/orders/";

  public getAllOrdersUrl = "api/get/all/orders";

  public getQuestionUrl = "api/send/question";


  public transportCompany;

  constructor(public http: Http) {
    super(http);
  }

}
