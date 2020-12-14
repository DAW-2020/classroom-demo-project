import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {ImagePreloaderDirective} from './image-preloader/image-preloader.directive';

const directiveArray = [ImagePreloaderDirective];

@NgModule({
  declarations: directiveArray,
  imports: [
    CommonModule
  ],
  exports: directiveArray
})
export class DirectivesModule {
}
