import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';
import {HttpClientModule} from "@angular/common/http";
import { TextMaskModule } from 'angular2-text-mask';
import { BotDetectCaptchaModule } from 'angular-captcha';

import { AppComponent } from './app.component';
import { FeedbacksComponent } from './feedbacks/feedbacks.component';
import { FeedbackComponent } from './feedbacks/feedback/feedback.component';
import { FeedbackService } from './shared/feedback.service';

@NgModule({
  declarations: [
    AppComponent,
    FeedbackComponent,
    FeedbacksComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    TextMaskModule,
    BotDetectCaptchaModule
  ],
  providers: [FeedbackService],
  bootstrap: [AppComponent]
})
export class AppModule { }
