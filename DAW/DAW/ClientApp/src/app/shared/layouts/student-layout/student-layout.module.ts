import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {StudentLayoutComponent} from './student-layout.component';
import {CoursesComponent} from '../../../pages/courses/courses.component';
import {RouterModule} from '@angular/router';
import {StudentLayoutRoutes} from './student-layout.routing';

const componentsArray = [StudentLayoutComponent, CoursesComponent];

@NgModule({
  declarations: componentsArray,
  imports: [
    CommonModule,
    RouterModule.forChild(StudentLayoutRoutes),

  ],
  exports: componentsArray
})
export class StudentLayoutModule {
}
