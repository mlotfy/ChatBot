import { Component, OnInit, Inject, ViewChild, ElementRef, AfterViewChecked } from '@angular/core';

import { HttpClient, HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-chat',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.css']
})
export class ChatComponent implements OnInit, AfterViewChecked {
  @ViewChild('scrollMe', { static: true }) private myScrollContainer: ElementRef;

  public data: string[];
  public model: string;
  public http: HttpClient;
  public baseUrl: string;
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {

    this.http = http;
    this.data = [];
    this.baseUrl = baseUrl;
    //http.get<string[]>(baseUrl + 'api/bot').subscribe(result => {
    //  this.data = result;
    //}, error => console.error(error));
  }
  ngAfterViewChecked() {
    this.scrollToBottom();
  }
  scrollToBottom(): void {
    try {
      this.myScrollContainer.nativeElement.scrollTop = this.myScrollContainer.nativeElement.scrollHeight;
    } catch (err) { }
  }
  addData() {
    const headers = new HttpHeaders().set('Content-Type', 'text/plain; charset=utf-8');
    if (this.model) {
      this.http.post<string>(this.baseUrl + 'api/bot?value=' + this.model, null, { headers, responseType: 'text' as 'json' }).subscribe(result => {
        this.data.push("User : " + this.model)
        this.data.push("ChatBot : " + result);
        this.model = "";
      }, error => console.error(error));
    }
  }

  ngOnInit() {
    this.scrollToBottom();
  }

}
