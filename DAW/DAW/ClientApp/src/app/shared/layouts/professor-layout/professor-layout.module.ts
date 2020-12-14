import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {ProfessorLayoutComponent} from './professor-layout.component';
import {CoursesManagementComponent} from '../../../pages/courses-management/courses-management.component';
import {StudentManagementComponent} from '../../../pages/student-management/student-management.component';
import {RouterModule} from '@angular/router';
import {ProfessorLayoutRoutes} from './prefessor-layout.routing';

const componentsArray = [ProfessorLayoutComponent, CoursesManagementComponent, StudentManagementComponent];

@NgModule({
  declarations: componentsArray,
  imports: [
    CommonModule,
    RouterModule.forChild(ProfessorLayoutRoutes),
  ],
  exports: componentsArray
})
export class ProfessorLayoutModule { }
