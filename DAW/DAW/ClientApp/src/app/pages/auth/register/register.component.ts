import {Component, OnInit} from '@angular/core';
import {FormBuilder, Validators} from '@angular/forms';
import {AuthenticationService} from '../../../core/services/authentification/authentication.service';
import {ActivatedRoute, Router} from '@angular/router';
import {ToastrService} from 'ngx-toastr';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  public hide = true;
  public registrationForm = this.fb.group({
    Email: ['', Validators.email],
    Password: ['', Validators.required]
  });

  constructor(private fb: FormBuilder,
              private authenticationService: AuthenticationService,
              private router: Router,
              private toastService: ToastrService,
              private route: ActivatedRoute) {
  }

  ngOnInit() {
  }

  register() {
    this.authenticationService.register(this.registrationForm.value)
      .subscribe(data => {
          console.log('Successfully registered', data);
          this.router.navigateByUrl('home');
        }
      );
  }
}
