import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { TrasactionService } from '../../services/RestFull/trasaction.service';
import { Detail } from '../../interfaces/detail';

@Component({
  selector: 'app-report-trasaction',
  templateUrl: './report-trasaction.component.html',
  styleUrl: './report-trasaction.component.css'
})
export class ReportTrasactionComponent {
  public Details: Detail[] = []
  public IsBusy: boolean = false

  constructor(private serviceTransaction: TrasactionService,
    private router: Router
  ) { }

  ngOnInit() {
    this.LoadData(1)
  }

  Back() {
    this.router.navigate([""])
  }

  LoadData(TransactionId: number) {
    this.IsBusy = true
    this.serviceTransaction.GetTransactionDetails(TransactionId)
      .subscribe({
        next: (response: Detail[]) => {
          this.IsBusy = false
          this.Details = response
        },
        error: (error: Error) => {
          this.IsBusy = false
          console.error(error);
        }
      });
  }
}
