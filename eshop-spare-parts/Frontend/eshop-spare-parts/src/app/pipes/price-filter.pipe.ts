import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'priceFilter'
})
export class PriceFilterPipe implements PipeTransform {
  transform(value, minPrice, maxPrice) {
    return value.filter(_product => {
      return _product.price >= +minPrice && _product.price <= +maxPrice;
    });
  }
}
