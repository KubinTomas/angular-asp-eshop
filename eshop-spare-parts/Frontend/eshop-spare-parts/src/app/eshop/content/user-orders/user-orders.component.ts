import { AuthenticationService } from './../../../services/http/authentication.service';
import { OrderService } from './../../../services/http/order.service';
import { Component, OnInit, ViewEncapsulation } from '@angular/core';

@Component({
  selector: 'app-user-orders',
  templateUrl: './user-orders.component.html',
  styleUrls: ['./user-orders.component.scss'],
  providers: [OrderService],
  encapsulation: ViewEncapsulation.None
})
export class UserOrdersComponent implements OnInit {

  orders;

  constructor(
    private orderService: OrderService,
    private authService: AuthenticationService
    ) { }

  ngOnInit() {
    this.loadOrders();
  }

  loadOrders(){

    let userId = this.authService.currentUser.unique_name;

    console.log(userId);

    this.orderService.get(userId, this.orderService.getOrdersForUserUrl)
        .subscribe(response => {
          this.orders = response.Orders;

          console.log(this.orders);
        });
  }
}
