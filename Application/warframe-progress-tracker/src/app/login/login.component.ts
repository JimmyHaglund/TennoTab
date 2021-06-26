import { Component, OnInit } from '@angular/core';
import {FormBuilder, FormGroup, Validators, AbstractControl } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  public loginForm!: FormGroup;
  public submitted = false;
  public loading = false;

  constructor(private _formBuilder: FormBuilder) { }

  public get formFields() : { [key: string]: AbstractControl} {
    return this.loginForm.controls;
  }

  ngOnInit(): void {
    this.loginForm = this._formBuilder.group({
      username: ['', Validators.required],
      password: ['', Validators.required]
    });
  }

  public onSubmit() : void {
    this.submitted = true;

    if (this.loginForm.invalid) return;
    this.loading = true;
    console.log("login submitted");
  }

}
