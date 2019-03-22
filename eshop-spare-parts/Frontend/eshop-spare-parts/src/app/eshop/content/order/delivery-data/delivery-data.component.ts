import { OrderService } from './../../../../services/http/order.service';
import { ShoppingCartService } from 'src/app/services/others/shopping-cart.service';
import { Router } from '@angular/router';
import { SnackBarService } from 'src/app/services/others/snack-bar.service';
import { AuthenticationService } from './../../../../services/http/authentication.service';
import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { ReturnCodes } from '../../../../models/others/return-codes.model';
import { User } from 'src/app/models/dbModels/user.model';
import { Location } from '@angular/common';
import {
  FormBuilder,
  Validators,
  FormGroup,
  FormControl
} from '@angular/forms';
import { trigger, transition, style, animate } from '@angular/animations';
import { OrderTransport } from '../../../../models/dbModels/order-transport.model';
import { OrderSummary } from 'src/app/models/dbModels/order-summary.model';

@Component({
  selector: 'app-delivery-data',
  templateUrl: './delivery-data.component.html',
  styleUrls: ['./delivery-data.component.scss'],
  animations: [
    trigger('fade', [
      transition('void => *', [style({ opacity: 0 }), animate(700)]),

      transition('* => void', [animate(400, style({ opacity: 0 }))])
    ])
  ],
  encapsulation: ViewEncapsulation.None
})
export class DeliveryDataComponent implements OnInit {
  form;
  isLoading;
  errorMessage;
  user: User;
  useDifferentAddress = false;

  constructor(
    private authService: AuthenticationService,
    private snackBarService: SnackBarService,
    private location: Location,
    private router: Router,
    private fb: FormBuilder,
    private shoppingCart: ShoppingCartService,
    private orderService: OrderService
  ) {}

  ngOnInit() {
    this.isLoading = true;
    this.user = new User();

    if (this.authService.isLoggedIn()) this.loadUser();
    else this.buildForm();
  }
  loadUser() {
    this.authService.getUser().subscribe(response => {
      this.isLoading = false;

      if (response.StatusCode == ReturnCodes.BadRequest) {
        this.errorMessage = 'Bad Request';
      } else if (response.StatusCode == ReturnCodes.Ok) {
        this.user = response.UserDto;
        this.buildForm();
      }
    });
  }
  submit(form) {
    this.create(form.value);
  }
  create(order) {
    if (!this.useDifferentAddress) order.orderDifferentDataAndAddress = null;

    order.items = this.shoppingCart.cartItems;
    order.orderTransport = new OrderTransport(
      this.orderService.transportCompany.id,
      this.orderService.transportCompany.price,
      this.shoppingCart.itemsWeight(),
      this.orderService.transportCompany.name
    );
    order.user = new User();

    if(this.authService.isLoggedIn())
    order.user.id = this.authService.currentUser.unique_name;
    else
    order.user.id = null;

    this.setOrderData(order);

    order.billingAddress = null;
    order.personalData = null;

    this.orderService
      .create(order, this.orderService.getCreateOrderUrl)
      .subscribe(response => {
        let body = JSON.parse(response.text());

        if (body.StatusCode == ReturnCodes.Ok) {
          this.afterSuccessSubmit('Objednávka byla odeslána');
        }
      });
  }
  setOrderData(order) {
    if (order.orderDifferentDataAndAddress) {
      order.orderSummary = new OrderSummary(
        order.orderDifferentDataAndAddress.name,
        order.orderDifferentDataAndAddress.surname,
        order.orderDifferentDataAndAddress.email,
        order.orderDifferentDataAndAddress.phoneNumber,
        order.orderDifferentDataAndAddress.town,
        order.orderDifferentDataAndAddress.townNumber,
        order.orderDifferentDataAndAddress.townStreet,
        order.billingAddress.town,
        order.billingAddress.townNumber,
        order.billingAddress.townStreet,
        this.shoppingCart.getTotalCartPrice() +
          this.orderService.transportCompany.price
      );
    } else {
      order.orderSummary = new OrderSummary(
        order.personalData.name,
        order.personalData.surname,
        order.personalData.email,
        order.personalData.phoneNumber,
        order.billingAddress.town,
        order.billingAddress.townNumber,
        order.billingAddress.townStreet,
        order.billingAddress.town,
        order.billingAddress.townNumber,
        order.billingAddress.townStreet,
        this.shoppingCart.getTotalCartPrice() +
          this.orderService.transportCompany.price
      );
    }
  }
  afterSuccessSubmit(message) {
    this.snackBarService.openSnackBar(message, 'Ok');
    this.shoppingCart.clearCart();
    this.router.navigate(['']);
  }
  buildForm() {
    this.form = this.fb.group({
      personalData: new FormGroup({
        name: new FormControl(this.user.name, Validators.required),
        surname: new FormControl(this.user.surname, Validators.required),
        email: new FormControl(this.user.email, [Validators.required, Validators.email]),
        phoneNumber: new FormControl(this.user.phoneNumber, Validators.required)
      }),
      billingAddress: new FormGroup({
        town: new FormControl('', Validators.required),
        townNumber: new FormControl('', Validators.required),
        townStreet: new FormControl('', Validators.required)
      }),
      orderDifferentDataAndAddress: new FormGroup({
        name: new FormControl(),
        surname: new FormControl(),
        email: new FormControl(),
        phoneNumber: new FormControl(),
        town: new FormControl(),
        townNumber: new FormControl(),
        townStreet: new FormControl()
      }),
      agreePersonalData: ['', [Validators.requiredTrue]]
    });

    this.isLoading = false;
  }

  onBack() {
    this.location.back();
  }
  onOrderDifferentChange(input) {
    let isChecked = input.checked;
    this.useDifferentAddress = isChecked;

    let orderDiff = this.form.get('orderDifferentDataAndAddress');

    Object.keys(orderDiff.controls).forEach(key => {
      let control = orderDiff.get(key);

      if (isChecked) control.setValidators([Validators.required]);
      else control.setValidators(null);

      if(key == 'email' && isChecked){
        control.setValidators([Validators.email]);
      }

      control.updateValueAndValidity();
    });
  }
}
