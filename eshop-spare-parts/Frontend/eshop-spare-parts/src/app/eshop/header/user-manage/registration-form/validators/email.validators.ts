import { AuthenticationService } from './../../../../../services/http/authentication.service';
import { AbstractControl, ValidationErrors } from '@angular/forms';
import { Injectable } from '@angular/core';

@Injectable()
export class EmailValidators {
    constructor(private authService: AuthenticationService) { }

    shouldBeUnique(control: AbstractControl): ValidationErrors | null {
        return new Promise((resolve, reject) => {

            this.authService.isEmailUnique(control.value).subscribe(response => {

                let isCodeUnique = response;

                if (!isCodeUnique) resolve({ shouldBeUnique: true });

                resolve(null);
            });
        });


    }
}

