import { ShoppingCartService } from 'src/app/services/others/shopping-cart.service';
import { OrderService } from './../../../services/http/order.service';
import { Component, OnInit, ViewChild, ViewEncapsulation } from '@angular/core';

@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.scss'],
  providers: [OrderService],
  encapsulation: ViewEncapsulation.None
})
export class OrderComponent implements OnInit {

  @ViewChild('shippingAndPayment') child;

  constructor(
    public cartService: ShoppingCartService,
    public orderService: OrderService
  ) { }

  ngOnInit() {}

  selectionChange(event) {
    if(event.selectedIndex == 1){
      this.child.setCompaniesPrice();
    }
  }
}
