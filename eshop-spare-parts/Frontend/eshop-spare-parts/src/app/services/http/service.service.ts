import { url } from '../../models/others/url';
import { Http, Headers } from '@angular/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export abstract class ServiceService {

  http: Http;

  constructor(http: Http) {
    this.http = http;
  }
  public headers: Headers = new Headers({
    'user': localStorage.getItem('user'),
    'cart': ''
  });


  create(postObject, postUrl) {
    console.log(this.headers);
    return this.http.post(url + postUrl, postObject, { headers: this.headers });
  }
  update(postObject, postUrl) {
    return this.http.put(url + postUrl, postObject, { headers: this.headers });
  }
  delete(id, postUrl) {
    return this.http.delete(url + postUrl + id, { headers: this.headers });
  }
  get(id, postUrl) {
    return this.http
      .get(url + postUrl + id, { headers: this.headers })
      .pipe(map((response: any) => response.json()));
  }
  getAll(postUrl) {
    return this.http
      .get(url + postUrl , { headers: this.headers })
      .pipe(map((response: any) => response.json()));
  }

}
