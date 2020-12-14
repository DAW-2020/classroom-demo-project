import {Directive, HostBinding, Input, OnInit} from '@angular/core';

@Directive({
  selector: '[appImagePreloader]',
  // host: {
  //   '[attr.src]': 'finalImage'
  // }
})
export class ImagePreloaderDirective implements OnInit {
  @Input('appImagePreloader') targetSource: string;
  downloadingImage: any;
  @Input() defaultImage = '../../../assets/gifs/preloader.gif';
  @HostBinding('[attr.src]') finalImage;

  ngOnInit() {
    this.finalImage = this.defaultImage;
    this.downloadingImage = new Image();
    this.downloadingImage.src = this.targetSource;

    this.downloadingImage.onload = () => {
      this.finalImage = this.targetSource;
    };

    this.downloadingImage.onerror  = (e) => {
      console.log(e);
    };
  }

}
