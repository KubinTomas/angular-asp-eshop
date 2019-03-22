import { AuthenticationService } from './../http/authentication.service';
import { CanActivate, Router } from '@angular/router';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthGuardIsLogged implements CanActivate {

  constructor(
    private authService: AuthenticationService,
    private router: Router
    ) { }

  canActivate(){
    if(this.authService.isLoggedIn()) return true;

    this.router.navigate(['/login']);

    return false;
  }
}
