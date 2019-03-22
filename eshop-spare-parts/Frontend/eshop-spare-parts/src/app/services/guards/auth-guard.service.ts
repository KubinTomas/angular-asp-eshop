import { AuthenticationService } from './../http/authentication.service';
import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { Observable } from 'rxjs';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/first';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {

  constructor(
    private router: Router,
    private authService: AuthenticationService
  ) { }


  canActivate() {

    return this.authService
      .isAdminHttpGet()
      .map((response: any) => {
        let isAdmin = JSON.parse(response.text()).UserDto.isAdmin;

        if (!isAdmin) this.router.navigate(['/']);

        return isAdmin;
      })
      .first();
  }
}
