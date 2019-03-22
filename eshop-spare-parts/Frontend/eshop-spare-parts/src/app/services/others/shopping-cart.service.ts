import { map } from 'rxjs/operators';
import { Http } from '@angular/http';
import { SnackBarService } from 'src/app/services/others/snack-bar.service';
import { Item } from './../../models/dbModels/item.model';
import { Injectable } from '@angular/core';
import { GlobalConst } from '../../models/others/cons.model';
import { CartService } from '../http/cart.service';
import { ServiceService } from '../http/service.service';
import { url } from 'src/app/models/others/url';

@Injectable({
  providedIn: 'root'
})
export class ShoppingCartService extends ServiceService {
  public getHashedCart = 'api/get/hashed/cart';

  public getUnhashedCart = 'api/get/unhashed/cart';

  public cartItems = [];

  constructor(
    private snackBarService: SnackBarService,
    private cartService: CartService,
    public http: Http
  ) {
    super(http);

    if (localStorage.getItem('RANDOMSSID') !== null)
      this.loadCartItems();
  }

  clearCart() {
    this.cartItems = [];
    this.saveCartItems();
  }
  updateItemCount(item: Item, count: number) {
    for (let cartItem of this.cartItems) {
      if (cartItem.id == item.id) {
        cartItem.countInCart = count;
      }
    }
    this.saveCartItems();
  }

  loadCartItems() {
    // this.cartItems = JSON.parse(localStorage.getItem('shoppingCartItems'));

    //  this.headers.set('cart', localStorage.getItem('RANDOMSSID'));

    // this.get('', this.getUnhashedCart).subscribe(response => {
    //   console.log(response);
    //   this.cartItems = JSON.parse(response);
    // });

    this.http.post(url + this.getUnhashedCart, { cart: localStorage.getItem('RANDOMSSID') })
      .pipe(map((response: any) => response.json()))
      .subscribe(response => {
        this.cartItems = JSON.parse(response);
      });
  }
  saveCartItems() {

    // this.headers.set('cart', JSON.stringify(this.cartItems));

    // this.get('', this.getHashedCart).subscribe(response => {
    //   localStorage.setItem('RANDOMSSID', response);
    // });

    this.http.post(url + this.getHashedCart, { cart: JSON.stringify(this.cartItems) })
      .pipe(map((response: any) => response.json()))
      .subscribe(response => {
        localStorage.setItem('RANDOMSSID', response);
      });

    // localStorage.setItem('shoppingCartItems', JSON.stringify(this.cartItems));
  }
  addItem(item: Item) {
    if (item.itemAvailability.id != GlobalConst.ItemInStock) {
      this.snackBarService.openSnackBar('Položka není dostupná, prosím kontaktujte nás.', 'Ok', 2000);
      return;
    }

    this.itemIsAlreadyAdded(item);
    this.saveCartItems();

    this.snackBarService.openSnackBar('Položka byla přidána', 'Ok', 800);
  }
  itemIsAlreadyAdded(item: Item) {
    let isItemInCart: boolean = false;

    for (let cartItem of this.cartItems) {
      if (cartItem.id == item.id) {
        cartItem.countInCart++;
        isItemInCart = true;
      }
    }

    if (!isItemInCart) this.addItemToCart(item);
  }
  addItemToCart(item: Item) {
    this.setItemCountInCart(item);

    this.cartItems.push(item);
  }
  setItemCountInCart(item: Item, count: number = 1) {
    item.countInCart = count;

    this.saveCartItems();
  }
  removeItemFromCart(item: Item) {
    const index = this.cartItems.indexOf(item);
    if (index !== -1) {
      this.snackBarService.openSnackBar('Item byl smazán.', 'Ok');
      this.cartItems.splice(index, 1);
    }
    this.saveCartItems();
  }
  itemsCount() {
    if (!this.cartItems) return 0;

    let counter = 0;

    for (let item of this.cartItems) {
      counter += +item.countInCart;
    }

    return counter;
  }
  getTotalCartPrice() {
    let totalPrice = 0;

    for (let item of this.cartItems) {
      totalPrice += +item.countInCart * item.price;
    }

    return totalPrice;
  }
  itemsWeight() {
    if (!this.cartItems) return 0;

    let weight = 0;

    for (let item of this.cartItems) {
      weight += +item.countInCart * +item.weight;
    }

    return weight;
  }

  getPrice(deliveryCompany: number) {
    let orderWeight = this.itemsWeight();

    if (deliveryCompany == GlobalConst.CeskaPost)
      return this.getPriceForCeskaPosta(orderWeight);
    else if (deliveryCompany == GlobalConst.DPD)
      return this.getPriceForDPD(orderWeight);
    else return 9999999;
  }
  getPriceForDPD(orderWeight: number) {
    if (orderWeight < 1) {
      return 155;
    } else if (orderWeight >= 1 && orderWeight < 5) {
      return 185;
    } else if (orderWeight >= 5 && orderWeight < 30) {
      return 275;
    } else if (orderWeight >= 30 && orderWeight <= 50) {
      return 571;
    } else {
      return 0;
    }
  }
  getPriceForCeskaPosta(orderWeight: number) {
    if (orderWeight < 1) {
      return 99;
    } else if (orderWeight >= 1 && orderWeight < 5) {
      return 180;
    } else if (orderWeight >= 5 && orderWeight < 30) {
      return 250;
    } else {
      return 0;
    }
  }
  haveItems() {
    return this.cartItems.length > 0;
  }
}
