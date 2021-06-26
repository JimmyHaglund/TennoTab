import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';


@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})

export class RegisterComponent implements OnInit {
  public registerForm!: FormGroup;
  public loading = false;
  public submitted = false; 
  
  constructor(
    private _formBuilder: FormBuilder
  ) { }
  
  public get formFields(): any { return this.registerForm.controls };

  public onSubmit() : void {
    this.submitted = true;
    if (this.registerForm.invalid) return;
    this.loading = true;
    console.log("Register form submitted");
  }
  
  ngOnInit(): void {
    this.registerForm = this._formBuilder.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      username: ['', Validators.required],
      password: ['', [Validators.required, Validators.minLength(6)]]
    });
  }
}
