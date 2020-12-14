import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {AuthLayoutComponent} from './auth-layout.component';
import {RouterModule} from '@angular/router';
import {AuthLayoutRoutes} from './auth-layout.routing';
import {LoginComponent} from '../../../pages/auth/login/login.component';
import {RegisterComponent} from '../../../pages/auth/register/register.component';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import {MatFormFieldModule, MatIconModule, MatInputModule} from '@angular/material';

const componentsArray = [RegisterComponent, LoginComponent, AuthLayoutComponent];

@NgModule({
  declarations: componentsArray,
  imports: [
    CommonModule,
    RouterModule,
    RouterModule.forChild(AuthLayoutRoutes),
    FormsModule,
    ReactiveFormsModule,
    MatFormFieldModule,
    MatIconModule,
    MatInputModule

  ],
  exports: componentsArray
})
export class AuthLayoutModule {
}
