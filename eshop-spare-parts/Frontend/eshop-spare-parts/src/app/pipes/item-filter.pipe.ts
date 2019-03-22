import { Pipe, PipeTransform } from '@angular/core'


@Pipe({
    name: 'itemFilter'
  })
export class ItemFilterPipe implements PipeTransform{
    public transform(items, keys: string, filterString: string) {

        if (!filterString) return items;
        return (items || []).filter((item) => keys.split(',').some(key => item.hasOwnProperty(key) && new RegExp(filterString, 'gi').test(item[key])));
    
      }
}