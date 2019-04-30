import { Component, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'MyToDoListWeb';
  items:any;
  constructor(private http:HttpClient) {}

  ngOnInit() {
    this.http.get("https://localhost:44374/api/todolist").subscribe(result => { this.items = result; })
  }
}
