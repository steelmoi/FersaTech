import { Component, OnInit } from '@angular/core';
import { Transacciones } from '../../interfaces/transacciones';
import { TrasactionService } from '../../services/RestFull/trasaction.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent implements OnInit{
  
  public Transactions: Transacciones[] = [];

  constructor(private trasactionService: TrasactionService, private route: Router) { }

  ngOnInit(): void {
    this.LoadData()
  }

  LoadData() {
    this.trasactionService.GetTransactions()
      .subscribe({
        next: (response: Transacciones[]) => {
          this.Transactions = response
        },
        error: (error: Error) => {
          console.error(error);
        }
      });
  }
}
