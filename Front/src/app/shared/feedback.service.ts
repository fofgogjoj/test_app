import { Injectable } from '@angular/core';
import { Feedback, LastMessage} from './feedback.model';
import { FeedbackComponent } from '../feedbacks/feedback/feedback.component';
import { HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FeedbackService {
  formData = new Feedback();
  formMessage = new LastMessage();
  readonly rootURL = 'https://feedback-appl.azurewebsites.net/api/Feedbacks';

  constructor(private http:HttpClient) { }

  getData(): Observable<Object>{
    return this.http.get(this.rootURL);
  }

  postFeedback(formData:Feedback){

return this.http.post(this.rootURL,formData)
  }
}
