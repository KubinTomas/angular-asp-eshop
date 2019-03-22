import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import { ServiceService } from './service.service';

@Injectable({
  providedIn: 'root'
})
export class CartService extends ServiceService{


  public getHashedCart = "api/get/hashed/cart/";

  public getUnhashedCart = "api/get/unhashed/cart/text/";


  constructor(public http: Http) {
    super(http);
  }
}
