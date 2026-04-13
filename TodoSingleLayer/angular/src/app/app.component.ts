import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import {
  InternetConnectionStatusComponent,
  LoaderBarComponent
} from '@abp/ng.theme.shared';

@Component({
  selector: 'app-root',
  standalone: true,
  template: `
    <abp-loader-bar />
    <router-outlet />
    <abp-internet-status />
  `,
  imports: [
    RouterOutlet,
    LoaderBarComponent,
    InternetConnectionStatusComponent
  ]
})
export class AppComponent {}