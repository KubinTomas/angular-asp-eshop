import { Location } from '@angular/common';
import { ActivatedRoute } from '@angular/router';
import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { OrderService } from 'src/app/services/http/order.service';

@Component({
  selector: 'app-order-detail',
  templateUrl: './order-detail.component.html',
  styleUrls: ['./order-detail.component.scss'],
  providers: [OrderService],
  encapsulation: ViewEncapsulation.None
})
export class OrderDetailComponent implements OnInit {


  order;

  constructor(
    private route: ActivatedRoute,
    private location: Location,
    private orderService: OrderService
  ) { }

  ngOnInit() {
    this.route.params.subscribe(response => {
      let code = response['code'];

      this.loadOrderDetail(code);
    });
  }
  loadOrderDetail(code) {
    this.orderService.get(code, this.orderService.getOrderDetailUrl)
      .subscribe(response => {
        this.order = response;
        console.log(this.order);
      });
  }
  onBack() {
    this.location.back();
  }
}
