// import { JwtHelper } from 'angular2-jwt';
import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import { ServiceService } from './service.service';
import { url } from '../../models/others/url';
import { map } from 'rxjs/operators';
import { JwtModule } from '@auth0/angular-jwt';
import { JwtHelperService } from '@auth0/angular-jwt';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService extends ServiceService {
  public createUserUrl = 'api/create/user';
  public loginUserUrl = 'api/login/user/';
  public isAdminUrl = 'api/user/isAdmin/';
  public getUserUrl = 'api/get/user/';
  public getEditUserUrl = 'api/edit/user';

  isAdminProperty;

  apiLoginUser(email, password) {
    return this.http
      .get(url + this.loginUserUrl + email + '/' + password)
      .pipe(map((response: any) => response.json()));
  }
  getUser() {
      return this.http
        .get(
          url +
            this.getUserUrl +
            this.currentUser.email +
            '/' +
            this.currentUser.unique_name
        )
        .pipe(map((response: any) => response.json()));
  }
  isEmailUnique(email) {
    return this.http
      .get(url + 'api/user/email/isAvailable/' + email)
      .pipe(map((response: any) => response.json()));
  }

  constructor(public http: Http) {
    super(http);

    if (this.isLoggedIn()) this.loadAdminProperty(this.currentUser.unique_name);
    else this.isAdminProperty = false;
  }

  loadAdminProperty(userId) {
    this.http.get(url + this.isAdminUrl + userId).subscribe(response => {
      let body = JSON.parse(response.text());

      this.isAdminProperty = body.UserDto.isAdmin;
    });
  }

  login(token: string) {
    localStorage.setItem('token', token);
  }
  logout() {
    localStorage.removeItem('token');
  }
  isLoggedIn() {
    let token = localStorage.getItem('token');

    if (token) return true;
    else return false;
  }
  getCurrentToken() {
    return localStorage.getItem('token');
  }
  isAdmin() {
    return this.isAdminProperty;
  }
  isAdminHttpGet() {
    return this.http.get(url + this.isAdminUrl + this.currentUser.unique_name);
  }
  get currentUser() {
    return this.getTokenAsJSON(this.getCurrentToken());
  }
  getTokenAsJSON(token) {
    return new JwtHelperService().decodeToken(token);
  }
}
