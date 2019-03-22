import { ReturnCodes } from './../../../models/others/return-codes.model';
import { User } from './../../../models/dbModels/user.model';
import { AuthenticationService } from './../../../services/http/authentication.service';
import { Component, OnInit, ViewEncapsulation } from '@angular/core';

@Component({
  selector: 'app-user-profil',
  templateUrl: './user-profil.component.html',
  styleUrls: ['./user-profil.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class UserProfilComponent implements OnInit {

  isLoading;
  errorMessage;
  user: User;

  constructor(private authService: AuthenticationService) { }

  ngOnInit() {
    this.isLoading = true;
    this.loadUser();
  }
  loadUser() {
    let loggedUser = this.authService.currentUser;

    this.authService.getUser().subscribe(response => {
      this.isLoading = false;

      if (response.StatusCode == ReturnCodes.BadRequest) {
        this.errorMessage = "Bad Request";
      } else if(response.StatusCode == ReturnCodes.Ok){
        this.user = response.UserDto;
      }
    })
  }

}
