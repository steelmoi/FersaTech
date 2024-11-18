import { Component, OnInit } from '@angular/core';
import { FileService } from '../../services/RestFull/file.service';
import { HttpResponse } from '@angular/common/http';
import { ResponseFile } from '../../interfaces/ApiResponse/response-file';
import { Router } from '@angular/router';

@Component({
  selector: 'app-load-file',
  templateUrl: './load-file.component.html',
  styleUrl: './load-file.component.css'
})
export class LoadFileComponent implements OnInit {
  currentFile?: File;
  public Summary: ResponseFile = new ResponseFile()
  public Success: boolean = false
  public IsBusy: boolean = false
  constructor(private uploadService: FileService,
              private router: Router) { }

  ngOnInit() {

  }

  selectFile(event: any) {
    this.currentFile = event.target.files.item(0);
    this.Summary = new ResponseFile()
    this.Success = false
  }

  Back() {
    this.router.navigate([""]);
  }
  
  upload() {
    if (this.currentFile) {
      this.IsBusy = true
      this.uploadService.UploadFile(this.currentFile).subscribe({
        next: (event: any) => {
          if (event instanceof HttpResponse) {
            this.Success = true
            this.IsBusy = false
            this.Summary = event.body;
          }
        },
        error: (err: any) => {
          this.Summary = new ResponseFile()
          this.Success = false
          this.IsBusy = false
          console.log(err);
        },
        complete: () => {
          this.currentFile = undefined;
          this.IsBusy = false
        },
      });
    }
  }
}
