import { User } from 'src/app/models/dbModels/user.model';
import { Item } from './item.model';

export class Order {
    public id: string;

    public user: User;

    public items: Item[];

}