import { GlobalConst } from './../../../../models/others/cons.model';
import { ShoppingCartService } from './../../../../services/others/shopping-cart.service';
import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { OrderService } from '../../../../services/http/order.service';

@Component({
  selector: 'app-shipping-and-payment',
  templateUrl: './shipping-and-payment.component.html',
  styleUrls: ['./shipping-and-payment.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class ShippingAndPaymentComponent implements OnInit {
  transportCompanies;
  isLoading = true;
  price;

  constructor(
    public cart: ShoppingCartService,
    private orderService: OrderService
  ) { }

  ngOnInit() {
    this.price = 0;
    this.loadTransportCompanies();
  }

  loadTransportCompanies() {
    this.orderService
      .getAll(this.orderService.getDeliveryCompaniesUrl)
      .subscribe(response => {
        this.transportCompanies = response.TransportCompaniesDto;

        this.setCompaniesPrice();

        this.isLoading = false;
      });
  }
  setCompaniesPrice() {
    for (let company of this.transportCompanies) {
      company.price = this.cart.getPrice(company.id);

      this.recalculateSelectedCompanyPrice(company);

    }

  }
  onCompanySelect(company) {
    this.orderService.transportCompany = company;
    this.price = this.orderService.transportCompany.price;
  }
  recalculateSelectedCompanyPrice(company) {
    if (this.orderService.transportCompany && company.id == this.orderService.transportCompany.id) {
       this.orderService.transportCompany.price = company.price;
       this.price = this.orderService.transportCompany.price;
    }
  }
}
