import { Component, OnInit } from '@angular/core';
import { TrasactionService } from './services/RestFull/trasaction.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {

  constructor(private trasactionService: TrasactionService, private route: Router) { }

  ngOnInit() {
    
  }

  title = 'FersaTech.client';
}
