import { OrderService } from 'src/app/services/http/order.service';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator, MatTableDataSource, MatSort } from '@angular/material';


@Component({
  selector: 'app-adm-orders',
  templateUrl: './adm-orders.component.html',
  styleUrls: ['./adm-orders.component.scss'],
  providers: [OrderService]
})
export class AdmOrdersComponent implements OnInit {

  orders;
  isLoading;
  dataSource;
  displayedColumns: string[] = ['code', 'created', 'finished','status', 'settings'];


  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  constructor(private orderService: OrderService) { }

  ngOnInit() {
    this.isLoading = true;
    this.loadOrders();
  }

  loadOrders() {
    this.orderService.getAll(this.orderService.getAllOrdersUrl)
      .subscribe(response => {
        this.orders = response.Orders;
        this.dataSource = new MatTableDataSource(this.orders);
        setTimeout(() => this.dataSource.paginator = this.paginator);
        setTimeout(() => this.dataSource.sort = this.sort);
        this.isLoading = false;
      });
  }

  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
}
